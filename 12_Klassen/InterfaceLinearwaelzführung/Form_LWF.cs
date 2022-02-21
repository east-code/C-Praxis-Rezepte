using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linearwaelzfuehrung

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
    int n = wf.istn; //lokal für kürzere Schreibweise
    for (int i = 0; i < wf.istn; i++)
        wf.istv[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[1].Value);
    for (int i = 0; i < n; i++) wf.istt[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[2].Value);
    double vMittel = wf.MittelwertGewichtet(wf.istv, wf.istt);
    dataGridView_Gesamt.Rows.Add();
    dataGridView_Gesamt.Rows[0].Cells[1].Value = vMittel;
    wf.ists = wf.ToWegAnteil(wf.istv, wf.istt);
    for (int i = 0; i < n; i++) dataGridView_Betrieb.Rows[i].Cells[3].Value = wf.ists[i];
    for (int i = 0; i < n; i++)//Kräfte ------------------------------------------------------
    {
        wf.istFy[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[4].Value);
        wf.istFz[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[5].Value);
    }
    double Fäqu = wf.AequivalentKraft(wf.BetragsKraft(wf.istFy,wf.istFz), wf.ists);
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
