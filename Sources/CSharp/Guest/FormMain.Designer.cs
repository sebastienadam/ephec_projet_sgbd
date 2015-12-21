namespace Guest {
  partial class FormMain {
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
      this.panelCurrentClient = new System.Windows.Forms.Panel();
      this.labelClientSelect = new System.Windows.Forms.Label();
      this.comboBoxCurrentClient = new System.Windows.Forms.ComboBox();
      this.panelReservations = new System.Windows.Forms.Panel();
      this.buttonDetailsReservations = new System.Windows.Forms.Button();
      this.buttonDeleteReservations = new System.Windows.Forms.Button();
      this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
      this.labelReservations = new System.Windows.Forms.Label();
      this.buttonAddReservations = new System.Windows.Forms.Button();
      this.panelDishWish = new System.Windows.Forms.Panel();
      this.buttonDeleteDishWish = new System.Windows.Forms.Button();
      this.dataGridViewDishWish = new System.Windows.Forms.DataGridView();
      this.buttonEditDishWish = new System.Windows.Forms.Button();
      this.labelDishWish = new System.Windows.Forms.Label();
      this.buttonAddDishWish = new System.Windows.Forms.Button();
      this.panelFeeling = new System.Windows.Forms.Panel();
      this.buttonDeleteFeeling = new System.Windows.Forms.Button();
      this.dataGridViewFeeling = new System.Windows.Forms.DataGridView();
      this.buttonEditFeeling = new System.Windows.Forms.Button();
      this.labelFeeling = new System.Windows.Forms.Label();
      this.buttonAddFeeling = new System.Windows.Forms.Button();
      this.panelCurrentClient.SuspendLayout();
      this.panelReservations.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
      this.panelDishWish.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishWish)).BeginInit();
      this.panelFeeling.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeeling)).BeginInit();
      this.SuspendLayout();
      // 
      // panelCurrentClient
      // 
      this.panelCurrentClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelCurrentClient.Controls.Add(this.labelClientSelect);
      this.panelCurrentClient.Controls.Add(this.comboBoxCurrentClient);
      this.panelCurrentClient.Location = new System.Drawing.Point(12, 12);
      this.panelCurrentClient.Name = "panelCurrentClient";
      this.panelCurrentClient.Size = new System.Drawing.Size(341, 30);
      this.panelCurrentClient.TabIndex = 0;
      // 
      // labelClientSelect
      // 
      this.labelClientSelect.AutoSize = true;
      this.labelClientSelect.Location = new System.Drawing.Point(3, 6);
      this.labelClientSelect.Name = "labelClientSelect";
      this.labelClientSelect.Size = new System.Drawing.Size(78, 13);
      this.labelClientSelect.TabIndex = 1;
      this.labelClientSelect.Text = "Client courant :";
      // 
      // comboBoxCurrentClient
      // 
      this.comboBoxCurrentClient.FormattingEnabled = true;
      this.comboBoxCurrentClient.Location = new System.Drawing.Point(87, 3);
      this.comboBoxCurrentClient.Name = "comboBoxCurrentClient";
      this.comboBoxCurrentClient.Size = new System.Drawing.Size(249, 21);
      this.comboBoxCurrentClient.Sorted = true;
      this.comboBoxCurrentClient.TabIndex = 0;
      this.comboBoxCurrentClient.SelectedValueChanged += new System.EventHandler(this.comboBoxCurrentClient_SelectedValueChanged);
      // 
      // panelReservations
      // 
      this.panelReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelReservations.Controls.Add(this.buttonDetailsReservations);
      this.panelReservations.Controls.Add(this.buttonDeleteReservations);
      this.panelReservations.Controls.Add(this.dataGridViewReservations);
      this.panelReservations.Controls.Add(this.labelReservations);
      this.panelReservations.Controls.Add(this.buttonAddReservations);
      this.panelReservations.Location = new System.Drawing.Point(12, 48);
      this.panelReservations.Name = "panelReservations";
      this.panelReservations.Size = new System.Drawing.Size(657, 218);
      this.panelReservations.TabIndex = 2;
      // 
      // buttonDetailsReservations
      // 
      this.buttonDetailsReservations.Location = new System.Drawing.Point(558, 56);
      this.buttonDetailsReservations.Name = "buttonDetailsReservations";
      this.buttonDetailsReservations.Size = new System.Drawing.Size(94, 23);
      this.buttonDetailsReservations.TabIndex = 19;
      this.buttonDetailsReservations.Text = "Détails";
      this.buttonDetailsReservations.UseVisualStyleBackColor = true;
      this.buttonDetailsReservations.Click += new System.EventHandler(this.buttonDetailsReservations_Click);
      // 
      // buttonDeleteReservations
      // 
      this.buttonDeleteReservations.Location = new System.Drawing.Point(558, 85);
      this.buttonDeleteReservations.Name = "buttonDeleteReservations";
      this.buttonDeleteReservations.Size = new System.Drawing.Size(94, 23);
      this.buttonDeleteReservations.TabIndex = 18;
      this.buttonDeleteReservations.Text = "Supprimer";
      this.buttonDeleteReservations.UseVisualStyleBackColor = true;
      this.buttonDeleteReservations.Click += new System.EventHandler(this.buttonDeleteReservations_Click);
      // 
      // dataGridViewReservations
      // 
      this.dataGridViewReservations.AllowUserToAddRows = false;
      this.dataGridViewReservations.AllowUserToDeleteRows = false;
      this.dataGridViewReservations.AllowUserToOrderColumns = true;
      this.dataGridViewReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReservations.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewReservations.MultiSelect = false;
      this.dataGridViewReservations.Name = "dataGridViewReservations";
      this.dataGridViewReservations.ReadOnly = true;
      this.dataGridViewReservations.RowHeadersVisible = false;
      this.dataGridViewReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewReservations.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewReservations.TabIndex = 1;
      // 
      // labelReservations
      // 
      this.labelReservations.AutoSize = true;
      this.labelReservations.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelReservations.Location = new System.Drawing.Point(3, 0);
      this.labelReservations.Name = "labelReservations";
      this.labelReservations.Size = new System.Drawing.Size(184, 24);
      this.labelReservations.TabIndex = 0;
      this.labelReservations.Text = "Mes réservations";
      // 
      // buttonAddReservations
      // 
      this.buttonAddReservations.Location = new System.Drawing.Point(558, 27);
      this.buttonAddReservations.Name = "buttonAddReservations";
      this.buttonAddReservations.Size = new System.Drawing.Size(94, 23);
      this.buttonAddReservations.TabIndex = 16;
      this.buttonAddReservations.Text = "Ajouter";
      this.buttonAddReservations.UseVisualStyleBackColor = true;
      this.buttonAddReservations.Click += new System.EventHandler(this.buttonAddReservations_Click);
      // 
      // panelDishWish
      // 
      this.panelDishWish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelDishWish.Controls.Add(this.buttonDeleteDishWish);
      this.panelDishWish.Controls.Add(this.dataGridViewDishWish);
      this.panelDishWish.Controls.Add(this.buttonEditDishWish);
      this.panelDishWish.Controls.Add(this.labelDishWish);
      this.panelDishWish.Controls.Add(this.buttonAddDishWish);
      this.panelDishWish.Location = new System.Drawing.Point(12, 272);
      this.panelDishWish.Name = "panelDishWish";
      this.panelDishWish.Size = new System.Drawing.Size(657, 218);
      this.panelDishWish.TabIndex = 3;
      // 
      // buttonDeleteDishWish
      // 
      this.buttonDeleteDishWish.Location = new System.Drawing.Point(558, 85);
      this.buttonDeleteDishWish.Name = "buttonDeleteDishWish";
      this.buttonDeleteDishWish.Size = new System.Drawing.Size(94, 23);
      this.buttonDeleteDishWish.TabIndex = 15;
      this.buttonDeleteDishWish.Text = "Supprimer";
      this.buttonDeleteDishWish.UseVisualStyleBackColor = true;
      // 
      // dataGridViewDishWish
      // 
      this.dataGridViewDishWish.AllowUserToAddRows = false;
      this.dataGridViewDishWish.AllowUserToDeleteRows = false;
      this.dataGridViewDishWish.AllowUserToOrderColumns = true;
      this.dataGridViewDishWish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDishWish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDishWish.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewDishWish.MultiSelect = false;
      this.dataGridViewDishWish.Name = "dataGridViewDishWish";
      this.dataGridViewDishWish.ReadOnly = true;
      this.dataGridViewDishWish.RowHeadersVisible = false;
      this.dataGridViewDishWish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDishWish.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewDishWish.TabIndex = 1;
      this.dataGridViewDishWish.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDishWish_DataBindingComplete);
      // 
      // buttonEditDishWish
      // 
      this.buttonEditDishWish.Location = new System.Drawing.Point(558, 56);
      this.buttonEditDishWish.Name = "buttonEditDishWish";
      this.buttonEditDishWish.Size = new System.Drawing.Size(94, 23);
      this.buttonEditDishWish.TabIndex = 14;
      this.buttonEditDishWish.Text = "Modifier";
      this.buttonEditDishWish.UseVisualStyleBackColor = true;
      // 
      // labelDishWish
      // 
      this.labelDishWish.AutoSize = true;
      this.labelDishWish.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDishWish.Location = new System.Drawing.Point(3, 0);
      this.labelDishWish.Name = "labelDishWish";
      this.labelDishWish.Size = new System.Drawing.Size(218, 24);
      this.labelDishWish.TabIndex = 0;
      this.labelDishWish.Text = "Préférences de plats";
      // 
      // buttonAddDishWish
      // 
      this.buttonAddDishWish.Location = new System.Drawing.Point(558, 27);
      this.buttonAddDishWish.Name = "buttonAddDishWish";
      this.buttonAddDishWish.Size = new System.Drawing.Size(94, 23);
      this.buttonAddDishWish.TabIndex = 13;
      this.buttonAddDishWish.Text = "Ajouter";
      this.buttonAddDishWish.UseVisualStyleBackColor = true;
      // 
      // panelFeeling
      // 
      this.panelFeeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelFeeling.Controls.Add(this.buttonDeleteFeeling);
      this.panelFeeling.Controls.Add(this.dataGridViewFeeling);
      this.panelFeeling.Controls.Add(this.buttonEditFeeling);
      this.panelFeeling.Controls.Add(this.labelFeeling);
      this.panelFeeling.Controls.Add(this.buttonAddFeeling);
      this.panelFeeling.Location = new System.Drawing.Point(12, 496);
      this.panelFeeling.Name = "panelFeeling";
      this.panelFeeling.Size = new System.Drawing.Size(657, 218);
      this.panelFeeling.TabIndex = 3;
      // 
      // buttonDeleteFeeling
      // 
      this.buttonDeleteFeeling.Location = new System.Drawing.Point(558, 85);
      this.buttonDeleteFeeling.Name = "buttonDeleteFeeling";
      this.buttonDeleteFeeling.Size = new System.Drawing.Size(94, 23);
      this.buttonDeleteFeeling.TabIndex = 12;
      this.buttonDeleteFeeling.Text = "Supprimer";
      this.buttonDeleteFeeling.UseVisualStyleBackColor = true;
      // 
      // dataGridViewFeeling
      // 
      this.dataGridViewFeeling.AllowUserToAddRows = false;
      this.dataGridViewFeeling.AllowUserToDeleteRows = false;
      this.dataGridViewFeeling.AllowUserToOrderColumns = true;
      this.dataGridViewFeeling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewFeeling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFeeling.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewFeeling.MultiSelect = false;
      this.dataGridViewFeeling.Name = "dataGridViewFeeling";
      this.dataGridViewFeeling.ReadOnly = true;
      this.dataGridViewFeeling.RowHeadersVisible = false;
      this.dataGridViewFeeling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewFeeling.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewFeeling.TabIndex = 1;
      this.dataGridViewFeeling.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewFeeling_DataBindingComplete);
      // 
      // buttonEditFeeling
      // 
      this.buttonEditFeeling.Location = new System.Drawing.Point(558, 56);
      this.buttonEditFeeling.Name = "buttonEditFeeling";
      this.buttonEditFeeling.Size = new System.Drawing.Size(94, 23);
      this.buttonEditFeeling.TabIndex = 11;
      this.buttonEditFeeling.Text = "Modifier";
      this.buttonEditFeeling.UseVisualStyleBackColor = true;
      // 
      // labelFeeling
      // 
      this.labelFeeling.AutoSize = true;
      this.labelFeeling.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFeeling.Location = new System.Drawing.Point(3, 0);
      this.labelFeeling.Name = "labelFeeling";
      this.labelFeeling.Size = new System.Drawing.Size(336, 24);
      this.labelFeeling.TabIndex = 0;
      this.labelFeeling.Text = "Relations avec les autres clients";
      // 
      // buttonAddFeeling
      // 
      this.buttonAddFeeling.Location = new System.Drawing.Point(558, 27);
      this.buttonAddFeeling.Name = "buttonAddFeeling";
      this.buttonAddFeeling.Size = new System.Drawing.Size(94, 23);
      this.buttonAddFeeling.TabIndex = 10;
      this.buttonAddFeeling.Text = "Ajouter";
      this.buttonAddFeeling.UseVisualStyleBackColor = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(681, 725);
      this.Controls.Add(this.panelFeeling);
      this.Controls.Add(this.panelDishWish);
      this.Controls.Add(this.panelReservations);
      this.Controls.Add(this.panelCurrentClient);
      this.Name = "FormMain";
      this.Text = "Client";
      this.panelCurrentClient.ResumeLayout(false);
      this.panelCurrentClient.PerformLayout();
      this.panelReservations.ResumeLayout(false);
      this.panelReservations.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
      this.panelDishWish.ResumeLayout(false);
      this.panelDishWish.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishWish)).EndInit();
      this.panelFeeling.ResumeLayout(false);
      this.panelFeeling.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeeling)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelCurrentClient;
    private System.Windows.Forms.Label labelClientSelect;
    private System.Windows.Forms.ComboBox comboBoxCurrentClient;
    private System.Windows.Forms.Panel panelReservations;
    private System.Windows.Forms.DataGridView dataGridViewReservations;
    private System.Windows.Forms.Label labelReservations;
    private System.Windows.Forms.Panel panelDishWish;
    private System.Windows.Forms.DataGridView dataGridViewDishWish;
    private System.Windows.Forms.Label labelDishWish;
    private System.Windows.Forms.Panel panelFeeling;
    private System.Windows.Forms.DataGridView dataGridViewFeeling;
    private System.Windows.Forms.Label labelFeeling;
    private System.Windows.Forms.Button buttonDeleteReservations;
    private System.Windows.Forms.Button buttonAddReservations;
    private System.Windows.Forms.Button buttonDeleteDishWish;
    private System.Windows.Forms.Button buttonEditDishWish;
    private System.Windows.Forms.Button buttonAddDishWish;
    private System.Windows.Forms.Button buttonDeleteFeeling;
    private System.Windows.Forms.Button buttonEditFeeling;
    private System.Windows.Forms.Button buttonAddFeeling;
    private System.Windows.Forms.Button buttonDetailsReservations;
  }
}

