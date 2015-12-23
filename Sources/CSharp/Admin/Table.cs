using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin {
  public class Table {
    public bool HasRemainingSeats { get { return Seateds.Count < NbSeats; } }
    public int NbSeats { get; private set; }
    public int RemainingSeats { get { return NbSeats - Seateds.Count; } }
    public List<GetReservation_Result> Seateds { get; private set; }

    public Table(int nbSeats) {
      NbSeats = nbSeats;
      Seateds = new List<GetReservation_Result>();
    }

    public void Add(GetReservation_Result seated) {
      if(HasRemainingSeats) {
        Seateds.Add(seated);
      } else {
        throw new OverflowException("There are no more empty seat at the table.");
      }
    }
  }
}
