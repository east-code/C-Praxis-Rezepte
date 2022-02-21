using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Normalization {
  public partial class FormGeneric_Normalisierung : Form {
    public FormGeneric_Normalisierung() {
      InitializeComponent();
    }


    #region 1. Ereignismethoden
    /// <summary>
    /// Ereignismethode zum Normalisieren in den  Float-Intervall [0.0 .. 1.0]
    /// </summary>
    private void button_0_1_normalization_Click(object sender, EventArgs e) {
      // Methodenaufruf zur Normalisierung
      float[] output_array = normalisieren<float>(textBox_Array.Lines);
      // Methodenaufruf zur Ausgabe
      ausgabe<float>(output_array);
    }

    /// <summary>
    /// Ereignismethode zum Normalisierung in den Byte-Intervall [0 .. 255]
    /// </summary>
    private void button_0_255_normalization_Click(object sender, EventArgs e) {
      // Methodenaufruf zur Normalisierung
      byte[] output_array = normalisieren<byte>(textBox_Array.Lines);
      // Methodenaufruf zur Ausgabe
      ausgabe<byte>(output_array);
    }
    #endregion Ereignismethoden


    #region 2. Generische Methoden
    /// <summary>
    /// Normaliert Elemente eines Feldes
    /// </summary>
    /// <typeparam name="Tout"></typeparam> Ausgabe-Typparameter Float oder Byte
    /// <param name="input"></param> Nichtnormaliertes Feld vom Typ String[]
    /// <returns></returns> fload- oder byte-normalisiertes Feld 
    /// float - [0 .. 1] | byte - [0 .. 255]
    private Tout[] normalisieren<Tout>(string[] input){
      // Float-Eingangsfeld
      float[] input_array  = new float[input.Length];
      // Typparametriertes Ergebnisfeld
      Tout[]  output_array = new Tout[input.Length];
      // Float-Konvertierung der Elemente des Eingangsfeldes
      for (int i = 0; i < input.Length; i++) {
        input_array[i] = Convert.ToSingle(input[i]);
      }
      // Bestimmung der Extremwerte, notwendig zur Normalisierung
      float max = input_array.Max();
      float min = input_array.Min();
      /// Der typeof-Operator ruft die System.Type-Instanz für einen Typ ab.
      /// Das Argument für den typeof-Operator muss der Name eines Typs oder eines Typparameters sein.
      Type type = typeof(Tout);
      // Normalisierung
      for (int i = 0; i < input.Length; i++) { 
        if (type.Equals(typeof(float))) //Vergleich
          // Float-Normalisierung und Konvertierung
          output_array[i] = (Tout) Convert.ChangeType((input_array[i] - min) / (max-min), type) ;
        if (type.Equals(typeof(byte))) // Vergleich
          // Byte-Normalisierung und Konvertierung
          output_array[i] = (Tout) Convert.ChangeType((input_array[i] - min) / (max - min) * 255, type);
       }
      return output_array;
    }

    /// <summary>
    /// Zeilenweise Ausgabe der Elemente eines Feldes
    /// in einer Textbox
    /// </summary>
    /// <typeparam name="Tin"></typeparam> Eingabe-Typparameter Float oder Byte
    /// <param name="output_array"></param> Ausgabefeld
    private void ausgabe<Tin>(Tin[] output_array) {
      textBox_normalizedArray.Clear();
      for (int i = 0; i < output_array.Length; i++) {
        // In eine neue Zeile schreiben
        textBox_normalizedArray.Text += Convert.ToString(output_array[i]) + "\r\n";
      }
    }

    #endregion Generische Methoden

    private void label_normalisierteAusgabe_Click(object sender, EventArgs e) {

    }
  }
}
