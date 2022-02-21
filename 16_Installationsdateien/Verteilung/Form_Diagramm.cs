using System;
using System.Windows.Forms;
namespace Verteilung
{
public partial class Form_Diagramm : Form
{
public Form_Diagramm()
{
    InitializeComponent();
}
/// <summary>
/// Übernimmt Daten aus dem Hauptformular und überträgt diese in das Diagramm
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_Diagramm_Load(object sender, EventArgs e)
{
    Form_Verteilung form_Verteilung=new Form_Verteilung();
    double[,] klasse=form_Verteilung.getKlasse;
    double[,] h = form_Verteilung.get_h;
    for (int i = 0; i <= h.GetUpperBound(0); i++) chart.Series[0].Points.AddXY(Math.Round(h[i, 0], 2), h[i, 1]);
    for (int k = 0; k <= klasse.GetUpperBound(0); k++) chart.Series[1].Points.AddXY(Math.Round(klasse[k, 0], 2), klasse[k, 1]);
}
/// <summary>
/// Schließen des Formulars
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
}
}
