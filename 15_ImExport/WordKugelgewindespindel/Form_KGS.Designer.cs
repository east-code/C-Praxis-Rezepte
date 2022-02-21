namespace Kugelgewindespindel
{
    partial class Form_KGS
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
            this.drehzahlenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Titel = new System.Windows.Forms.Label();
            this.listBox_k = new System.Windows.Forms.ListBox();
            this.textBox_nzul = new System.Windows.Forms.TextBox();
            this.textBox_nk = new System.Windows.Forms.TextBox();
            this.textBox_lk = new System.Windows.Forms.TextBox();
            this.textBox_dk = new System.Windows.Forms.TextBox();
            this.label_nzul = new System.Windows.Forms.Label();
            this.label_nk = new System.Windows.Forms.Label();
            this.label_k = new System.Windows.Forms.Label();
            this.label_lk = new System.Windows.Forms.Label();
            this.label_dk = new System.Windows.Forms.Label();
            this.saveFileDialog_Word = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox_support = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_support)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drehzahlenToolStripMenuItem,
            this.wordExportToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(455, 42);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // drehzahlenToolStripMenuItem
            // 
            this.drehzahlenToolStripMenuItem.Name = "drehzahlenToolStripMenuItem";
            this.drehzahlenToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.drehzahlenToolStripMenuItem.Text = "Drehzahlen";
            this.drehzahlenToolStripMenuItem.Click += new System.EventHandler(this.drehzahlenToolStripMenuItem_Click);
            // 
            // wordExportToolStripMenuItem
            // 
            this.wordExportToolStripMenuItem.Name = "wordExportToolStripMenuItem";
            this.wordExportToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.wordExportToolStripMenuItem.Text = "Word-Export";
            this.wordExportToolStripMenuItem.Click += new System.EventHandler(this.wordExportToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // label_Titel
            // 
            this.label_Titel.AutoSize = true;
            this.label_Titel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titel.ForeColor = System.Drawing.Color.Navy;
            this.label_Titel.Location = new System.Drawing.Point(15, 338);
            this.label_Titel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Titel.Name = "label_Titel";
            this.label_Titel.Size = new System.Drawing.Size(409, 19);
            this.label_Titel.TabIndex = 28;
            this.label_Titel.Text = "Support einer Fräsmaschine mit Kugelumlaufspindel";
            // 
            // listBox_k
            // 
            this.listBox_k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_k.ItemHeight = 25;
            this.listBox_k.Items.AddRange(new object[] {
            "0,42 (Einseitige Lagerung)",
            "1,22 (Lose-Lose-Lagerung)",
            "1,88 (Fest-Lose-Lagerung)",
            "2,74 (Fest-Fest-Lagerung)"});
            this.listBox_k.Location = new System.Drawing.Point(14, 473);
            this.listBox_k.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_k.Name = "listBox_k";
            this.listBox_k.Size = new System.Drawing.Size(424, 104);
            this.listBox_k.TabIndex = 27;
            // 
            // textBox_nzul
            // 
            this.textBox_nzul.BackColor = System.Drawing.Color.Silver;
            this.textBox_nzul.Location = new System.Drawing.Point(339, 635);
            this.textBox_nzul.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_nzul.Name = "textBox_nzul";
            this.textBox_nzul.Size = new System.Drawing.Size(99, 31);
            this.textBox_nzul.TabIndex = 26;
            // 
            // textBox_nk
            // 
            this.textBox_nk.BackColor = System.Drawing.Color.Silver;
            this.textBox_nk.Location = new System.Drawing.Point(339, 589);
            this.textBox_nk.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_nk.Name = "textBox_nk";
            this.textBox_nk.Size = new System.Drawing.Size(99, 31);
            this.textBox_nk.TabIndex = 25;
            // 
            // textBox_lk
            // 
            this.textBox_lk.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_lk.Location = new System.Drawing.Point(339, 403);
            this.textBox_lk.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_lk.Name = "textBox_lk";
            this.textBox_lk.Size = new System.Drawing.Size(99, 31);
            this.textBox_lk.TabIndex = 24;
            this.textBox_lk.Text = "1000";
            // 
            // textBox_dk
            // 
            this.textBox_dk.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_dk.Location = new System.Drawing.Point(339, 363);
            this.textBox_dk.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_dk.Name = "textBox_dk";
            this.textBox_dk.Size = new System.Drawing.Size(99, 31);
            this.textBox_dk.TabIndex = 23;
            this.textBox_dk.Text = "10";
            // 
            // label_nzul
            // 
            this.label_nzul.AutoSize = true;
            this.label_nzul.Location = new System.Drawing.Point(15, 635);
            this.label_nzul.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nzul.Name = "label_nzul";
            this.label_nzul.Size = new System.Drawing.Size(322, 25);
            this.label_nzul.TabIndex = 22;
            this.label_nzul.Text = "zulässige Drehzahl nzul in 1/min";
            // 
            // label_nk
            // 
            this.label_nk.AutoSize = true;
            this.label_nk.Location = new System.Drawing.Point(15, 595);
            this.label_nk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nk.Name = "label_nk";
            this.label_nk.Size = new System.Drawing.Size(294, 25);
            this.label_nk.TabIndex = 21;
            this.label_nk.Text = "kritische Drehzahl nk in 1/min";
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_k.Location = new System.Drawing.Point(15, 440);
            this.label_k.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(281, 27);
            this.label_k.TabIndex = 20;
            this.label_k.Text = "Einbauart der Lagerung k";
            // 
            // label_lk
            // 
            this.label_lk.AutoSize = true;
            this.label_lk.Location = new System.Drawing.Point(15, 409);
            this.label_lk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_lk.Name = "label_lk";
            this.label_lk.Size = new System.Drawing.Size(308, 25);
            this.label_lk.TabIndex = 19;
            this.label_lk.Text = "kritische Spindellänge lk in mm";
            // 
            // label_dk
            // 
            this.label_dk.AutoSize = true;
            this.label_dk.Location = new System.Drawing.Point(15, 363);
            this.label_dk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_dk.Name = "label_dk";
            this.label_dk.Size = new System.Drawing.Size(273, 25);
            this.label_dk.TabIndex = 18;
            this.label_dk.Text = "Kerndurchmesser dk in mm";
            // 
            // saveFileDialog_Word
            // 
            this.saveFileDialog_Word.DefaultExt = "docx";
            this.saveFileDialog_Word.FileName = "Kugelgewindespindel";
            this.saveFileDialog_Word.Filter = "Dokument (*.docx)|*.docx|Document (*.doc)|*.doc|alle Dokumente (*.*)|*.*";
            // 
            // pictureBox_support
            // 
            this.pictureBox_support.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_support.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_support.Image = global::Kugelgewindespindel.Properties.Resources.Bild_Kugelumlaufspindel267dpi;
            this.pictureBox_support.Location = new System.Drawing.Point(0, 42);
            this.pictureBox_support.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox_support.Name = "pictureBox_support";
            this.pictureBox_support.Size = new System.Drawing.Size(455, 284);
            this.pictureBox_support.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_support.TabIndex = 17;
            this.pictureBox_support.TabStop = false;
            // 
            // Form_KGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 680);
            this.Controls.Add(this.label_Titel);
            this.Controls.Add(this.listBox_k);
            this.Controls.Add(this.textBox_nzul);
            this.Controls.Add(this.textBox_nk);
            this.Controls.Add(this.textBox_lk);
            this.Controls.Add(this.textBox_dk);
            this.Controls.Add(this.label_nzul);
            this.Controls.Add(this.label_nk);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.label_lk);
            this.Controls.Add(this.label_dk);
            this.Controls.Add(this.pictureBox_support);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_KGS";
            this.Text = "Kugelgewindespindel";
            this.Load += new System.EventHandler(this.Form_KGS_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_support)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_support;
        private System.Windows.Forms.Label label_Titel;
        private System.Windows.Forms.ListBox listBox_k;
        private System.Windows.Forms.TextBox textBox_nzul;
        private System.Windows.Forms.TextBox textBox_nk;
        private System.Windows.Forms.TextBox textBox_lk;
        private System.Windows.Forms.TextBox textBox_dk;
        private System.Windows.Forms.Label label_nzul;
        private System.Windows.Forms.Label label_nk;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_lk;
        private System.Windows.Forms.Label label_dk;
        private System.Windows.Forms.ToolStripMenuItem drehzahlenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordExportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Word;
    }
}

