using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belastungsfall
{
    public partial class Form_Belastungsfall : Form
    {
        public Form_Belastungsfall()
        {
            InitializeComponent();
        }

        private void label_SigZul_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// In Abhängigkeit von der Streckgrenze R_e und dem Belastungsfall BF
        /// {ruhend, schwellen, wechselnd} werden die zulässige Biegespannung σ_zul
        /// und die zulässige Scherspannung τ_zul berechnet und ausgegeben.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            double Re = Convert.ToDouble(textBox_Re.Text);//Streckgrenze
            string BF = comboBox_BF.Text;                 //Belastungsfall  
            double Ksig;                                  //Konstanten 
            double Ktau;
            switch (BF)     //Mehrfachalternative
            {
                case "ruhend":
                    Ksig = 0.85;
                    Ktau = 0.67;
                    break;  //break beendet die Mehrfachalternative
                case "schwellend":
                    Ksig = 0.55;
                    Ktau = 0.45;
                    break;
                case "wechselnd":
                    Ksig = 0.40;
                    Ktau = 0.33;
                    break;
                default:      //Nein-Fall      
                    Ksig = 0;
                    Ktau = 0;
                    break;
            } //Ende der Mehrfachalternative: switch (BF)
            double sigZul = Re * Ksig;  //Berechnung
            double tauZul = Re * Ktau;
            string masseinheit = " N/mm²"; //String für die Maßeinheit
            //Formatstring:  {Wert} {linksbündige Maßeinheit} 
            string format = "{0,10:0.0}{1,-5}"; 
            //Ausgabe
            textBox_sigZul.Text = String.Format(format, sigZul, masseinheit); 
            textBox_tauZul.Text = String.Format(format, tauZul, masseinheit);
        }
    }
}
