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

namespace Guest {
  public partial class FormReservationDetails : Form {
    private ClientSelection _currentClient;
    private GetReservedReception_Result _currentReception;
    private Dish _starter;
    private Dish _mainCourse;
    private Dish _dessert;
    private GetReservedDish_Result _starter_old;
    private GetReservedDish_Result _mainCourse_old;
    private GetReservedDish_Result _dessert_old;
    private int DishTypeStarter = Int32.Parse(ConfigurationManager.AppSettings["DishTypeStarter"]);
    private int DishTypeMainDish = Int32.Parse(ConfigurationManager.AppSettings["DishTypeMainDish"]);
    private int DishTypeDessert = Int32.Parse(ConfigurationManager.AppSettings["DishTypeDessert"]);

    public ClientSelection CurrentClient { get { return _currentClient; } set { _currentClient = value; } }
    public GetReservedReception_Result CurrentReception { get { return _currentReception; } private set { _currentReception = value; } }

    public FormReservationDetails() {
      InitializeComponent();
      CurrentClient = null;
      CurrentReception = null;
      _starter = null;
      _mainCourse = null;
      _dessert = null;
      _starter_old = null;
      _mainCourse_old = null;
      _dessert_old = null;
    }

    public void LoadReception(int id) {
      if(CurrentClient != null) {
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          IQueryable<GetReservedReception_Result> recs = context.GetReservedReception(CurrentClient.Id);
          if(recs.Where(rec => rec.ReceptionId == id).Count() == 1) {
            CurrentReception = recs.Where(rec => rec.ReceptionId == id).First();
          }
        }
      }
    }

    private void FormReservationDetails_Load(object sender, EventArgs e) {
      if((CurrentClient != null) && (CurrentReception != null)) {
        textBoxDate.Text = CurrentReception.ReceptionDate.ToString("dd MMMM yyyy");
        textBoxName.Text = CurrentReception.ReceptionName;
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            IQueryable<GetReservedDish_Result> _reservedDishes = context.GetReservedDish(CurrentReception.ReceptionId, CurrentClient.Id);
            if(_reservedDishes.Where(dish => dish.DishTypeId == DishTypeStarter).Count() == 1) {
              _starter_old = _reservedDishes.Where(dish => dish.DishTypeId == DishTypeStarter).First();
              _starter = context.Dish.Where(dish => dish.DishId == _starter_old.DishId).First();
              textBoxStarter.Text = _starter.Name;
            }
            if(_reservedDishes.Where(dish => dish.DishTypeId == DishTypeMainDish).Count() == 1) {
              _mainCourse_old = _reservedDishes.Where(dish => dish.DishTypeId == DishTypeMainDish).First();
              _mainCourse = context.Dish.Where(dish => dish.DishId == _mainCourse_old.DishId).First();
              textBoxMainCourse.Text = _mainCourse.Name;
            }
            if(_reservedDishes.Where(dish => dish.DishTypeId == DishTypeDessert).Count() == 1) {
              _dessert_old = _reservedDishes.Where(dish => dish.DishTypeId == DishTypeDessert).First();
              _dessert = context.Dish.Where(dish => dish.DishId == _dessert_old.DishId).First();
              textBoxDessert.Text = _dessert.Name;
            }
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          DialogResult = DialogResult.Abort;
          Close();
        }
      }
    }

    private void buttonStarter_Click(object sender, EventArgs e) {
      FormSelectDish form = new FormSelectDish();
      DialogResult result;
      try {
        form.PopulateList(CurrentReception.ReceptionId, DishTypeStarter, CurrentClient);
        result = form.ShowDialog();
        if((result == DialogResult.OK) && (form.SelectedDishId != null)) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            _starter = context.Dish.Where(dish => dish.DishId == form.SelectedDishId).First();
            textBoxStarter.Text = _starter.Name;
          }
        }
      } catch(Exception ex) {
        ModelError modelError = new ModelError(ex);
        MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonMainCourse_Click(object sender, EventArgs e) {
      FormSelectDish form = new FormSelectDish();
      DialogResult result;
      try {
        form.PopulateList(CurrentReception.ReceptionId, DishTypeMainDish, CurrentClient);
        result = form.ShowDialog();
        if((result == DialogResult.OK) && (form.SelectedDishId != null)) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            _mainCourse = context.Dish.Where(dish => dish.DishId == form.SelectedDishId).First();
            textBoxMainCourse.Text = _mainCourse.Name;
          }
        }
      } catch(Exception ex) {
        ModelError modelError = new ModelError(ex);
        MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonDessert_Click(object sender, EventArgs e) {
      FormSelectDish form = new FormSelectDish();
      DialogResult result;
      try {
        form.PopulateList(CurrentReception.ReceptionId, DishTypeDessert, CurrentClient);
        result = form.ShowDialog();
        if((result == DialogResult.OK) && (form.SelectedDishId != null)) {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            _dessert = context.Dish.Where(dish => dish.DishId == form.SelectedDishId).First();
            textBoxDessert.Text = _dessert.Name;
          }
        }
      } catch(Exception ex) {
        ModelError modelError = new ModelError(ex);
        MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonSave_Click(object sender, EventArgs e) {
      try {
        UpdateDish(_starter_old, _starter);
        UpdateDish(_mainCourse_old, _mainCourse);
        UpdateDish(_dessert_old, _dessert);
      } catch(Exception ex) {
        ModelError modelError = new ModelError(ex);
        MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        DialogResult = DialogResult.None;
      }
    }

    private void UpdateDish(GetReservedDish_Result oldDish, Dish newDish) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        if(oldDish != null) {
          if((newDish != null) && (oldDish.DishId != newDish.DishId)) {
            context.DeleteReservedDish(oldDish.ClientId, oldDish.DishId, CurrentReception.ReceptionId, oldDish.ModifiedAt);
            context.NewReservedDish(CurrentClient.Id, newDish.DishId, CurrentReception.ReceptionId, CurrentClient.Acronym);
          }
        } else {
          if(newDish != null) {
            context.NewReservedDish(CurrentClient.Id, newDish.DishId, CurrentReception.ReceptionId, CurrentClient.Acronym);
          }
        }
      }
    }

    private void buttonDelete_Click(object sender, EventArgs e) {
      DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la réservation " + CurrentReception.ReceptionName + "?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
      if(result == DialogResult.Yes) {
        try {
          using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
            context.DeleteReservation(CurrentReception.ReceptionId, CurrentClient.Id, CurrentReception.ModifiedAt);
          }
        } catch(Exception ex) {
          ModelError modelError = new ModelError(ex);
          MessageBox.Show(modelError.Message, "Erreur fatale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          DialogResult = DialogResult.None;
        }
      } else {
        DialogResult = DialogResult.None;
      }
    }
  }
}
