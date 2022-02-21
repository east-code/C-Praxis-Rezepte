using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpannungImZugstab
{
    public partial class Form_SpannungImZugstab : Form
    {
        public Form_SpannungImZugstab()
        {
            InitializeComponent();
        }

        private void Form_SpannungImZugstab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Berechnet die Spannung in einem runden Zugstab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            //Deklaration
            double d;       //Durchmesser des Zugstabs
            double F;       //Äußere Kraft
            double A;       //Fläche des Zugstabs
            double Sigma;   //Spannung im Zugstab
            //Eingabe, Werteübernahme
            d = Convert.ToDouble(textBox_d.Text);
            F = Convert.ToDouble(textBox_F.Text);
            //Verarbeitung
            A = Math.PI * d * d / 4;
            Sigma = F / A;
            //Ausgabe
            //Formatstring: Position, Gesamtlänge: Mindestens eine Vorkommanull
            //                                      mit 3 Nachkommastellen 
            string format="{0,10:0.000}"; 
            textBox_Sigma.Text= String.Format(format,Sigma);
        }
    }
}
