using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Error;

namespace Admin {
  public partial class FormMain : Form {
    public FormMain() {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e) {
      try {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          IQueryable<Reception> Receptions = from item in context.Reception select item;
          IQueryable<Client> Clients = from item in context.Client select item;
          IQueryable<Dish> Dishes = from item in context.Dish select item;
          dataGridViewReceptions.DataSource = Receptions.ToList();
          dataGridViewReceptions.Columns[6].Visible = false;
          dataGridViewReceptions.Columns[7].Visible = false;
          dataGridViewReceptions.Columns[8].Visible = false;
          dataGridViewClients.DataSource = Clients.ToList();
          dataGridViewClients.Columns[0].Visible = false;
          dataGridViewClients.Columns[6].Visible = false;
          dataGridViewClients.Columns[7].Visible = false;
          dataGridViewClients.Columns[8].Visible = false;
          dataGridViewDish.DataSource = Dishes.OrderBy(dish => dish.DishTypeId).ThenBy(dish => dish.Name).ToList();
          dataGridViewDish.Columns[2].Visible = false;
          dataGridViewDish.Columns[3].Visible = false;
          dataGridViewDish.Columns[4].Visible = false;
          dataGridViewDish.Columns[5].Visible = false;
        }
      } catch(Exception ex) {
        ModelError modelError = new ModelError(ex);
        MessageBox.Show(modelError.Message,"Erreur fatale!",MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }

    private void dataGridViewReceptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      foreach(DataGridViewRow row in dataGridViewReceptions.Rows) {
        Reception rec = (Reception)row.DataBoundItem;
        if(rec.IsValid) {
          row.DefaultCellStyle.Font = new Font(dataGridViewReceptions.Font, FontStyle.Bold);
        } else {
          row.DefaultCellStyle.ForeColor = Color.Red;
        }
      }
    }

    private void dataGridViewReceptions_DoubleClick(object sender, EventArgs e) {
      ReceptionDetail();
    }

    private void buttonDetails_Click(object sender, EventArgs e) {
      ReceptionDetail();
    }

    private void ReceptionDetail() {
      Reception rec = (Reception)dataGridViewReceptions.SelectedRows[0].DataBoundItem;
      FormReceptionDetail formDetail = new FormReceptionDetail();
      formDetail.SetReception(rec.ReceptionId);
      formDetail.ShowDialog();
    }
  }
}
