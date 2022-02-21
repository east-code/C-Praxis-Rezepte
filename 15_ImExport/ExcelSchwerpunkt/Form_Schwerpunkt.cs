using System;
using System.Windows.Forms;

namespace Excel_Schwerpunkt
{
public partial class Form_Schwerpunkt: Form
{
    public Form_Schwerpunkt()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Ein- Ausgabe in Sachen Schwerpunkt
    /// Die Berechnung des Gesamtschwerpunkts erfolgt über 
    /// das Objekt "schwerpunkt" der Klasse "Schwerpunkt"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void gesamtschwerpunktToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int n = dataGridView_Schwerpkt.RowCount;  //liefert die Anzahl der Datenzeilen
        Schwerpunkt schwerpunkt = new Schwerpunkt(n); //n wird an den Konstruktor der Klasse übergeben
        for (int i=0; i<n; i++)
        {
            schwerpunkt.seti = i;  //Flächenindex
            schwerpunkt.setA = Convert.ToDouble(dataGridView_Schwerpkt["Column_A", i].Value);
            schwerpunkt.setXs = Convert.ToDouble(dataGridView_Schwerpkt["Column_Xs", i].Value);
            schwerpunkt.setYs = Convert.ToDouble(dataGridView_Schwerpkt["Column_Ys", i].Value);
        }
        textBox_gesamtA.Text  = schwerpunkt.gesamtFlaeche().ToString("0.00"); 
        textBox_gesamtXs.Text = schwerpunkt.gesamtX().ToString("0.000");          
        textBox_gesamtYs.Text = schwerpunkt.gesamtY().ToString("0.000");        
    }
    /// <summary>
    /// Öffnet Excel und überträgt die Werte in eine geöffnete Tabelle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void excelExportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //SaveFileDialog save = new SaveFileDialog();
        MsExcel excel = new MsExcel();
        if (saveFileDialog_Excel.ShowDialog() == DialogResult.OK)
        {
            excel.openSheed("Schwerpunkt");
            excel.headRowToSheed(dataGridView_Schwerpkt.Columns[0].HeaderText,
                                    dataGridView_Schwerpkt.Columns[1].HeaderText,
                                    dataGridView_Schwerpkt.Columns[2].HeaderText);
            for (int i = 0; i < dataGridView_Schwerpkt.RowCount; i++) //Alle zeilen
                for (int j = 0; j < 3; j++) //alle Spalten
                {
                    excel.toSheed(i, j, dataGridView_Schwerpkt[j, i].Value);
                }
                excel.saveAndClose(saveFileDialog_Excel.FileName);
        }

    }
    /// <summary>
    /// Importiert Daten aus einer Exceltabelle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void excelImportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MsExcel excel = new MsExcel();
        if (openFileDialog_Excel.ShowDialog() == DialogResult.OK)
        {
            dataGridView_Schwerpkt.Rows.Clear();  //Löscht alte Daten in der Tabelle
            excel.openSheed(openFileDialog_Excel.FileName, "Schwerpunkt");
            int zeile=0;
            while (excel.FromSheed(zeile, 0) != null) //Bis eine Zelle leer ist
            {
                dataGridView_Schwerpkt.Rows.Add();
                for (int spalte = 0; spalte < 3; spalte++) //alle Spalten
                {
                    object wert = excel.FromSheed(zeile, spalte);
                    dataGridView_Schwerpkt[spalte, zeile].Value = wert;
                }
                zeile++; //
            }
            excel.Close();
        }
    }
    /// <summary>
    /// Schließt das Formular
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
}
}
