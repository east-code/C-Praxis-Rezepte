using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection
{
  public partial class FormCollection : Form  //Formularklasse
  {
    public FormCollection()           //Konstruktor     
    {
      InitializeComponent();  //Methode zur Designerunterstützung
    }

    private void mittelwertToolStripMenuItem_Click(object sender, EventArgs e)
    {
      double[] X = new double[textBox_X.Lines.Count()];
      for (int i = 0; i < textBox_X.Lines.Count(); i++)
      {
        X[i] = Convert.ToDouble(textBox_X.Lines[i]);
      }
      textBox_Y.Text = "Mittelwert: " + Statistik.Mittelwert(X);
    }

    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
