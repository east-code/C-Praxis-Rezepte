using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werkstoffverwaltung
{
public partial class Form_matManagement : Form
{
public Form_matManagement()
{
    InitializeComponent();
}
#region struct, list, variable
/// <summary>
/// Werkstoffmerkmale
/// </summary>
private struct MaterialStruct
{
  public string name;
  public double tension;
  public string descrition;
}

/// <summary>
/// Kombination einer Liste mit einer Struktur
/// </summary>
private List<MaterialStruct> Materials = new List<MaterialStruct>();
/// <summary>
/// Aktuelle Listenzeile (Zeilenindex)
/// </summary>
int Line = 0; //aktuelle Zeile innerhalb der Liste
#endregion struct, list, variables

#region Standardwerte, Anfangswerte
/// <summary>
/// Hinzufügen der Standarddatensätze zur Strukturliste
/// </summary>
private void Form_matManagement_Load(object sender, EventArgs e)
{

  // lokale Eingabe
  MaterialStruct mat = new MaterialStruct();

  // 0. Materialeigenschaften
  mat.name = "G-X6CrNiMo18-10";
  mat.tension = 800;
  mat.descrition = "V4A, Für Pumpen";
  // Übergabe des Datensatzes an die Liste
  Materials.Add(mat);
  // 1.
  mat.name = "S235JR+AR";
  mat.tension = 235;
  mat.descrition = "Re in N/mm², Baustahl";
  Materials.Add(mat);
  //2.
  mat.name = "C45 E+N";
  mat.tension = 430;
  mat.descrition = "Rp0.2, Für Zahnräder";
  Materials.Add(mat);
  // Ausgabe der internen Lista 
  foreachOutput();
  // Setzt den Fokus auf den letzten Datensatz 
  Line = Materials.Count - 1;
  // Überträgt den aktuellen Datensatz zu den Editierfeldern
  showLine();
}
#endregion Standardwerte, Anfangswerte


#region Elementarmethoden
/// <summary>
/// Ausgabe der Listendaten per "foreach loop"
/// </summary>
private void foreachOutput()
{
  //  Löschen der alten Daten vor erneuter Ausgabe
  listBox_materials.Items.Clear();
  //  Ausgabeformat
  string format ="{0,-18} | {1,7:0.0} | {2,-25}"; 
  foreach (var mat in Materials)
  {
    // Formatierte Ausgabe entsprechend des Formatierungsstrings
    listBox_materials.Items.Add(String.Format(format, mat.name, mat.tension, mat.descrition));
  }
}
/// <summary>
/// Shows the data of the current line in the edit fields (Text Boxes).
/// </summary>
private void showLine()
{
  // Transfer the properties
  textBox_matName.Text = Materials[Line].name;
  textBox_matTension.Text = Materials[Line].tension.ToString();
  textBox_matDescription.Text = Materials[Line].descrition;
  // Output the recordnumber
  label_mat.Text = "Werkstoff, Zeile: " + Line.ToString();
}


/// <summary>
/// Saves all material data in a text file * .mat.
/// The separator between the properties is "|".
/// </summary>
/// <param name="fileName"></param> Path
private void saveAsTextfile(string fileName)
{
  // Deletes, if applicable, existing file
  System.IO.File.Delete(fileName);
  // Save in text format (separator: "|")
  foreach (var mat in Materials)
    System.IO.File.AppendAllText(fileName, mat.name + " | " +
                mat.tension + " | " + mat.descrition + "\r\n");
}
/// <summary>
/// Loads the data of the text file and hand over it to the list.
/// </summary>
/// <param name="fileName"></param> Path
private void loadFromTextfile(string fileName)
{
  //Removes all elements from the material list
  Materials.Clear(); 
  MaterialStruct mat =new MaterialStruct();
  // Reads all lines of the text file
  string[] text=System.IO.File.ReadAllLines(fileName);
  // Characters to be removed
  char[] charsToTrim = { '\r', '\n', ' ' };
  // Processes all lines
  foreach (var line in text){
    // Separates the string into its elements
    string[] element = line.Split('|');
    // Maps the elements to the properties of the material
    mat.name = element[0].Trim(charsToTrim);
    mat.tension = Convert.ToDouble(element[1].Trim(charsToTrim));
    mat.descrition = element[2].Trim(charsToTrim);
    // Adds the material to the list
    Materials.Add(mat);
  }
}
    #endregion Elementarmethoden

#region event methods of main menu
/// <summary>
/// Adds a record to the list.
/// </summary>
private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Local structure
  MaterialStruct mat=new MaterialStruct();
  // Input
  mat.name = textBox_matName.Text;
  mat.tension = Convert.ToDouble(textBox_matTension.Text);
  mat.descrition = textBox_matDescription.Text;
  // Transfer to the list
  Materials.Add(mat);
  // Display
  foreachOutput();
}

/// <summary>
/// Deletes the displayed record 
/// </summary>
private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Local structure
  MaterialStruct mat = new MaterialStruct();
  // Data to be deleted

  mat.name = textBox_matName.Text;
  mat.tension = Convert.ToDouble(textBox_matTension.Text);
  mat.descrition = textBox_matDescription.Text;
  // Removes record from the list
  Materials.Remove(mat);
  // Update the display
  foreachOutput();
}
/// <summary>
/// Save the list
/// </summary>
private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
{
      // Save dialog
      SaveFileDialog saveFildDialog =new SaveFileDialog();
      if (saveFileDialog.ShowDialog() == DialogResult.OK) {
              // Calls the method
              saveAsTextfile(saveFileDialog.FileName);
      }
}
/// <summary>
/// Load the list
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
    private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Open dialog
  OpenFileDialog openFileDialog=new OpenFileDialog();
  if (openFileDialog.ShowDialog() == DialogResult.OK) {
    // Calls the method
    loadFromTextfile(openFileDialog.FileName);
  }
  // Update the display
  foreachOutput();
}
/// <summary>
/// Exit the application
/// </summary>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
  Close();
}
    #endregion event methods of main menu

#region event method of Listbox
/// <summary>
/// Gets the index of the active row and record
/// </summary>
private void listBox_materials_SelectedIndexChanged(object sender, EventArgs e)
{
  // Returns the line text
  string stringLine = listBox_materials.Text;
  // Returns the associated index
  Line = listBox_materials.Items.IndexOf(stringLine);
  // Check limits
  if (Line < 0) Line = 0;
  if (Line > Materials.Count - 1) Line = Materials.Count - 1;
  // Display elements
  showLine();
}
#endregion event method of Listbox














  }
}
