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
  public partial class FormReservationDetails : Form {
    private ClientSelection _currentClient;
    private GetReservedReception_Result _currentReception;
    private GetReservedDish_Result _starter;
    private GetReservedDish_Result _maincoorse;
    private GetReservedDish_Result _dessert;

    public ClientSelection CurrentClient { get { return _currentClient; } set { _currentClient = value; } }
    public GetReservedReception_Result CurrentReception { get { return _currentReception; } private set { _currentReception = value; } }

    public FormReservationDetails() {
      InitializeComponent();
      CurrentClient = null;
      CurrentReception = null;
      _starter = null;
      _maincoorse = null;
      _dessert = null;
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
        using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
          IQueryable<GetReservedDish_Result> _reservedDishes = context.GetReservedDish(CurrentReception.ReceptionId, CurrentClient.Id);
          if(_reservedDishes.Where(dish => dish.DishTypeId == 1).Count() == 1) {
            _starter = _reservedDishes.Where(dish => dish.DishTypeId == 1).First();
            textBoxStarter.Text = _starter.DishName;
          }
          if(_reservedDishes.Where(dish => dish.DishTypeId == 2).Count() == 1) {
            _maincoorse = _reservedDishes.Where(dish => dish.DishTypeId == 2).First();
            textBoxMaincoorse.Text = _maincoorse.DishName;
          }
          if(_reservedDishes.Where(dish => dish.DishTypeId == 3).Count() == 1) {
            _dessert = _reservedDishes.Where(dish => dish.DishTypeId == 3).First();
            textBoxDessert.Text = _dessert.DishName;
          }
        }
      }
    }
  }
}
