namespace Guest {
  partial class FormNewDishWish {
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
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.panelChoice = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.labelDish = new System.Windows.Forms.Label();
      this.comboBoxFeeling = new System.Windows.Forms.ComboBox();
      this.comboBoxDishes = new System.Windows.Forms.ComboBox();
      this.panelButton.SuspendLayout();
      this.panelChoice.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelButton
      // 
      this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelButton.Controls.Add(this.buttonSave);
      this.panelButton.Controls.Add(this.buttonCancel);
      this.panelButton.Location = new System.Drawing.Point(12, 76);
      this.panelButton.Name = "panelButton";
      this.panelButton.Size = new System.Drawing.Size(395, 31);
      this.panelButton.TabIndex = 18;
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
      // panelChoice
      // 
      this.panelChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelChoice.Controls.Add(this.label2);
      this.panelChoice.Controls.Add(this.labelDish);
      this.panelChoice.Controls.Add(this.comboBoxFeeling);
      this.panelChoice.Controls.Add(this.comboBoxDishes);
      this.panelChoice.Location = new System.Drawing.Point(12, 12);
      this.panelChoice.Name = "panelChoice";
      this.panelChoice.Size = new System.Drawing.Size(395, 58);
      this.panelChoice.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Reesnti :";
      // 
      // labelDish
      // 
      this.labelDish.AutoSize = true;
      this.labelDish.Location = new System.Drawing.Point(3, 6);
      this.labelDish.Name = "labelDish";
      this.labelDish.Size = new System.Drawing.Size(31, 13);
      this.labelDish.TabIndex = 2;
      this.labelDish.Text = "Plat :";
      // 
      // comboBoxFeeling
      // 
      this.comboBoxFeeling.FormattingEnabled = true;
      this.comboBoxFeeling.Location = new System.Drawing.Point(58, 30);
      this.comboBoxFeeling.Name = "comboBoxFeeling";
      this.comboBoxFeeling.Size = new System.Drawing.Size(332, 21);
      this.comboBoxFeeling.TabIndex = 1;
      // 
      // comboBoxDishes
      // 
      this.comboBoxDishes.FormattingEnabled = true;
      this.comboBoxDishes.Location = new System.Drawing.Point(58, 3);
      this.comboBoxDishes.Name = "comboBoxDishes";
      this.comboBoxDishes.Size = new System.Drawing.Size(332, 21);
      this.comboBoxDishes.TabIndex = 0;
      // 
      // FormNewDishWish
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(419, 118);
      this.Controls.Add(this.panelChoice);
      this.Controls.Add(this.panelButton);
      this.Name = "FormNewDishWish";
      this.Text = "Nouveau ressenti de plat";
      this.Load += new System.EventHandler(this.FormNewDishWish_Load);
      this.panelButton.ResumeLayout(false);
      this.panelChoice.ResumeLayout(false);
      this.panelChoice.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelButton;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Panel panelChoice;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelDish;
    private System.Windows.Forms.ComboBox comboBoxFeeling;
    private System.Windows.Forms.ComboBox comboBoxDishes;
  }
}