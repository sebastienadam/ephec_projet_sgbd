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
          comboBoxCurrentClient.Items.Add(new ClientSelection(client.ClientId, client.DisplayName()));
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
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          IQueryable<GetReservedReception_Result> Receptions = context.GetReservedReception(CurrentClient.Id);
          IQueryable <GetFeeling_Result> Feelings = context.GetFeeling(CurrentClient.Id, null);
          IQueryable<GetWishedDish_Result> DishWishs = context.GetWishedDish(CurrentClient.Id, null);
          dataGridViewDishWish.DataSource = DishWishs.ToList();
          foreach(DataGridViewColumn column in dataGridViewDishWish.Columns) {
            column.Visible = false;
          }
          dataGridViewDishWish.Columns[0].Visible = true;
          dataGridViewDishWish.Columns[1].Visible = true;
          dataGridViewDishWish.Columns[2].Visible = true;
          dataGridViewFeeling.DataSource = Feelings.ToList();
          dataGridViewFeeling.DataSource = DishWishs.ToList();
          foreach(DataGridViewColumn column in dataGridViewFeeling.Columns) {
            column.Visible = false;
          }
          dataGridViewFeeling.Columns[0].Visible = true;
          dataGridViewFeeling.Columns[1].Visible = true;
          dataGridViewFeeling.Columns[2].Visible = true;
          dataGridViewReceptions.DataSource = Receptions.ToList();
          dataGridViewReceptions.Columns[3].Visible = false;
          dataGridViewReceptions.Columns[4].Visible = false;
          dataGridViewReceptions.Columns[5].Visible = false;
        }
      }
    }
  }
}
