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
        /// Aufruf der Exponentialfunktion in der übergeordneten Ereignisprozedur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox_x.Text);
            double y = Convert.ToDouble(textBox_y.Text);
            double z = basisHochExponent(x, y); //Funktionsaufruf
            textBox_z.Text = z.ToString();
        }

        /// <summary>
        /// Berechnet den Funktionswert basis hoch exponent
        /// </summary>
        /// <param name="basis"></param>
        /// <param name="exponent"></param>
        /// <returns></returns> Funktionswert
        private double basisHochExponent(double basis, double exponent)
        {
            return Math.Exp(exponent * Math.Log(basis, Math.E));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
