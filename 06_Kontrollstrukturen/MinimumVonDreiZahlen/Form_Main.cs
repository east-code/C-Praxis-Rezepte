using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimumVonDreiZahlen
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ermittelt das Minimum von drei Zahlen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            double z1 = Convert.ToDouble(textBox_z1.Text); //Werteübernahme
            double z2 = Convert.ToDouble(textBox_z2.Text);
            double z3 = Convert.ToDouble(textBox_z3.Text);
            double zMin = z1;                               //Anfangsannahme
            if (z2 < zMin) zMin = z2;                       //Alternativen
            if (z3 < zMin) zMin = z3;
            textBox_zMin.Text = zMin.ToString();            //Ausgabe mit Typumwandlung
        }
    }
}
