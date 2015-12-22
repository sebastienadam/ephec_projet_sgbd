namespace Guest {
  partial class FormEditFeeling {
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
      this.panelChoice = new System.Windows.Forms.Panel();
      this.comboBoxFeeling = new System.Windows.Forms.ComboBox();
      this.textBoxClient = new System.Windows.Forms.TextBox();
      this.labelFeeling = new System.Windows.Forms.Label();
      this.labelClient = new System.Windows.Forms.Label();
      this.panelButton = new System.Windows.Forms.Panel();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.panelChoice.SuspendLayout();
      this.panelButton.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelChoice
      // 
      this.panelChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelChoice.Controls.Add(this.comboBoxFeeling);
      this.panelChoice.Controls.Add(this.textBoxClient);
      this.panelChoice.Controls.Add(this.labelFeeling);
      this.panelChoice.Controls.Add(this.labelClient);
      this.panelChoice.Location = new System.Drawing.Point(12, 12);
      this.panelChoice.Name = "panelChoice";
      this.panelChoice.Size = new System.Drawing.Size(395, 58);
      this.panelChoice.TabIndex = 21;
      // 
      // comboBoxFeeling
      // 
      this.comboBoxFeeling.FormattingEnabled = true;
      this.comboBoxFeeling.Location = new System.Drawing.Point(58, 29);
      this.comboBoxFeeling.Name = "comboBoxFeeling";
      this.comboBoxFeeling.Size = new System.Drawing.Size(332, 21);
      this.comboBoxFeeling.TabIndex = 5;
      // 
      // textBoxClient
      // 
      this.textBoxClient.Location = new System.Drawing.Point(58, 3);
      this.textBoxClient.Name = "textBoxClient";
      this.textBoxClient.ReadOnly = true;
      this.textBoxClient.Size = new System.Drawing.Size(332, 20);
      this.textBoxClient.TabIndex = 4;
      // 
      // labelFeeling
      // 
      this.labelFeeling.AutoSize = true;
      this.labelFeeling.Location = new System.Drawing.Point(3, 32);
      this.labelFeeling.Name = "labelFeeling";
      this.labelFeeling.Size = new System.Drawing.Size(49, 13);
      this.labelFeeling.TabIndex = 3;
      this.labelFeeling.Text = "Reesnti :";
      // 
      // labelClient
      // 
      this.labelClient.AutoSize = true;
      this.labelClient.Location = new System.Drawing.Point(3, 6);
      this.labelClient.Name = "labelClient";
      this.labelClient.Size = new System.Drawing.Size(39, 13);
      this.labelClient.TabIndex = 2;
      this.labelClient.Text = "Client :";
      // 
      // panelButton
      // 
      this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelButton.Controls.Add(this.buttonSave);
      this.panelButton.Controls.Add(this.buttonCancel);
      this.panelButton.Location = new System.Drawing.Point(12, 76);
      this.panelButton.Name = "panelButton";
      this.panelButton.Size = new System.Drawing.Size(395, 31);
      this.panelButton.TabIndex = 22;
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
      // FormEditFeeling
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(419, 118);
      this.Controls.Add(this.panelChoice);
      this.Controls.Add(this.panelButton);
      this.Name = "FormEditFeeling";
      this.Text = "Modification ressenti client";
      this.Load += new System.EventHandler(this.FormEditFeeling_Load);
      this.panelChoice.ResumeLayout(false);
      this.panelChoice.PerformLayout();
      this.panelButton.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelChoice;
    private System.Windows.Forms.ComboBox comboBoxFeeling;
    private System.Windows.Forms.TextBox textBoxClient;
    private System.Windows.Forms.Label labelFeeling;
    private System.Windows.Forms.Label labelClient;
    private System.Windows.Forms.Panel panelButton;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonCancel;
  }
}