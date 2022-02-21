using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verteilung

{
    class Statistik
    {
#region Mittelwert
/// <summary>
/// Berechnet den Mittelwert eines Feldes
/// </summary>
/// <param name="x"></param> Feld x
/// <returns></returns> Mittelwert
public double Mittelwert(double[] x){
    double mittelwert = 0;
    foreach(double element in x) //Summe
    {
        mittelwert += element;
    }
    mittelwert /= x.Length;
    return mittelwert;
}
/// <summary>
/// Berechnet den Mittelwert und 
/// zusätzlich die Standardabweichung
/// Methode überladen
/// </summary>
/// <param name="x"></param> Feld x
/// <param name="Standardabweichung"></param> Standardabweichung
/// <returns></returns> Mittelwert
public double Mittelwert(double[] x, out double Standardabweichung)
{
    double mittelwert = Mittelwert(x);
    Standardabweichung = 0;
    foreach (double element in x) //Summe
    {
        Standardabweichung += (mittelwert - element) * (mittelwert - element);
    }
    Standardabweichung = Math.Sqrt(Standardabweichung / (x.Length - 1));
    return mittelwert;
}
#endregion Mittelwert

#region Standardabweichung
/// <summary>
/// Berechnet die Standardabweichung der Datenmenge x
/// </summary>
/// <param name="x"></param>
/// <returns></returns>
public double Standardabweichung(double[] x)
{
    double mittelwert = Mittelwert(x);
    double Standardabweichung = 0;
    foreach (double element in x) //Summe
    {
        Standardabweichung += (mittelwert - element) * (mittelwert - element);
    }
    Standardabweichung = Math.Sqrt(Standardabweichung / (x.Length - 1));
    return Standardabweichung;
}
#endregion Standardabweichung

#region Dichtefunktion
/// <summary>
/// Berechnet einen Dichtefunktionswert
/// </summary>
/// <param name="x"></param>
/// <param name="xM"></param>
/// <param name="S"></param>
/// <returns></returns>
public double Dichtefunktion(double x, double xM, double S)
{
    return Math.Exp(-(x-xM)*(x-xM)/2/S/S)/ (S * Math.Sqrt(2 * Math.PI));
}
/// <summary>
/// Berechnet alle Dichtefunktionswerte h(x, xM, S)
/// </summary>
/// <param name="x"></param>
/// <param name="xM"></param>
/// <param name="S"></param>
/// <returns></returns>
private double[] Dichtefunktion(double[] x, double xM, double S)
{
    double[] h = new double[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        h[i] = Dichtefunktion(x[i], xM, S);
    }
    return h;
}
/// <summary>
/// Berechnet alle Dichtefunktionswerte h(x)
/// </summary>
/// <param name="x"></param>
/// <returns></returns>
public double[] Dichtefunktion(double[] x, out double[] x_)
{
    double xM = Mittelwert(x);
    double S = Standardabweichung(x);
    const int length=101;
    double[] h = new double[length];
                x_ = new double[length];
    double dx = 6 * S / (length - 1);
    
    for (int i = 0; i < length; i++)
    {
        x_[i]=xM + dx*i- 3*S;
        h[i] = Dichtefunktion(x_[i], xM, S);
    }
    return h;
}
/// <summary>
/// Berechnet alle Dichtefunktionswerte h(x)
/// </summary>
/// <param name="x"></param>
/// <returns></returns> x-h-Wertepaare
public double[,] Dichtefunktion(double[] x)
{
    double xM = Mittelwert(x);
    double S = Standardabweichung(x);
    const int length = 101;
    double[,] h = new double[length,2];
    double dx = 6 * S / (length - 1);

    for (int i = 0; i < length; i++)
    {
        h[i,0] = xM + dx * i - 3 * S;
        h[i,1] = Dichtefunktion(h[i,0], xM, S);
    }
    return h;
}
#endregion Dichtefunktion

#region Klassen
/// <summary>
/// Sortiert die x-Werte nach Klassen 
/// </summary>
/// <param name="x"></param>
/// <returns></returns>
public double[,] Klassen(double[] x)
{
    int klassenanzahl = (int) ((x.Length / 10)*2+1);
    double[,] klasse = Klassen(x, klassenanzahl);
    return klasse;
}
/// <summary>
/// Sortiert die x-Werte nach Klassen 
/// </summary>
/// <param name="x"></param> Datenfeld
/// <param name="klassenanzahl"></param> Anzahl der gewünschten Klassen
/// <returns></returns>
public double[,] Klassen(double[] x, int klassenanzahl)
{
    double[] extrem = Extremwerte(x);
    double klassenbreite = (extrem[1] - extrem[0]) / klassenanzahl; //Klassenbreite
    double[,] klasse = new double[klassenanzahl, 2];
    for (int k = 0; k < klassenanzahl; k++)
    {
        klasse[k, 0] = extrem[0] + k * klassenbreite + klassenbreite / 2;
    }
    foreach (var element in x)
    {
        for (int k = 0; k < klassenanzahl; k++)
        {
            if (element > (extrem[0] + k * klassenbreite) && (element < (extrem[0] + (k + 1) * klassenbreite))) klasse[k, 1]++;
        }
    }
    return klasse;
}
#endregion Klassen

#region MinimumMaximum
/// <summary>
/// Sucht das Minimum der Datenmenge x
/// </summary>
/// <param name="x"></param> Daten
/// <returns></returns> Minimum
private double Minimum(double[] x)
{
    double minimum = x[0];
    foreach (var element in x)
    {
        if (element < minimum) minimum = element;
    }
    return minimum;
}
/// <summary>
/// Sucht das Minimum und das Maximum der Datenmenge x
/// Das Minimum besitzt den Index 0, das Maximum den Index 1.
/// </summary>
/// <param name="x"></param> Menge x
/// <returns></returns> Minimum[0], Maximum[1]
private double[] Extremwerte(double[] x)
{
    double[] extrem = new double[2];
    extrem[0] = x[0];  //Minimum
    extrem[1] = x[0];   //Maximum
    foreach (var element in x)
    {
        if (element < extrem[0]) extrem[0] = element;
        if (element > extrem[1]) extrem[1] = element;
    }
    return extrem;
}
#endregion MinimumMaximum
    }
}

