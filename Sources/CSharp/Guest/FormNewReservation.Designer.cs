namespace Guest {
  partial class FormNewReservation {
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
      this.panelSelectReception = new System.Windows.Forms.Panel();
      this.labelReception = new System.Windows.Forms.Label();
      this.comboBoxReception = new System.Windows.Forms.ComboBox();
      this.panelMenu = new System.Windows.Forms.Panel();
      this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
      this.labelStarter = new System.Windows.Forms.Label();
      this.labelMeat = new System.Windows.Forms.Label();
      this.labelDessert = new System.Windows.Forms.Label();
      this.dataGridViewStarter = new System.Windows.Forms.DataGridView();
      this.dataGridViewMaincoorse = new System.Windows.Forms.DataGridView();
      this.dataGridViewDessert = new System.Windows.Forms.DataGridView();
      this.labelMenuTitle = new System.Windows.Forms.Label();
      this.panelButton = new System.Windows.Forms.Panel();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.panelSelectReception.SuspendLayout();
      this.panelMenu.SuspendLayout();
      this.tableLayoutPanelMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaincoorse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDessert)).BeginInit();
      this.panelButton.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelSelectReception
      // 
      this.panelSelectReception.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelSelectReception.Controls.Add(this.labelReception);
      this.panelSelectReception.Controls.Add(this.comboBoxReception);
      this.panelSelectReception.Location = new System.Drawing.Point(12, 12);
      this.panelSelectReception.Name = "panelSelectReception";
      this.panelSelectReception.Size = new System.Drawing.Size(550, 29);
      this.panelSelectReception.TabIndex = 0;
      // 
      // labelReception
      // 
      this.labelReception.AutoSize = true;
      this.labelReception.Location = new System.Drawing.Point(3, 6);
      this.labelReception.Name = "labelReception";
      this.labelReception.Size = new System.Drawing.Size(62, 13);
      this.labelReception.TabIndex = 1;
      this.labelReception.Text = "Réception :";
      // 
      // comboBoxReception
      // 
      this.comboBoxReception.FormattingEnabled = true;
      this.comboBoxReception.Location = new System.Drawing.Point(71, 3);
      this.comboBoxReception.Name = "comboBoxReception";
      this.comboBoxReception.Size = new System.Drawing.Size(473, 21);
      this.comboBoxReception.TabIndex = 0;
      this.comboBoxReception.SelectedIndexChanged += new System.EventHandler(this.comboBoxReception_SelectedIndexChanged);
      // 
      // panelMenu
      // 
      this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelMenu.Controls.Add(this.tableLayoutPanelMenu);
      this.panelMenu.Controls.Add(this.labelMenuTitle);
      this.panelMenu.Location = new System.Drawing.Point(12, 47);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(550, 175);
      this.panelMenu.TabIndex = 14;
      // 
      // tableLayoutPanelMenu
      // 
      this.tableLayoutPanelMenu.ColumnCount = 3;
      this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanelMenu.Controls.Add(this.labelStarter, 0, 0);
      this.tableLayoutPanelMenu.Controls.Add(this.labelMeat, 1, 0);
      this.tableLayoutPanelMenu.Controls.Add(this.labelDessert, 2, 0);
      this.tableLayoutPanelMenu.Controls.Add(this.dataGridViewStarter, 0, 1);
      this.tableLayoutPanelMenu.Controls.Add(this.dataGridViewMaincoorse, 1, 1);
      this.tableLayoutPanelMenu.Controls.Add(this.dataGridViewDessert, 2, 1);
      this.tableLayoutPanelMenu.Location = new System.Drawing.Point(6, 25);
      this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
      this.tableLayoutPanelMenu.RowCount = 2;
      this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
      this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelMenu.Size = new System.Drawing.Size(538, 145);
      this.tableLayoutPanelMenu.TabIndex = 1;
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
      // dataGridViewStarter
      // 
      this.dataGridViewStarter.AllowUserToAddRows = false;
      this.dataGridViewStarter.AllowUserToDeleteRows = false;
      this.dataGridViewStarter.AllowUserToResizeColumns = false;
      this.dataGridViewStarter.AllowUserToResizeRows = false;
      this.dataGridViewStarter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewStarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewStarter.ColumnHeadersVisible = false;
      this.dataGridViewStarter.Location = new System.Drawing.Point(3, 24);
      this.dataGridViewStarter.MultiSelect = false;
      this.dataGridViewStarter.Name = "dataGridViewStarter";
      this.dataGridViewStarter.ReadOnly = true;
      this.dataGridViewStarter.RowHeadersVisible = false;
      this.dataGridViewStarter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewStarter.Size = new System.Drawing.Size(173, 118);
      this.dataGridViewStarter.TabIndex = 3;
      this.dataGridViewStarter.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewStarter_DataBindingComplete);
      // 
      // dataGridViewMaincoorse
      // 
      this.dataGridViewMaincoorse.AllowUserToAddRows = false;
      this.dataGridViewMaincoorse.AllowUserToDeleteRows = false;
      this.dataGridViewMaincoorse.AllowUserToResizeColumns = false;
      this.dataGridViewMaincoorse.AllowUserToResizeRows = false;
      this.dataGridViewMaincoorse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewMaincoorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMaincoorse.ColumnHeadersVisible = false;
      this.dataGridViewMaincoorse.Location = new System.Drawing.Point(182, 24);
      this.dataGridViewMaincoorse.MultiSelect = false;
      this.dataGridViewMaincoorse.Name = "dataGridViewMaincoorse";
      this.dataGridViewMaincoorse.ReadOnly = true;
      this.dataGridViewMaincoorse.RowHeadersVisible = false;
      this.dataGridViewMaincoorse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewMaincoorse.Size = new System.Drawing.Size(173, 118);
      this.dataGridViewMaincoorse.TabIndex = 4;
      this.dataGridViewMaincoorse.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewMaincoorse_DataBindingComplete);
      // 
      // dataGridViewDessert
      // 
      this.dataGridViewDessert.AllowUserToAddRows = false;
      this.dataGridViewDessert.AllowUserToDeleteRows = false;
      this.dataGridViewDessert.AllowUserToResizeColumns = false;
      this.dataGridViewDessert.AllowUserToResizeRows = false;
      this.dataGridViewDessert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDessert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDessert.ColumnHeadersVisible = false;
      this.dataGridViewDessert.Location = new System.Drawing.Point(361, 24);
      this.dataGridViewDessert.MultiSelect = false;
      this.dataGridViewDessert.Name = "dataGridViewDessert";
      this.dataGridViewDessert.ReadOnly = true;
      this.dataGridViewDessert.RowHeadersVisible = false;
      this.dataGridViewDessert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDessert.Size = new System.Drawing.Size(174, 118);
      this.dataGridViewDessert.TabIndex = 5;
      this.dataGridViewDessert.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDessert_DataBindingComplete);
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
      // panelButton
      // 
      this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelButton.Controls.Add(this.buttonCancel);
      this.panelButton.Controls.Add(this.buttonSave);
      this.panelButton.Location = new System.Drawing.Point(12, 228);
      this.panelButton.Name = "panelButton";
      this.panelButton.Size = new System.Drawing.Size(550, 31);
      this.panelButton.TabIndex = 15;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(466, 3);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Text = "Annuler";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(385, 3);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 0;
      this.buttonSave.Text = "Enregistrer";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // FormNewReservation
      // 
      this.AcceptButton = this.buttonSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(574, 271);
      this.Controls.Add(this.panelButton);
      this.Controls.Add(this.panelMenu);
      this.Controls.Add(this.panelSelectReception);
      this.Name = "FormNewReservation";
      this.Text = "Nouvelle réservation";
      this.Load += new System.EventHandler(this.FormNewReservation_Load);
      this.panelSelectReception.ResumeLayout(false);
      this.panelSelectReception.PerformLayout();
      this.panelMenu.ResumeLayout(false);
      this.panelMenu.PerformLayout();
      this.tableLayoutPanelMenu.ResumeLayout(false);
      this.tableLayoutPanelMenu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaincoorse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDessert)).EndInit();
      this.panelButton.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelSelectReception;
    private System.Windows.Forms.ComboBox comboBoxReception;
    private System.Windows.Forms.Label labelReception;
    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
    private System.Windows.Forms.Label labelStarter;
    private System.Windows.Forms.Label labelMeat;
    private System.Windows.Forms.Label labelDessert;
    private System.Windows.Forms.DataGridView dataGridViewStarter;
    private System.Windows.Forms.DataGridView dataGridViewMaincoorse;
    private System.Windows.Forms.DataGridView dataGridViewDessert;
    private System.Windows.Forms.Label labelMenuTitle;
    private System.Windows.Forms.Panel panelButton;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonSave;
  }
}