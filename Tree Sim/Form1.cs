using System;
using System.Windows.Forms;

namespace Tree_Sim
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      nTextBox.Text = "3";
    }

    private void GoButton_Click(object sender, EventArgs e)
    {
      var process = new Process();
      pictureBox.Dock = DockStyle.Fill;
      var args = new TreeArgs { Width = pictureBox.Width, Height = pictureBox.Height, N = N };
      process.Go(args);
      pictureBox.Image = process.Bmp;
    }

    protected int N
    {
      get 
      {
        try
        {
          if (Convert.ToInt16(nTextBox.Text) < 0) throw new ArgumentException();
          return Convert.ToInt16(nTextBox.Text);
        }
        catch (Exception)
        {
          return 3;
        }
      }
    }
  }
}
