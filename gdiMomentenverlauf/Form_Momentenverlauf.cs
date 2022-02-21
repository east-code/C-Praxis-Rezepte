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
    double dz =  l / (N - 1);  //Schrittweite in z
    Graphics diagramm = panel_diagramm.CreateGraphics(); //panel als Zeichenfläche
    diagramm.Clear(panel_diagramm.BackColor);             //Löschen des Panels      
    Pen stift=new Pen(Color.Blue,2);//Stift rot, 2 Pixel breit
    int rand = 50;      //Rand zur Diagrammfläche
    int abstand = 10;   //Abstand zu einer Kante oder Linie
    Rectangle flaeche = new Rectangle(rand, rand, panel_diagramm.Width - 2*rand, panel_diagramm.Height - 2*rand);
    diagramm.DrawRectangle(stift, flaeche); //Umrandung zur Diagrammfläche
    Font font = new Font("Microsoft Sans Serif", 16); //Schriftart //Microsoft Sans Serif; 15,75pt
    SolidBrush brush = new SolidBrush(Color.Blue); //Schriftfarbe
    diagramm.DrawString("<-- Koordinate z", font, brush, rand + 150, abstand); //Ausgabe
    StringFormat richtung = new StringFormat(StringFormatFlags.DirectionVertical);
    //diagramm.RotateTransform(270);
    diagramm.DrawString("Biegemoment Mb(z) -->", font, brush, flaeche.Width + rand + abstand, rand + abstand, richtung);
    //Anfangspunkt P0
    float z0  = (float) (dz*0);  //z-Koordinate berechnet aus Schrittweite und Index
    float Mb0 = (float) (q * z0 * z0 / 2);  //Biegemoment an der Stelle z
    Pen stiftFunktion=new Pen(Color.DarkRed,3);
    float massstabZ = (float) (flaeche.Width / l); //Massstab zum Zeichnen
    float MbMax = (float)(q * l * l / 2); 
    float massstabMb = (float)(flaeche.Height / MbMax);
    for (int i = 1; i < N; i++)
    {
        float z  = (float) dz*i;  //z-Koordinate berechnet aus Schrittweite und Index
        float Mb = (float) (q * z * z / 2);  //Biegemoment an der Stelle z
        //Zeichnen der Funktion, Hinweis: DrawLine erlaubt keinen Datentyp "double" 
        diagramm.DrawLine(stiftFunktion, rand+flaeche.Width - z0*massstabZ, rand+Mb0 * massstabMb, rand+flaeche.Width - z*massstabZ, rand+Mb*massstabMb);
        z0 = z;
        Mb0 = Mb;
    }
    brush = new SolidBrush(Color.DarkRed); //Schriftfarbe
    diagramm.DrawString(MbMax.ToString("0.00") + " Nm", font, brush, abstand, flaeche.Height + rand + 2);
}
       
        private void chart_Mb_Click(object sender, EventArgs e)
        {

        }

        private void panel_Dag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Dag_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
