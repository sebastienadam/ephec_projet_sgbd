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
        DialogResult result;
        FormReservationDetails form = new FormReservationDetails();
        form.CurrentClient = CurrentClient;
        form.LoadReception(((GetReservedReception_Result)dataGridViewReservations.SelectedRows[0].DataBoundItem).ReceptionId);
        result = form.ShowDialog();
        if(result == DialogResult.OK) {
          PopulateReceptions();
        }
      }
    }

    private void dataGridViewDishWish_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      int FeelingTypeLike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeLike"]);
      int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);
      Color color;
      foreach(DataGridViewRow row in dataGridViewDishWish.Rows) {
        GetWishedDish_Result dishWish = (GetWishedDish_Result)row.DataBoundItem;
        if(dishWish.FeelingTypeId == FeelingTypeLike) {
          color = Color.Green;
        } else if(dishWish.FeelingTypeId == FeelingTypeDislike) {
          color = Color.Red;
        } else {
          color = Color.Black;
        }
        row.DefaultCellStyle.ForeColor = color;
        row.DefaultCellStyle.SelectionBackColor = color;
      }
    }

    private void dataGridViewFeeling_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      int FeelingTypeLike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeLike"]);
      int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);
      Color color;
      foreach(DataGridViewRow row in dataGridViewFeeling.Rows) {
        GetFeeling_Result feeling = (GetFeeling_Result)row.DataBoundItem;
        if(feeling.FeelingTypeId == FeelingTypeLike) {
          color = Color.Green;
        } else if(feeling.FeelingTypeId == FeelingTypeDislike) {
          color = Color.Red;
        } else {
          color = Color.Black;
        }
        row.DefaultCellStyle.ForeColor = color;
        row.DefaultCellStyle.SelectionBackColor = color;
      }
    }

    private void buttonDeleteReservations_Click(object sender, EventArgs e) {
      if(dataGridViewReservations.SelectedRows.Count == 1) {
        GetReservedReception_Result selected = (GetReservedReception_Result)dataGridViewReservations.SelectedRows[0].DataBoundItem;
        DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la réservation " + selected.ReceptionName + "?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        if(result == DialogResult.Yes) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.DeleteReservation(selected.ReceptionId, CurrentClient.Id, selected.ModifiedAt);
          }
          PopulateReceptions();
        }
      }
    }

    private void buttonAddDishWish_Click(object sender, EventArgs e) {
      if(CurrentClient != null) {
        FormNewDishWish form = new FormNewDishWish();
        form.CurrentClient = CurrentClient;
        DialogResult result = form.ShowDialog();
        if(result == DialogResult.OK) {
          PopulateDishWishes();
        }
      }
    }

    private void buttonEditDishWish_Click(object sender, EventArgs e) {
      if(dataGridViewDishWish.SelectedRows.Count == 1) {
        GetWishedDish_Result selected = (GetWishedDish_Result)dataGridViewDishWish.SelectedRows[0].DataBoundItem;
        FormEditDishWish form = new FormEditDishWish();
        form.CurrentDish = selected;
        form.CurrentClient = CurrentClient;
        DialogResult result = form.ShowDialog();
        if(result == DialogResult.OK) {
          PopulateDishWishes();
        }
      }
    }

    private void buttonDeleteDishWish_Click(object sender, EventArgs e) {
      if(dataGridViewDishWish.SelectedRows.Count == 1) {
        GetWishedDish_Result selected = (GetWishedDish_Result)dataGridViewDishWish.SelectedRows[0].DataBoundItem;
        DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la ressenti pour le plat '" + selected.DisplayName() + "'?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        if(result == DialogResult.Yes) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.DeleteDishWish(CurrentClient.Id, selected.DishId, selected.ModifiedAt);
          }
          PopulateDishWishes();
        }
      }
    }

    private void buttonAddFeeling_Click(object sender, EventArgs e) {
      if(CurrentClient != null) {
        FormNewFeeling form = new FormNewFeeling();
        form.CurrentClient = CurrentClient;
        DialogResult result = form.ShowDialog();
        if(result == DialogResult.OK) {
          PopulateFeelings();
        }
      }
    }

    private void buttonEditFeeling_Click(object sender, EventArgs e) {
      if(dataGridViewFeeling.SelectedRows.Count == 1) {
        GetFeeling_Result selected = (GetFeeling_Result)dataGridViewFeeling.SelectedRows[0].DataBoundItem;
        FormEditFeeling form = new FormEditFeeling();
        form.ClientTo = selected;
        form.CurrentClient = CurrentClient;
        DialogResult result = form.ShowDialog();
        if(result == DialogResult.OK) {
          PopulateFeelings();
        }
      }
    }

    private void buttonDeleteFeeling_Click(object sender, EventArgs e) {
      if(dataGridViewFeeling.SelectedRows.Count == 1) {
        GetFeeling_Result selected = (GetFeeling_Result)dataGridViewFeeling.SelectedRows[0].DataBoundItem;
        DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la ressenti pour le client '" + selected.DisplayName() + "'?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        if(result == DialogResult.Yes) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.DeleteFeeling(CurrentClient.Id, selected.ClientId, selected.ModifiedAt);
          }
          PopulateFeelings();
        }
      }
    }
  }
}
