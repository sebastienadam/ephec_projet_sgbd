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
      this.checkBoxValid = new System.Windows.Forms.CheckBox();
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
      this.panelModified = new System.Windows.Forms.Panel();
      this.dateTimePickerModifiedAt = new System.Windows.Forms.DateTimePicker();
      this.textBoxModifiedBy = new System.Windows.Forms.TextBox();
      this.labelLastModified = new System.Windows.Forms.Label();
      this.panelMenu = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.labelStarter = new System.Windows.Forms.Label();
      this.labelMeat = new System.Windows.Forms.Label();
      this.labelDessert = new System.Windows.Forms.Label();
      this.dataGridViewStarters = new System.Windows.Forms.DataGridView();
      this.dataGridViewMainCourses = new System.Windows.Forms.DataGridView();
      this.dataGridViewDesserts = new System.Windows.Forms.DataGridView();
      this.labelMenuTitle = new System.Windows.Forms.Label();
      this.panelReservations = new System.Windows.Forms.Panel();
      this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
      this.labelReservations = new System.Windows.Forms.Label();
      this.panelTablesMap = new System.Windows.Forms.Panel();
      this.dataGridViewTablesMap = new System.Windows.Forms.DataGridView();
      this.buttonTablesMapGenerate = new System.Windows.Forms.Button();
      this.buttonTablesMapSave = new System.Windows.Forms.Button();
      this.labelTablesMap = new System.Windows.Forms.Label();
      this.panelDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatsPerTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
      this.panelModified.SuspendLayout();
      this.panelMenu.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainCourses)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).BeginInit();
      this.panelReservations.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
      this.panelTablesMap.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesMap)).BeginInit();
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
      // panelModified
      // 
      this.panelModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelModified.Controls.Add(this.dateTimePickerModifiedAt);
      this.panelModified.Controls.Add(this.textBoxModifiedBy);
      this.panelModified.Controls.Add(this.labelLastModified);
      this.panelModified.Location = new System.Drawing.Point(12, 102);
      this.panelModified.Name = "panelModified";
      this.panelModified.Size = new System.Drawing.Size(549, 28);
      this.panelModified.TabIndex = 1;
      // 
      // dateTimePickerModifiedAt
      // 
      this.dateTimePickerModifiedAt.Enabled = false;
      this.dateTimePickerModifiedAt.Location = new System.Drawing.Point(345, 3);
      this.dateTimePickerModifiedAt.Name = "dateTimePickerModifiedAt";
      this.dateTimePickerModifiedAt.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerModifiedAt.TabIndex = 12;
      // 
      // textBoxModifiedBy
      // 
      this.textBoxModifiedBy.Enabled = false;
      this.textBoxModifiedBy.Location = new System.Drawing.Point(122, 3);
      this.textBoxModifiedBy.Name = "textBoxModifiedBy";
      this.textBoxModifiedBy.ReadOnly = true;
      this.textBoxModifiedBy.Size = new System.Drawing.Size(217, 20);
      this.textBoxModifiedBy.TabIndex = 1;
      // 
      // labelLastModified
      // 
      this.labelLastModified.AutoSize = true;
      this.labelLastModified.Location = new System.Drawing.Point(4, 6);
      this.labelLastModified.Name = "labelLastModified";
      this.labelLastModified.Size = new System.Drawing.Size(112, 13);
      this.labelLastModified.TabIndex = 0;
      this.labelLastModified.Text = "Dernière modification :";
      // 
      // panelMenu
      // 
      this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelMenu.Controls.Add(this.tableLayoutPanel1);
      this.panelMenu.Controls.Add(this.labelMenuTitle);
      this.panelMenu.Location = new System.Drawing.Point(12, 136);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(549, 175);
      this.panelMenu.TabIndex = 13;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Controls.Add(this.labelStarter, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.labelMeat, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.labelDessert, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.dataGridViewStarters, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.dataGridViewMainCourses, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.dataGridViewDesserts, 2, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 145);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // labelStarter
      // 
      this.labelStarter.AutoSize = true;
      this.labelStarter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelStarter.Location = new System.Drawing.Point(3, 0);
      this.labelStarter.Name = "labelStarter";
      this.labelStarter.Size = new System.Drawing.Size(49, 16);
      this.labelStarter.TabIndex = 0;
      this.labelStarter.Text = "Entrée";
      // 
      // labelMeat
      // 
      this.labelMeat.AutoSize = true;
      this.labelMeat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelMeat.Location = new System.Drawing.Point(182, 0);
      this.labelMeat.Name = "labelMeat";
      this.labelMeat.Size = new System.Drawing.Size(93, 16);
      this.labelMeat.TabIndex = 1;
      this.labelMeat.Text = "Plat principal";
      // 
      // labelDessert
      // 
      this.labelDessert.AutoSize = true;
      this.labelDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDessert.Location = new System.Drawing.Point(361, 0);
      this.labelDessert.Name = "labelDessert";
      this.labelDessert.Size = new System.Drawing.Size(54, 16);
      this.labelDessert.TabIndex = 2;
      this.labelDessert.Text = "Desert";
      // 
      // dataGridViewStarters
      // 
      this.dataGridViewStarters.AllowUserToAddRows = false;
      this.dataGridViewStarters.AllowUserToDeleteRows = false;
      this.dataGridViewStarters.AllowUserToResizeColumns = false;
      this.dataGridViewStarters.AllowUserToResizeRows = false;
      this.dataGridViewStarters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewStarters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewStarters.ColumnHeadersVisible = false;
      this.dataGridViewStarters.Location = new System.Drawing.Point(3, 24);
      this.dataGridViewStarters.MultiSelect = false;
      this.dataGridViewStarters.Name = "dataGridViewStarters";
      this.dataGridViewStarters.ReadOnly = true;
      this.dataGridViewStarters.RowHeadersVisible = false;
      this.dataGridViewStarters.Size = new System.Drawing.Size(173, 118);
      this.dataGridViewStarters.TabIndex = 3;
      // 
      // dataGridViewMainCourses
      // 
      this.dataGridViewMainCourses.AllowUserToAddRows = false;
      this.dataGridViewMainCourses.AllowUserToDeleteRows = false;
      this.dataGridViewMainCourses.AllowUserToResizeColumns = false;
      this.dataGridViewMainCourses.AllowUserToResizeRows = false;
      this.dataGridViewMainCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewMainCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMainCourses.ColumnHeadersVisible = false;
      this.dataGridViewMainCourses.Location = new System.Drawing.Point(182, 24);
      this.dataGridViewMainCourses.MultiSelect = false;
      this.dataGridViewMainCourses.Name = "dataGridViewMainCourses";
      this.dataGridViewMainCourses.ReadOnly = true;
      this.dataGridViewMainCourses.RowHeadersVisible = false;
      this.dataGridViewMainCourses.Size = new System.Drawing.Size(173, 118);
      this.dataGridViewMainCourses.TabIndex = 4;
      // 
      // dataGridViewDesserts
      // 
      this.dataGridViewDesserts.AllowUserToAddRows = false;
      this.dataGridViewDesserts.AllowUserToDeleteRows = false;
      this.dataGridViewDesserts.AllowUserToResizeColumns = false;
      this.dataGridViewDesserts.AllowUserToResizeRows = false;
      this.dataGridViewDesserts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDesserts.ColumnHeadersVisible = false;
      this.dataGridViewDesserts.Location = new System.Drawing.Point(361, 24);
      this.dataGridViewDesserts.MultiSelect = false;
      this.dataGridViewDesserts.Name = "dataGridViewDesserts";
      this.dataGridViewDesserts.ReadOnly = true;
      this.dataGridViewDesserts.RowHeadersVisible = false;
      this.dataGridViewDesserts.Size = new System.Drawing.Size(174, 118);
      this.dataGridViewDesserts.TabIndex = 5;
      // 
      // labelMenuTitle
      // 
      this.labelMenuTitle.AutoSize = true;
      this.labelMenuTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelMenuTitle.Location = new System.Drawing.Point(3, 0);
      this.labelMenuTitle.Name = "labelMenuTitle";
      this.labelMenuTitle.Size = new System.Drawing.Size(62, 22);
      this.labelMenuTitle.TabIndex = 0;
      this.labelMenuTitle.Text = "Menu";
      // 
      // panelReservations
      // 
      this.panelReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelReservations.Controls.Add(this.dataGridViewReservations);
      this.panelReservations.Controls.Add(this.labelReservations);
      this.panelReservations.Location = new System.Drawing.Point(567, 12);
      this.panelReservations.Name = "panelReservations";
      this.panelReservations.Size = new System.Drawing.Size(349, 660);
      this.panelReservations.TabIndex = 2;
      // 
      // dataGridViewReservations
      // 
      this.dataGridViewReservations.AllowUserToAddRows = false;
      this.dataGridViewReservations.AllowUserToDeleteRows = false;
      this.dataGridViewReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReservations.Location = new System.Drawing.Point(4, 25);
      this.dataGridViewReservations.Name = "dataGridViewReservations";
      this.dataGridViewReservations.RowHeadersVisible = false;
      this.dataGridViewReservations.Size = new System.Drawing.Size(340, 630);
      this.dataGridViewReservations.TabIndex = 1;
      // 
      // labelReservations
      // 
      this.labelReservations.AutoSize = true;
      this.labelReservations.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelReservations.Location = new System.Drawing.Point(0, 0);
      this.labelReservations.Name = "labelReservations";
      this.labelReservations.Size = new System.Drawing.Size(120, 22);
      this.labelReservations.TabIndex = 0;
      this.labelReservations.Text = "Inscriptions";
      // 
      // panelTablesMap
      // 
      this.panelTablesMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelTablesMap.Controls.Add(this.dataGridViewTablesMap);
      this.panelTablesMap.Controls.Add(this.buttonTablesMapGenerate);
      this.panelTablesMap.Controls.Add(this.buttonTablesMapSave);
      this.panelTablesMap.Controls.Add(this.labelTablesMap);
      this.panelTablesMap.Location = new System.Drawing.Point(12, 317);
      this.panelTablesMap.Name = "panelTablesMap";
      this.panelTablesMap.Size = new System.Drawing.Size(549, 355);
      this.panelTablesMap.TabIndex = 14;
      // 
      // dataGridViewTablesMap
      // 
      this.dataGridViewTablesMap.AllowUserToAddRows = false;
      this.dataGridViewTablesMap.AllowUserToDeleteRows = false;
      this.dataGridViewTablesMap.AllowUserToOrderColumns = true;
      this.dataGridViewTablesMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewTablesMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTablesMap.Location = new System.Drawing.Point(3, 32);
      this.dataGridViewTablesMap.Name = "dataGridViewTablesMap";
      this.dataGridViewTablesMap.ReadOnly = true;
      this.dataGridViewTablesMap.RowHeadersVisible = false;
      this.dataGridViewTablesMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewTablesMap.Size = new System.Drawing.Size(541, 318);
      this.dataGridViewTablesMap.TabIndex = 5;
      // 
      // buttonTablesMapGenerate
      // 
      this.buttonTablesMapGenerate.Enabled = false;
      this.buttonTablesMapGenerate.Location = new System.Drawing.Point(389, 3);
      this.buttonTablesMapGenerate.Name = "buttonTablesMapGenerate";
      this.buttonTablesMapGenerate.Size = new System.Drawing.Size(75, 23);
      this.buttonTablesMapGenerate.TabIndex = 4;
      this.buttonTablesMapGenerate.Text = "Générer";
      this.buttonTablesMapGenerate.UseVisualStyleBackColor = true;
      this.buttonTablesMapGenerate.Click += new System.EventHandler(this.buttonTablesMapGenerate_Click);
      // 
      // buttonTablesMapSave
      // 
      this.buttonTablesMapSave.Enabled = false;
      this.buttonTablesMapSave.Location = new System.Drawing.Point(470, 3);
      this.buttonTablesMapSave.Name = "buttonTablesMapSave";
      this.buttonTablesMapSave.Size = new System.Drawing.Size(75, 23);
      this.buttonTablesMapSave.TabIndex = 3;
      this.buttonTablesMapSave.Text = "Enregistrer";
      this.buttonTablesMapSave.UseVisualStyleBackColor = true;
      this.buttonTablesMapSave.Click += new System.EventHandler(this.buttonTablesMapSave_Click);
      // 
      // labelTablesMap
      // 
      this.labelTablesMap.AutoSize = true;
      this.labelTablesMap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesMap.Location = new System.Drawing.Point(3, 0);
      this.labelTablesMap.Name = "labelTablesMap";
      this.labelTablesMap.Size = new System.Drawing.Size(140, 22);
      this.labelTablesMap.TabIndex = 2;
      this.labelTablesMap.Text = "Plan de tables";
      // 
      // FormReceptionDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 684);
      this.Controls.Add(this.panelTablesMap);
      this.Controls.Add(this.panelReservations);
      this.Controls.Add(this.panelMenu);
      this.Controls.Add(this.panelModified);
      this.Controls.Add(this.panelDetails);
      this.Name = "FormReceptionDetail";
      this.Text = "Détails d\'une réception";
      this.Load += new System.EventHandler(this.FormReceptionDetail_Load);
      this.panelDetails.ResumeLayout(false);
      this.panelDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatsPerTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
      this.panelModified.ResumeLayout(false);
      this.panelModified.PerformLayout();
      this.panelMenu.ResumeLayout(false);
      this.panelMenu.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainCourses)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).EndInit();
      this.panelReservations.ResumeLayout(false);
      this.panelReservations.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
      this.panelTablesMap.ResumeLayout(false);
      this.panelTablesMap.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesMap)).EndInit();
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
    private System.Windows.Forms.Panel panelModified;
    private System.Windows.Forms.DateTimePicker dateTimePickerModifiedAt;
    private System.Windows.Forms.TextBox textBoxModifiedBy;
    private System.Windows.Forms.Label labelLastModified;
    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label labelStarter;
    private System.Windows.Forms.Label labelMeat;
    private System.Windows.Forms.Label labelDessert;
    private System.Windows.Forms.DataGridView dataGridViewStarters;
    private System.Windows.Forms.DataGridView dataGridViewMainCourses;
    private System.Windows.Forms.DataGridView dataGridViewDesserts;
    private System.Windows.Forms.Label labelMenuTitle;
    private System.Windows.Forms.Panel panelReservations;
    private System.Windows.Forms.DataGridView dataGridViewReservations;
    private System.Windows.Forms.Label labelReservations;
    private System.Windows.Forms.Panel panelTablesMap;
    private System.Windows.Forms.DataGridView dataGridViewTablesMap;
    private System.Windows.Forms.Button buttonTablesMapGenerate;
    private System.Windows.Forms.Button buttonTablesMapSave;
    private System.Windows.Forms.Label labelTablesMap;
  }
}