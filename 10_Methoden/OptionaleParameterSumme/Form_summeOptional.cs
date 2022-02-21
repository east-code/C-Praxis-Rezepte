using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summeOptional
{
    public partial class Form_summeOptional : Form
    {
        public Form_summeOptional()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Nutzerschnittstelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_a.Text);
            double b = Convert.ToDouble(textBox_b.Text);
            double c = Convert.ToDouble(textBox_c.Text);
            double d = Convert.ToDouble(textBox_d.Text);
            //Aufruf einer Methode mit optinalen Parametern
            textBox_sum_ab.Text = summeOptional(a, b).ToString(); 
            textBox_sum_abc.Text = summeOptional(a, b, c).ToString();
            textBox_sum_abcd.Text = summeOptional(a, b, c, d).ToString();
        }

        /// <summary>
        /// Summe von maximal vier Zahlen
        /// Zahlen X2, x3, x4 sin optinal
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        /// <param name="x4"></param>
        /// <returns></returns>
        private double summeOptional(double x1, double x2=0, double x3=0, double x4=0)
        {
        return x1 + x2 + x3 + x4;
        }




    }
}
