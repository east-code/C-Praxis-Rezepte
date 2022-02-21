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

namespace ThreadInvoke
{
  public partial class Form_ThreadInvoke : Form
  {
    public Form_ThreadInvoke()
    {
      InitializeComponent();
    }

    // Feld mit Testdaten
    Int32[] feld = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 9, 7, 5, 3, 1};

    private void Form_ThreadKlasse_Load(object sender, EventArgs e)
    {
      textBox_Feld.Text += "Daten des Feldes\r\n";
      for (int i = 0; i < feld.Length; i++) textBox_Feld.Text += feld[i] + ", ";
    }

private void button_Start_Click(object sender, EventArgs e)
{
  // Instanz der Klasse
  Klasse.Work work = new Klasse.Work();
  // Übergabe der Daten per Eigenschaftsmethoden
  work.setFeld = feld;
  // Paralle Prozesse werden angesoßen
  Parallel.Invoke(work.Maximum, work.Mittelwert);
  // Erst nach Abarbeitung der Parallel-Prozesse
  // läuft der Hauptprozess weiter

  // Ausgabe der Ergebnisse mit Hilfe Eigenschaftsmethoden
  textBox_Merkmale.Text += "Maximum   : " + work.getMaximum +"\r\n";
  textBox_Merkmale.Text += "Mittelwert: " + work.getMittelwert + "\r\n"; 
}
  }
}


// Daher eine Pause (0.1 s) im Hauptprozess mit: Thread.Sleep(100);