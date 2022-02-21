namespace Momentenverlauf
{
    partial class Form_Momentenverlauf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Momentenverlauf));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_l = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.textBox_l = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.chart_Mb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_BildTraeger = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Mb)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(530, 261);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(248, 74);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_l
            // 
            this.label_l.AutoSize = true;
            this.label_l.Location = new System.Drawing.Point(40, 261);
            this.label_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(250, 25);
            this.label_l.TabIndex = 1;
            this.label_l.Text = "Länge des Trägers l in m";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Location = new System.Drawing.Point(40, 310);
            this.label_q.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(241, 25);
            this.label_q.TabIndex = 2;
            this.label_q.Text = "Streckenlast q(z) in N/m";
            // 
            // textBox_l
            // 
            this.textBox_l.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_l.Location = new System.Drawing.Point(319, 261);
            this.textBox_l.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_l.Name = "textBox_l";
            this.textBox_l.Size = new System.Drawing.Size(180, 31);
            this.textBox_l.TabIndex = 3;
            this.textBox_l.Text = "2";
            // 
            // textBox_q
            // 
            this.textBox_q.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_q.Location = new System.Drawing.Point(319, 304);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(180, 31);
            this.textBox_q.TabIndex = 4;
            this.textBox_q.Text = "100";
            // 
            // chart_Mb
            // 
            this.chart_Mb.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart_Mb.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_Mb.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart_Mb.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.Title = "Koordinate z in m";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea2.AxisY.Title = "Biegemoment Mb in Nm";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            chartArea2.Name = "ChartArea_Mb";
            this.chart_Mb.ChartAreas.Add(chartArea2);
            this.chart_Mb.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_Mb.Legends.Add(legend2);
            this.chart_Mb.Location = new System.Drawing.Point(0, 342);
            this.chart_Mb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chart_Mb.Name = "chart_Mb";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea_Mb";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.DarkBlue;
            series2.EmptyPointStyle.BorderWidth = 4;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series[0] Mb";
            series2.YValuesPerPoint = 4;
            this.chart_Mb.Series.Add(series2);
            this.chart_Mb.Size = new System.Drawing.Size(792, 443);
            this.chart_Mb.TabIndex = 5;
            this.chart_Mb.Text = "Biegemomentenverlauf";
            this.chart_Mb.Click += new System.EventHandler(this.chart_Mb_Click);
            // 
            // panel_BildTraeger
            // 
            this.panel_BildTraeger.BackColor = System.Drawing.SystemColors.Window;
            this.panel_BildTraeger.BackgroundImage = global::Momentenverlauf.Properties.Resources.EingespannterTrägerOnly200dpi;
            this.panel_BildTraeger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_BildTraeger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BildTraeger.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BildTraeger.Location = new System.Drawing.Point(0, 0);
            this.panel_BildTraeger.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel_BildTraeger.Name = "panel_BildTraeger";
            this.panel_BildTraeger.Size = new System.Drawing.Size(792, 249);
            this.panel_BildTraeger.TabIndex = 6;
            // 
            // Form_Momentenverlauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 785);
            this.Controls.Add(this.panel_BildTraeger);
            this.Controls.Add(this.chart_Mb);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_l);
            this.Controls.Add(this.label_q);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_Momentenverlauf";
            this.Text = "Momentenverlauf: Eingespannter Träger";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Mb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.TextBox textBox_l;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Mb;
        private System.Windows.Forms.Panel panel_BildTraeger;
    }
}

