namespace collection
{
    partial class FormCollection
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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.mittelwertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.standardabweichungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.spannweiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.maximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.minimumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox_X = new System.Windows.Forms.TextBox();
      this.textBox_Y = new System.Windows.Forms.TextBox();
      this.label_ergebnis = new System.Windows.Forms.Label();
      this.label_X = new System.Windows.Forms.Label();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mittelwertToolStripMenuItem,
            this.standardabweichungToolStripMenuItem,
            this.spannweiteToolStripMenuItem,
            this.maximumToolStripMenuItem,
            this.minimumToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(1282, 53);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // mittelwertToolStripMenuItem
      // 
      this.mittelwertToolStripMenuItem.Name = "mittelwertToolStripMenuItem";
      this.mittelwertToolStripMenuItem.Size = new System.Drawing.Size(178, 49);
      this.mittelwertToolStripMenuItem.Text = "Mittelwert";
      this.mittelwertToolStripMenuItem.Click += new System.EventHandler(this.mittelwertToolStripMenuItem_Click);
      // 
      // standardabweichungToolStripMenuItem
      // 
      this.standardabweichungToolStripMenuItem.Name = "standardabweichungToolStripMenuItem";
      this.standardabweichungToolStripMenuItem.Size = new System.Drawing.Size(329, 49);
      this.standardabweichungToolStripMenuItem.Text = "Standardabweichung";
      // 
      // spannweiteToolStripMenuItem
      // 
      this.spannweiteToolStripMenuItem.Name = "spannweiteToolStripMenuItem";
      this.spannweiteToolStripMenuItem.Size = new System.Drawing.Size(196, 49);
      this.spannweiteToolStripMenuItem.Text = "Spannweite";
      // 
      // maximumToolStripMenuItem
      // 
      this.maximumToolStripMenuItem.Name = "maximumToolStripMenuItem";
      this.maximumToolStripMenuItem.Size = new System.Drawing.Size(174, 49);
      this.maximumToolStripMenuItem.Text = "Maximum";
      // 
      // minimumToolStripMenuItem
      // 
      this.minimumToolStripMenuItem.Name = "minimumToolStripMenuItem";
      this.minimumToolStripMenuItem.Size = new System.Drawing.Size(169, 49);
      this.minimumToolStripMenuItem.Text = "Minimum";
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(156, 49);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // textBox_X
      // 
      this.textBox_X.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_X.Location = new System.Drawing.Point(186, 53);
      this.textBox_X.Margin = new System.Windows.Forms.Padding(6);
      this.textBox_X.Multiline = true;
      this.textBox_X.Name = "textBox_X";
      this.textBox_X.Size = new System.Drawing.Size(221, 317);
      this.textBox_X.TabIndex = 1;
      // 
      // textBox_Y
      // 
      this.textBox_Y.BackColor = System.Drawing.Color.Silver;
      this.textBox_Y.Location = new System.Drawing.Point(559, 182);
      this.textBox_Y.Margin = new System.Windows.Forms.Padding(6);
      this.textBox_Y.Name = "textBox_Y";
      this.textBox_Y.Size = new System.Drawing.Size(278, 43);
      this.textBox_Y.TabIndex = 2;
      // 
      // label_ergebnis
      // 
      this.label_ergebnis.AutoSize = true;
      this.label_ergebnis.Location = new System.Drawing.Point(562, 139);
      this.label_ergebnis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_ergebnis.Name = "label_ergebnis";
      this.label_ergebnis.Size = new System.Drawing.Size(143, 37);
      this.label_ergebnis.TabIndex = 3;
      this.label_ergebnis.Text = "Ergebnis";
      // 
      // label_X
      // 
      this.label_X.AutoSize = true;
      this.label_X.Location = new System.Drawing.Point(26, 56);
      this.label_X.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_X.Name = "label_X";
      this.label_X.Size = new System.Drawing.Size(132, 37);
      this.label_X.TabIndex = 4;
      this.label_X.Text = "Werte X";
      // 
      // FormCollection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1282, 382);
      this.Controls.Add(this.label_X);
      this.Controls.Add(this.label_ergebnis);
      this.Controls.Add(this.textBox_Y);
      this.Controls.Add(this.textBox_X);
      this.Controls.Add(this.menuStrip);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FormCollection";
      this.Text = "Anwendung: Methodensammlung";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mittelwertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardabweichungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spannweiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label_ergebnis;
        private System.Windows.Forms.Label label_X;

    }
}

