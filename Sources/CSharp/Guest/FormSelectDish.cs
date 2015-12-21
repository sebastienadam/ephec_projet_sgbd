using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest {
  public partial class FormSelectDish : Form {
    private ClientSelection CurrentClient;
    public int? SelectedDishId { get; private set; }
    public FormSelectDish() {
      InitializeComponent();
      SelectedDishId = null;
    }

    public void PopulateList(int recId, int dtyId, ClientSelection client) {
      IQueryable<GetMenu_Result> dishes;
      CurrentClient = client;
      int DishTypeStarter = Int32.Parse(ConfigurationManager.AppSettings["DishTypeStarter"]);
      int DishTypeMainDish = Int32.Parse(ConfigurationManager.AppSettings["DishTypeMainDish"]);
      int DishTypeDessert = Int32.Parse(ConfigurationManager.AppSettings["DishTypeDessert"]);
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dishes = context.GetMenu(recId, dtyId);
        dataGridViewDish.DataSource = dishes.ToList();
        foreach(DataGridViewColumn colum in dataGridViewDish.Columns) {
          colum.Visible = false;
        }
        dataGridViewDish.Columns[1].Visible = true;
      }
      if(dtyId == DishTypeStarter) {
        labelSelection.Text = "Nouvelle entrée :";
      } else if(dtyId == DishTypeMainDish) {
        labelSelection.Text = "Nouveau plat principal :";
      } else if(dtyId == DishTypeDessert) {
        labelSelection.Text = "Nouveau dessert :";
      }
    }

    private void dataGridViewDish_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      ColorizeMenu((DataGridView)sender);
    }

    private void ColorizeMenu(DataGridView source) {
      int FeelingTypeLike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeLike"]);
      int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);
      GetMenu_Result item;
      IQueryable<GetWishedDish_Result> liked;
      IQueryable<GetWishedDish_Result> disliked;
      Color color;
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        liked = context.GetWishedDish(CurrentClient.Id, FeelingTypeLike);
        disliked = context.GetWishedDish(CurrentClient.Id, FeelingTypeDislike);
        foreach(DataGridViewRow row in source.Rows) {
          item = (GetMenu_Result)row.DataBoundItem;
          if(liked.Where(mainCourse => mainCourse.DishId == item.DishId).Count() > 0) {
            color = Color.Green;
          } else if(disliked.Where(mainCourse => mainCourse.DishId == item.DishId).Count() > 0) {
            color = Color.Red;
          } else {
            color = Color.Black;
          }
          row.DefaultCellStyle.ForeColor = color;
          row.DefaultCellStyle.SelectionBackColor = color;
        }
      }
    }

    private void buttonOK_Click(object sender, EventArgs e) {
      if(dataGridViewDish.SelectedRows.Count == 1) {
        SelectedDishId = ((GetMenu_Result)dataGridViewDish.SelectedRows[0].DataBoundItem).DishId;
      }
    }
  }
}
