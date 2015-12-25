using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin {
  public class Disliked {
    private int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);
    public int ClientId { get; private set; }
    public IList<int?> DislikedIds { get; private set; }

    public Disliked(int Id) {
      ClientId = Id;
      LoadDisliked();
    }

    private void LoadDisliked() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        DislikedIds = (from client in context.GetFeeling(ClientId, FeelingTypeDislike) select client.ClientId).ToList();
      }
    }
  }
}
