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
  public partial class FormNewDishWish : Form {
    public ClientSelection CurrentClient { get; set; }

    public FormNewDishWish() {
      InitializeComponent();
      CurrentClient = null;
    }

    private void FormNewDishWish_Load(object sender, EventArgs e) {
      if(CurrentClient != null) {
        PopulateDishes();
        PopulateFeeling();
      }
    }

    private void PopulateDishes() {
      IQueryable<GetUnwishedDish_Result> dishes;
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dishes = context.GetUnwishedDish(CurrentClient.Id);
        foreach(GetUnwishedDish_Result dish in dishes) {
          comboBoxDishes.Items.Add(new DishWishSelection(dish.DishId, dish.DisplayName()));
        }
        comboBoxDishes.DisplayMember = "DisplayName";
      }
    }

    private void PopulateFeeling() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        comboBoxFeeling.DataSource = context.FeelingType.ToList();
      }
      comboBoxFeeling.DisplayMember = "Label";
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      DishWishSelection dish = (DishWishSelection)comboBoxDishes.SelectedItem;
      FeelingType feelingtype = (FeelingType)comboBoxFeeling.SelectedItem;
      if((dish != null) && (feelingtype != null)) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          context.NewWishedDish(CurrentClient.Id, dish.DishId, feelingtype.Id, CurrentClient.Acronym);
        }
      }
    }
  }
}
