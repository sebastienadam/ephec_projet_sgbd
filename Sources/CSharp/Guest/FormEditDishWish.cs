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
  public partial class FormEditDishWish : Form {
    public ClientSelection CurrentClient { get; set; }
    public GetWishedDish_Result CurrentDish { get; private set; }
    public FormEditDishWish() {
      InitializeComponent();
      CurrentClient = null;
      CurrentDish = null;
    }

    private void FormEditDishWish_Load(object sender, EventArgs e) {
      if(CurrentClient != null && CurrentDish != null) {
        textBoxDish.Text = CurrentDish.DisplayName();
        try {
          PopulateFeeling();
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    public void LoadDishWish(int dishId) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        CurrentDish = context.GetWishedDish(CurrentClient.Id, null).Where(dish => dish.DishId == dishId).First();
      }
    }

    private void PopulateFeeling() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        comboBoxFeeling.DataSource = context.FeelingType.ToList();
      }
      comboBoxFeeling.DisplayMember = "Label";
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      FeelingType feelingtype = (FeelingType)comboBoxFeeling.SelectedItem;
      if(CurrentDish != null && feelingtype != null) {
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.UpdateWishedDish(CurrentClient.Id, CurrentDish.DishId, feelingtype.Id, CurrentDish.ModifiedAt, CurrentClient.Acronym);
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          if(modelError.Number == ModelError.DATA_NOT_UP_TO_DATE) {
            MessageBox.Show(modelError.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDishWish(CurrentDish.DishId);
            DialogResult = DialogResult.None;
          } else {
            MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }
  }
}
