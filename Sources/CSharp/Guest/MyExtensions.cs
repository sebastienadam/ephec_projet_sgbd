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
  }
}
