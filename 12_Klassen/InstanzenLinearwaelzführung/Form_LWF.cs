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
    Waelzfuehrung fuehrung = new Waelzfuehrung(); //eine Instanz ----------------------------
    Waelzfuehrung rollenFuehrung = new Waelzfuehrung(); //eine weitere Instanz der Klasse
    int n=dataGridView_Betrieb.RowCount-1; //Anzahl der Elemente
    double[] v = new double[n]; //Geschwindigkeiten /Zeiten und Wege 
    for (int i=0; i<n; i++)
    {
        v[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[1].Value); //oder:
        //  v[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[Column_v.ToString()].Value);
    }
    double[] t = new double[n];
    for (int i = 0; i < n; i++) t[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[2].Value);
    double vMittel = fuehrung.MittelwertGewichtet(v, t);//Statistik.Mittelwert(v);
    dataGridView_Gesamt.Rows.Add();
    dataGridView_Gesamt.Rows[0].Cells[1].Value = vMittel;
    double[] s = new double[n];
    s = fuehrung.ToWegAnteil(v, t);
    for (int i = 0; i < n; i++) dataGridView_Betrieb.Rows[i].Cells[3].Value = s[i];
    double[] Fy = new double[n]; //Kräfte ------------------------------------------------------
    double[] Fz = new double[n];
    for (int i = 0; i < n; i++)
    {
        Fy[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[4].Value);
        Fz[i] = Convert.ToDouble(dataGridView_Betrieb.Rows[i].Cells[5].Value);
    }
    double Fäqu = fuehrung.AequivalentKraft(fuehrung.BetragsKraft(Fy,Fz), s);
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
