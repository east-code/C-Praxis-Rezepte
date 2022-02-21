using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrammvorlage
{
    public partial class Form_Diagrammvorlage : Form
    {
        public Form_Diagrammvorlage()
        {
            InitializeComponent();
        }
/// <summary>
/// Ereignismethode
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_Diagrammvorlage_Click(object sender, EventArgs e)
{
    string abzisse = textBox_Abzisse.Text;
    string ordinate = textBox_Ordinate.Text;
    diagramm(x:abzisse, y:ordinate);
}
/// <summary>
/// Diagrammvorlage erstellen
/// </summary>
/// <param name="y"></param> Ordinate
/// <param name="x"></param> Abzisse
/// <param name="randLinks"></param> Breite des linken Randes
/// <param name="randUnten"></param> Breite des unteren Randes
/// <param name="abzissenTeilung"></param> Abzissen-Teilstriche=Teilung-1
/// <param name="ordinatenTeilung"></param> Ordinaten-Teilstriche=Teilung-1
private void diagramm(string y = "Ordinate", string x = "Abzisse",  int randLinks=40, int randUnten=40,
    int abzissenTeilung = 5, int ordinatenTeilung = 3)
{
  Graphics diagramm = panel_diagramm.CreateGraphics();//Panel als Zeichenfläche
  diagramm.Clear(panel_diagramm.BackColor); //Zeichenfläche zurücksetzen
  Pen stift = new Pen(Color.Blue, 1);
  int randObenRechts = 20;
  Rectangle flaeche = new Rectangle(randLinks, randObenRechts,
    panel_diagramm.Width - randObenRechts - randLinks, panel_diagramm.Height - randObenRechts - randUnten);
  diagramm.DrawRectangle(stift, flaeche);

  Font font = new Font("Arial", 14);
  SolidBrush brush = new SolidBrush(Color.Blue);
  StringFormat format = new StringFormat();
  format.Alignment = StringAlignment.Center;
  Rectangle textRect = new Rectangle(flaeche.Left, flaeche.Bottom, flaeche.Width, randUnten);
  diagramm.DrawString(x, font, brush, textRect, format);

  StringFormat formatVertikal = new StringFormat(StringFormatFlags.DirectionVertical);
  formatVertikal.LineAlignment = StringAlignment.Far;
  formatVertikal.Alignment = StringAlignment.Center;
  textRect = new Rectangle(0, flaeche.Top, randLinks, flaeche.Height);
  diagramm.DrawString(y, font, brush, textRect, formatVertikal);

  float dx = flaeche.Width / abzissenTeilung;
  for (int i = 1; i < abzissenTeilung; i++)
    diagramm.DrawLine(stift, flaeche.Left + dx * i, flaeche.Top, flaeche.Left + dx * i, flaeche.Bottom);

  float dy = flaeche.Height / ordinatenTeilung;
  for (int j = 1; j < ordinatenTeilung; j++)
    diagramm.DrawLine(stift, flaeche.Left, flaeche.Top + dy * j, flaeche.Right, flaeche.Top + dy * j);
}

}
}
