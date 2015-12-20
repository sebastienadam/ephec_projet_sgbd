using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guest {
  public class ClientSelection {
    public int Id { get; set; }
    public string DisplayName { get; set; }

    public ClientSelection(int i, string dn) {
      DisplayName = dn;
      Id = i;
    }
  }
}
