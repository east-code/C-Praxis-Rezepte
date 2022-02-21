using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quersumme
{
    public partial class Form_Quersumme : Form
    {
        public Form_Quersumme()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ermittelt die Quersumme qs einer natürlichen Zahl n.
        /// - unterschiedliche Integer-Datentypen sind zu beachten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            Int64 n = Convert.ToInt64(textBox_n.Text); //natürliche Zahl
            int qs = 0;     //Quersumme
            while (n > 0)   // Abweisschleife
            {
                //Abtrennen der letzten Ziffer und aufsummieren
                qs = qs + (int) (n % 10);
                n = (Int64)(n / 10);
            }
            textBox_qs.Text = qs.ToString();
        }
    }
}
