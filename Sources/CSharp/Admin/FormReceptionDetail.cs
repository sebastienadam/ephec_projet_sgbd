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

namespace Admin {
  public partial class FormReceptionDetail : Form {
    private ReceptionAdmin currentReception;

    public void LoadReception(int id) {
      using(ProjetSGBDEntities context = new ProjetSGBDEntities()) {
        currentReception = context.ReceptionAdmin.Where(rec => rec.ReceptionId == id).First();
      }
    }

    public FormReceptionDetail() {
      currentReception = null;
      InitializeComponent();
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
      }
    }
  }
}
