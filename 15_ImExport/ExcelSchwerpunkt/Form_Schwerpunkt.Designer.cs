namespace Excel_Schwerpunkt
{
    partial class Form_Schwerpunkt
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
            this.textBox_gesamtYs = new System.Windows.Forms.TextBox();
            this.textBox_gesamtXs = new System.Windows.Forms.TextBox();
            this.textBox_gesamtA = new System.Windows.Forms.TextBox();
            this.label_Yges = new System.Windows.Forms.Label();
            this.label_Xges = new System.Windows.Forms.Label();
            this.label_Schwerpunkt = new System.Windows.Forms.Label();
            this.label_Ages = new System.Windows.Forms.Label();
            this.label_Flächenschwerpunkte = new System.Windows.Forms.Label();
            this.dataGridView_Schwerpkt = new System.Windows.Forms.DataGridView();
            this.Column_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Xs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gesamtschwerpunktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_Excel = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_Excel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schwerpkt)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_gesamtYs
            // 
            this.textBox_gesamtYs.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtYs.Location = new System.Drawing.Point(441, 354);
            this.textBox_gesamtYs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_gesamtYs.Name = "textBox_gesamtYs";
            this.textBox_gesamtYs.Size = new System.Drawing.Size(180, 31);
            this.textBox_gesamtYs.TabIndex = 19;
            // 
            // textBox_gesamtXs
            // 
            this.textBox_gesamtXs.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtXs.Location = new System.Drawing.Point(443, 282);
            this.textBox_gesamtXs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_gesamtXs.Name = "textBox_gesamtXs";
            this.textBox_gesamtXs.Size = new System.Drawing.Size(180, 31);
            this.textBox_gesamtXs.TabIndex = 18;
            // 
            // textBox_gesamtA
            // 
            this.textBox_gesamtA.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtA.Location = new System.Drawing.Point(441, 121);
            this.textBox_gesamtA.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_gesamtA.Name = "textBox_gesamtA";
            this.textBox_gesamtA.Size = new System.Drawing.Size(182, 31);
            this.textBox_gesamtA.TabIndex = 17;
            // 
            // label_Yges
            // 
            this.label_Yges.AutoSize = true;
            this.label_Yges.Location = new System.Drawing.Point(446, 321);
            this.label_Yges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Yges.Name = "label_Yges";
            this.label_Yges.Size = new System.Drawing.Size(138, 25);
            this.label_Yges.TabIndex = 16;
            this.label_Yges.Text = "Y-Koordinate";
            // 
            // label_Xges
            // 
            this.label_Xges.AutoSize = true;
            this.label_Xges.Location = new System.Drawing.Point(447, 249);
            this.label_Xges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Xges.Name = "label_Xges";
            this.label_Xges.Size = new System.Drawing.Size(137, 25);
            this.label_Xges.TabIndex = 15;
            this.label_Xges.Text = "X-Koordinate";
            // 
            // label_Schwerpunkt
            // 
            this.label_Schwerpunkt.AutoSize = true;
            this.label_Schwerpunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Schwerpunkt.Location = new System.Drawing.Point(447, 210);
            this.label_Schwerpunkt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Schwerpunkt.Name = "label_Schwerpunkt";
            this.label_Schwerpunkt.Size = new System.Drawing.Size(147, 25);
            this.label_Schwerpunkt.TabIndex = 14;
            this.label_Schwerpunkt.Text = "Schwerpunkt";
            // 
            // label_Ages
            // 
            this.label_Ages.AutoSize = true;
            this.label_Ages.Location = new System.Drawing.Point(436, 88);
            this.label_Ages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Ages.Name = "label_Ages";
            this.label_Ages.Size = new System.Drawing.Size(199, 25);
            this.label_Ages.TabIndex = 13;
            this.label_Ages.Text = "Gesamtfläche Ages";
            // 
            // label_Flächenschwerpunkte
            // 
            this.label_Flächenschwerpunkte.AutoSize = true;
            this.label_Flächenschwerpunkte.ForeColor = System.Drawing.Color.Blue;
            this.label_Flächenschwerpunkte.Location = new System.Drawing.Point(15, 55);
            this.label_Flächenschwerpunkte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Flächenschwerpunkte.Name = "label_Flächenschwerpunkte";
            this.label_Flächenschwerpunkte.Size = new System.Drawing.Size(382, 25);
            this.label_Flächenschwerpunkte.TabIndex = 11;
            this.label_Flächenschwerpunkte.Text = "Eingabe der Teilflächen-Schwerpunkte";
            // 
            // dataGridView_Schwerpkt
            // 
            this.dataGridView_Schwerpkt.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView_Schwerpkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Schwerpkt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_A,
            this.Column_Xs,
            this.Column_Ys});
            this.dataGridView_Schwerpkt.Location = new System.Drawing.Point(10, 88);
            this.dataGridView_Schwerpkt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView_Schwerpkt.Name = "dataGridView_Schwerpkt";
            this.dataGridView_Schwerpkt.RowTemplate.Height = 24;
            this.dataGridView_Schwerpkt.Size = new System.Drawing.Size(414, 297);
            this.dataGridView_Schwerpkt.TabIndex = 10;
            // 
            // Column_A
            // 
            this.Column_A.HeaderText = "Fläche A";
            this.Column_A.Name = "Column_A";
            // 
            // Column_Xs
            // 
            this.Column_Xs.HeaderText = "Koordinate X";
            this.Column_Xs.Name = "Column_Xs";
            this.Column_Xs.Width = 120;
            // 
            // Column_Ys
            // 
            this.Column_Ys.HeaderText = "Koordinate Y";
            this.Column_Ys.Name = "Column_Ys";
            this.Column_Ys.Width = 120;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gesamtschwerpunktToolStripMenuItem,
            this.excelExportToolStripMenuItem,
            this.excelImportToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(654, 38);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gesamtschwerpunktToolStripMenuItem
            // 
            this.gesamtschwerpunktToolStripMenuItem.Name = "gesamtschwerpunktToolStripMenuItem";
            this.gesamtschwerpunktToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.gesamtschwerpunktToolStripMenuItem.Text = "Gesamtschwerpunkt";
            this.gesamtschwerpunktToolStripMenuItem.Click += new System.EventHandler(this.gesamtschwerpunktToolStripMenuItem_Click);
            // 
            // excelExportToolStripMenuItem
            // 
            this.excelExportToolStripMenuItem.Name = "excelExportToolStripMenuItem";
            this.excelExportToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.excelExportToolStripMenuItem.Text = "Excel-Export";
            this.excelExportToolStripMenuItem.Click += new System.EventHandler(this.excelExportToolStripMenuItem_Click);
            // 
            // excelImportToolStripMenuItem
            // 
            this.excelImportToolStripMenuItem.Name = "excelImportToolStripMenuItem";
            this.excelImportToolStripMenuItem.Size = new System.Drawing.Size(142, 34);
            this.excelImportToolStripMenuItem.Text = "Excel-Import";
            this.excelImportToolStripMenuItem.Click += new System.EventHandler(this.excelImportToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // saveFileDialog_Excel
            // 
            this.saveFileDialog_Excel.FileName = "Schwerpunkt";
            this.saveFileDialog_Excel.Filter = "Excel (*.xlsx)|*.xlsx|alle Dateien (*.*)|*.*";
            this.saveFileDialog_Excel.Title = "Export nach Excel";
            // 
            // openFileDialog_Excel
            // 
            this.openFileDialog_Excel.FileName = "Schwerpunkt";
            this.openFileDialog_Excel.Filter = "Excel (*.xlsx)|*.xlsx|alle Dateien (*.*)|*.*";
            this.openFileDialog_Excel.Title = "Import von Excel";
            // 
            // Form_Schwerpunkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.textBox_gesamtYs);
            this.Controls.Add(this.textBox_gesamtXs);
            this.Controls.Add(this.textBox_gesamtA);
            this.Controls.Add(this.label_Yges);
            this.Controls.Add(this.label_Xges);
            this.Controls.Add(this.label_Schwerpunkt);
            this.Controls.Add(this.label_Ages);
            this.Controls.Add(this.label_Flächenschwerpunkte);
            this.Controls.Add(this.dataGridView_Schwerpkt);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form_Schwerpunkt";
            this.Text = "Schwerpunkt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schwerpkt)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_gesamtYs;
        private System.Windows.Forms.TextBox textBox_gesamtXs;
        private System.Windows.Forms.TextBox textBox_gesamtA;
        private System.Windows.Forms.Label label_Yges;
        private System.Windows.Forms.Label label_Xges;
        private System.Windows.Forms.Label label_Schwerpunkt;
        private System.Windows.Forms.Label label_Ages;
        private System.Windows.Forms.Label label_Flächenschwerpunkte;
        private System.Windows.Forms.DataGridView dataGridView_Schwerpkt;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gesamtschwerpunktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelImportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Excel;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Xs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ys;
    }
}

