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

namespace Admin {
  public partial class FormMain : Form {
    public FormMain() {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<ReceptionAdmin> Receptions = from item in context.Reception1 select item;
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
    }

    private void dataGridViewReceptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      foreach(DataGridViewRow row in dataGridViewReceptions.Rows) {
        if((bool)row.Cells[5].Value) {
          row.DefaultCellStyle.Font = new Font(dataGridViewReceptions.Font, FontStyle.Bold);
        } else {
          row.DefaultCellStyle.ForeColor = Color.Red;
        }
      }
    }
  }
}
