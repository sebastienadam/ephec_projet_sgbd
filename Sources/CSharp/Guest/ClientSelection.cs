﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guest {
  public class ClientSelection {
    public int Id { get; private set; }
    public string DisplayName { get; private set; }
    public string Acronym { get; private set; }

    public ClientSelection(int i, string dn, string a) {
      DisplayName = dn;
      Id = i;
      Acronym = a;
    }
  }
}
