using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guest {
  public class ReceptionSelection {
    public int Id { get; private set; }
    public string DisplayName { get; private set; }

    public ReceptionSelection(int i, string dn) {
      Id = i;
      DisplayName = dn;
    }
  }
}
