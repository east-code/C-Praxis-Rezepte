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
    public partial class Form_Division: Form
    {
        public Form_Division()
        {
            InitializeComponent();
        }
/// <summary>
/// ganzzahlige Division
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_division_Click(object sender, EventArgs e)
{
    textBox_Hinweis.Clear(); //Löschen des Hinweises
    try
    {
        int a = Convert.ToInt32(textBox_a.Text);
        int b = Convert.ToInt32(textBox_b.Text);
        int x = a / b;
        textBox_x.Text = "Quotient a/b= " + x; 
    }
    catch (FormatException ex) //Ausnahme abfragen und behandeln
    {
        textBox_Hinweis.Text = "Fehlerhaftes Eingabeformat!";
        textBox_x.Clear(); //löschen des Ergebnisfeldes
    }
    catch (DivideByZeroException ex) //Ausnahme abfragen und behandeln
    {
        textBox_Hinweis.Text = "Division durch 0 ist unzulässig!" ;
        textBox_x.Clear(); //löschen des Ergebnisfeldes
    }
    catch(Exception ex) //Ausnahme abfragen und behandeln
    {
        textBox_Hinweis.Text = "Allgemeiner Fehler!" + ex.Message;
        textBox_x.Clear(); //löschen des Ergebnisfeldes
    }
}

private void label1_Click(object sender, EventArgs e)
{

}


    }
}
