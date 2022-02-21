using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// using alias=namespace.Klasse;
using Spanen=Spanungstechnik.BasisSpanen;
namespace SpanenBohren
{
    public partial class FormBohren : Form
    {
public FormBohren()
{
    InitializeComponent();
}
private void schnittkraftFcToolStripMenuItem_Click(object sender, EventArgs e)
{
    Spanen spanen = new Spanen(); //Objekt als Instanz der Klasse!
    double D = Convert.ToDouble(textBox_D.Text);
    double f = Convert.ToDouble(textBox_f.Text);
    double kc11 = Convert.ToDouble(textBox_kc11.Text);
    double m = Convert.ToDouble(textBox_m.Text);
    double spitzenwinkel = 118 * Math.PI / 180;  //Spitzenwinkel des Bohrers (° --> rad)
    double kappa=Math.PI / 2 - spitzenwinkel / 2;
    double ap = D / 2;
    double h = spanen.Spanungsdicke_h(f, kappa);
    double b = spanen.Spanungsbreite_b(ap, kappa);
    double Fc = spanen.Schnittkraft_Fc(b, h, kc11, m);  //Objekt-Methode zur Schnittkraftberechnung 
    textBox_Fc.Text = (Fc * 2).ToString("0.0");
}

private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
    }
}
