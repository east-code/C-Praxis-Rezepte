using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauptzeit
{
class BasisHauptzeit
{
    /// <summary>
    /// Berechnet die Hauptzeit
    /// Da sie "virtual" ist, kann diese Methode in der erbenden Klasse überschrieben werden.
    /// </summary>
    /// <param name="L"></param> Länge in mm
    /// <param name="i"></param> Schnitt-Anzahl
    /// <param name="vf"></param> Vorschubgeschwindigkeit in mm/Min
    /// <returns></returns> Hauptzeit in Min
    public virtual double Hauptzeit(double L, int i, double vf)
    {
        return (L + i )/ vf;
    }
}
}
