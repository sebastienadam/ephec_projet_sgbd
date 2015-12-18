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

namespace Admin {
  public partial class FormReceptionDetail : Form {
    private ReceptionAdmin currentReception;
    private IList<Model.Menu> starters;
    private IList<Model.Menu> meals;
    private IList<Model.Menu> desserts;

    public void LoadReception(int id) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        currentReception = context.ReceptionAdmin.Where(rec => rec.ReceptionId == id).First();
        starters = context.Menu.Where(menu => (menu.ReceptionId == id) && (menu.DishTypeId == 1)).ToList();
        meals = context.Menu.Where(menu => (menu.ReceptionId == id) && (menu.DishTypeId == 2)).ToList();
        desserts = context.Menu.Where(menu => (menu.ReceptionId == id) && (menu.DishTypeId == 3)).ToList();
      }
    }

    public FormReceptionDetail() {
      currentReception = null;
      starters = null;
      meals = null;
      desserts = null;
      InitializeComponent();
    }

    private void FormReceptionDetail_Load(object sender, EventArgs e) {
      if(currentReception != null) {
        textBoxId.Text = currentReception.ReceptionId.ToString();
        textBoxName.Text = currentReception.Name;
        dateTimePickerBookingClosingDate.Value = currentReception.BookingClosingDate;
        dateTimePickerDate.Value = currentReception.Date;
        numericUpDownCapacity.Value = currentReception.Capacity;
        numericUpDownSeatsPerTable.Value = currentReception.SeatsPerTable;
        checkBoxValid.Checked = currentReception.IsValid;
        textBoxModifiedBy.Text = currentReception.ModifiedBy;
        dateTimePickerModifiedAt.Value = (DateTime)currentReception.ModifiedAt;
        dataGridViewDessert.DataSource = desserts;
        foreach(DataGridViewColumn colum in dataGridViewDessert.Columns) {
          colum.Visible = false;
        }
        dataGridViewDessert.Columns[3].Visible = true;
        dataGridViewMeal.DataSource = meals;
        foreach(DataGridViewColumn colum in dataGridViewMeal.Columns) {
          colum.Visible = false;
        }
        dataGridViewMeal.Columns[3].Visible = true;
        dataGridViewStarter.DataSource = starters;
        foreach(DataGridViewColumn colum in dataGridViewStarter.Columns) {
          colum.Visible = false;
        }
        dataGridViewStarter.Columns[3].Visible = true;
      }
    }
  }
}
