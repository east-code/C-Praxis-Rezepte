using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpression
{
    public partial class Form_Polygon : Form
    {
        public Form_Polygon()
        {
            InitializeComponent();
        }

        private void button_polygon_Click(object sender, EventArgs e)
        {
            Funktionen fkt=new Funktionen(); //Instanz fkt
            double x = Convert.ToDouble(textBox_x.Text); //Wert aus dem Formular
            textBox_y.Text = fkt.polygon3(x).ToString();
        }
    }
}
