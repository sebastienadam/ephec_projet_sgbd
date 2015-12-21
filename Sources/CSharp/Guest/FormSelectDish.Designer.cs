namespace Guest {
  partial class FormSelectDish {
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
      this.panelButton = new System.Windows.Forms.Panel();
      this.buttonOK = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.panelSelection = new System.Windows.Forms.Panel();
      this.labelSelection = new System.Windows.Forms.Label();
      this.dataGridViewDish = new System.Windows.Forms.DataGridView();
      this.panelButton.SuspendLayout();
      this.panelSelection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
      this.SuspendLayout();
      // 
      // panelButton
      // 
      this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelButton.Controls.Add(this.buttonOK);
      this.panelButton.Controls.Add(this.buttonCancel);
      this.panelButton.Location = new System.Drawing.Point(12, 199);
      this.panelButton.Name = "panelButton";
      this.panelButton.Size = new System.Drawing.Size(185, 33);
      this.panelButton.TabIndex = 0;
      // 
      // buttonOK
      // 
      this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOK.Location = new System.Drawing.Point(24, 3);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 1;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(105, 3);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 0;
      this.buttonCancel.Text = "Annuler";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // panelSelection
      // 
      this.panelSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelSelection.Controls.Add(this.dataGridViewDish);
      this.panelSelection.Controls.Add(this.labelSelection);
      this.panelSelection.Location = new System.Drawing.Point(12, 12);
      this.panelSelection.Name = "panelSelection";
      this.panelSelection.Size = new System.Drawing.Size(185, 181);
      this.panelSelection.TabIndex = 1;
      // 
      // labelSelection
      // 
      this.labelSelection.AutoSize = true;
      this.labelSelection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSelection.Location = new System.Drawing.Point(3, 0);
      this.labelSelection.Name = "labelSelection";
      this.labelSelection.Size = new System.Drawing.Size(68, 16);
      this.labelSelection.TabIndex = 1;
      this.labelSelection.Text = "Sélection";
      // 
      // dataGridViewDish
      // 
      this.dataGridViewDish.AllowUserToAddRows = false;
      this.dataGridViewDish.AllowUserToDeleteRows = false;
      this.dataGridViewDish.AllowUserToResizeColumns = false;
      this.dataGridViewDish.AllowUserToResizeRows = false;
      this.dataGridViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDish.ColumnHeadersVisible = false;
      this.dataGridViewDish.Location = new System.Drawing.Point(3, 19);
      this.dataGridViewDish.MultiSelect = false;
      this.dataGridViewDish.Name = "dataGridViewDish";
      this.dataGridViewDish.ReadOnly = true;
      this.dataGridViewDish.RowHeadersVisible = false;
      this.dataGridViewDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDish.Size = new System.Drawing.Size(177, 157);
      this.dataGridViewDish.TabIndex = 4;
      this.dataGridViewDish.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDish_DataBindingComplete);
      // 
      // FormSelectDish
      // 
      this.AcceptButton = this.buttonOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(210, 244);
      this.Controls.Add(this.panelSelection);
      this.Controls.Add(this.panelButton);
      this.Name = "FormSelectDish";
      this.Text = "Sélection d\'un plat";
      this.panelButton.ResumeLayout(false);
      this.panelSelection.ResumeLayout(false);
      this.panelSelection.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelButton;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Panel panelSelection;
    private System.Windows.Forms.Label labelSelection;
    private System.Windows.Forms.DataGridView dataGridViewDish;
  }
}