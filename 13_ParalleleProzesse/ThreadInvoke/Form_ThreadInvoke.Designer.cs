namespace ThreadInvoke
{
  partial class Form_ThreadInvoke
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.button_Start = new System.Windows.Forms.Button();
      this.textBox_Feld = new System.Windows.Forms.TextBox();
      this.textBox_Merkmale = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button_Start
      // 
      this.button_Start.Location = new System.Drawing.Point(67, 116);
      this.button_Start.Margin = new System.Windows.Forms.Padding(5);
      this.button_Start.Name = "button_Start";
      this.button_Start.Size = new System.Drawing.Size(296, 82);
      this.button_Start.TabIndex = 1;
      this.button_Start.Text = "Start der Threads";
      this.button_Start.UseVisualStyleBackColor = true;
      this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
      // 
      // textBox_Feld
      // 
      this.textBox_Feld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Feld.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox_Feld.Location = new System.Drawing.Point(0, 0);
      this.textBox_Feld.Multiline = true;
      this.textBox_Feld.Name = "textBox_Feld";
      this.textBox_Feld.Size = new System.Drawing.Size(471, 88);
      this.textBox_Feld.TabIndex = 2;
      // 
      // textBox_Merkmale
      // 
      this.textBox_Merkmale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.textBox_Merkmale.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox_Merkmale.Location = new System.Drawing.Point(0, 229);
      this.textBox_Merkmale.Multiline = true;
      this.textBox_Merkmale.Name = "textBox_Merkmale";
      this.textBox_Merkmale.Size = new System.Drawing.Size(471, 137);
      this.textBox_Merkmale.TabIndex = 3;
      // 
      // Form_ThreadKlasse
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(471, 366);
      this.Controls.Add(this.textBox_Merkmale);
      this.Controls.Add(this.textBox_Feld);
      this.Controls.Add(this.button_Start);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form_ThreadKlasse";
      this.Text = "Threads";
      this.Load += new System.EventHandler(this.Form_ThreadKlasse_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button_Start;
    private System.Windows.Forms.TextBox textBox_Feld;
    private System.Windows.Forms.TextBox textBox_Merkmale;
  }
}

