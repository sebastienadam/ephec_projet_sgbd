using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest {
  public partial class FormNewFeeling : Form {
    public ClientSelection CurrentClient { get; set; }
    public FormNewFeeling() {
      InitializeComponent();
    }

    private void PopulateClients() {
      IQueryable<GetUnfeeling_Result> clients;
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        clients = context.GetUnfeeling(CurrentClient.Id);
        foreach(GetUnfeeling_Result client in clients) {
          comboBoxClients.Items.Add(new ClientSelection(client.ClientId, client.DisplayName(), client.LastName));
        }
        comboBoxClients.DisplayMember = "DisplayName";
      }
    }

    private void PopulateFeeling() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        comboBoxFeeling.DataSource = context.FeelingType.ToList();
      }
      comboBoxFeeling.DisplayMember = "Label";
    }

    private void FormNewFeeling_Load(object sender, EventArgs e) {
      PopulateClients();
      PopulateFeeling();
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      ClientSelection client = (ClientSelection)comboBoxClients.SelectedItem;
      FeelingType feelingtype = (FeelingType)comboBoxFeeling.SelectedItem;
      if((client != null) && (feelingtype != null)) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          context.NewFeeling(CurrentClient.Id, client.Id,feelingtype.Id,CurrentClient.Acronym);
        }
      }
    }
  }
}
