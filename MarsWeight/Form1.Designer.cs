namespace MarsWeight
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.txtMass = new System.Windows.Forms.TextBox();
      this.txtMars = new System.Windows.Forms.TextBox();
      this.btnCalc = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtMass
      // 
      this.txtMass.Location = new System.Drawing.Point(190, 111);
      this.txtMass.Name = "txtMass";
      this.txtMass.Size = new System.Drawing.Size(351, 31);
      this.txtMass.TabIndex = 1;
      // 
      // txtMars
      // 
      this.txtMars.Location = new System.Drawing.Point(190, 186);
      this.txtMars.Name = "txtMars";
      this.txtMars.ReadOnly = true;
      this.txtMars.Size = new System.Drawing.Size(351, 31);
      this.txtMars.TabIndex = 1;
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(220, 254);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(124, 48);
      this.btnCalc.TabIndex = 2;
      this.btnCalc.Text = "Calculate";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 111);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Mass";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 186);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(133, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Weight Mars";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(190, 33);
      this.txtName.MaxLength = 50;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(351, 31);
      this.txtName.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 33);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(136, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Object Name";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(582, 331);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(579, 329);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalc);
      this.Controls.Add(this.txtMars);
      this.Controls.Add(this.txtMass);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMass;
    private System.Windows.Forms.TextBox txtMars;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

