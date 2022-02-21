using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reihe_e
{
    public partial class Form_Reihe_e : Form
    {
        public Form_Reihe_e()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Berechnung der eulerschen Zahl e mit Hilfe einer Reihenentwicklung. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            decimal deZul = Convert.ToDecimal(textBox_deZul.Text);
            decimal e_ = 1;  //Anfangsbedingungen
            //Achtung e ist eine global deklarierte Konstante, daher e_
            long i = 1;     //Index 
            decimal iFa = 1;   //i!
            do   //Nichtabweisschleife, Beginn
            {
                iFa = iFa * i;
                e_ = e_ + 1 / iFa;
                i++;
             }
            while ((1/iFa) > deZul); //Abweisschleife, Ende
            textBox_e.Text = e_.ToString(); //Ausgabe mit maximaler Genauigkeit
        }
    }
}
