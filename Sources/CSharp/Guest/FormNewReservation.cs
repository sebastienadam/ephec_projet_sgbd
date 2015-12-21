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
  public partial class FormNewReservation : Form {
    private ClientSelection _currentClient;

    public ClientSelection CurrentClient { get { return _currentClient; } set { _currentClient = value; } }

    public FormNewReservation() {
      InitializeComponent();
      CurrentClient = null;
    }

    private void FormNewReservation_Load(object sender, EventArgs e) {
      if(CurrentClient != null) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          IQueryable<GetReservableReception_Result> Receptions = context.GetReservableReception(CurrentClient.Id);
          foreach(GetReservableReception_Result rec in Receptions) {
            comboBoxReception.Items.Add(new ReceptionSelection(rec.ReceptionId, rec.DisplayName()));
          }
          comboBoxReception.DisplayMember = "DisplayName";
        }
      }
    }

    private void comboBoxReception_SelectedIndexChanged(object sender, EventArgs e) {
      ReceptionSelection selected = (ReceptionSelection)comboBoxReception.SelectedItem;
      if(selected != null) {
        PopulateMenu(selected.Id);
      }
    }

    private void PopulateMenu(int IdReception) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<GetMenu_Result> Starters = context.GetMenu(IdReception, 1);
        IQueryable<GetMenu_Result> Meals = context.GetMenu(IdReception, 2);
        IQueryable<GetMenu_Result> Desserts = context.GetMenu(IdReception, 3);
        dataGridViewDessert.DataSource = Desserts.ToList();
        foreach(DataGridViewColumn colum in dataGridViewDessert.Columns) {
          colum.Visible = false;
        }
        dataGridViewDessert.Columns[1].Visible = true;
        dataGridViewMeal.DataSource = Meals.ToList();
        foreach(DataGridViewColumn colum in dataGridViewMeal.Columns) {
          colum.Visible = false;
        }
        dataGridViewMeal.Columns[1].Visible = true;
        dataGridViewStarter.DataSource = Starters.ToList();
        foreach(DataGridViewColumn colum in dataGridViewStarter.Columns) {
          colum.Visible = false;
        }
        dataGridViewStarter.Columns[1].Visible = true;
      }
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      ReceptionSelection selectedRec = (ReceptionSelection)comboBoxReception.SelectedItem;
      GetMenu_Result selectedMenu;
      if(selectedRec != null) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          context.NewReservation(selectedRec.Id, CurrentClient.Id, CurrentClient.Acronym);
          if(dataGridViewDessert.SelectedRows.Count == 1) {
            selectedMenu = (GetMenu_Result)dataGridViewDessert.SelectedRows[0].DataBoundItem;
            context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
          }
          if(dataGridViewMeal.SelectedRows.Count == 1) {
            selectedMenu = (GetMenu_Result)dataGridViewMeal.SelectedRows[0].DataBoundItem;
            context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
          }
          if(dataGridViewStarter.SelectedRows.Count == 1) {
            selectedMenu = (GetMenu_Result)dataGridViewStarter.SelectedRows[0].DataBoundItem;
            context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
          }
        }
        this.Close();
      }
    }
  }
}
