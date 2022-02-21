namespace Kugelgewindespindel
{
class Kugelgewindespindel
{
    /// <summary>
    /// Konstante
    /// </summary>
    const double Sn = 1.25; //Sicherheitsfaktor für zulässige Drehzahl
    /// <summary>
    /// Berechnet die kritische Drehzahl einer Kugelgewindespindel
    /// </summary>
    /// <param name="dk"></param> Kerndurchmesser der Spindel
    /// <param name="lk"></param> kritische Länge
    /// <param name="k"></param> Lagerungsart-Beiwert
    /// <returns></returns> kritische Drehzahl
    public double kritischeDrehzahl(double dk, double lk, double k)
    {
        return k * dk * 100000000 / lk / lk;
    }
    /// <summary>
    /// Berechnet die kritische Drehzahl einer Kugelgewindespindel
    /// </summary>
    /// <param name="nk"></param> kritische Drehzahl
    /// <returns></returns> zulässige Drehzahl
    public double zulaessigeDrehzahl(double nk)
    {
        return nk / Sn;
    }
    /// <summary>
    /// zulässige Drehzahl (Überladung)
    /// </summary>
    /// <param name="dk"></param> Kerndurchmesser der Spindel
    /// <param name="lk"></param> kritische Länge
    /// <param name="k"></param> Lagerungsart-Beiwert
    /// <returns></returns> zulässige Drehzahl
    public double zulaessigeDrehzahl(double dk, double lk, double k)
    {
        return kritischeDrehzahl(dk,lk,k)/ Sn;
    }

}
}
