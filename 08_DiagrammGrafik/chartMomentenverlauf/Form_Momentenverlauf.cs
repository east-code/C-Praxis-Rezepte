using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Momentenverlauf
{
    public partial class Form_Momentenverlauf : Form
    {
        public Form_Momentenverlauf()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            const int N = 101;  //Anzahl der Stützpunkte als Konstante
            double l = Convert.ToDouble(textBox_l.Text); //Eingabe
            double q = Convert.ToDouble(textBox_q.Text);
            double dz = l / (N - 1);  //Schrittweite in z
            chart_Mb.Series[0].Points.Clear();//Löschen der Datenpunkte der Serie 
            for (int i = 0; i < N; i++)
            {
                double z=dz* (double) i;  //z-Koordinate berechnet aus Schrittweite und Index
                double Mb = q * z * z / 2;  //Biegemoment an der Stelle z
                //Diagrammkomponente: Fügt der Serie 0 einen Punkt hinzu.
                chart_Mb.Series[0].Points.AddXY(z, Mb);
            }
        }

        private void chart_Mb_Click(object sender, EventArgs e)
        {

        }
    }
}
