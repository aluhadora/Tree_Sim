namespace Tree_Sim
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
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.nTextBox = new System.Windows.Forms.TextBox();
      this.goButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox
      // 
      this.pictureBox.Location = new System.Drawing.Point(0, 0);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(0, 0);
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "N:";
      // 
      // nTextBox
      // 
      this.nTextBox.Location = new System.Drawing.Point(36, 12);
      this.nTextBox.Name = "nTextBox";
      this.nTextBox.Size = new System.Drawing.Size(100, 20);
      this.nTextBox.TabIndex = 2;
      // 
      // goButton
      // 
      this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.goButton.Location = new System.Drawing.Point(197, 229);
      this.goButton.Name = "goButton";
      this.goButton.Size = new System.Drawing.Size(75, 23);
      this.goButton.TabIndex = 3;
      this.goButton.Text = "Run";
      this.goButton.UseVisualStyleBackColor = true;
      this.goButton.Click += new System.EventHandler(this.GoButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 264);
      this.Controls.Add(this.goButton);
      this.Controls.Add(this.nTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox nTextBox;
    private System.Windows.Forms.Button goButton;
  }
}

