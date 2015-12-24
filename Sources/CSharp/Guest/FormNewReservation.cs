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
using System.Configuration;
using Error;

namespace Guest {
  public partial class FormNewReservation : Form {
    private int DishTypeStarter = Int32.Parse(ConfigurationManager.AppSettings["DishTypeStarter"]);
    private int DishTypeMainDish = Int32.Parse(ConfigurationManager.AppSettings["DishTypeMainDish"]);
    private int DishTypeDessert = Int32.Parse(ConfigurationManager.AppSettings["DishTypeDessert"]);
    private int FeelingTypeLike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeLike"]);
    private int FeelingTypeDislike = Int32.Parse(ConfigurationManager.AppSettings["FeelingTypeDislike"]);

    private ClientSelection _currentClient;

    public ClientSelection CurrentClient { get { return _currentClient; } set { _currentClient = value; } }

    public FormNewReservation() {
      InitializeComponent();
      CurrentClient = null;
    }

    private void FormNewReservation_Load(object sender, EventArgs e) {
      if(CurrentClient != null) {
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            IQueryable<GetReservableReception_Result> Receptions = context.GetReservableReception(CurrentClient.Id);
            foreach(GetReservableReception_Result rec in Receptions) {
              comboBoxReception.Items.Add(new ReceptionSelection(rec.ReceptionId, rec.DisplayName()));
            }
            comboBoxReception.DisplayMember = "DisplayName";
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          DialogResult = DialogResult.Abort;
          Close();
        }
      }
    }

    private void comboBoxReception_SelectedIndexChanged(object sender, EventArgs e) {
      ReceptionSelection selected = (ReceptionSelection)comboBoxReception.SelectedItem;
      if(selected != null) {
        try {
          PopulateMenu(selected.Id);
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void PopulateMenu(int IdReception) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        IQueryable<GetMenu_Result> Starters = context.GetMenu(IdReception, DishTypeStarter);
        IQueryable<GetMenu_Result> MainCourse = context.GetMenu(IdReception, DishTypeMainDish);
        IQueryable<GetMenu_Result> Desserts = context.GetMenu(IdReception, DishTypeDessert);
        dataGridViewDessert.DataSource = Desserts.ToList();
        foreach(DataGridViewColumn colum in dataGridViewDessert.Columns) {
          colum.Visible = false;
        }
        dataGridViewDessert.Columns[1].Visible = true;
        dataGridViewMainCourse.DataSource = MainCourse.ToList();
        foreach(DataGridViewColumn colum in dataGridViewMainCourse.Columns) {
          colum.Visible = false;
        }
        dataGridViewMainCourse.Columns[1].Visible = true;
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
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.NewReservation(selectedRec.Id, CurrentClient.Id, CurrentClient.Acronym);
            if(dataGridViewDessert.SelectedRows.Count == 1) {
              selectedMenu = (GetMenu_Result)dataGridViewDessert.SelectedRows[0].DataBoundItem;
              context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
            }
            if(dataGridViewMainCourse.SelectedRows.Count == 1) {
              selectedMenu = (GetMenu_Result)dataGridViewMainCourse.SelectedRows[0].DataBoundItem;
              context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
            }
            if(dataGridViewStarter.SelectedRows.Count == 1) {
              selectedMenu = (GetMenu_Result)dataGridViewStarter.SelectedRows[0].DataBoundItem;
              context.NewReservedDish(CurrentClient.Id, selectedMenu.DishId, selectedRec.Id, CurrentClient.Acronym);
            }
          }
          Close();
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          DialogResult = DialogResult.None;
        }
      }
    }

    private void dataGridViewStarter_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      ColorizeMenu((DataGridView)sender);
    }

    private void ColorizeMenu(DataGridView source) {
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

    private void dataGridViewMainCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      ColorizeMenu((DataGridView)sender);
    }

    private void dataGridViewDessert_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      ColorizeMenu((DataGridView)sender);
    }
  }
}
