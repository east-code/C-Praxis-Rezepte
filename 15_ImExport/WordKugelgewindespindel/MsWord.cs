//zur Bildverarbeitung
///Diese using-Anweisung einfügen
///"Word =" für verkürzte Schreibweise im Quelltext 
using Word = Microsoft.Office.Interop.Word; 

namespace Kugelgewindespindel
{
    class MsWord
    {
#region Instanz-Variablen
Word.Application word = new Word.Application(); //Anwendung
Word.Document document;                         //Dokument
Word.Paragraph paragraph;                       //Absatz
Word.Table table;                               //Tabelle
#endregion Instanz-Variablen

#region Instanz-Methoden
/// <summary>
/// Öffnet die Anwendung und fügt ein leeres Dokument hinzu.
/// </summary>
public void open()
{
    word.Visible = true;        //Eigenschaften der Anwendung ...
    word.WindowState = Word.WdWindowState.wdWindowStateNormal; //Word öffnen
    document = word.Documents.Add();  //Dokument hinzufügen
}
/// <summary>
/// Fügt einen Text ein.
/// </summary>
/// <param name="text"></param> Text
public void text(string text)
{
    paragraph = document.Paragraphs.Add(); //Absatz hinzufügen
    paragraph.Range.Text = text;            //Text übergeben
    paragraph.Range.InsertParagraphAfter(); //Absatzendezeichen setzen
}
/// <summary>
/// Fügt einen Text ein, fett hervorgehoben (Überladung)
/// </summary>
/// <param name="text"></param> Text
/// <param name="Bold"></param> Marker für Fett
public void text(string text, int Bold )
{
    paragraph = document.Paragraphs.Add(); //Absatz hinzufügen
    int oldBold = paragraph.Range.Bold;
    paragraph.Range.Bold = Bold;
    paragraph.Range.Text = text;            //Text übergeben
    paragraph.Range.InsertParagraphAfter(); //Absatzendezeichen setzen
    paragraph.Range.Bold = oldBold;
}
/// <summary>
/// Lädt eine Bild 
/// </summary>
/// <param name="bildPathName"></param> //Pfad des zu ladenden Bildes
public void bild(string bildPathName)
{
    paragraph = document.Paragraphs.Add(); //Absatz hinzufügen
    paragraph.Range.InlineShapes.AddPicture(bildPathName); //Einfügen eines Bildes
    paragraph.Range.InsertParagraphAfter(); //Absatzendezeichen setzen
}
/// <summary>
/// Fügt eine Tabelle ein und füllt diese mit Feldinformationen
/// </summary>
/// <param name="zeile"></param>
public void tabelle(params string[][] zeile)
{
    paragraph = document.Paragraphs.Add(); //Absatz hinzufügen
    int zeilenAnzahl = zeile.Length; // Zeilenanzahl der Folgezeilen (zeile.GetUpperBound(0) + 1)
    int spaltenAnzahl = zeile[0].Length;    //Spaltenanzahl
    table = document.Tables.Add(paragraph.Range, zeilenAnzahl, spaltenAnzahl); //Tabelle in den Bereich des Absatzes legen
    table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle; //Raster zeichnen
    table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble; //Umrandung zeichnen
    //Achtung: Word-Tabellen beginnen mit dem Index 1 für Zeilen und Spalten
    for (int j = 0; j < spaltenAnzahl; j++) //Spalten
        for (int i = 0; i < zeilenAnzahl; i++) table.Cell(i + 1, j + 1).Range.Text = zeile[i][j]; //Zeilen, Werte schreiben
}
/// <summary>
/// Speichert das Dokument, schließt das Dokument und beendet die Anwendung
/// </summary>
/// <param name="pfadName"></param> Speicherpfad des Dokumentes
public void saveAndClose(string pfadName)
{
    document.SaveAs(pfadName); //Speichern des Dokuments
    document.Close();   //Dokument schließen
    word.Quit();        //Anwendung schließen
}
#endregion Instanz-Methoden
    }
}
