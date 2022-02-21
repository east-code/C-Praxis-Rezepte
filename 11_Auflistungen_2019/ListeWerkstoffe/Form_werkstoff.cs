using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werkstoffe
{
  public partial class Form_werkstoff : Form
  {
    public Form_werkstoff()
    {
      InitializeComponent();
    }

/// <summary>
/// Eine Liste "werkstoff" zur Speicherung von Werkstoffdaten wird erzeugt
/// </summary>
private List<string> werkstoff = new List<string>();

/// <summary>
/// Fueht der Liste Standardwerte hinzu
/// </summary>
private void Form_werkstoff_Load(object sender, EventArgs e)
{
  werkstoff.Add("C45");
  werkstoff.Add("C45 E+N");
  werkstoff.Add("S235JR+AR");
  werkstoff.Add("G-X6CrNiMo18-10");
  werkstoff.Add("X6CrNiMoTi17-12-2");
  // Diese Methode übergibt die Daten der internen Liste an die  Listbox
  foreachOutput();
}

    // Gewoehnliche Methoden  mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
/// <summary>
/// Übergibt die Daten der Internen Liste an die Listbox.
/// Ausgabe der Listendaten per Zählschleife
/// </summary>
private void countingOutput()
{
  // Bevor die Ausgabe erfolt,  lösche die alten Daten
  listBox_output.Items.Clear();
  // Zugriff auf jedes Element
  for (int i = 0; i < werkstoff.Count; i++)
  {
    listBox_output.Items.Add(werkstoff[i]);
  }
}

/// <summary>
/// Ausgabe der Listendaten per Zählschleife
/// </summary>
private void foreachOutput()
{
  // Bevor die Ausgabe erfolt,  lösche die alten Daten
  listBox_output.Items.Clear();
  // Für alle Elemente der Liste
  foreach (var element in werkstoff)
  {
    listBox_output.Items.Add(element);
  }
}

    // Ereignismethoden für die deutsche Version  dddddddddddddddddddddddddddddddddddddddddd //

/// <summary>
/// Hinzufuegen eines Listeneintrags
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void hinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Eingabe: Übernahme in die Liste
  werkstoff.Add(textBox_edit.Text);
  // Ausgabe der Listeneinträge
  foreachOutput();
}
/// <summary>
/// Loescht den ausgewählten Eintrag aus der Werkstoffliste
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void loeschenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Auswahl des Eintrags in der Listbox
  string line = listBox_output.Text;
  // Loescht den Eintrag
  werkstoff.Remove(line);
  // Aktualisiert die Ausgabe
  countingOutput();
}
/// <summary>
/// Sortiert die Werkstoffliste
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void sortierenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Sort ist eine Methode der Liste
  werkstoff.Sort();
  //  Aktualisiert die Ausgabe
  countingOutput();
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


    // Ereignismethoden für Englisch eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

    /// <summary>
    /// Exits the application
    /// </summary>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
    /// <summary>
    /// Removes the selected item out of the material list
    /// </summary>
    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Selects the Item from the Listbox
      string line = listBox_output.Text;
      // Removes the item
      werkstoff.Remove(line);
      // Update the output
      countingOutput();
    }

    /// <summary>
    /// Sorting the material data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sortToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Sort is a method of a list
      werkstoff.Sort();
      //  Update the output
      countingOutput();
    }

    
    /// <summary>
    /// Add an item to the list
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Input
      werkstoff.Add(textBox_edit.Text);
      // output
      foreachOutput();
    }












  }
}


