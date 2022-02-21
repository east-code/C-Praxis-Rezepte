using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verteilung
{
public partial class Form_Verteilung : Form
{
/// <summary>
/// Klassenvariablen (static)
/// Alle Methoden dieser Klasse nutzen dies Variablen gleichberechtigt.
/// </summary>
#region Klassenvariablen
private static double[,] h;        //Häufigkeitsverteilung aus Mittelwert und Standardabweichung
private static double[,] klasse;   //Klassenverteilung
#endregion Klassenvariablen

public Form_Verteilung()
{
    InitializeComponent();
}

#region Ereignismethoden
/// <summary>
///  Steuert den Import der Excel_Daten
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void excelImportToolStripMenuItem_Click(object sender, EventArgs e)
{
    MsExcel excel = new MsExcel();
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
        dataGridView.Rows.Clear();
        excel.openSheed(openFileDialog.FileName, "Daten");
        int zeile = 0;
        while (excel.FromSheed(zeile, 0) != null)
        {
            dataGridView.Rows.Add();
            dataGridView[0, zeile].Value = excel.FromSheed(zeile, 0);
            zeile++;
        }
    }
    excel.Close();
}
/// <summary>
/// Aktiviert die Berechnung der Häufigkeitswerte entsprechend der Dichtefunktion
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void dichtefunktionToolStripMenuItem_Click(object sender, EventArgs e)
{
    double[] x = dataGridViewToX();
    Statistik statistik = new Statistik();
    h = statistik.Dichtefunktion(x);
    chart.Series[0].Points.Clear();
    for (int i = 0; i <= h.GetUpperBound(0); i++) chart.Series[0].Points.AddXY(Math.Round(h[i, 0],2), h[i, 1]);
}
/// <summary>
/// Aktiviert die Klassenanalyse
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void klassenanalyseToolStripMenuItem_Click(object sender, EventArgs e)
{
    double[] x = dataGridViewToX();
    Statistik statistik = new Statistik();
    klasse = statistik.Klassen(x);
    chart.Series[1].Points.Clear();
    for (int k = 0; k <= klasse.GetUpperBound(0); k++) chart.Series[1].Points.AddXY(Math.Round(klasse[k, 0],2), klasse[k, 1]);
    //Bemerkung Math.Round() hat mehrere Überladungen. Der zweite Parameter gibt die Stellen, auf die gerundet wird , an.
}
/// <summary>
/// Ruft das Unterformular mit dem Diagramm
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void diagrammToolStripMenuItem_Click(object sender, EventArgs e)
{
    Form_Diagramm diagramm = new Form_Diagramm();
    diagramm.Show();
}
/// <summary>
/// Beendet die Anwendung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
#endregion Ereignismethoden

#region Methoden
/// <summary>
/// Überträgt die Daten der Datentabelle in ein Feld.
/// </summary>
/// <returns></returns> Feld
private double[] dataGridViewToX()
{
    int n = dataGridView.RowCount;
    double[] x = new double[n];
    for (int i = 0; i < n; i++)
    {
        x[i] = Convert.ToDouble(dataGridView[0, i].Value);
    }
    return x;
}
#endregion Methoden

#region Eigenschaftsmethoden
/// <summary>
/// Liefert die Häufigkeits-Normalverteilung
/// </summary>
public double[,] get_h
{
    get
    {
        return h; //DataVisualization.Charting.DataPointCollection
    }
}
/// <summary>
/// Liefert die Klassen-Werte
/// </summary>
public double[,] getKlasse
{
    get
    {
        return klasse; //DataVisualization.Charting.DataPointCollection
    }
}
#endregion Eigenschaftsmethoden

#region Hilfe


private void hilfeAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Help.ShowHelp(this, "HilfeVerteilung.chm", HelpNavigator.Index);
}

#endregion Hilfe










private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

/// <summary>
/// Hinweis der Datentabelle
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void dataGridView_MouseEnter(object sender, EventArgs e)
{
    Help.ShowPopup(this, "Importierte Daten können manuell nachbearbeitet werden!",
        dataGridView.PointToScreen(new Point(0, 40)));
}

        /// <summary>
        /// Hinweis der Hauptmenüaktion zum Laden von Daten einer Exceltabelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelImportToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            //Hinweis
            Help.ShowPopup(this, "Importierte Daten einer Exceltabelle!",
                menuStrip.PointToScreen(new Point(0, 40)));
        }


        private void menuStrip_MouseEnter(object sender, EventArgs e)
        {
           // Help.ShowPopup(this, "Hauptmenüaktionen!",
            //    menuStrip.PointToScreen(new Point(0, 40)));
        }

        private void dataGridView_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



 




    }
}
