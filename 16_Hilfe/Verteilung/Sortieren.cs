using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verteilung
{
class Sortieren
{
    #region Delegate
    /// <summary>
    /// Deklaration des Delegaten
    /// Zeigt auf die Funktionen "SortAufsteigend" oder "SortAbsteigend"
    /// deren Signatur zum Delgaten passen muss.
    /// </summary>
    /// <param name="x"></param> Vergleichsparameter
    /// <param name="y"></param> Vergleichsparameter
    /// <returns></returns>
    public delegate bool CompareIntDelegate(int x, int y);
    public delegate bool CompareDoubleDelegate(double x, double y);
    /// <summary>
    /// Vergleichsfunktion für Aufsteigende Sortierung
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool Aufsteigend(int x, int y)
    {
        if (y < x) return true;
        else return false;
    }
    public bool Aufsteigend(double x, double y)
    {
        if (y < x) return true;
        else return false;
    }
    /// <summary>
    ///  Vergleichsfunktion für Absteigende Sortierung
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool Absteigend(int x, int y)
    {
        if (y > x) return true;
        else return false;
    }
    public bool Absteigend(double x, double y)
    {
        if (y > x) return true;
        else return false;
    }
    /// <summary>
    /// Sortiert wahlweise auf- oder absteigend mit Hilfe eines Delegaten.
    /// </summary>
    /// <param name="compareDelegate"></param> Delegate für Vergleichsmethode
    /// <param name="X"></param> zu sortierendes Feld
    /// <returns></returns>
    public int[] bubbleSortWithDelegate(CompareIntDelegate compare, int[] X)
    {
        int n = X.Length;  //Länge des Feldes
        int tausch;  //zum Tauschen der Werte zweier Feldelemente
        for (int i = n - 1; i >= 0; i--) //Feldelemente
        {
            for (int j = 1; j <= i; j++) //unsortierte Feldelemente
            {
                //if (X[j - 1] > X[j]) //Tauschbedingung
                if (compare(X[j - 1], X[j]))
                {
                    tausch = X[j - 1]; //Tauschen
                    X[j - 1] = X[j];
                    X[j] = tausch;
                }
            }
        }
        return X;
    }

    public double[] bubbleSortWithDelegate(CompareDoubleDelegate compare, double[] X)
    {
        int n = X.Length;  //Länge des Feldes
        double tausch;  //zum Tauschen der Werte zweier Feldelemente
        for (int i = n - 1; i >= 0; i--) //Feldelemente
        {
            for (int j = 1; j <= i; j++) //unsortierte Feldelemente
            {
                //if (X[j - 1] > X[j]) //Tauschbedingung
                if (compare(X[j - 1], X[j]))
                {
                    tausch = X[j - 1]; //Tauschen
                    X[j - 1] = X[j];
                    X[j] = tausch;
                }
            }
        }
        return X;
    }
    #endregion Delegate
}
}
