using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearwaelzführung
{
    interface IWaelzfuehrung
    {
/// <summary>
/// Berechnet den gewichteten Mittelwert
/// </summary>
/// <param name="x"></param> Einzelwerte
/// <param name="wichte"></param> Wichtungsfaktoren
/// <returns></returns>
double MittelwertGewichtet(double[] x, double[] wichte);
/// <summary>
/// Berechnet die Weganteile der Belastungsfälle
/// </summary>
/// <param name="v"></param> Geschwindigkeiten
/// <param name="tAnteil"></param> Zeitanteile
/// <returns></returns>
double[] ToWegAnteil(double[] v, double[] tAnteil);
/// <summary>
/// Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
/// </summary>
/// <param name="F1"></param> verikale Kraft
/// <param name="F2"></param> horizontale Kraft
/// <returns></returns>
double BetragsKraft(double F1, double F2);
/// <summary>
/// Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
/// für alle Belastungsfälle
/// </summary>
/// <param name="F1"></param> verikale Kraft als Feld
/// <param name="F2"></param> horizontale Kraft als Feld
/// <returns></returns>
double[] BetragsKraft(double[] F1, double[] F2);
/// <summary>
///  Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
///  unter Berücksichtigung eines wirkenden Momentes
/// </summary>
/// <param name="F1"></param> vertikale Kraft
/// <param name="F2"></param> horizontale Kraft
/// <param name="M"></param>  Moment
/// <param name="Mzul"></param> zulässiges Moment
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <returns></returns>
double BetragsKraft(double F1, double F2, double M, double Mzul, double Cdyn);
/// <summary>
/// Berechnet die Äquivalente Kraft gewichtet entsprechend der Weganteile
/// </summary>
/// <param name="F"></param> Einzelkräfte
/// <param name="sAnteil"></param> Weganteile der einzelnen Kräfte s[i]/sges
/// <returns></returns>
double AequivalentKraft(double[] F, double[] sAnteil);
/// <summary>
/// Berechnet die Äquivalente Kraft gewichtet entsprechend der Weganteile
/// </summary>
/// <param name="F"></param> Einzelkräfte
/// <param name="v"></param> Geschwindigkeit in Bezug zur Einzelkraft
/// <param name="tAnteil"></param> Zeitantei t[i]/tges
/// <returns></returns>
double AequivalentKraft(double[] F, double[] v, double[] tAnteil);
/// <summary>
/// Berechnet die Lebensdauer in Metern
/// </summary>
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <param name="F"></param> Äquivalente Kraft
/// <param name="p"></param> Wälzkörperbeiwert Kugel p=3, Rolle p=10/3 [optional]
/// <param name="Lb"></param> nominelle Lebensdauer Lb=100000 m
/// <returns></returns>
double LebensdauerMeter(double Cdyn, double F, double p = 3, int Lb = 100000);
/// <summary>
/// Berechnet die Lebensdauer in Stunden
/// </summary>
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <param name="F"></param> Äquivalente Kraft
/// <param name="p"></param> Wälzkörperbeiwert Kugel p=3, Rolle p=10/3
/// <param name="vMittel"></param> gewichtete Mittlere Geschwindigkeit
/// <param name="Lb"></param> nominelle Lebensdauer Lb=100000 m
/// <returns></returns>
double LebensdauerStunden(double Cdyn, double F, double p, double vMittel, int Lb = 100000);
/// <summary>
/// Berechnet die Lebensdauer in Stunden
/// </summary>
/// <param name="Lmeter"></param> Lebensdauer in Metern
/// <param name="vMittel"></param> gewichtetet mittlere Geschwindigkeit
/// <returns></returns>
double LebensdauerStunden(double Lmeter, double vMittel);


    }
}
