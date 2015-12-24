using Error;
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
    public GetFeeling_Result ClientTo { get; private set; }

    public FormEditFeeling() {
      InitializeComponent();
      CurrentClient = null;
      ClientTo = null;
    }

    public void LoadFeeling(int? clientToId) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        ClientTo = context.GetFeeling(CurrentClient.Id, null).Where(feeling => feeling.ClientId == clientToId).First();
      }
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
        try {
          PopulateFeeling();
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      FeelingType feelingtype = (FeelingType)comboBoxFeeling.SelectedItem;
      if(ClientTo != null && feelingtype != null) {
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.UpdateFeeling(CurrentClient.Id, ClientTo.ClientId, feelingtype.Id, ClientTo.ModifiedAt, CurrentClient.Acronym);
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          if(modelError.Number == ModelError.DATA_NOT_UP_TO_DATE) {
            MessageBox.Show(modelError.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadFeeling(ClientTo.ClientId);
            DialogResult = DialogResult.None;
          } else {
            MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }
  }
}
