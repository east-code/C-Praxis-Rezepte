using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maschinenbau
{
    public partial class Form_wörterbuch : Form
    {
        public Form_wörterbuch()
        {
            InitializeComponent();
        }

#region Struct of a Dictionary
// Dictionary<Key, Value>
Dictionary<string, string> dictionary = new Dictionary<string, string>();
string Key;  // Kay as index
#endregion Struct of a Dictionary


#region defaults
/// <summary>
/// Default settings
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_wörterbuch_Load(object sender, EventArgs e)
{
  dictionary.Add("machine tool", "A machine tool is a machine for shaping or machining metal or other rigid materials, usually by cutting, boring, grinding, shearing, or other forms of deformation. Machine tools employ some sort of tool that does the cutting or shaping.");
  dictionary.Add("Rolling-element bearing", "A rolling-element bearing, also known as a rolling bearing, is a bearing which carries a load by placing rolling elements (such as balls or rollers) between two bearing rings called races. ");
  dictionary.Add("Linear-motion bearing", "A linear-motion bearing or linear slide is a bearing designed to provide free motion in one direction. There are many different types of linear motion bearings. ");
  outputAllKeys();
  Key = dictionary.Last().Key;
  textBox_key.Text = Key;
  // richTextBox_value.Text = dictionary[Key];
  richTextBox_value.Text = Key = dictionary.Last().Value;
  textBox_Hint.Text = "Default settings!";
}
#endregion defaults

#region methods
/// <summary>
/// Output all key in the listbox
/// </summary>
private void outputAllKeys()
{
  listBox_keys.Items.Clear(); //Vor der Ausgabe ist der alte Inhalt zu entfernen.
  foreach (var element in dictionary)
  {
    listBox_keys.Items.Add(element.Key);
  }
}
/// <summary>
/// Saves the dictionary as a file in text format
/// </summary>
/// <param name="fileName"></param> file path
private void saveAsTextfile(string fileName)
{
  // Removes existing file if necessary
  System.IO.File.Delete(fileName);
  // Separator between the elements is: " | " 
  foreach (var element in dictionary) 
    System.IO.File.AppendAllText(fileName, element.Key +" | " +element.Value +"|\r\n");
}
/// <summary>
/// Loads the dictionary from a text file
/// </summary>
/// <param name="fileName"></param>
private void loadFromTextfile(string fileName)
{
  // Removes all elements from the dictionary
  dictionary.Clear();
  // Reads the content
  string[] text = System.IO.File.ReadAllLines(fileName);
  char[] charsToTrim = { '\r', '\n', ' ' };
  string key;
  string value;
  // Splits the string in his elements
  foreach (var line in text)
  {
    string[] element = line.Split('|');
    key = element[0].Trim(charsToTrim);
    value = element[1];
    dictionary.Add(key, value);
  }
}
#endregion methods



#region menu event methods
/// <summary>
/// Takes the input data into the dictionary
/// </summary>
private void addToolStripMenuItem_Click(object sender, EventArgs e)
{
  try
  {
      char[] charsToTrim = { '\r', '\n', ' ' };
      dictionary.Add(textBox_key.Text.Trim(charsToTrim), richTextBox_value.Text.Trim(charsToTrim));
      outputAllKeys();
      textBox_Hint.Text = "Added data!";
    }
  catch 
  {
      textBox_Hint.Text = "Key already exists!";
  }
}
/// <summary>
/// Update the value
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void updateToolStripMenuItem_Click(object sender, EventArgs e)
{
  try
  {
    char[] charsToTrim = { '\r', '\n', ' ' };
    dictionary[textBox_key.Text.Trim(charsToTrim)] = richTextBox_value.Text.Trim(charsToTrim);
    outputAllKeys();
    textBox_Hint.Text = "Value edit!";
  }
  catch
  {
    textBox_Hint.Text = "Update not successful!";
  }
}
/// <summary>
/// Search in the dictionary
/// </summary>
private void searchToolStripMenuItem_Click(object sender, EventArgs e)
{
      
  try
  {
    richTextBox_value.Text = dictionary[textBox_key.Text];
    textBox_Hint.Text = "Key available, text found!";
  }
  catch
  {
    textBox_Hint.Text = "Key does not exist!";
  }
}
/// <summary>
/// Deletes the record
/// </summary>
private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
{
  dictionary.Remove(textBox_key.Text);
  outputAllKeys();
}
/// <summary>
/// Saves the dictionary
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void saveToolStripMenuItem_Click(object sender, EventArgs e)
{
SaveFileDialog saveFildDialog = new SaveFileDialog();
if (saveFileDialog.ShowDialog() == DialogResult.OK) saveAsTextfile(saveFileDialog.FileName);
  textBox_Hint.Text = "Dictionary saved!";
}
/// <summary>
/// Loads the dictionary
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void loadToolStripMenuItem_Click(object sender, EventArgs e)
{
  OpenFileDialog openFileDialog = new OpenFileDialog();
  if (openFileDialog.ShowDialog() == DialogResult.OK)
      loadFromTextfile(openFileDialog.FileName);
  outputAllKeys();
  Key = dictionary.Last().Key;
  textBox_key.Text = Key;
  richTextBox_value.Text = dictionary.Last().Value;
  textBox_Hint.Text = "Dictionary loaded!";
}

/// <summary>
/// Exits the application
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void exitToolStripMenuItem_Click(object sender, EventArgs e)
{
  Close();
}
#endregion menu event methods


#region Event methods for easier actions
/// <summary>
/// Selects the key from the list
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void listBox_keys_SelectedIndexChanged(object sender, EventArgs e)
{
  textBox_key.Text = listBox_keys.Text;
  // Calls another event method
  searchToolStripMenuItem_Click(sender, e);
}
/// <summary>
/// Clear the rich text box
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button_clear_Click(object sender, EventArgs e)
{
  richTextBox_value.Clear();
  textBox_key.Clear();

}
#endregion Event methods for easier operation

    private void richTextBox_value_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
