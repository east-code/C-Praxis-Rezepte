using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohmascherWiderstand
{
    public partial class Form_Widerstand : Form
    {
        public Form_Widerstand()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ein- und Ausgabe - Nutzerdialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            double U = Convert.ToDouble(textBox_U.Text);
            double R= Convert.ToDouble(textBox_R.Text);
            double I = 999999999999999999;
            double P = 0;
            bool error = widerstand(U, R, ref I, ref P); //Aufruf der Methode
            if (!error) textBox_error.Visible = false;
            else
            {
                textBox_error.Text = "Der Widerstand R darf nicht 0 sein!";
                textBox_error.Visible = true;
            }
            textBox_I.Text = I.ToString();
            textBox_P.Text = P.ToString();
        }

        /// <summary>
        /// Berechnet den Strom und die Leistung eines ohmschen Widerstandes
        /// </summary>
        /// <param name="spannung"></param>
        /// <param name="widerstand"></param>
        /// <param name="strom"></param>
        /// <param name="leistung"></param>
        /// <returns></returns>
        private bool widerstand(double spannung, double widerstand, ref double strom, ref double leistung)
        {
            if (widerstand <= 0) return true; //Fehler
            strom = spannung / widerstand;
            leistung = spannung * strom;
            return false;
        }
    }
}
