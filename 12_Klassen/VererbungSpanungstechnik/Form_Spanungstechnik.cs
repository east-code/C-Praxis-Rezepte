using System;
using System.Windows.Forms;
namespace Spanungstechnik
{
    public partial class Form_Spanung : Form
    {
public Form_Spanung()
{
    InitializeComponent();
}
/// <summary>
/// Schließt die Anwendung
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
#region Spanen
double   m;     //Anstiegswert der Schnittkraft
double  kc11;   // Spezifische Schnittkraft für den Querschnitt 1x1 mm
/// <summary>
/// Läd die Wekstoffdaten aus der Klasse Werkstoffe
/// und überträgt diese in die Datentabelle "dataGridView_WSt"
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_Spanung_Load(object sender, EventArgs e)
{
    Werkstoffe wst = new Werkstoffe();
    dataGridView_WSt.RowCount = wst.getLength;
    for (int i = 0; i < wst.getLength; i++)
    {
        wst.seti = i;
        dataGridView_WSt.Rows[i].Cells[0].Value= wst.getName;
        dataGridView_WSt.Rows[i].Cells[1].Value = wst.getm;
        dataGridView_WSt.Rows[i].Cells[2].Value = wst.getKc11;
    }
    //Anfangswerte für m und Kc11
    m = Convert.ToInt32(dataGridView_WSt.Rows[1].Cells[1].Value);
    kc11 = Convert.ToInt32(dataGridView_WSt.Rows[1].Cells[2].Value);
}
/// <summary>
/// Auswahl der Konstanten m, kc11 aus der Tabelle "dataGridView_Wst"
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void dataGridView_WSt_CellClick(object sender, DataGridViewCellEventArgs e)
{
    string element = Convert.ToString(dataGridView_WSt.CurrentCell.Value); //Liefert den Inhalt des gewählten Elementes
    int zeile = dataGridView_WSt.CurrentCell.RowIndex; //Liefert die Zeilennumer, passend zum gewählen Element
    m = Convert.ToInt32(dataGridView_WSt.Rows[zeile].Cells[1].Value);
    kc11 = Convert.ToInt32(dataGridView_WSt.Rows[zeile].Cells[2].Value);
}
/// <summary>
/// Dialog zur Schnittkraft beim Drehen
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void drehenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Drehen turn = new Drehen();
    double ap = Convert.ToDouble(textBox_ap.Text);
    double f = Convert.ToDouble(textBox_f.Text);
    double kappa = Convert.ToDouble(textBox_kappa.Text);
    textBox_Fc.Text = (turn.Schittkraft_Fc(ap, f, kappa, kc11, m)/1000).ToString();
}
/// <summary>
/// Schnittkraft beim Fräsen
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void fräsenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Fraesen mill = new Fraesen();
    double ap = Convert.ToDouble(textBox_apMill.Text);
    double ae = Convert.ToDouble(textBox_aeMill.Text);
    double fz = Convert.ToDouble(textBox_fzMill.Text);
    double Dwz = Convert.ToDouble(textBox_DwzMill.Text);
    int z = Convert.ToInt16(textBox_zMill.Text);
    double kappa = Convert.ToDouble(textBox_kappaMill.Text);
    double phiS=Math.PI/2;
    if (radioButton_mittig.Checked) phiS = mill.phiWzMittig(ae, Dwz); 
    if (radioButton_links.Checked)  phiS = mill.phiWzLinks(ae, Dwz);
    double Fcz = mill.Schnittkraft_Fcz(ae, ap, fz, Dwz, kappa, phiS, kc11, m);
    double Fceff = mill.Schnittkraft_Fceff(Fcz, mill.Eingriffszaehnezahl_ze(z, phiS));
    textBox_FczMill.Text = (Fcz/1000).ToString("0.000");
    textBox_FcMill.Text = (Fceff/1000).ToString("0.000");
}
#endregion Spanen
#region leer
private void dataGridView_WSt_CellContentClick(object sender, DataGridViewCellEventArgs e)
{




}
private void zerspanungskraftToolStripMenuItem_Click(object sender, EventArgs e)
{

}
      
private void Form1_Load(object sender, EventArgs e)
{

}

private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
{

}

private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}
private void radioButton_links_CheckedChanged(object sender, EventArgs e)
{

}
private void radioButton_mittig_CheckedChanged(object sender, EventArgs e)
{

}
#endregion leer

private void textBox_DwzMill_TextChanged(object sender, EventArgs e)
{

}
    }
}
