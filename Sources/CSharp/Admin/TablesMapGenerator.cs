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
      //List<GetReservation_Result> ClientsToSeat = new List<GetReservation_Result>();
      //int i;
      Table CurrentTable = new Table(_nbSeats);
      //bool goodFeeling;
      //GetReservation_Result CurrentClient;
      _tablesMaps = null;
      foreach(GetReservation_Result client in _clients.Where(client => client.IsValid == true)) {
        if(!CurrentTable.HasRemainingSeats) {
          Tables.Add(CurrentTable);
          CurrentTable = new Table(_nbSeats);
        }
        CurrentTable.Add(client);
      }
      Tables.Add(CurrentTable);
      //i = 0;
      //while(ClientsToSeat.Count > 0) {
      //  try {
      //    CurrentClient = ClientsToSeat[i];
      //  } catch {
      //    if(ClientsToSeat.Count == 0) {
      //      break;
      //    } else {
      //      i = 0;
      //      Tables.Add(CurrentTable);
      //      CurrentTable = new Table(_nbSeats);
      //      continue;
      //    }
      //  }
      //  if(!CurrentTable.HasRemainingSeats) {
      //    i = -1;
      //    Tables.Add(CurrentTable);
      //    CurrentTable = new Table(_nbSeats);
      //  }
      //  goodFeeling = true;
      //  foreach(GetReservation_Result seated in CurrentTable.Seateds) {
      //    if(HasBadFeeling(seated.ClientId, CurrentClient.ClientId)) {
      //      goodFeeling = false;
      //      break;
      //    }
      //  }
      //  if(goodFeeling) {
      //    CurrentTable.Add(CurrentClient);
      //    ClientsToSeat.Remove(CurrentClient);
      //  } else {
      //    i++;
      //  }
      //}
    }

    private bool HasBadFeeling(int CliId1, int CliId2) {
      if(CliId1 == CliId2) {
        return true;
      } else {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          if(context.GetFeeling(CliId1, FeelingTypeDislike).Where(client => client.ClientId == CliId2).Count() > 0) {
            return false;
          } else if(context.GetFeeling(CliId2, FeelingTypeDislike).Where(client => client.ClientId == CliId1).Count() > 0) {
            return false;
          }
        }
        return true;
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
