using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin {
  public class TablesMapGenerator {
    private int _nbSeats;
    private int _recId;
    private List<GetTablesMap_Result> _tablesMaps;
    private List<Disliked> _disliked;
    private int FeelingTypeLike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeLike"]);
    private int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);

    private IList<GetReservation_Result> _clients;
    public List<Table> Tables { get; private set; }

    public TablesMapGenerator(int RecId) {
      Tables = new List<Table>();
      _tablesMaps = null;
      _recId = RecId;
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        _clients = context.GetReservation(RecId).Where(res => res.IsValid == true).ToList();
        _nbSeats = context.Reception.Where(rec => rec.ReceptionId == RecId).First().SeatsPerTable;
      }
    }

    public void Generate() {
      List<GetReservation_Result> ClientsToSeat = new List<GetReservation_Result>();
      Table CurrentTable = new Table(_nbSeats);
      bool goodFeeling;
      bool found;
      _tablesMaps = null;
      _disliked = new List<Disliked>();
      foreach(GetReservation_Result client in _clients.Where(client => client.IsValid == true)) {
        ClientsToSeat.Add(client);
        _disliked.Add(new Disliked(client.ClientId));
      }
      while(ClientsToSeat.Count > 0) {
        foreach(GetReservation_Result CurrentClient in ClientsToSeat.ToList()) {
          if(CurrentTable.HasRemainingSeats) {
            goodFeeling = true;
            foreach(GetReservation_Result seated in CurrentTable.Seateds) {
              if(HasBadFeeling(CurrentClient.ClientId, seated.ClientId)) { // BR024
                goodFeeling = false;
                break;
              }
            }
            if(goodFeeling) {
              CurrentTable.Add(CurrentClient);
              ClientsToSeat.Remove(CurrentClient);
            }
          } else {
            break;
          }
        }
        Tables.Add(CurrentTable);
        CurrentTable = new Table(_nbSeats);
      }
      foreach(Table table in Tables.Where(table => !table.isValid).ToList()) {
        if(table.Seateds.Count > 0) {
          GetReservation_Result seated = table.Seateds[0];
          foreach(Table otherTable in Tables.Where(tbl => tbl.isValid && tbl.HasRemainingSeats)) {
            goodFeeling = true;
            foreach(GetReservation_Result otherSeated in otherTable.Seateds) {
              if(HasBadFeeling(seated.ClientId, otherSeated.ClientId)) { // BR024
                goodFeeling = false;
                break;
              }
            }
            if(goodFeeling) {
              otherTable.Add(seated);
              Tables.Remove(table);
              break;
            }
          }
        } else {
          Tables.Remove(table);
        }
      }
      foreach(Table table in Tables.Where(table => !table.isValid).ToList()) {
        GetReservation_Result seated = table.Seateds[0];
        foreach(Table otherTable in Tables.Where(tbl => tbl.isValid && tbl.Seateds.Count > 2)) {
          found = false;
          foreach(GetReservation_Result otherSeated in otherTable.Seateds) {
            if(!HasBadFeeling(seated.ClientId, otherSeated.ClientId)) { // BR024
              otherTable.Seateds.Remove(otherSeated);
              table.Add(seated);
              found = true;
              break;
            }
          }
          if(found) {
            break;
          }
        }
      }
    }

    private bool HasBadFeeling(int CliId1, int CliId2) { // BR024
      if(CliId1 == CliId2) {
        return true;
      } else {
        if(_disliked.Where(disliked => disliked.ClientId == CliId1 && disliked.DislikedIds.Contains(CliId2)).Count() > 0) {
          return true;
        } else if(_disliked.Where(disliked => disliked.ClientId == CliId2 && disliked.DislikedIds.Contains(CliId1)).Count() > 0) {
          return true;
        } else {
          return false;
        }
      }
    }

    public IList<GetTablesMap_Result> ToList() {
      if(_tablesMaps == null) {
        _tablesMaps = new List<GetTablesMap_Result>();
        int i = 0;
        foreach(Table table in Tables) {
          i++;
          foreach(GetReservation_Result seated in table.Seateds) {
            GetTablesMap_Result current = new GetTablesMap_Result();
            current.ClientFirstName = seated.ClientFirstName;
            current.ClientId = seated.ClientId;
            current.ClientLastName = seated.ClientLastName;
            current.IsValid = table.isValid;
            current.ReceptionId = _recId;
            current.TableNumber = i;
            _tablesMaps.Add(current);
          }
        }
      }
      return _tablesMaps;
    }

    public void Save(string acronym) {
      int i = 0;
      ObjectParameter tableIdParam = new ObjectParameter("TabId", typeof(int));
      int tableId;
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        foreach(Table table in Tables) {
          i++;
          context.NewTable(_recId, i, acronym, tableIdParam);
          tableId = Int32.Parse(tableIdParam.Value.ToString());
          foreach(GetReservation_Result seated in table.Seateds) {
            context.NewSit(tableId, seated.ClientId, acronym);
          }
        }
      }
    }
  }
}
