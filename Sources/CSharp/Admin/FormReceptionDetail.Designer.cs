namespace Admin {
  partial class FormReceptionDetail {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.panelDetails = new System.Windows.Forms.Panel();
      this.labelSeatsPerTable = new System.Windows.Forms.Label();
      this.numericUpDownSeatsPerTable = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
      this.labelCapacity = new System.Windows.Forms.Label();
      this.textBoxId = new System.Windows.Forms.TextBox();
      this.labelId = new System.Windows.Forms.Label();
      this.labelEndRegistration = new System.Windows.Forms.Label();
      this.labelStart = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.dateTimePickerBookingClosingDate = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.checkBoxValid = new System.Windows.Forms.CheckBox();
      this.panelDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatsPerTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
      this.SuspendLayout();
      // 
      // panelDetails
      // 
      this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelDetails.Controls.Add(this.checkBoxValid);
      this.panelDetails.Controls.Add(this.labelSeatsPerTable);
      this.panelDetails.Controls.Add(this.numericUpDownSeatsPerTable);
      this.panelDetails.Controls.Add(this.numericUpDownCapacity);
      this.panelDetails.Controls.Add(this.labelCapacity);
      this.panelDetails.Controls.Add(this.textBoxId);
      this.panelDetails.Controls.Add(this.labelId);
      this.panelDetails.Controls.Add(this.labelEndRegistration);
      this.panelDetails.Controls.Add(this.labelStart);
      this.panelDetails.Controls.Add(this.labelName);
      this.panelDetails.Controls.Add(this.dateTimePickerBookingClosingDate);
      this.panelDetails.Controls.Add(this.dateTimePickerDate);
      this.panelDetails.Controls.Add(this.textBoxName);
      this.panelDetails.Location = new System.Drawing.Point(12, 12);
      this.panelDetails.Name = "panelDetails";
      this.panelDetails.Size = new System.Drawing.Size(549, 84);
      this.panelDetails.TabIndex = 0;
      // 
      // labelSeatsPerTable
      // 
      this.labelSeatsPerTable.AutoSize = true;
      this.labelSeatsPerTable.Location = new System.Drawing.Point(145, 57);
      this.labelSeatsPerTable.Name = "labelSeatsPerTable";
      this.labelSeatsPerTable.Size = new System.Drawing.Size(94, 13);
      this.labelSeatsPerTable.TabIndex = 11;
      this.labelSeatsPerTable.Text = "Places par tables :";
      // 
      // numericUpDownSeatsPerTable
      // 
      this.numericUpDownSeatsPerTable.Location = new System.Drawing.Point(245, 55);
      this.numericUpDownSeatsPerTable.Name = "numericUpDownSeatsPerTable";
      this.numericUpDownSeatsPerTable.ReadOnly = true;
      this.numericUpDownSeatsPerTable.Size = new System.Drawing.Size(54, 20);
      this.numericUpDownSeatsPerTable.TabIndex = 10;
      this.numericUpDownSeatsPerTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownSeatsPerTable.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // numericUpDownCapacity
      // 
      this.numericUpDownCapacity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.numericUpDownCapacity.Location = new System.Drawing.Point(64, 55);
      this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDownCapacity.Name = "numericUpDownCapacity";
      this.numericUpDownCapacity.ReadOnly = true;
      this.numericUpDownCapacity.Size = new System.Drawing.Size(75, 20);
      this.numericUpDownCapacity.TabIndex = 9;
      this.numericUpDownCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDownCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // labelCapacity
      // 
      this.labelCapacity.AutoSize = true;
      this.labelCapacity.Location = new System.Drawing.Point(3, 57);
      this.labelCapacity.Name = "labelCapacity";
      this.labelCapacity.Size = new System.Drawing.Size(55, 13);
      this.labelCapacity.TabIndex = 1;
      this.labelCapacity.Text = "Capacité :";
      // 
      // textBoxId
      // 
      this.textBoxId.Location = new System.Drawing.Point(479, 3);
      this.textBoxId.Name = "textBoxId";
      this.textBoxId.ReadOnly = true;
      this.textBoxId.Size = new System.Drawing.Size(65, 20);
      this.textBoxId.TabIndex = 7;
      this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // labelId
      // 
      this.labelId.AutoSize = true;
      this.labelId.Location = new System.Drawing.Point(451, 6);
      this.labelId.Name = "labelId";
      this.labelId.Size = new System.Drawing.Size(22, 13);
      this.labelId.TabIndex = 1;
      this.labelId.Text = "Id :";
      // 
      // labelEndRegistration
      // 
      this.labelEndRegistration.AutoSize = true;
      this.labelEndRegistration.Location = new System.Drawing.Point(251, 34);
      this.labelEndRegistration.Name = "labelEndRegistration";
      this.labelEndRegistration.Size = new System.Drawing.Size(87, 13);
      this.labelEndRegistration.TabIndex = 6;
      this.labelEndRegistration.Text = "Fin réservations :";
      // 
      // labelStart
      // 
      this.labelStart.AutoSize = true;
      this.labelStart.Location = new System.Drawing.Point(3, 35);
      this.labelStart.Name = "labelStart";
      this.labelStart.Size = new System.Drawing.Size(36, 13);
      this.labelStart.TabIndex = 5;
      this.labelStart.Text = "Date :";
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(3, 6);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(35, 13);
      this.labelName.TabIndex = 4;
      this.labelName.Text = "Nom :";
      // 
      // dateTimePickerBookingClosingDate
      // 
      this.dateTimePickerBookingClosingDate.Location = new System.Drawing.Point(344, 28);
      this.dateTimePickerBookingClosingDate.Name = "dateTimePickerBookingClosingDate";
      this.dateTimePickerBookingClosingDate.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerBookingClosingDate.TabIndex = 3;
      // 
      // dateTimePickerDate
      // 
      this.dateTimePickerDate.Location = new System.Drawing.Point(45, 29);
      this.dateTimePickerDate.Name = "dateTimePickerDate";
      this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerDate.TabIndex = 2;
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(45, 3);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.ReadOnly = true;
      this.textBoxName.Size = new System.Drawing.Size(400, 20);
      this.textBoxName.TabIndex = 0;
      // 
      // checkBoxValid
      // 
      this.checkBoxValid.AutoCheck = false;
      this.checkBoxValid.AutoSize = true;
      this.checkBoxValid.Location = new System.Drawing.Point(483, 56);
      this.checkBoxValid.Name = "checkBoxValid";
      this.checkBoxValid.Size = new System.Drawing.Size(61, 17);
      this.checkBoxValid.TabIndex = 1;
      this.checkBoxValid.Text = "Validée";
      this.checkBoxValid.UseVisualStyleBackColor = true;
      // 
      // FormReceptionDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(571, 684);
      this.Controls.Add(this.panelDetails);
      this.Name = "FormReceptionDetail";
      this.Text = "FormReceptionDetail";
      this.Load += new System.EventHandler(this.FormReceptionDetail_Load);
      this.panelDetails.ResumeLayout(false);
      this.panelDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatsPerTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelDetails;
    private System.Windows.Forms.Label labelStart;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.DateTimePicker dateTimePickerBookingClosingDate;
    private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.TextBox textBoxId;
    private System.Windows.Forms.Label labelId;
    private System.Windows.Forms.Label labelEndRegistration;
    private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
    private System.Windows.Forms.Label labelCapacity;
    private System.Windows.Forms.Label labelSeatsPerTable;
    private System.Windows.Forms.NumericUpDown numericUpDownSeatsPerTable;
    private System.Windows.Forms.CheckBox checkBoxValid;
  }
}