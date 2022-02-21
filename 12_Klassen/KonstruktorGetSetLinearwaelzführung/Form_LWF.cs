using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linearwaelzführung

{
    public partial class Form_LWF : Form
    {
        public Form_LWF()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Betriebsbedingungen_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

private void oKToolStripMenuItem_Click(object sender, EventArgs e)
{
    Waelzfuehrung wf = new Waelzfuehrung(); //eine Instanz der Klasse Wälzführung
    wf.istn = dataGridView_Betrieb.RowCount - 1; 
    // Werte aus dem Formular
    for (int i = 0; i < wf.istn; i++)
    {
        wf.istv[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[1].Value);
        wf.istt[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[2].Value);
        wf.istFy[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[4].Value);
        wf.istFz[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[5].Value);
    }
    //Verarbeitung
    double vMittel = wf.MittelwertGewichtet(wf.istv, wf.istt);
    dataGridView_Gesamt.Rows.Add();
    dataGridView_Gesamt.Rows[0].Cells[1].Value = vMittel;
    wf.ists = wf.ToWegAnteil(wf.istv, wf.istt);
    double Fäqu = wf.AequivalentKraft(wf.BetragsKraft(wf.istFy, wf.istFz), wf.ists);
    // zum Formular
    for (int i = 0; i < wf.istn; i++) 
        dataGridView_Betrieb.Rows[i].Cells[3].Value = wf.ists[i];
    dataGridView_Gesamt.Rows[0].Cells[4].Value = Fäqu.ToString("0.0");
}

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView_Gesamt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
