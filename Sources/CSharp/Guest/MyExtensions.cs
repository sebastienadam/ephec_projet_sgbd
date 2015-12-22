using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Guest {
  public static class MyExtensions {
    public static string DisplayName(this Client client) {
      return String.Format("{0} {1}", client.FirstName, client.LastName);
    }
    public static string DisplayName(this GetReservableReception_Result reception) {
      return String.Format("{0} du {1}", reception.Name, reception.Date.ToString("dd MMMM yyyy"));
    }
    public static string DisplayName(this GetUnwishedDish_Result dishWish) {
      return String.Format("{0} ({1})", dishWish.Name, dishWish.Type);
    }
    public static string DisplayName(this GetWishedDish_Result dishWish) {
      return String.Format("{0} ({1})", dishWish.DishName, dishWish.DishType);
    }
  }
}
