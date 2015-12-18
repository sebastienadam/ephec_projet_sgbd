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
    private IList<F_MENU_Result> starters;
    private IList<F_MENU_Result> meals;
    private IList<F_MENU_Result> desserts;
    private IList<Reservation> reservations;

    public void LoadReception(int id) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        currentReception = context.ReceptionAdmin.Where(rec => rec.ReceptionId == id).First();
        starters = context.F_MENU(id, 1).ToList();
        meals = context.F_MENU(id, 2).ToList();
        desserts = context.F_MENU(id, 3).ToList();
        reservations = context.Reservation.Where(res => res.ReceptionId == id).ToList();
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
        dataGridViewDessert.Columns[1].Visible = true;
        dataGridViewMeal.DataSource = meals;
        foreach(DataGridViewColumn colum in dataGridViewMeal.Columns) {
          colum.Visible = false;
        }
        dataGridViewMeal.Columns[1].Visible = true;
        dataGridViewStarter.DataSource = starters;
        foreach(DataGridViewColumn colum in dataGridViewStarter.Columns) {
          colum.Visible = false;
        }
        dataGridViewStarter.Columns[1].Visible = true;
        dataGridViewReservations.DataSource = reservations;
        foreach(DataGridViewColumn colum in dataGridViewReservations.Columns) {
          colum.Visible = false;
        }
        dataGridViewReservations.Columns[2].Visible = true;
        dataGridViewReservations.Columns[3].Visible = true;
        dataGridViewReservations.Columns[4].Visible = true;
      }
    }
  }
}
