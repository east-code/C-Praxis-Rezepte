namespace Hauptzeit
{
    partial class Form_Hauptzeit
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
      this.textBox_L = new System.Windows.Forms.TextBox();
      this.textBox_vf = new System.Windows.Forms.TextBox();
      this.textBox_i = new System.Windows.Forms.TextBox();
      this.textBox_thDrehen = new System.Windows.Forms.TextBox();
      this.label_Laenge = new System.Windows.Forms.Label();
      this.label_Schnittanzahl = new System.Windows.Forms.Label();
      this.label_Vorschubgeschwindigkeit = new System.Windows.Forms.Label();
      this.label_HauptzeitDrehen = new System.Windows.Forms.Label();
      this.button_OK = new System.Windows.Forms.Button();
      this.textBox_thOverride = new System.Windows.Forms.TextBox();
      this.label_HauptzeitOverride = new System.Windows.Forms.Label();
      this.label_HauptzeitBasis = new System.Windows.Forms.Label();
      this.textBox_thBasis = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox_L
      // 
      this.textBox_L.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_L.Location = new System.Drawing.Point(410, 3);
      this.textBox_L.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_L.Name = "textBox_L";
      this.textBox_L.Size = new System.Drawing.Size(170, 31);
      this.textBox_L.TabIndex = 0;
      this.textBox_L.Text = "100";
      // 
      // textBox_vf
      // 
      this.textBox_vf.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_vf.Location = new System.Drawing.Point(412, 83);
      this.textBox_vf.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_vf.Name = "textBox_vf";
      this.textBox_vf.Size = new System.Drawing.Size(170, 31);
      this.textBox_vf.TabIndex = 1;
      this.textBox_vf.Text = "600";
      // 
      // textBox_i
      // 
      this.textBox_i.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_i.Location = new System.Drawing.Point(412, 40);
      this.textBox_i.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_i.Name = "textBox_i";
      this.textBox_i.Size = new System.Drawing.Size(170, 31);
      this.textBox_i.TabIndex = 2;
      this.textBox_i.Text = "1";
      // 
      // textBox_thDrehen
      // 
      this.textBox_thDrehen.BackColor = System.Drawing.Color.Silver;
      this.textBox_thDrehen.Location = new System.Drawing.Point(412, 233);
      this.textBox_thDrehen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_thDrehen.Name = "textBox_thDrehen";
      this.textBox_thDrehen.Size = new System.Drawing.Size(168, 31);
      this.textBox_thDrehen.TabIndex = 3;
      // 
      // label_Laenge
      // 
      this.label_Laenge.AutoSize = true;
      this.label_Laenge.Location = new System.Drawing.Point(247, 9);
      this.label_Laenge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_Laenge.Name = "label_Laenge";
      this.label_Laenge.Size = new System.Drawing.Size(153, 25);
      this.label_Laenge.TabIndex = 4;
      this.label_Laenge.Text = "Länge L in mm";
      // 
      // label_Schnittanzahl
      // 
      this.label_Schnittanzahl.AutoSize = true;
      this.label_Schnittanzahl.Location = new System.Drawing.Point(190, 43);
      this.label_Schnittanzahl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_Schnittanzahl.Name = "label_Schnittanzahl";
      this.label_Schnittanzahl.Size = new System.Drawing.Size(210, 25);
      this.label_Schnittanzahl.TabIndex = 5;
      this.label_Schnittanzahl.Text = "Anzahl der Schnitte i";
      // 
      // label_Vorschubgeschwindigkeit
      // 
      this.label_Vorschubgeschwindigkeit.AutoSize = true;
      this.label_Vorschubgeschwindigkeit.Location = new System.Drawing.Point(15, 86);
      this.label_Vorschubgeschwindigkeit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_Vorschubgeschwindigkeit.Name = "label_Vorschubgeschwindigkeit";
      this.label_Vorschubgeschwindigkeit.Size = new System.Drawing.Size(385, 25);
      this.label_Vorschubgeschwindigkeit.TabIndex = 6;
      this.label_Vorschubgeschwindigkeit.Text = "Vorschubgeschwindigkeit Vf in mm/min";
      // 
      // label_HauptzeitDrehen
      // 
      this.label_HauptzeitDrehen.AutoSize = true;
      this.label_HauptzeitDrehen.Location = new System.Drawing.Point(19, 236);
      this.label_HauptzeitDrehen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_HauptzeitDrehen.Name = "label_HauptzeitDrehen";
      this.label_HauptzeitDrehen.Size = new System.Drawing.Size(381, 25);
      this.label_HauptzeitDrehen.TabIndex = 7;
      this.label_HauptzeitDrehen.Text = "Hauptzeit für das Drehen th in Minuten";
      // 
      // button_OK
      // 
      this.button_OK.Location = new System.Drawing.Point(31, 130);
      this.button_OK.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(551, 49);
      this.button_OK.TabIndex = 8;
      this.button_OK.Text = "Hauptzeitberechnung OK";
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
      // 
      // textBox_thOverride
      // 
      this.textBox_thOverride.BackColor = System.Drawing.Color.Silver;
      this.textBox_thOverride.Location = new System.Drawing.Point(412, 270);
      this.textBox_thOverride.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_thOverride.Name = "textBox_thOverride";
      this.textBox_thOverride.Size = new System.Drawing.Size(168, 31);
      this.textBox_thOverride.TabIndex = 9;
      // 
      // label_HauptzeitOverride
      // 
      this.label_HauptzeitOverride.AutoSize = true;
      this.label_HauptzeitOverride.Location = new System.Drawing.Point(79, 276);
      this.label_HauptzeitOverride.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_HauptzeitOverride.Name = "label_HauptzeitOverride";
      this.label_HauptzeitOverride.Size = new System.Drawing.Size(321, 25);
      this.label_HauptzeitOverride.TabIndex = 10;
      this.label_HauptzeitOverride.Text = "Hauptzeit Override th in Minuten";
      // 
      // label_HauptzeitBasis
      // 
      this.label_HauptzeitBasis.AutoSize = true;
      this.label_HauptzeitBasis.Location = new System.Drawing.Point(9, 201);
      this.label_HauptzeitBasis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_HauptzeitBasis.Name = "label_HauptzeitBasis";
      this.label_HauptzeitBasis.Size = new System.Drawing.Size(391, 25);
      this.label_HauptzeitBasis.TabIndex = 14;
      this.label_HauptzeitBasis.Text = "Hauptzeit der Basisklasse th in Minuten";
      // 
      // textBox_thBasis
      // 
      this.textBox_thBasis.BackColor = System.Drawing.Color.Silver;
      this.textBox_thBasis.Location = new System.Drawing.Point(412, 195);
      this.textBox_thBasis.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.textBox_thBasis.Name = "textBox_thBasis";
      this.textBox_thBasis.Size = new System.Drawing.Size(168, 31);
      this.textBox_thBasis.TabIndex = 13;
      // 
      // Form_Hauptzeit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(602, 352);
      this.Controls.Add(this.label_HauptzeitBasis);
      this.Controls.Add(this.textBox_thBasis);
      this.Controls.Add(this.label_HauptzeitOverride);
      this.Controls.Add(this.textBox_thOverride);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.label_HauptzeitDrehen);
      this.Controls.Add(this.label_Vorschubgeschwindigkeit);
      this.Controls.Add(this.label_Schnittanzahl);
      this.Controls.Add(this.label_Laenge);
      this.Controls.Add(this.textBox_thDrehen);
      this.Controls.Add(this.textBox_i);
      this.Controls.Add(this.textBox_vf);
      this.Controls.Add(this.textBox_L);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.Name = "Form_Hauptzeit";
      this.Text = "Hauptzeitberechnung";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.TextBox textBox_vf;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.TextBox textBox_thDrehen;
        private System.Windows.Forms.Label label_Laenge;
        private System.Windows.Forms.Label label_Schnittanzahl;
        private System.Windows.Forms.Label label_Vorschubgeschwindigkeit;
        private System.Windows.Forms.Label label_HauptzeitDrehen;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_thOverride;
        private System.Windows.Forms.Label label_HauptzeitOverride;
        private System.Windows.Forms.Label label_HauptzeitBasis;
        private System.Windows.Forms.TextBox textBox_thBasis;
    }
}

