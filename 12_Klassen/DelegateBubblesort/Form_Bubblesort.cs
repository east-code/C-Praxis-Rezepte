using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
public partial class Form_Bubblesort : Form
{
    public Form_Bubblesort()
    {
        InitializeComponent();
    }
    #region Variablen
    const int n = 20;
    int[] X = new int[n];
    #endregion Variablen
    /// <summary>
    /// Generiert 20 Zufallszahlen zwische 0 und 100
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_zufallszahlen_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        listBox_unsort.Items.Clear();
        for (int i = 0; i < n; i++)
        {
            X[i] = rnd.Next(0, 100);
            listBox_unsort.Items.Add(X[i].ToString());
        }
    }
    /// <summary>
    /// Schreibt die aufsteigend sortierten Zahlen in eine List-Box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_aufwaertsSortieren_Click(object sender, EventArgs e)
    {
        Sortieren sort = new Sortieren();
        listBox_sort.Items.Clear();
        foreach (var x in sort.bubbleSortWithDelegate(sort.Aufsteigend, X))
        {
            listBox_sort.Items.Add(x);
        }
    }
    /// <summary>
    /// Schreibt die abwärts sortierten Zahlen in eine List-Box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_abwaertsSortieren_Click(object sender, EventArgs e)
    {
        Sortieren sort = new Sortieren();
        listBox_upSort.Items.Clear();
        foreach (var x in sort.bubbleSortWithDelegate(sort.Absteigend, X))
        {
            listBox_upSort.Items.Add(x);
        }
    }
}
}
