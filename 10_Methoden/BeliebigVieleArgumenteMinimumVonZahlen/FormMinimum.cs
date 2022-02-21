using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimumVonZahlen
{
    public partial class FormMinimum : Form
    {
        public FormMinimum()
        {
            InitializeComponent();
        }

/// <summary>
/// Ereignismethode zum Testen der Methode
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_OK_Click(object sender, EventArgs e)
{
    double a ;
    double b ;
    double c ;
    double d ;
    a = Convert.ToDouble(textBox_a.Text);
    b = Convert.ToDouble(textBox_b.Text);
    c = Convert.ToDouble(textBox_c.Text);
    d = Convert.ToDouble(textBox_d.Text);

    textBox_min.Text = MinimumVonZahlen(a, b, c, d).ToString();
}
/// <summary>
/// Ermittelt das Minimum von Zahlen ohne Begrenzung der Anzahl
/// </summary>
/// <param name="zahlen"></param>
/// <returns></returns>
private double MinimumVonZahlen(params double[] zahlen)
{
    double minimum = zahlen[0];
    for (int i = 0; i < zahlen.Length; i++)
    {
        if (minimum > zahlen[i]) minimum = zahlen[i];
    }
            return minimum;
}


    }
}
