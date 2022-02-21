///Diese using-Anweisung einfügen
using Excel = Microsoft.Office.Interop.Excel;  
namespace Excel_Schwerpunkt
{
class MsExcel
{   
    #region Variablen
    Excel.Application excel = new Excel.Application(); //Anwendung
    Excel.Workbook workbook;        //Arbeitsmappe
    Excel.Worksheet worksheet;      //Tabelle
    //Excel.Range range;            //Tabellenbereich
    #endregion Variablen

    #region Excel
    /// <summary>
    /// Öffnet Excel, legt eine Arbeitsmappe an und öffnet die Tabelle 1
    /// Die Tabelle 1 wird entsprechend Übergabeparameter umbenannt
    /// </summary>
    /// <param name="tableName"></param> Neuer Name der Tabelle 1
    public void openSheed(string tableName)
    {
        excel.Visible = true;        //Eigenschaften der Anwendung ...
        excel.WindowState = Excel.XlWindowState.xlNormal;
        workbook = excel.Workbooks.Add();   //Arbeitsmappe hinzufügen
        worksheet = workbook.Worksheets["Tabelle1"]; //Tabelle1 ist aktuell
        excel.ActiveSheet.Name = tableName;  //Umbenennen der aktuellen Tabelle
    }
    /// <summary>
    /// Öffnet Excel, legt eine Arbeitsmappe an und öffnet die Tabelle 1
    /// </summary>
    public void openSheed()
    {
        excel.Visible = true;        //Eigenschaften der Anwendung ...
        excel.WindowState = Excel.XlWindowState.xlNormal;
        workbook = excel.Workbooks.Add();   //Arbeitsmappe hinzufügen
        worksheet = workbook.Worksheets["Tabelle1"]; //Tabelle1 ist aktuell
    }
    /// <summary>
    /// Öffnet Excel, öffnet eine Arbeitsmappe mit den enthaltenen Tabellen
    /// Die Tabelle tableName wird aktuell.
    /// </summary>
    /// <param name="filePath"></param> Pfad und Dateiname der zu öffnenden Arbeitsmappe
    /// <param name="tableName"></param> aktuelle Tabelle
    public void openSheed(string filePath, string tableName)
    {
        excel.Visible = true;        //Eigenschaften der Anwendung ...
        excel.WindowState = Excel.XlWindowState.xlNormal;
        workbook = excel.Workbooks.Open(filePath);
        worksheet = workbook.Worksheets[tableName]; //Tabelle tableName ist aktuell
    }
    #endregion Excel

    #region Export
    /// <summary>
    /// Schreibt den Tabellenkopf (Kopfzeile) in die oberste (1.) Zeile
    /// </summary>
    /// <param name="row"></param> Kopfzeile mit Spaltenbeschriftung
    public void headRowToSheed(params string[] headRow)
    {
        for (int spalte = 0; spalte < headRow.Length; spalte++)
            worksheet.Cells[1, spalte + 1] = headRow[spalte];
    }
    /// <summary>
    /// Schreibt einen Wert in die Zellenkoordinaten,
    /// Zeile beginnt mit 0, Spalte beginnt mit 0
    /// </summary>
    /// <param name="zeile"></param> Zeilenindex mit 0 beginnend
    /// <param name="spalte"></param> Spaltenindex mit 0 beginnend
    ///  /// <param name="value"></param> Wert
    public void toSheed(int zeile, int spalte, object value)
    {
        //+1 da Excel mit 1 anfängt zu zählen
        //+1 für die Datenzeile, da eine Zeile für den Tabellenkopf
        //Excel-Zellen kennen den Typ object
        worksheet.Cells[zeile + 2, spalte + 1] = value;
    }
    /// <summary>
    /// Speichert die Excel-Mappe und beendet die EXCEL-Anwendung
    /// </summary>
    /// <param name="pathName"></param> Speicherort
    public void saveAndClose(string pathName)
    {
        workbook.SaveAs(pathName);
        workbook.Close();
        excel.Quit();
    }
    #endregion Export

    #region Import
    /// <summary>
    /// Liefert die Spaltenüberschriften
    /// </summary>
    /// <param name="spaltenAnzahl"></param> Anzahl der Spalten
    /// <returns></returns> Spaltenüberschriften
    public string[] headRowFromSheed(int spaltenAnzahl)
    {
        string[] headRow = new string[spaltenAnzahl];
        for (int spalte = 0; spalte < spaltenAnzahl; spalte++)
               
            headRow[spalte]=worksheet.Cells[1, spalte + 1];
        return headRow;
    }
    /// <summary>
    /// Liefert den Inhalt einer Zelle einer Exceltabelle
    /// </summary>
    /// <param name="zeile"></param> //Zeilenindex
    /// <param name="spalte"></param> //Spaltenindex
    /// <returns></returns>
    public object FromSheed(int zeile, int spalte)
    {
        //+1 da Excel mit 1 anfängt zu zählen
        //+1 für die Datenzeile, da eine Zeile für den Tabellenkopf
        //Excel-Zellen kennen den Typ object
        return worksheet.Cells[zeile + 2, spalte + 1].Value;;
    }
    /// <summary>
    /// Schließt die Anwendung
    /// </summary>
    public void Close()
    {
        workbook.Close();
        excel.Quit();
    }
    #endregion Import
}
}
