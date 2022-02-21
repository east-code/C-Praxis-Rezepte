using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeptionDivision
{
    public partial class Form_Division : Form
    {
        public Form_Division()
        {
            InitializeComponent();
        }
/// <summary>
/// Division mit einfacher Exeption
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_division_Click(object sender, EventArgs e)
{
    try
    {
        double a = Convert.ToDouble(textBox_a.Text);
        double b = Convert.ToDouble(textBox_b.Text);
        double x = a / b;
        textBox_x.Text = x.ToString();
        textBox_Hinweis.Clear(); //Löscht alten Hinweis
    }
    catch(Exception ex) //Ausnahme abfragen und behandeln
    {
        textBox_Hinweis.Text = "Fehler: "+ ex.Message;
        textBox_x.Clear(); //Löscht Ergebnisfeldes
    }
}


    }
}
