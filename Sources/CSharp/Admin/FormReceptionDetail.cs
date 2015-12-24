using Error;
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

namespace Admin {
  public partial class FormReceptionDetail : Form {
    private Reception currentReception;
    private TablesMapGenerator tablesMapGenerator;
    private IList<GetTablesMap_Result> tablesMap;
    private int DishTypeStarter = Int32.Parse(ConfigurationManager.AppSettings["DishTypeStarter"]);
    private int DishTypeMainDish = Int32.Parse(ConfigurationManager.AppSettings["DishTypeMainDish"]);
    private int DishTypeDessert = Int32.Parse(ConfigurationManager.AppSettings["DishTypeDessert"]);
    private string Acronym = ConfigurationManager.AppSettings["Acronym"].ToString();

    public void SetReception(int id) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        currentReception = context.Reception.Where(rec => rec.ReceptionId == id).First();
      }
    }

    public FormReceptionDetail() {
      InitializeComponent();
      currentReception = null;
      tablesMapGenerator = null;
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
        try {
          PopulateDesserts();
          PopulateMainCourses();
          PopulateStarters();
          PopulateReservations();
          PopulateTablesMap();
          if(tablesMap.Count == 0) {
            buttonTablesMapGenerate.Enabled = true;
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void PopulateDesserts() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dataGridViewDesserts.DataSource = context.GetMenu(currentReception.ReceptionId, DishTypeDessert).ToList();
      }
      foreach(DataGridViewColumn colum in dataGridViewDesserts.Columns) {
        colum.Visible = false;
      }
      dataGridViewDesserts.Columns[1].Visible = true;
    }
    private void PopulateMainCourses() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dataGridViewMainCourses.DataSource = context.GetMenu(currentReception.ReceptionId, DishTypeMainDish).ToList();
      }
      foreach(DataGridViewColumn colum in dataGridViewMainCourses.Columns) {
        colum.Visible = false;
      }
      dataGridViewMainCourses.Columns[1].Visible = true;
    }
    private void PopulateStarters() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dataGridViewStarters.DataSource = context.GetMenu(currentReception.ReceptionId, DishTypeStarter).ToList();
      }
      foreach(DataGridViewColumn colum in dataGridViewStarters.Columns) {
        colum.Visible = false;
      }
      dataGridViewStarters.Columns[1].Visible = true;
    }
    private void PopulateReservations() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        dataGridViewReservations.DataSource = context.Reservation.Where(res => res.ReceptionId == currentReception.ReceptionId).ToList();
      }
      foreach(DataGridViewColumn colum in dataGridViewReservations.Columns) {
        colum.Visible = false;
      }
      dataGridViewReservations.Columns[2].Visible = true;
      dataGridViewReservations.Columns[3].Visible = true;
      dataGridViewReservations.Columns[4].Visible = true;
    }
    private void PopulateTablesMap() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        tablesMap = context.GetTablesMap(currentReception.ReceptionId, null).ToList();
      }
      ShowTablesMap();
    }

    private void ShowTablesMap() {
      dataGridViewTablesMap.DataSource = tablesMap;
      foreach(DataGridViewColumn colum in dataGridViewTablesMap.Columns) {
        colum.Visible = false;
      }
      dataGridViewTablesMap.Columns[0].Visible = true;
      dataGridViewTablesMap.Columns[1].Visible = true;
      dataGridViewTablesMap.Columns[2].Visible = true;
      dataGridViewTablesMap.Columns[3].Visible = true;
    }

    private void buttonTablesMapGenerate_Click(object sender, EventArgs e) {
      tablesMapGenerator = new TablesMapGenerator(currentReception.ReceptionId);
      tablesMapGenerator.Generate();
      tablesMap = tablesMapGenerator.ToList();
      buttonTablesMapSave.Enabled = true;
      buttonTablesMapGenerate.Enabled = false;
      ShowTablesMap();
    }

    private void buttonTablesMapSave_Click(object sender, EventArgs e) {
      if(tablesMapGenerator != null) {
        try {
          tablesMapGenerator.Save(Acronym);
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        buttonTablesMapSave.Enabled = false;
        PopulateTablesMap();
      }
    }
  }
}
