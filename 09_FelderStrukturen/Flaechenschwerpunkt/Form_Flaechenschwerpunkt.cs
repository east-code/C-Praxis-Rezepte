using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flaechenschwerpunkt
{


    public partial class Form_Flaechenschwerpunkt : Form
    {
        public Form_Flaechenschwerpunkt()
        {
            InitializeComponent();
        }
/// <summary>
/// Datentripel
/// </summary>
private struct Schwerpunkt
{
    public double A;
    public double Xs;
    public double Ys;
}      
/// <summary>
/// Berechnet den Gesamtschwerpunkt
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_OK_Click(object sender, EventArgs e)
{
    int n;
    n = dataGridView_Schwerpkt.RowCount;  //liefert die Anzahl der Datenzeilen
    Schwerpunkt[] teilfl = new Schwerpunkt[n]; //Teilflächen
    Schwerpunkt gesamt;
    for (int i=0; i<n; i++){
        teilfl[i].A  = Convert.ToDouble(dataGridView_Schwerpkt["Column_A",  i].Value);
        teilfl[i].Xs = Convert.ToDouble(dataGridView_Schwerpkt["Column_Xs", i].Value);
        teilfl[i].Ys = Convert.ToDouble(dataGridView_Schwerpkt["Column_Ys", i].Value);
    }
    gesamt.A = 0;    //Summen
    gesamt.Xs= 0;
    gesamt.Ys = 0;
    for (int i = 0; i < n;i++ )
    {
        gesamt.A += teilfl[i].A; 
        gesamt.Xs += teilfl[i].A * teilfl[i].Xs;
        gesamt.Ys += teilfl[i].A * teilfl[i].Ys;
    }
    textBox_gesamtA.Text = gesamt.A.ToString("0.00");//Ausgabe
    textBox_gesamtXs.Text = (gesamt.Xs / gesamt.A).ToString("0.000");
    textBox_gesamtYs.Text = (gesamt.Ys / gesamt.A).ToString("0.000");
}
        //-----------------------------------------------
    }
}
