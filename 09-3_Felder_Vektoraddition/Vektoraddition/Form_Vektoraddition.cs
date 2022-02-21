using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektoraddition
{
    public partial class Form_Vektoraddition : Form
    {
        public Form_Vektoraddition()
        {
            InitializeComponent();
        }
// <summary>
/// Addition zweier Vektoren
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_Addition_Click(object sender, EventArgs e)
{
  // Drei Vektoren, von denen jeder drei Elemente besitzt.
  // Der Datentyp der Elemente ist reell (double).
  double[] Vektor1 = new double[3];
  double[] Vektor2 = new double[3];
  double[] VektorResult = new double[3];

  // Stringfelder für die Eingabekomponenten
  // sind möglich. Dadurch lassen sich Schleifen
  // während der Eingabe verwenden. Die Größe
  // der Felder und der Inhalt der Feldelemente
  // ergibt sich aus der in geschweiften Klammern
  // stehenden Werteliste.
  string[] textBox1 = { textBox_V1x.Text, textBox_V1y.Text, textBox_V1z.Text };
  string[] textBox2 = { textBox_V2x.Text, textBox_V2y.Text, textBox_V2z.Text };
 
  // Daten aus dem Formular
  for (int i=0; i<3; i++)
  {
    Vektor1[i] = Convert.ToDouble(textBox1[i]);
    Vektor2[i] = Convert.ToDouble(textBox2[i]);
  }

  // Addition der Felder
  for (int i=0; i<3; i++)
  {
    VektorResult[i] = Vektor1[i] + Vektor2[i];
  }

  //Ausgabe
  textBox_VRx.Text = VektorResult[0].ToString();
  textBox_VRy.Text = VektorResult[1].ToString();
  textBox_VRz.Text = VektorResult[2].ToString();
}                                 
    }
}
