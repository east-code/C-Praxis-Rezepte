namespace Generic_Normalization
{
  partial class FormGeneric_Normalisierung
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      this.textBox_Array = new System.Windows.Forms.TextBox();
      this.textBox_normalizedArray = new System.Windows.Forms.TextBox();
      this.label_Eingabe = new System.Windows.Forms.Label();
      this.label_normalisierteAusgabe = new System.Windows.Forms.Label();
      this.button_0_1_normalization = new System.Windows.Forms.Button();
      this.button_0_255_normalization = new System.Windows.Forms.Button();
      this.label_normalization = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox_Array
      // 
      this.textBox_Array.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_Array.Location = new System.Drawing.Point(13, 35);
      this.textBox_Array.Margin = new System.Windows.Forms.Padding(4);
      this.textBox_Array.Multiline = true;
      this.textBox_Array.Name = "textBox_Array";
      this.textBox_Array.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox_Array.Size = new System.Drawing.Size(112, 203);
      this.textBox_Array.TabIndex = 0;
      this.textBox_Array.Text = "4\r\n-3\r\n6,6\r\n133\r\n199\r\n-55\r\n60";
      // 
      // textBox_normalizedArray
      // 
      this.textBox_normalizedArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.textBox_normalizedArray.Location = new System.Drawing.Point(278, 35);
      this.textBox_normalizedArray.Margin = new System.Windows.Forms.Padding(4);
      this.textBox_normalizedArray.Multiline = true;
      this.textBox_normalizedArray.Name = "textBox_normalizedArray";
      this.textBox_normalizedArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox_normalizedArray.Size = new System.Drawing.Size(116, 203);
      this.textBox_normalizedArray.TabIndex = 0;
      // 
      // label_Eingabe
      // 
      this.label_Eingabe.AutoSize = true;
      this.label_Eingabe.Location = new System.Drawing.Point(13, 9);
      this.label_Eingabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label_Eingabe.Name = "label_Eingabe";
      this.label_Eingabe.Size = new System.Drawing.Size(61, 18);
      this.label_Eingabe.TabIndex = 1;
      this.label_Eingabe.Text = "Eingabe";
      // 
      // label_normalisierteAusgabe
      // 
      this.label_normalisierteAusgabe.AutoSize = true;
      this.label_normalisierteAusgabe.Location = new System.Drawing.Point(296, 9);
      this.label_normalisierteAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label_normalisierteAusgabe.Name = "label_normalisierteAusgabe";
      this.label_normalisierteAusgabe.Size = new System.Drawing.Size(65, 18);
      this.label_normalisierteAusgabe.TabIndex = 1;
      this.label_normalisierteAusgabe.Text = "Ausgabe";
      this.label_normalisierteAusgabe.Click += new System.EventHandler(this.label_normalisierteAusgabe_Click);
      // 
      // button_0_1_normalization
      // 
      this.button_0_1_normalization.Location = new System.Drawing.Point(132, 35);
      this.button_0_1_normalization.Name = "button_0_1_normalization";
      this.button_0_1_normalization.Size = new System.Drawing.Size(138, 73);
      this.button_0_1_normalization.TabIndex = 3;
      this.button_0_1_normalization.Text = "Intervall: 0 bis 1";
      this.button_0_1_normalization.UseVisualStyleBackColor = true;
      this.button_0_1_normalization.Click += new System.EventHandler(this.button_0_1_normalization_Click);
      // 
      // button_0_255_normalization
      // 
      this.button_0_255_normalization.Location = new System.Drawing.Point(132, 114);
      this.button_0_255_normalization.Name = "button_0_255_normalization";
      this.button_0_255_normalization.Size = new System.Drawing.Size(138, 85);
      this.button_0_255_normalization.TabIndex = 3;
      this.button_0_255_normalization.Text = "Intervall: 0 bis 255";
      this.button_0_255_normalization.UseVisualStyleBackColor = true;
      this.button_0_255_normalization.Click += new System.EventHandler(this.button_0_255_normalization_Click);
      // 
      // label_normalization
      // 
      this.label_normalization.AutoSize = true;
      this.label_normalization.Location = new System.Drawing.Point(129, 9);
      this.label_normalization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label_normalization.Name = "label_normalization";
      this.label_normalization.Size = new System.Drawing.Size(154, 18);
      this.label_normalization.TabIndex = 1;
      this.label_normalization.Text = "--> Normalisierung -->";
      // 
      // FormGeneric_Normalisierung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(404, 250);
      this.Controls.Add(this.button_0_255_normalization);
      this.Controls.Add(this.button_0_1_normalization);
      this.Controls.Add(this.label_normalization);
      this.Controls.Add(this.label_normalisierteAusgabe);
      this.Controls.Add(this.label_Eingabe);
      this.Controls.Add(this.textBox_normalizedArray);
      this.Controls.Add(this.textBox_Array);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "FormGeneric_Normalisierung";
      this.Text = "Normalisierung der Elemente eines Feldes";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_Array;
    private System.Windows.Forms.TextBox textBox_normalizedArray;
    private System.Windows.Forms.Label label_Eingabe;
    private System.Windows.Forms.Label label_normalisierteAusgabe;
    private System.Windows.Forms.Button button_0_1_normalization;
    private System.Windows.Forms.Button button_0_255_normalization;
    private System.Windows.Forms.Label label_normalization;
  }
}

