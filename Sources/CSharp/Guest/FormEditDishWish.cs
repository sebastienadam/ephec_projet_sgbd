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
    public GetWishedDish_Result CurrentDish { get; set; }
    public FormEditDishWish() {
      InitializeComponent();
      CurrentClient = null;
      CurrentDish = null;
    }

    private void FormEditDishWish_Load(object sender, EventArgs e) {
      if(CurrentClient != null && CurrentDish != null) {
        textBoxDish.Text = CurrentDish.DisplayName();
        PopulateFeeling();
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
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          context.UpdateWishedDish(CurrentClient.Id, CurrentDish.DishId, feelingtype.Id, CurrentDish.ModifiedAt, CurrentClient.Acronym);
        }
      }
    }
  }
}
