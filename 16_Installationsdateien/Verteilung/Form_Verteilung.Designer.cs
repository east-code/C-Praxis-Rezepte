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
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_Daten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelImportToolStripMenuItem,
            this.dichtefunktionToolStripMenuItem,
            this.klassenanalyseToolStripMenuItem,
            this.diagrammToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(708, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseEnter += new System.EventHandler(this.menuStrip_MouseEnter);
            // 
            // excelImportToolStripMenuItem
            // 
            this.excelImportToolStripMenuItem.Name = "excelImportToolStripMenuItem";
            this.excelImportToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.excelImportToolStripMenuItem.Text = "Excel-Import";
            this.excelImportToolStripMenuItem.Click += new System.EventHandler(this.excelImportToolStripMenuItem_Click);
            this.excelImportToolStripMenuItem.MouseEnter += new System.EventHandler(this.excelImportToolStripMenuItem_MouseEnter);
            // 
            // dichtefunktionToolStripMenuItem
            // 
            this.dichtefunktionToolStripMenuItem.Name = "dichtefunktionToolStripMenuItem";
            this.dichtefunktionToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.dichtefunktionToolStripMenuItem.Text = "Dichtefunktion";
            this.dichtefunktionToolStripMenuItem.Click += new System.EventHandler(this.dichtefunktionToolStripMenuItem_Click);
            // 
            // klassenanalyseToolStripMenuItem
            // 
            this.klassenanalyseToolStripMenuItem.Name = "klassenanalyseToolStripMenuItem";
            this.klassenanalyseToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.klassenanalyseToolStripMenuItem.Text = "Klassenanalyse";
            this.klassenanalyseToolStripMenuItem.Click += new System.EventHandler(this.klassenanalyseToolStripMenuItem_Click);
            // 
            // diagrammToolStripMenuItem
            // 
            this.diagrammToolStripMenuItem.Name = "diagrammToolStripMenuItem";
            this.diagrammToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.diagrammToolStripMenuItem.Text = "Diagramm";
            this.diagrammToolStripMenuItem.Click += new System.EventHandler(this.diagrammToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeAnzeigenToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // hilfeAnzeigenToolStripMenuItem
            // 
            this.hilfeAnzeigenToolStripMenuItem.Name = "hilfeAnzeigenToolStripMenuItem";
            this.hilfeAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.hilfeAnzeigenToolStripMenuItem.Text = "Hilfe anzeigen";
            this.hilfeAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.hilfeAnzeigenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Daten});
            this.helpProvider.SetHelpKeyword(this.dataGridView, "");
            this.dataGridView.Location = new System.Drawing.Point(25, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.helpProvider.SetShowHelp(this.dataGridView, true);
            this.dataGridView.Size = new System.Drawing.Size(176, 412);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.MouseEnter += new System.EventHandler(this.dataGridView_MouseEnter);
            this.dataGridView.MouseLeave += new System.EventHandler(this.dataGridView_MouseLeave);
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
            chartArea1.AxisX.Title = "Wert x";
            chartArea1.AxisY.Title = "Häufigkeit h(x)";
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY2.Title = "Anzahl m";
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.helpProvider.SetHelpKeyword(this.chart, "HilfeVerteilung.htm");
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(236, 49);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend";
            series1.Name = "S[0] - Verteilung";
            series2.ChartArea = "ChartArea";
            series2.Legend = "Legend";
            series2.Name = "S[1] - Klassen";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.helpProvider.SetShowHelp(this.chart, true);
            this.chart.Size = new System.Drawing.Size(438, 412);
            this.chart.TabIndex = 2;
            this.chart.Text = "Datenanalyse";
            title1.Name = "Title";
            title1.Text = "Datenanalyse";
            this.chart.Titles.Add(title1);
            this.chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "HilfeVerteilung.chm";
            // 
            // Form_Verteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 474);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.helpProvider.SetHelpKeyword(this, "Verteilung");
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_Verteilung";
            this.helpProvider.SetShowHelp(this, true);
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
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeAnzeigenToolStripMenuItem;
    }
}

