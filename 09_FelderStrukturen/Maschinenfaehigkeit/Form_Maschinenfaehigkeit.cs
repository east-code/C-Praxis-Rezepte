using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maschinenfaehigkeit
{
    public partial class Form_Cmk : Form
    {
        public Form_Cmk()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Berechnet die Maschinenfähigkeit Cmk für eine
        /// Serie bis zu 50 Werkstücken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            //Eingabe, Maßeinheit intern-> mm
            double dNenn = Convert.ToDouble(textBox_dNenn.Text);
            double ddo = Convert.ToDouble(textBox_ddo.Text)/1000;
            double ddu = Convert.ToDouble(textBox_ddu.Text)/1000;
            int n = textBox_di.Lines.Count();
            double[] d = new double[n];
            for (int i = 0; i < n; i++) d[i] = Convert.ToDouble(textBox_di.Lines[i]);
            //Verarbeitung
            double To = dNenn + ddo;
            double Tu = dNenn + ddu;;
            double T = ddo - ddu;
            double dSoll = (To + Tu) / 2;
            double sum=0; //Mittelwert
            for (int i = 0; i < n; i++) sum = sum + d[i];
            double dM = sum / n;
                sum = 0;  //Standardabweichung
            for (int i = 0; i < n; i++) sum = sum + (dM - d[i]) * (dM - d[i]);
            double dS = Math.Sqrt(sum / (n - 1));
            double Cmk = (T / 2 - Math.Abs(dSoll - dM)) / 3 / dS;
            //Ausgabe
            textBox_Cmk.Text = Cmk.ToString("0.00");
        }
    }
}
