using System;
namespace Spanungstechnik
{
    /// <summary>
    /// Basisgleichungen zur Spanungstechnik
    /// - Verfahrensunabhängige Gleichungen
    /// </summary>
    class BasisSpanen //if(DLL) then Public
    {
        /// <summary>
        /// Berechnet die spezifische Schnittkraft
        /// </summary>
        /// <param name="kc11"></param> Spezifische Schnittkraft für den Querschnitt 1x1 mm
        /// <param name="h"></param> Spanungsdicke
        /// <param name="m"></param> Anstieg
        /// <returns></returns> Spezifische Schnittkraft
        public double spezifischeSchnittkraft_kc(double kc11, double h, double m)
        {
            return kc11 / Math.Pow(h, m); //spezifische Schnittkraft in N/mm²
        }
        /// <summary>
        /// allgemeine Schnittkraftberechnung 
        /// </summary>
        /// <param name="b"></param> Spanungsbreite
        /// <param name="h"></param> Spanungsdicke
        /// <param name="kc11"></param> Spezifische Schnittkraft für den Querschnitt 1x1 mm
        /// <param name="m"></param> Anstieg
        /// <returns></returns> Schnittkraft in N
        public double Schnittkraft_Fc(double b, double h, double kc11, double m)
        {
            return b * kc11 * Math.Pow(h, 1-m); // Schnittkraft in N
        }
        /// <summary>
        /// Umrechnung von Grad in Bogenmaß
        /// </summary>
        /// <param name="kappa"></param> Winkel in Grad
        /// <returns></returns> Winkel als Bogenmaß
        protected double ToRad(double winkelGrad)
        {
            return winkelGrad * Math.PI / 180;
        }
        /// <summary>
        /// Berechnet die Schnittleistung in kW
        /// </summary>
        /// <param name="Fc"></param> Schnittkraft in N
        /// <param name="vc"></param> Schnittgeschwindigkeit in m/min
        /// <returns></returns> Schnittleistung
        public double Schnittleistung_Pc(double Fc, double vc)
        {
            return Fc * vc / 60000; //Schnittleistung in kW
        }
        /// <summary>
        /// Berechnet die Spanungsbreite
        /// </summary>
        /// <param name="ap"></param> Schnitttiefe
        /// <param name="kappa"></param> Einstellwinkel
        /// <returns></returns> Spanungsbreit
        public double Spanungsbreite_b(double ap, double kappa)
        {
            return ap / Math.Sin(ToRad(kappa));
        }
        public double Spanungsdicke_h(double f, double kappa)
        {
            return f * Math.Sin(ToRad(kappa));
        }
    }
}
