using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methoden
{
    public partial class Form_Funktion : Form
    {
        public Form_Funktion()
        {
            InitializeComponent();
        }

/// <summary>
/// Aufruf einer Potenzfunktionen
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button1_Click(object sender, EventArgs e)
{
    string hinweis = "";
    double x = Convert.ToDouble(textBox_x.Text); 
    double yDouble = Convert.ToDouble(textBox_y.Text);
    int yInt = Convert.ToInt16(yDouble);
    if (yInt != yDouble) hinweis=" Der Ganzzahl-Exponent wurde gerundet!";
    //In Abhängigkeit des Datentyps des Exponenten erfolgt der Funktionsaufruf. 
    textBox_zDoubleHochDouble.Text = basisHochExponent(x, yDouble).ToString(); //Funktionsaufruf
    textBox_zDoubleHochInt.Text = basisHochExponent(x, yInt).ToString();    //Funktionsaufruf
    textBox_Hinweis.Text = hinweis;
}

/// <summary>
/// Berechnet die Potenz Basis hoch Exponent
/// für Gleitkommazahlen
/// </summary>
/// <param name="basis"></param>
/// <param name="exponent"></param>
/// <returns></returns> Funktionswert
private double basisHochExponent(double basis, double exponent)
{
    return Math.Exp(exponent * Math.Log(basis, Math.E));
}

/// <summary>
/// Berechnet die Potenz Basis hoch Exponent für
/// ganzzahlige Exponenten
/// </summary>
/// <param name="basis"></param>
/// <param name="exponent"></param>
/// <returns></returns>
private double basisHochExponent(double basis, int exponent)
{
    double potenz = 1;
    for (int i = 1; i <= exponent; i++)
    {
        potenz *= basis;
    }
    return potenz;
}









        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
