using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition
{
    public partial class Form_Addition : Form
    {
        public Form_Addition()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Addition zweier reeller Zahlen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addition_Click(object sender, EventArgs e)
        {
            //Eingabe
            // Die reele Variable x bzw. y erhalten den Inhalt 
            // der Texteigenschaften der TextBox-Komponenten.
            // Zur Typanpassung wird die Methode Convert.ToDouble verwendet.
            double x = Convert.ToDouble(textBox_x.Text); 
            double y = Convert.ToDouble(textBox_y.Text);
            
            //Verarbeitung
            // Zuweisung
            double z = x + y;
            //Ausgabe
            // Der Inhalt der z-Variablen wird auf die Texteigenschaft
            // der TextBox-Komponente geschrieben.
            // Die Typanpassung erfolgt mit der Methode ToString().
            textBox_z.Text = z.ToString();
        }
    }
}
