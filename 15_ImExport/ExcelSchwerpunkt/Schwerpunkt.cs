namespace Excel_Schwerpunkt
{
class Schwerpunkt
{
    #region Instanzvariablen
    private int i;       //Index der Teilflächen
    private int n;       //Anzahl der Teilflächen
    private double[] A;  //Teilflächen
    private double[] X;  //Schwerpunkt einer Teilfläche in x-Richtung
    private double[] Y;  //Schwerpunkt einer Teilfläche in y-Richtung
    private double Ages; //Gesamtfläche
    private double Xges; //Gesamtschwerpunkt in x-Richtung
    private double Yges; //Gesamtschwerpunkt in y-Richtung
    #endregion Instanzvariablen

    #region Konstruktoren
    /// <summary>
    /// leerer Schwerpunktkonstruktor
    /// Deklariert Felder mit einem Element.
    /// </summary>
    public Schwerpunkt() //mindestens ein Feldelement
    {
        this.n = 1;
        A = new double[n];
        X = new double[n];
        Y = new double[n];
    }
    /// <summary>
    /// Standard-Schwerpunktkonstruktor
    /// Deklariert Felder mit jeweils n Elementen
    /// </summary>
    /// <param name="n"></param> Anzahl der Elemente
    public Schwerpunkt(int n) //n Feldelemente
    {
        this.n = n;
        A = new double[n];
        X = new double[n];
        Y = new double[n];
    }
    #endregion Konstruktoren
        
    #region Methoden Fläche x-Schwerpunkt, y-Schwerpunkt mit jeweils einer Überladung
    /// <summary>
    /// Berechnet die Gesamtfläche
    /// Methode verwendet die Instanzvariablen (Attribute)
    /// </summary>
    /// <returns></returns>
    public double gesamtFlaeche()
    {
        Ages=0;
        foreach (var element in A)
        {
            Ages +=element;
        }
        return Ages;
    }
    /// <summary>
    /// Berechnet die Gesamtfläche
    /// Methode verwendet Parameter
    /// </summary>
    /// <param name="A"></param> Einzelflächen
    /// <returns></returns>
    public double gesamtFlaeche(double[] A)
    {
        Ages=0;
        foreach (var element in A)
        {
            Ages +=element;
        }
        return Ages;
    }
    /// <summary>
    /// Berechnet den Gesamtschwerpunkt in X-Richtung
    /// Methode verwendet die Instanzvariablen (Attribute)
    /// </summary>
    /// <returns></returns>
    public double gesamtX()
    {
        Xges=0;
        for (int i=0; i<n; i++)
        {
            Xges +=A[i] * X[i];
        }
        return Xges/Ages;
    }
    /// <summary>
    /// Berechnet den Gesamtschwerpunkt in X-Richtung
    /// Methode verwendet Parameter
    /// </summary>
    /// <param name="A"></param>
    /// <param name="X"></param>
    /// <returns></returns>
    public double gesamtX(double[] A, double[] X)
    {
        Xges = 0;
        for (int i = 0; i < n; i++)
        {
            Xges += A[i] * X[i];
        }
        double Ages = gesamtFlaeche(A);
        return Xges/Ages;
    }
    /// <summary>
    /// Berechnet den Gesamtschwerpunkt in Y-Richtung
    /// Methode verwendet die Instanzvariablen (Attribute)
    /// </summary>
    /// <returns></returns>
    public double gesamtY()
    {
        Yges=0;
        for (int i=0; i<n; i++)
        {
            Yges +=A[i] * Y[i];
        }
        return Yges/Ages;
    }
    /// <summary>
    /// Berechnet den Gesamtschwerpunkt in Y-Richtung
    /// Methode verwendet Parameter
    /// </summary>
    /// <param name="A"></param>
    /// <param name="Y"></param>
    /// <returns></returns>
    public double gesamtY(double[] A, double[] Y)
    {
        Yges = 0;
        for (int i = 0; i < n; i++)
        {
            Yges += A[i] * Y[i];
        }
        double Ages=gesamtFlaeche(A);
        return Yges/Ages;
    }
    #endregion Methoden
        
    #region Eigenschaftsmethoden
    /// <summary>
    /// Setzt den Flächenindex
    /// </summary>
    public int seti
    {
        set { this.i = value; }
    }
    /// <summary>
    /// Teilfläche
    /// </summary>
    public double setA
    {
        set {this.A[i] = value;}
    }
    /// <summary>
    /// X-Schwerpunktkoordinate einer Teilfläche
    /// </summary>
    public double setXs
    {
        set {this.X[i] = value;}
    }
    /// <summary>
    /// Y-Schwerpunktkoordinate einer Teilfläche
    /// </summary>
    public double setYs
    {
        set {this.Y[i] = value;}
    }
    #endregion Eigenschaftsmethoden
}
}
