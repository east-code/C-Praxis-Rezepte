namespace SpanenBohren
{
    partial class FormBohren
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
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_kc11 = new System.Windows.Forms.TextBox();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_Fc = new System.Windows.Forms.TextBox();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label_Fc = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.label_kc11 = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            this.label_D = new System.Windows.Forms.Label();
            this.label_titelBohren = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schnittkraftFcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_m
            // 
            this.textBox_m.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_m.Location = new System.Drawing.Point(407, 211);
            this.textBox_m.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(180, 31);
            this.textBox_m.TabIndex = 23;
            this.textBox_m.Text = "0,26";
            // 
            // textBox_kc11
            // 
            this.textBox_kc11.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_kc11.Location = new System.Drawing.Point(407, 164);
            this.textBox_kc11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_kc11.Name = "textBox_kc11";
            this.textBox_kc11.Size = new System.Drawing.Size(180, 31);
            this.textBox_kc11.TabIndex = 22;
            this.textBox_kc11.Text = "1990";
            // 
            // textBox_f
            // 
            this.textBox_f.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_f.Location = new System.Drawing.Point(407, 121);
            this.textBox_f.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(180, 31);
            this.textBox_f.TabIndex = 21;
            this.textBox_f.Text = "0,2";
            // 
            // textBox_Fc
            // 
            this.textBox_Fc.BackColor = System.Drawing.Color.Silver;
            this.textBox_Fc.Location = new System.Drawing.Point(407, 271);
            this.textBox_Fc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Fc.Name = "textBox_Fc";
            this.textBox_Fc.Size = new System.Drawing.Size(180, 31);
            this.textBox_Fc.TabIndex = 20;
            // 
            // textBox_D
            // 
            this.textBox_D.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_D.Location = new System.Drawing.Point(407, 81);
            this.textBox_D.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(180, 31);
            this.textBox_D.TabIndex = 19;
            this.textBox_D.Text = "10";
            // 
            // label_Fc
            // 
            this.label_Fc.AutoSize = true;
            this.label_Fc.Location = new System.Drawing.Point(196, 277);
            this.label_Fc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Fc.Name = "label_Fc";
            this.label_Fc.Size = new System.Drawing.Size(194, 25);
            this.label_Fc.TabIndex = 18;
            this.label_Fc.Text = "Schnittkraft Fc in N";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(86, 214);
            this.label_m.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(309, 25);
            this.label_m.TabIndex = 17;
            this.label_m.Text = "Anstiegswert der Schnittkraft m";
            // 
            // label_kc11
            // 
            this.label_kc11.AutoSize = true;
            this.label_kc11.Location = new System.Drawing.Point(6, 164);
            this.label_kc11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_kc11.Name = "label_kc11";
            this.label_kc11.Size = new System.Drawing.Size(389, 25);
            this.label_kc11.TabIndex = 16;
            this.label_kc11.Text = "Spezifische Schnittkraft Kc1.1 in N/mm²";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(196, 124);
            this.label_f.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(199, 25);
            this.label_f.TabIndex = 15;
            this.label_f.Text = "Vorschub f in mm/U";
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(172, 81);
            this.label_D.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(223, 25);
            this.label_D.TabIndex = 14;
            this.label_D.Text = "Durchmesser D in mm";
            // 
            // label_titelBohren
            // 
            this.label_titelBohren.AutoSize = true;
            this.label_titelBohren.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titelBohren.Location = new System.Drawing.Point(295, 42);
            this.label_titelBohren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_titelBohren.Name = "label_titelBohren";
            this.label_titelBohren.Size = new System.Drawing.Size(271, 25);
            this.label_titelBohren.TabIndex = 13;
            this.label_titelBohren.Text = "Schnittkraft beim Bohren";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schnittkraftFcToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(618, 42);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schnittkraftFcToolStripMenuItem
            // 
            this.schnittkraftFcToolStripMenuItem.Name = "schnittkraftFcToolStripMenuItem";
            this.schnittkraftFcToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.schnittkraftFcToolStripMenuItem.Text = "Schnittkraft Fc";
            this.schnittkraftFcToolStripMenuItem.Click += new System.EventHandler(this.schnittkraftFcToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // FormBohren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 320);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.textBox_kc11);
            this.Controls.Add(this.textBox_f);
            this.Controls.Add(this.textBox_Fc);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.label_Fc);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label_kc11);
            this.Controls.Add(this.label_f);
            this.Controls.Add(this.label_D);
            this.Controls.Add(this.label_titelBohren);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormBohren";
            this.Text = "Schnittkraftberechnung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_kc11;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.TextBox textBox_Fc;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label_Fc;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.Label label_kc11;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.Label label_titelBohren;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schnittkraftFcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

