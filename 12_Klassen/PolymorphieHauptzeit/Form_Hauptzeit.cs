using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hauptzeit
{
    public partial class Form_Hauptzeit : Form
    {
        public Form_Hauptzeit()
        {
            InitializeComponent();
        }

private void button_OK_Click(object sender, EventArgs e)
{
    BasisHauptzeit  basis         = new BasisHauptzeit();
    DrehenHauptzeit drehen        = new DrehenHauptzeit();
    BasisHauptzeit  basisOverride = new DrehenHauptzeit();

    double L= Convert.ToDouble(textBox_L.Text);
    int i= Convert.ToInt16(textBox_i.Text);
    double vf= Convert.ToDouble(textBox_vf.Text);

    textBox_thBasis.Text = basis.Hauptzeit(L, i, vf).ToString();
    /* Beide Methoden besitzen gleiche Namen und gleiche Signatur.
    Die Methode zur Zeitberechnung beim Drehen unterscheidet sich im Vgl. zur Basisklasse.
    Die Methode der Basisklasse wird überschrieben mit "override" da diese "virtual" ist. */
    textBox_thDrehen.Text   = drehen.Hauptzeit(L, i, vf).ToString();
    textBox_thOverride.Text = basisOverride.Hauptzeit(L, i, vf).ToString(); 
}
    }
}
