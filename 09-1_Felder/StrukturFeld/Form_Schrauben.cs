using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrukturFeld
{
public partial class Form_Schrauben : Form
{
  public Form_Schrauben()
  {
    InitializeComponent();
  }
  /// <summary>
  /// Beendet das Programm
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Close();
  }
  /// <summary>
  /// Datenstruktur einer Schraube
  /// </summary>
  private struct Schrauben
  {
    public string gewinde;
    public double laenge;
    public int stueck;
  }
  /// <summary>
  /// Die Datenstruktur dient als eigener Datentyp zur
  /// Deklaration eines Feldes.
  /// </summary>
  Schrauben[] schraube = new Schrauben[0];
  /// <summary>
  /// Fügt dem Feld ein Schraube hinzu.
  /// </summary>
  private void hinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
  {
    // Ein Element wird hinzugefügt
    Array.Resize(ref schraube, schraube.Length + 1);
    // Inhalte werden aus dem Formular übernommen
    schraube[schraube.Length - 1].gewinde = textBox_Gewinde.Text;
    schraube[schraube.Length - 1].laenge = Convert.ToDouble(textBox_Laenge.Text);
    schraube[schraube.Length - 1].stueck = Convert.ToInt32(textBox_Stueck.Text);
  }
  /// <summary>
  /// Schreibt den Inhalt des Feldes in die Textbox.
  /// </summary>
  private void ausgabeToolStripMenuItem_Click(object sender, EventArgs e)
  {
    //Tabellenkopf
    textBox_Schrauben.Text += String.Format("{0,8}{1,8}{2,8}\r\n", "Gewinde", "Länge", "Stück");
    //Zeilenweise Ausgabe der Schraubendaten
    for (int i=0; i < schraube.Length; i++)
    {
      // Formatierte Ausgabe in tabellarischer Anordnung
      textBox_Schrauben.Text += String.Format("{0,8}{1,8:0.0}{2,8:0}\r\n", schraube[i].gewinde, schraube[i].laenge, schraube[i].stueck);
     
    }
  }
}
}
