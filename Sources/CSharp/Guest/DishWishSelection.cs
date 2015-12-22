using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guest {
  public class DishWishSelection {
    public int DishId { get; set; }
    public string DisplayName { get; set; }

    public DishWishSelection(int id, string dn) {
      DishId = id;
      DisplayName = dn;
    }
  }
}
