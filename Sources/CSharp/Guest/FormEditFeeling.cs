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
  public partial class FormEditFeeling : Form {
    public ClientSelection CurrentClient { get; set; }
    public GetFeeling_Result ClientTo { get; set; }

    public FormEditFeeling() {
      InitializeComponent();
      CurrentClient = null;
      ClientTo = null;
    }

    private void PopulateFeeling() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        comboBoxFeeling.DataSource = context.FeelingType.ToList();
      }
      comboBoxFeeling.DisplayMember = "Label";
    }

    private void FormEditFeeling_Load(object sender, EventArgs e) {
      if(CurrentClient != null && ClientTo != null) {
        textBoxClient.Text = ClientTo.DisplayName();
        PopulateFeeling();
      }
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      FeelingType feelingtype = (FeelingType)comboBoxFeeling.SelectedItem;
      if(ClientTo != null && feelingtype != null) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          context.UpdateFeeling(CurrentClient.Id, ClientTo.ClientId, feelingtype.Id, ClientTo.ModifiedAt, CurrentClient.Acronym);
        }
      }
    }
  }
}
