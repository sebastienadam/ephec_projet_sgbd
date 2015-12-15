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
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.dataGridReception = new System.Windows.Forms.DataGridView();
      this.dataGridClient = new System.Windows.Forms.DataGridView();
      this.dataGridDish = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridReception)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridDish)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.dataGridReception);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(902, 196);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.dataGridClient);
      this.panel2.Location = new System.Drawing.Point(12, 214);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(902, 196);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.dataGridDish);
      this.panel3.Location = new System.Drawing.Point(12, 416);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(902, 196);
      this.panel3.TabIndex = 1;
      // 
      // dataGridReception
      // 
      this.dataGridReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridReception.Location = new System.Drawing.Point(3, 3);
      this.dataGridReception.Name = "dataGridReception";
      this.dataGridReception.Size = new System.Drawing.Size(720, 188);
      this.dataGridReception.TabIndex = 2;
      // 
      // dataGridClient
      // 
      this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridClient.Location = new System.Drawing.Point(3, 3);
      this.dataGridClient.Name = "dataGridClient";
      this.dataGridClient.Size = new System.Drawing.Size(720, 188);
      this.dataGridClient.TabIndex = 3;
      // 
      // dataGridDish
      // 
      this.dataGridDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridDish.Location = new System.Drawing.Point(3, 3);
      this.dataGridDish.Name = "dataGridDish";
      this.dataGridDish.Size = new System.Drawing.Size(720, 188);
      this.dataGridDish.TabIndex = 4;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(926, 621);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FormMain";
      this.Text = "Gestionnaire de réceptions";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridReception)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridDish)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridReception;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataGridView dataGridClient;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.DataGridView dataGridDish;
  }
}

