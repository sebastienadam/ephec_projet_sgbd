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
      this.panelReceptions = new System.Windows.Forms.Panel();
      this.dataGridViewReceptions = new System.Windows.Forms.DataGridView();
      this.labelReceptions = new System.Windows.Forms.Label();
      this.panelDishWish = new System.Windows.Forms.Panel();
      this.dataGridViewDishWish = new System.Windows.Forms.DataGridView();
      this.labelDishWish = new System.Windows.Forms.Label();
      this.panelFeeling = new System.Windows.Forms.Panel();
      this.dataGridViewFeeling = new System.Windows.Forms.DataGridView();
      this.labelFeeling = new System.Windows.Forms.Label();
      this.panelCurrentClient.SuspendLayout();
      this.panelReceptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceptions)).BeginInit();
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
      // panelReceptions
      // 
      this.panelReceptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelReceptions.Controls.Add(this.dataGridViewReceptions);
      this.panelReceptions.Controls.Add(this.labelReceptions);
      this.panelReceptions.Location = new System.Drawing.Point(12, 48);
      this.panelReceptions.Name = "panelReceptions";
      this.panelReceptions.Size = new System.Drawing.Size(657, 218);
      this.panelReceptions.TabIndex = 2;
      // 
      // dataGridViewReceptions
      // 
      this.dataGridViewReceptions.AllowUserToAddRows = false;
      this.dataGridViewReceptions.AllowUserToDeleteRows = false;
      this.dataGridViewReceptions.AllowUserToOrderColumns = true;
      this.dataGridViewReceptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewReceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReceptions.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewReceptions.Name = "dataGridViewReceptions";
      this.dataGridViewReceptions.RowHeadersVisible = false;
      this.dataGridViewReceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewReceptions.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewReceptions.TabIndex = 1;
      // 
      // labelReceptions
      // 
      this.labelReceptions.AutoSize = true;
      this.labelReceptions.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelReceptions.Location = new System.Drawing.Point(3, 0);
      this.labelReceptions.Name = "labelReceptions";
      this.labelReceptions.Size = new System.Drawing.Size(184, 24);
      this.labelReceptions.TabIndex = 0;
      this.labelReceptions.Text = "Mes réservations";
      // 
      // panelDishWish
      // 
      this.panelDishWish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelDishWish.Controls.Add(this.dataGridViewDishWish);
      this.panelDishWish.Controls.Add(this.labelDishWish);
      this.panelDishWish.Location = new System.Drawing.Point(12, 272);
      this.panelDishWish.Name = "panelDishWish";
      this.panelDishWish.Size = new System.Drawing.Size(657, 218);
      this.panelDishWish.TabIndex = 3;
      // 
      // dataGridViewDishWish
      // 
      this.dataGridViewDishWish.AllowUserToAddRows = false;
      this.dataGridViewDishWish.AllowUserToDeleteRows = false;
      this.dataGridViewDishWish.AllowUserToOrderColumns = true;
      this.dataGridViewDishWish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDishWish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDishWish.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewDishWish.Name = "dataGridViewDishWish";
      this.dataGridViewDishWish.RowHeadersVisible = false;
      this.dataGridViewDishWish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDishWish.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewDishWish.TabIndex = 1;
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
      // panelFeeling
      // 
      this.panelFeeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelFeeling.Controls.Add(this.dataGridViewFeeling);
      this.panelFeeling.Controls.Add(this.labelFeeling);
      this.panelFeeling.Location = new System.Drawing.Point(12, 496);
      this.panelFeeling.Name = "panelFeeling";
      this.panelFeeling.Size = new System.Drawing.Size(657, 218);
      this.panelFeeling.TabIndex = 3;
      // 
      // dataGridViewFeeling
      // 
      this.dataGridViewFeeling.AllowUserToAddRows = false;
      this.dataGridViewFeeling.AllowUserToDeleteRows = false;
      this.dataGridViewFeeling.AllowUserToOrderColumns = true;
      this.dataGridViewFeeling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewFeeling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFeeling.Location = new System.Drawing.Point(3, 27);
      this.dataGridViewFeeling.Name = "dataGridViewFeeling";
      this.dataGridViewFeeling.RowHeadersVisible = false;
      this.dataGridViewFeeling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewFeeling.Size = new System.Drawing.Size(549, 188);
      this.dataGridViewFeeling.TabIndex = 1;
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
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(681, 725);
      this.Controls.Add(this.panelFeeling);
      this.Controls.Add(this.panelDishWish);
      this.Controls.Add(this.panelReceptions);
      this.Controls.Add(this.panelCurrentClient);
      this.Name = "FormMain";
      this.Text = "Client";
      this.panelCurrentClient.ResumeLayout(false);
      this.panelCurrentClient.PerformLayout();
      this.panelReceptions.ResumeLayout(false);
      this.panelReceptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceptions)).EndInit();
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
    private System.Windows.Forms.Panel panelReceptions;
    private System.Windows.Forms.DataGridView dataGridViewReceptions;
    private System.Windows.Forms.Label labelReceptions;
    private System.Windows.Forms.Panel panelDishWish;
    private System.Windows.Forms.DataGridView dataGridViewDishWish;
    private System.Windows.Forms.Label labelDishWish;
    private System.Windows.Forms.Panel panelFeeling;
    private System.Windows.Forms.DataGridView dataGridViewFeeling;
    private System.Windows.Forms.Label labelFeeling;
  }
}

