using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse
{
  class Work
  {
    #region Instanzvariablen bzw. Attribute
    private
    Int32[] Feld ;
    Int32 Max;
    double Mit;
    #endregion

    #region Instanzmethoden
    public void Maximum()
    {
      Max = 0;
      for (int i=0; i< Feld.Length; i++)
        if (Feld[i] > Max) Max = Feld[i];
    }
    public void Mittelwert()
    {
      Mit = 0;
      for (int i = 0; i < Feld.Length; i++) Mit += Feld[i];
      Mit /= Feld.Length;
    }
    #endregion

    #region Eigenschaftsmethoden
    public Int32[] setFeld
    {
      set { this.Feld = value; }
    }
    public Int32 getMaximum
    {
      get { return this.Max; }
    }
    public double getMittelwert
    {
      get { return this.Mit; }
    }
    #endregion


  }
}
