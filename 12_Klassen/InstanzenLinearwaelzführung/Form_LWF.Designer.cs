namespace Linearwaelzführung
{
    partial class Form_LWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Betrieb = new System.Windows.Forms.DataGridView();
            this.dataGridView_Gesamt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn_Zusammenfassung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Betriebsbedingung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Betrieb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gesamt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oKToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1046, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Image = global::Linearwaelzführung.Properties.Resources.accept;
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.oKToolStripMenuItem.Text = "OK";
            this.oKToolStripMenuItem.Click += new System.EventHandler(this.oKToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Image = global::Linearwaelzführung.Properties.Resources.beenden_2;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(122, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // dataGridView_Betrieb
            // 
            this.dataGridView_Betrieb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Betrieb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Betrieb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Betriebsbedingung,
            this.Column_v,
            this.Column_t,
            this.Column_s,
            this.Column_Fy,
            this.Column_Fz});
            this.dataGridView_Betrieb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Betrieb.Location = new System.Drawing.Point(0, 42);
            this.dataGridView_Betrieb.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView_Betrieb.Name = "dataGridView_Betrieb";
            this.dataGridView_Betrieb.RowTemplate.Height = 24;
            this.dataGridView_Betrieb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Betrieb.Size = new System.Drawing.Size(1046, 431);
            this.dataGridView_Betrieb.TabIndex = 1;
            this.dataGridView_Betrieb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_Betrieb.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Betriebsbedingungen_RowLeave);
            // 
            // dataGridView_Gesamt
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Gesamt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Gesamt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gesamt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_Zusammenfassung,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_Gesamt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Gesamt.Location = new System.Drawing.Point(0, 352);
            this.dataGridView_Gesamt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView_Gesamt.Name = "dataGridView_Gesamt";
            this.dataGridView_Gesamt.RowTemplate.Height = 24;
            this.dataGridView_Gesamt.Size = new System.Drawing.Size(1046, 121);
            this.dataGridView_Gesamt.TabIndex = 2;
            this.dataGridView_Gesamt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Gesamt_CellContentClick);
            // 
            // dataGridViewTextBoxColumn_Zusammenfassung
            // 
            this.dataGridViewTextBoxColumn_Zusammenfassung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataGridViewTextBoxColumn_Zusammenfassung.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn_Zusammenfassung.HeaderText = "Zusammenfassung";
            this.dataGridViewTextBoxColumn_Zusammenfassung.Name = "dataGridViewTextBoxColumn_Zusammenfassung";
            this.dataGridViewTextBoxColumn_Zusammenfassung.Width = 219;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "mittlere Geschwindigkeit v in m/min";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 286;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Zeitanteil";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Weganteil";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 133;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "Äquivalente Kraft        Fäqu in N";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 204;
            // 
            // Column_Betriebsbedingung
            // 
            this.Column_Betriebsbedingung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_Betriebsbedingung.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Betriebsbedingung.HeaderText = "Betriebsbedingung";
            this.Column_Betriebsbedingung.Name = "Column_Betriebsbedingung";
            this.Column_Betriebsbedingung.Width = 217;
            // 
            // Column_v
            // 
            this.Column_v.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_v.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_v.HeaderText = "Geschwindigkeit v[i] in m/min";
            this.Column_v.Name = "Column_v";
            this.Column_v.Width = 207;
            // 
            // Column_t
            // 
            this.Column_t.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_t.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_t.HeaderText = "Zeitanteil t[i]/t";
            this.Column_t.Name = "Column_t";
            this.Column_t.Width = 151;
            // 
            // Column_s
            // 
            this.Column_s.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_s.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_s.HeaderText = "Weganteil s[i]/s";
            this.Column_s.Name = "Column_s";
            this.Column_s.ReadOnly = true;
            this.Column_s.Width = 168;
            // 
            // Column_Fy
            // 
            this.Column_Fy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_Fy.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_Fy.HeaderText = "Kraft        Fy in N";
            this.Column_Fy.Name = "Column_Fy";
            this.Column_Fy.Width = 119;
            // 
            // Column_Fz
            // 
            this.Column_Fz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Column_Fz.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_Fz.HeaderText = "Kraft        Fz in N";
            this.Column_Fz.Name = "Column_Fz";
            this.Column_Fz.Width = 119;
            // 
            // Form_LWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 473);
            this.Controls.Add(this.dataGridView_Gesamt);
            this.Controls.Add(this.dataGridView_Betrieb);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form_LWF";
            this.Text = "Linearwälzführung";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Betrieb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gesamt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Betrieb;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Gesamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_Zusammenfassung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Betriebsbedingung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fz;
    }
}

