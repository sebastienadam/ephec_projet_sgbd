namespace Admin {
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonDetails = new System.Windows.Forms.Button();
      this.labelReception = new System.Windows.Forms.Label();
      this.dataGridViewReceptions = new System.Windows.Forms.DataGridView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.labelClients = new System.Windows.Forms.Label();
      this.dataGridViewClients = new System.Windows.Forms.DataGridView();
      this.panel3 = new System.Windows.Forms.Panel();
      this.labelDish = new System.Windows.Forms.Label();
      this.dataGridViewDish = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceptions)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.buttonDetails);
      this.panel1.Controls.Add(this.labelReception);
      this.panel1.Controls.Add(this.dataGridViewReceptions);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(888, 335);
      this.panel1.TabIndex = 0;
      // 
      // buttonDetails
      // 
      this.buttonDetails.Location = new System.Drawing.Point(724, 32);
      this.buttonDetails.Name = "buttonDetails";
      this.buttonDetails.Size = new System.Drawing.Size(159, 23);
      this.buttonDetails.TabIndex = 6;
      this.buttonDetails.Text = "Détails";
      this.buttonDetails.UseVisualStyleBackColor = true;
      this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
      // 
      // labelReception
      // 
      this.labelReception.AutoSize = true;
      this.labelReception.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelReception.Location = new System.Drawing.Point(3, 0);
      this.labelReception.Name = "labelReception";
      this.labelReception.Size = new System.Drawing.Size(142, 29);
      this.labelReception.TabIndex = 5;
      this.labelReception.Text = "Réceptions";
      // 
      // dataGridViewReceptions
      // 
      this.dataGridViewReceptions.AllowUserToAddRows = false;
      this.dataGridViewReceptions.AllowUserToDeleteRows = false;
      this.dataGridViewReceptions.AllowUserToOrderColumns = true;
      this.dataGridViewReceptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewReceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReceptions.Location = new System.Drawing.Point(3, 32);
      this.dataGridViewReceptions.MultiSelect = false;
      this.dataGridViewReceptions.Name = "dataGridViewReceptions";
      this.dataGridViewReceptions.ReadOnly = true;
      this.dataGridViewReceptions.RowHeadersVisible = false;
      this.dataGridViewReceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewReceptions.Size = new System.Drawing.Size(715, 298);
      this.dataGridViewReceptions.TabIndex = 2;
      this.dataGridViewReceptions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewReceptions_DataBindingComplete);
      this.dataGridViewReceptions.DoubleClick += new System.EventHandler(this.dataGridViewReceptions_DoubleClick);
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.labelClients);
      this.panel2.Controls.Add(this.dataGridViewClients);
      this.panel2.Location = new System.Drawing.Point(12, 353);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(588, 332);
      this.panel2.TabIndex = 1;
      // 
      // labelClients
      // 
      this.labelClients.AutoSize = true;
      this.labelClients.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelClients.Location = new System.Drawing.Point(3, 0);
      this.labelClients.Name = "labelClients";
      this.labelClients.Size = new System.Drawing.Size(93, 29);
      this.labelClients.TabIndex = 4;
      this.labelClients.Text = "Clients";
      // 
      // dataGridViewClients
      // 
      this.dataGridViewClients.AllowUserToAddRows = false;
      this.dataGridViewClients.AllowUserToDeleteRows = false;
      this.dataGridViewClients.AllowUserToOrderColumns = true;
      this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewClients.Location = new System.Drawing.Point(3, 32);
      this.dataGridViewClients.MultiSelect = false;
      this.dataGridViewClients.Name = "dataGridViewClients";
      this.dataGridViewClients.ReadOnly = true;
      this.dataGridViewClients.RowHeadersVisible = false;
      this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewClients.Size = new System.Drawing.Size(580, 295);
      this.dataGridViewClients.TabIndex = 3;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.labelDish);
      this.panel3.Controls.Add(this.dataGridViewDish);
      this.panel3.Location = new System.Drawing.Point(606, 353);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(294, 332);
      this.panel3.TabIndex = 1;
      // 
      // labelDish
      // 
      this.labelDish.AutoSize = true;
      this.labelDish.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDish.Location = new System.Drawing.Point(3, 0);
      this.labelDish.Name = "labelDish";
      this.labelDish.Size = new System.Drawing.Size(70, 29);
      this.labelDish.TabIndex = 5;
      this.labelDish.Text = "Plats";
      // 
      // dataGridViewDish
      // 
      this.dataGridViewDish.AllowUserToAddRows = false;
      this.dataGridViewDish.AllowUserToDeleteRows = false;
      this.dataGridViewDish.AllowUserToOrderColumns = true;
      this.dataGridViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDish.Location = new System.Drawing.Point(3, 32);
      this.dataGridViewDish.MultiSelect = false;
      this.dataGridViewDish.Name = "dataGridViewDish";
      this.dataGridViewDish.ReadOnly = true;
      this.dataGridViewDish.RowHeadersVisible = false;
      this.dataGridViewDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDish.Size = new System.Drawing.Size(286, 295);
      this.dataGridViewDish.TabIndex = 4;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(912, 697);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FormMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceptions)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridViewReceptions;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.DataGridView dataGridViewClients;
    private System.Windows.Forms.DataGridView dataGridViewDish;
    private System.Windows.Forms.Label labelReception;
    private System.Windows.Forms.Label labelClients;
    private System.Windows.Forms.Label labelDish;
    private System.Windows.Forms.Button buttonDetails;
  }
}

