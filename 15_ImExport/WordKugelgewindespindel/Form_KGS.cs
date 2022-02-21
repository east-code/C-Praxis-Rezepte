using System;
using System.Windows.Forms;
using System.IO; //Hinzugefügt, um aktuelles Verzeichnis abzufragen

namespace Kugelgewindespindel
{
    public partial class Form_KGS : Form
    {
/// <summary>
///Statische Klassenvariable für, speichert den Pfad der Anwendung
///steht allen Methoden der Klasse unverändert zur Verfügung
/// </summary>
static string applicationPath; 

public Form_KGS()
{
    InitializeComponent();
}
/// <summary>
/// Einstellungen zum Programmstart
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void Form_KGS_Load(object sender, EventArgs e)
{
    applicationPath = Directory.GetCurrentDirectory(); //Liefert den Pfad der Anwendung
    listBox_k.Text = "0,42 (Einseitige Lagerung)"; //Anfangswert für Lagerung
}
/// <summary>
/// Werteübergabe und Aufruf der Berechnungsmethoden
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void drehzahlenToolStripMenuItem_Click(object sender, EventArgs e)
{
    double dk=Convert.ToDouble(textBox_dk.Text);
    double lk=Convert.ToDouble(textBox_lk.Text);
    string[] kString = listBox_k.Text.Split(' ');
    double k=Convert.ToDouble(kString[0]);
    Kugelgewindespindel kgs=new Kugelgewindespindel();
    textBox_nk.Text = kgs.kritischeDrehzahl(dk, lk, k).ToString("0.0");
    textBox_nzul.Text = kgs.zulaessigeDrehzahl(dk, lk, k).ToString("0.0");
}
/// <summary>
/// Dialog mit Word
/// Export von Text, Bild und Tabelle
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void wordExportToolStripMenuItem_Click(object sender, EventArgs e)
{
    drehzahlenToolStripMenuItem_Click(sender, e);//Vor dem Exportieren -> berechnen
    MsWord word = new MsWord();
    if (saveFileDialog_Word.ShowDialog() == DialogResult.OK)
    {
        word.open();
        word.text(label_Titel.Text, 1); //1 = fett
        word.text("");
        word.text("Die kritische Drehzahl und die zulässige Drehzahl einer Kugelumlaufspindel sind zu berechnen.");
        word.text(String.Format("Eingangsdaten sind der Spindelkerndurchmesser dk= {0} mm und die kritische Spindellänge lk= {1} mm.", textBox_dk.Text, textBox_lk.Text));
        word.text(String.Format("Gewählte Lagerungsart k= {0}!", listBox_k.Text));
        string bildPathName = applicationPath + @"\Resources\KugelumlaufspindelEinbauarten.png"; //Pfad der Ressourcen - muss Kopiert werden
        word.bild(bildPathName);
        word.text(String.Format("Die kritische Drehzahl nk beträgt {0} Umdrehungen je Minute und die zulässige Drehzahl nzul beträgt {1} Umdrehungen je Minute.", textBox_nk.Text, textBox_nzul.Text));
        word.text("Tabelle: Zusammenfassung", 1);
        string[] kopf = { " dk ", " lk", " Lagerung k", " nk", " nzul" }; //Tabelle
        string[] maßeinheit = { " mm ", " mm", " ---", " 1/min", " 1/min" };
        string[] daten = { textBox_dk.Text, textBox_lk.Text, listBox_k.Text, textBox_nk.Text, textBox_nzul.Text };
        word.tabelle(kopf, maßeinheit, daten);
    }
    word.saveAndClose(saveFileDialog_Word.FileName);//Speichert die Word-Datei und Schließt Word
}
/// <summary>
/// Anwendung schließen
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
    }
}
