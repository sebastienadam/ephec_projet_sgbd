namespace Guest {
  partial class FormReservationDetails {
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
      this.textBoxDate = new System.Windows.Forms.TextBox();
      this.labelStart = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.panelMenu = new System.Windows.Forms.Panel();
      this.buttonStarter = new System.Windows.Forms.Button();
      this.buttonMainCourse = new System.Windows.Forms.Button();
      this.buttonDessert = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxDessert = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxStarter = new System.Windows.Forms.TextBox();
      this.textBoxMainCourse = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.labelMenuTitle = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.panelDetails.SuspendLayout();
      this.panelMenu.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelDetails
      // 
      this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelDetails.Controls.Add(this.textBoxDate);
      this.panelDetails.Controls.Add(this.labelStart);
      this.panelDetails.Controls.Add(this.labelName);
      this.panelDetails.Controls.Add(this.textBoxName);
      this.panelDetails.Location = new System.Drawing.Point(12, 12);
      this.panelDetails.Name = "panelDetails";
      this.panelDetails.Size = new System.Drawing.Size(395, 57);
      this.panelDetails.TabIndex = 1;
      // 
      // textBoxDate
      // 
      this.textBoxDate.Location = new System.Drawing.Point(45, 29);
      this.textBoxDate.Name = "textBoxDate";
      this.textBoxDate.ReadOnly = true;
      this.textBoxDate.Size = new System.Drawing.Size(345, 20);
      this.textBoxDate.TabIndex = 6;
      // 
      // labelStart
      // 
      this.labelStart.AutoSize = true;
      this.labelStart.Location = new System.Drawing.Point(3, 32);
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
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(45, 3);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.ReadOnly = true;
      this.textBoxName.Size = new System.Drawing.Size(345, 20);
      this.textBoxName.TabIndex = 0;
      // 
      // panelMenu
      // 
      this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelMenu.Controls.Add(this.buttonStarter);
      this.panelMenu.Controls.Add(this.buttonMainCourse);
      this.panelMenu.Controls.Add(this.buttonDessert);
      this.panelMenu.Controls.Add(this.tableLayoutPanel1);
      this.panelMenu.Controls.Add(this.labelMenuTitle);
      this.panelMenu.Location = new System.Drawing.Point(12, 75);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(395, 119);
      this.panelMenu.TabIndex = 16;
      // 
      // buttonStarter
      // 
      this.buttonStarter.Location = new System.Drawing.Point(153, 3);
      this.buttonStarter.Name = "buttonStarter";
      this.buttonStarter.Size = new System.Drawing.Size(75, 23);
      this.buttonStarter.TabIndex = 5;
      this.buttonStarter.Text = "Entrée";
      this.buttonStarter.UseVisualStyleBackColor = true;
      this.buttonStarter.Click += new System.EventHandler(this.buttonStarter_Click);
      // 
      // buttonMainCourse
      // 
      this.buttonMainCourse.Location = new System.Drawing.Point(234, 3);
      this.buttonMainCourse.Name = "buttonMainCourse";
      this.buttonMainCourse.Size = new System.Drawing.Size(75, 23);
      this.buttonMainCourse.TabIndex = 4;
      this.buttonMainCourse.Text = "Plat principal";
      this.buttonMainCourse.UseVisualStyleBackColor = true;
      this.buttonMainCourse.Click += new System.EventHandler(this.buttonMainCourse_Click);
      // 
      // buttonDessert
      // 
      this.buttonDessert.Location = new System.Drawing.Point(315, 3);
      this.buttonDessert.Name = "buttonDessert";
      this.buttonDessert.Size = new System.Drawing.Size(75, 23);
      this.buttonDessert.TabIndex = 3;
      this.buttonDessert.Text = "Dessert";
      this.buttonDessert.UseVisualStyleBackColor = true;
      this.buttonDessert.Click += new System.EventHandler(this.buttonDessert_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.textBoxDessert, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.textBoxStarter, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxMainCourse, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 80);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 16);
      this.label3.TabIndex = 3;
      this.label3.Text = "Dessert :";
      // 
      // textBoxDessert
      // 
      this.textBoxDessert.Location = new System.Drawing.Point(100, 55);
      this.textBoxDessert.Name = "textBoxDessert";
      this.textBoxDessert.ReadOnly = true;
      this.textBoxDessert.Size = new System.Drawing.Size(287, 20);
      this.textBoxDessert.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Plat principal :";
      // 
      // textBoxStarter
      // 
      this.textBoxStarter.Location = new System.Drawing.Point(100, 3);
      this.textBoxStarter.Name = "textBoxStarter";
      this.textBoxStarter.ReadOnly = true;
      this.textBoxStarter.Size = new System.Drawing.Size(287, 20);
      this.textBoxStarter.TabIndex = 11;
      // 
      // textBoxMainCourse
      // 
      this.textBoxMainCourse.Location = new System.Drawing.Point(100, 29);
      this.textBoxMainCourse.Name = "textBoxMainCourse";
      this.textBoxMainCourse.ReadOnly = true;
      this.textBoxMainCourse.Size = new System.Drawing.Size(287, 20);
      this.textBoxMainCourse.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Entrée :";
      // 
      // labelMenuTitle
      // 
      this.labelMenuTitle.AutoSize = true;
      this.labelMenuTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelMenuTitle.Location = new System.Drawing.Point(2, 1);
      this.labelMenuTitle.Name = "labelMenuTitle";
      this.labelMenuTitle.Size = new System.Drawing.Size(62, 22);
      this.labelMenuTitle.TabIndex = 0;
      this.labelMenuTitle.Text = "Menu";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.buttonDelete);
      this.panel1.Controls.Add(this.buttonSave);
      this.panel1.Controls.Add(this.buttonCancel);
      this.panel1.Location = new System.Drawing.Point(12, 200);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(395, 31);
      this.panel1.TabIndex = 17;
      // 
      // buttonDelete
      // 
      this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonDelete.Location = new System.Drawing.Point(153, 3);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 2;
      this.buttonDelete.Text = "Supprimer";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonSave.Location = new System.Drawing.Point(234, 3);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Enregistrer";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(315, 3);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 0;
      this.buttonCancel.Text = "Annuler";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // FormReservationDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(419, 245);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panelMenu);
      this.Controls.Add(this.panelDetails);
      this.Name = "FormReservationDetails";
      this.Text = "Détails d\'une réservation";
      this.Load += new System.EventHandler(this.FormReservationDetails_Load);
      this.panelDetails.ResumeLayout(false);
      this.panelDetails.PerformLayout();
      this.panelMenu.ResumeLayout(false);
      this.panelMenu.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelDetails;
    private System.Windows.Forms.TextBox textBoxDate;
    private System.Windows.Forms.Label labelStart;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxDessert;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxStarter;
    private System.Windows.Forms.TextBox textBoxMainCourse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelMenuTitle;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonStarter;
    private System.Windows.Forms.Button buttonMainCourse;
    private System.Windows.Forms.Button buttonDessert;
    private System.Windows.Forms.Button buttonDelete;
  }
}