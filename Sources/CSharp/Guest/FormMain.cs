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
  public partial class FormMain : Form {
    private ClientSelection CurrentClient;

    public FormMain() {
      InitializeComponent();
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<Client> Clients = from item in context.Client select item;
        foreach(Client client in Clients) {
          comboBoxCurrentClient.Items.Add(new ClientSelection(client.ClientId, client.DisplayName(), client.Acronym));
        }
        comboBoxCurrentClient.DisplayMember = "DisplayName";
      }
    }

    private void comboBoxCurrentClient_SelectedValueChanged(object sender, EventArgs e) {
      CurrentClient = (ClientSelection)comboBoxCurrentClient.SelectedItem;
      PopulateGrids();
    }

    private void PopulateGrids() {
      if(CurrentClient != null) {
        PopulateReceptions();
        PopulateDishWishes();
        PopulateFeelings();
      }
    }

    private void PopulateReceptions() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<GetReservedReception_Result> Receptions = context.GetReservedReception(CurrentClient.Id);
        dataGridViewReservations.DataSource = Receptions.ToList();
        dataGridViewReservations.Columns[3].Visible = false;
        dataGridViewReservations.Columns[4].Visible = false;
        dataGridViewReservations.Columns[5].Visible = false;
      }
    }

    private void PopulateDishWishes() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<GetWishedDish_Result> DishWishs = context.GetWishedDish(CurrentClient.Id, null);
        dataGridViewDishWish.DataSource = DishWishs.ToList();
        foreach(DataGridViewColumn column in dataGridViewDishWish.Columns) {
          column.Visible = false;
        }
        dataGridViewDishWish.Columns[0].Visible = true;
        dataGridViewDishWish.Columns[1].Visible = true;
        dataGridViewDishWish.Columns[2].Visible = true;
      }
    }

    private void PopulateFeelings() {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<GetFeeling_Result> Feelings = context.GetFeeling(CurrentClient.Id, null);
        dataGridViewFeeling.DataSource = Feelings.ToList();
        foreach(DataGridViewColumn column in dataGridViewFeeling.Columns) {
          column.Visible = false;
        }
        dataGridViewFeeling.Columns[0].Visible = true;
        dataGridViewFeeling.Columns[1].Visible = true;
        dataGridViewFeeling.Columns[2].Visible = true;
      }
    }

    private void buttonAddReservations_Click(object sender, EventArgs e) {
      if(CurrentClient != null) {
        FormNewReservation form = new FormNewReservation();
        form.CurrentClient = CurrentClient;
        form.ShowDialog();
        PopulateReceptions();
      }
    }

    private void buttonDetailsReservations_Click(object sender, EventArgs e) {
      if(dataGridViewReservations.SelectedRows.Count == 1) {
        FormReservationDetails form = new FormReservationDetails();
        form.CurrentClient = CurrentClient;
        form.LoadReception(((GetReservedReception_Result)dataGridViewReservations.SelectedRows[0].DataBoundItem).ReceptionId);
        form.ShowDialog();
      }
    }
  }
}
