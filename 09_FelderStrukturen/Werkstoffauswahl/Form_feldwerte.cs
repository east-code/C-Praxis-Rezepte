using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufzaehlung
{
    public partial class Form_feldwerte : Form
    {
        public Form_feldwerte()
        {
            InitializeComponent();
        }


/// <summary>
/// Programminterne Zuweisung der Elemente eines Feldes
/// </summary>
public string[] Wst   = { "S185", "S235J", "S235JRG1", "S275JR", "S355J0", "38Si7" };  // Werkstückbezeichnung
public double[] WstNr = { 1.0035, 1.0037,   1.0036,     1.0044,   1.0553,   1.5023 };  // Werkstücknummern
       

        private void Form_enum_Load(object sender, EventArgs e)
        {

        }


/// <summary>
/// Überträgt Werkstoffbezeichnungen Wst in listBox
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_feldwerte_Load(object sender, EventArgs e)
{
    foreach (var wst in Wst) //Für alle Elemente des Feldes
    {
        listBox_Wst.Items.Add(wst.ToString()); //Zuweisung
    }

}
/// <summary>
/// Zeigt zum ausgewählten Werkstoff die zugehörige Werkstoffnummer 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void listBox_Wst_SelectedIndexChanged(object sender, EventArgs e)
{
    string wstAuswahl = listBox_Wst.Text;  //Übernahme des ausgewählten Listenelementes
    int index=listBox_Wst.Items.IndexOf(wstAuswahl); //Liefert den zugehörigen Index
    double wstnr = WstNr[index];            //Liest die Werkstoffnummer 
    textBox_WstNr.Text = wstnr.ToString("0.0000"); //Formatierte Ausgabe
}

    }
}
