namespace Verteilung
{
    partial class Form_Verteilung
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.excelImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dichtefunktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klassenanalyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_Daten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelImportToolStripMenuItem,
            this.dichtefunktionToolStripMenuItem,
            this.klassenanalyseToolStripMenuItem,
            this.diagrammToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(724, 37);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // excelImportToolStripMenuItem
            // 
            this.excelImportToolStripMenuItem.Name = "excelImportToolStripMenuItem";
            this.excelImportToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.excelImportToolStripMenuItem.Text = "Excel-Import";
            this.excelImportToolStripMenuItem.Click += new System.EventHandler(this.excelImportToolStripMenuItem_Click);
            // 
            // dichtefunktionToolStripMenuItem
            // 
            this.dichtefunktionToolStripMenuItem.Name = "dichtefunktionToolStripMenuItem";
            this.dichtefunktionToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.dichtefunktionToolStripMenuItem.Text = "Dichtefunktion";
            this.dichtefunktionToolStripMenuItem.Click += new System.EventHandler(this.dichtefunktionToolStripMenuItem_Click);
            // 
            // klassenanalyseToolStripMenuItem
            // 
            this.klassenanalyseToolStripMenuItem.Name = "klassenanalyseToolStripMenuItem";
            this.klassenanalyseToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.klassenanalyseToolStripMenuItem.Text = "Klassenanalyse";
            this.klassenanalyseToolStripMenuItem.Click += new System.EventHandler(this.klassenanalyseToolStripMenuItem_Click);
            // 
            // diagrammToolStripMenuItem
            // 
            this.diagrammToolStripMenuItem.Name = "diagrammToolStripMenuItem";
            this.diagrammToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.diagrammToolStripMenuItem.Text = "Diagramm";
            this.diagrammToolStripMenuItem.Click += new System.EventHandler(this.diagrammToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Daten});
            this.dataGridView.Location = new System.Drawing.Point(0, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(162, 391);
            this.dataGridView.TabIndex = 1;
            // 
            // Column_Daten
            // 
            this.Column_Daten.HeaderText = "Daten";
            this.Column_Daten.Name = "Column_Daten";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.FileName = "Daten";
            this.openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| alle Dateien (*.*)|*.*";
            this.openFileDialog.Title = "Daten importieren";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // chart
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.Title = "Wert x";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Häufigkeit h(x)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY2.Title = "Anzahl m";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(162, 50);
            this.chart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart.Name = "chart";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Maroon;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend";
            series1.Name = "S[0] - Verteilung";
            series2.ChartArea = "ChartArea";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend";
            series2.Name = "S[1] - Klassen";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(569, 391);
            this.chart.TabIndex = 2;
            this.chart.Text = "Datenanalyse";
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Datenanalyse";
            this.chart.Titles.Add(title1);
            this.chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form_Verteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 440);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Verteilung";
            this.Text = "Verteilung";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelImportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Daten;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem klassenanalyseToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart; 
        private System.Windows.Forms.ToolStripMenuItem dichtefunktionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrammToolStripMenuItem;
    }
}

