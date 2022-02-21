using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartEpizykloide
{
  public partial class Form_Epizykloide : Form
  {
    public Form_Epizykloide()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Beendet die Anwendung
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
/// <summary>
/// Grafische Darstellung einer Epizykloide, der y-Funktion und deren Ableitung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void epizykloideToolStripMenuItem_Click(object sender, EventArgs e)
{
  //Führungskreisradius R, Abrollkreisradius r
  double R = Convert.ToDouble(textBox_R.Text);
  double r_ = Convert.ToDouble(textBox_r_.Text);
  // Löschen der Vorgängerfunktionen
  chart_epizykloide.Series[0].Points.Clear();
  chart_epizykloide.Series[1].Points.Clear();
  chart_epizykloide.Series[2].Points.Clear();
  for (int alpha=-180; alpha <= 180; alpha += 10)
  {
    double alpha_ = alpha * Math.PI / 180; // Winkel in Bogenmaß
    double k = 1 + R / r_;  // Radienverhältnis
    // Koodinaten
    double x = r_ * Math.Cos(k * alpha_) + (R + r_) * Math.Cos(alpha_);
    double y = r_ * Math.Sin(k * alpha_) + (R + r_) * Math.Sin(alpha_);
    // Erste Ableitung von y = y'
    double  y_ = k * R * Math.Cos(k * alpha_) + (R+r_)* Math.Cos(alpha_);
    // Funktionen zeichnen
    chart_epizykloide.Series[0].Points.AddXY(x, y);
    chart_epizykloide.Series[1].Points.AddXY(alpha, y);
    chart_epizykloide.Series[2].Points.AddXY(alpha, y_);
  }
}

    private void textBox_r__TextChanged(object sender, EventArgs e)
    {

    }

    private void label_r__Click(object sender, EventArgs e)
    {

    }
  }
}
