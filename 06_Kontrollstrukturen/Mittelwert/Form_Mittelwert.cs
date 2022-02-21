using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mittelwert
{
    public partial class Form_Mittelwert : Form
    {
        public Form_Mittelwert()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Berechnet den Mittelwert von beliebig vielen Zahlen (n Zahlen).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ok_Click(object sender, EventArgs e)
        {
            int n = textBox_x.Lines.Count(); //Anzahl der belegten Zeilen = n
            double sum=0;                    //Anfangswert für die Summe
            for (int i=0; i<n; i++)//Zählschleife, vorzugsweise mit 0 beginnend   
            {
                double x = Convert.ToDouble(textBox_x.Lines[i]); //x-Wert übernehmen
                sum = sum + x;      //Aufsummieren
            }
            double xm = sum / n;    //Mittelwert
            textBox_xm.Text = xm.ToString(); //Ausgabe des Mittelwertes
            //Anpassen des Label-Textes
            label_xm.Text = "Mittelwert xm von " + n.ToString() + " Zahlen"; 
        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
