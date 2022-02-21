using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;      // wird für Threads benötigt

namespace ThreadKlasse
{
  public partial class Form_ThreadKlasse : Form
  {
    public Form_ThreadKlasse()
    {
      InitializeComponent();
    }


/// <summary>
/// Feld mit Testdaten
/// </summary>
    Int32[] feld = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 9, 7, 5, 3, 1};

/// <summary>
/// Ausgabe der Daten des Feldes zur Kontrolle
/// </summary>
private void Form_ThreadKlasse_Load(object sender, EventArgs e)
{
  textBox_Feld.Text += "Daten des Feldes\r\n";
  for (int i = 0; i < feld.Length; i++) textBox_Feld.Text += feld[i] + ", ";
}

/// <summary>
/// Einsatz der Threads zur Berechnung
/// des Mittelwertes und zur Ermittlung des Maximums
/// </summary>
private void button_Start_Click(object sender, EventArgs e)
{
  // Instanz der Klasse
  Klasse.Work work = new Klasse.Work();
  // Übergabe der Daten per Eigenschaftsmethoden
  work.setFeld = feld;
  // Threadinstanzen mit Funktionszeiger als Parameter
  Thread threadMaximum = new Thread(work.Maximum);
  Thread threadMittelwert = new Thread(work.Mittelwert);
  // Start der beiden Threads
  threadMaximum.Start();
  threadMittelwert.Start();
  // Die Ausgabe kann erst dann sinnvolle Ergebnisse liefern, nachdem
  // beide Threads beendet wurden. Die Methode Join() sorgt dafür,
  // das der Hauptprozess erst nach Ende der Threads
  // threadMittelwert und threadMaximum weiterläuft. 
  threadMittelwert.Join();
  threadMaximum.Join();
  // Ausgabe der Ergebnisse mit Hilfe Eigenschaftsmethoden
  textBox_Merkmale.Text += "Maximum   : " + work.getMaximum +"\r\n";
  textBox_Merkmale.Text += "Mittelwert: " + work.getMittelwert + "\r\n"; 
}


  }
}


// Daher eine Pause (0.1 s) im Hauptprozess mit: Thread.Sleep(100);