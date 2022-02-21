using System;
namespace Spanungstechnik
{
    class Fraesen: BasisSpanen
    {
/// <summary>
/// Berechnet die mittlere Schnittkraft eies Zahns Fz beim Fräsen währen des Eingriffs
/// </summary>
/// <param name="ae"></param> Eingriffsbreite in mm
/// <param name="ap"></param> Schnitttiefe in mm
/// <param name="fz"></param> Zahnvorschub mm/U
/// <param name="Dwz"></param> Werkzeugdurchmesser in mm
/// <param name="kappa"></param> Einstellwinkel in °
/// <param name="phi_s"></param> Schnittbogenwinkel in °
/// <param name="kc11"></param> spezifische Schnittkraft in N/mm²
/// <param name="m"></param> Anstiegswert der Schnittkraft
/// <returns></returns>
public double Schnittkraft_Fcz(double ae, double ap, double fz, double Dwz, double kappa, double phiS, double kc11, double m)
{
    kappa = ToRad(kappa); //Umrechnung in Bogenmaß
    double b = Spanungsbreite_b(ap, kappa); //Spanungsbreite in mm
    double hm = mittlereSpanungsdicke_hm(fz, kappa, ae, phiS, Dwz);//mittlere Spanungsdicke in mm
    double kc = spezifischeSchnittkraft_kc(kc11, hm, m); //spezifische Schnittkraft in N/mm²
    return b * hm * kc;  //Schnittkraft eines Zahns in N
}
/// <summary>
/// Berechnet die Eingriffszähnezahl beim Fräsen
/// </summary>
/// <param name="z"></param> Zähnezahl
/// <param name="phi_s"></param> Schnittbogenwinkel in °
/// <returns></returns>
public double Eingriffszaehnezahl_ze(int z, double phiS)
{
    return phiS * z / 2 / Math.PI;
}
/// <summary>
/// Berechnet die effektive Schnittkraft
/// </summary>
/// <param name="Fcz"></param> Schnittkraft eines Zahns
/// <param name="ze"></param>  //Eingriffszähnezahl, Rechengröße
/// <returns></returns>
public double Schnittkraft_Fceff(double Fcz, double ze)
{
    return Fcz * ze;
}
/// <summary>
/// Berechnet die mittlere Spanungsdicke
/// </summary>
/// <param name="fz"></param> Zahnvorschub mm/U 
/// <param name="kappa"></param> Einstellwinkel in °
/// <param name="ae"></param> Schnitttiefe in mm
/// <param name="phiS"></param> Schnittbogenwinkel in °
/// <param name="Dwz"></param> Werkzeugdurchmesser in mm
/// <returns></returns>
public double mittlereSpanungsdicke_hm(double fz, double kappa, double ae, double phiS, double Dwz)
{
    return ToRad(114.6) * fz * Math.Sin(kappa) * ae / phiS / Dwz; 
}
#region Delegate Werkzeuglage
/// <summary>
/// Typisierter Zeiger zur Berechnung des Schnittwinkels
/// </summary>
/// <param name="ae"></param>
/// <param name="Dwz"></param>
/// <returns></returns>
public delegate double Schnittbogenwinkel(double ae, double Dwz);
/// <summary>
/// Berechnet den Schnittbogenwinkel phiS für mittige Werkzeuglage
/// phi1=pi/2°- phiS
/// phi2=pi/2 + phiS
/// </summary>
public Schnittbogenwinkel phiWzMittig = (ae, Dwz) => 2 * Math.Asin(ae / Dwz);
/// <summary>
/// Berechnet den Schnittbogenwinkel phiS, Werkzeug links von der Kontur
/// phi1=0
/// phi2= phiS
/// </summary>
public Schnittbogenwinkel phiWzLinks = (ae, Dwz) => Math.PI / 2 + Math.Asin(2* ae / Dwz  - 1);
#endregion Delegate
    }
}
