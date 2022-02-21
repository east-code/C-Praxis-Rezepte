using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptzeit
{
class DrehenHauptzeit: BasisHauptzeit
{
    /// <summary>
    /// Berechnet  die Hauptzeit
    /// Mit "override" wir eine gleichnamige Methode der basisklasse überschrieben.
    /// Diese Methode berücksichtigt den Vorlaufweg und der Überlaufweg 
    /// </summary>
    /// <param name="L"></param> Drehlänge in mm
    /// <param name="i"></param> Anzahl der Schnitte
    /// <param name="vf"></param> Vorschubgeschwindigkeit mm/Min
    /// <returns></returns> Hauptzeit in Min
    public override double Hauptzeit(double L, int i, double vf)
    {
        const int la = 2;   //Anlaufweg
        const int lü = 3;   //Überlaufweg
        return (L + la + lü )* i / vf;
    }
    /// <summary>
    /// Berechnet  die Hauptzeit
    /// </summary>
    /// <param name="L"></param> Drehlänge in mm
    /// <param name="i"></param> Anzahl der Schnitte
    /// <param name="f"></param> Vorschub in mm/U
    /// <param name="n"></param> Drehzahl in U/Min
    /// <returns></returns> Hauptzeit in Min
    public double Hauptzeit(double L, int i, double f, double n)
    {
        const int la = 2;   //Anlaufweg
        const int lü = 3;   //Überlaufweg
        return (L + la + lü) * i / f /n;
    }
}
}
