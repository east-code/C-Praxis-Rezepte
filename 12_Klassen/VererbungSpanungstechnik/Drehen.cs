
namespace Spanungstechnik
{
    class Drehen: BasisSpanen
    {
        /// <summary>
        /// Berechnet die Schnittkraft beim Drehen einer Welle
        /// </summary>
        /// <param name="ap"></param> Schnitttiefe in mm
        /// <param name="f"></param> Vorschubgeschwindigkeit in mm/min
        /// <param name="kappa"></param> Einstellwinkel Kappa in °
        /// <param name="kc11"></param> Spezifische Schittkraft für einen 1*1 mm Spanungsquerschnitt in N/mm²
        /// <param name="m"></param> Anstiegswert der Schnittkraft
        /// <returns></returns>
        public double Schittkraft_Fc(double ap, double f, double kappa, double kc11, double m)
        {
            kappa = ToRad(kappa);  //Umrechnung in Bogenmaß
            double b = Spanungsbreite_b(ap, kappa); //Spanungsbreite in mm
            double h = Spanungsdicke_h(f, kappa);   //Spanungsdicke in mm
            double kc = spezifischeSchnittkraft_kc(kc11, h, m); //spezifische Schnittkraft in N/mm²
            return b * h * kc;              //Schnittkraft Fc in N
        }
    }
}
