using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
class Funktionen
{
    /// <summary>
    /// Deklaration des Delgaten
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double funktion(double x);
    /// <summary>
    /// Lambda Expression
    /// </summary>
    public funktion polygon = x => 5 + 2 * x + 0.5 * x * x;

    /// <summary>
    /// Lambda Expression mit Anweisungsblock
    /// </summary>
    public funktion polygon2 = x => { return 5 + 2 * x + 0.5 * x * x; };

    /// <summary>
    /// Lambda Expression mit Anweisungsblock und mehreren Anweisungen
    /// </summary>
    public funktion polygon3 = x => { double x1 = 5 + 2 * x;  return x1 + 0.5 * x * x; };
}
}
