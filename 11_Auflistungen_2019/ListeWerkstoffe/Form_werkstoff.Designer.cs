namespace werkstoffe
{
    partial class Form_werkstoff
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
      this.menuStrip_wst = new System.Windows.Forms.MenuStrip();
      this.hinzufuegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loeschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sortierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer_werkstoff = new System.Windows.Forms.SplitContainer();
      this.label_edit = new System.Windows.Forms.Label();
      this.textBox_edit = new System.Windows.Forms.TextBox();
      this.label_autput = new System.Windows.Forms.Label();
      this.listBox_output = new System.Windows.Forms.ListBox();
      this.menuStrip_wst.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_werkstoff)).BeginInit();
      this.splitContainer_werkstoff.Panel1.SuspendLayout();
      this.splitContainer_werkstoff.Panel2.SuspendLayout();
      this.splitContainer_werkstoff.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip_wst
      // 
      this.menuStrip_wst.BackColor = System.Drawing.Color.White;
      this.menuStrip_wst.Font = new System.Drawing.Font("Segoe UI", 18F);
      this.menuStrip_wst.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip_wst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufuegenToolStripMenuItem,
            this.loeschenToolStripMenuItem,
            this.sortierenToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.menuStrip_wst.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_wst.Name = "menuStrip_wst";
      this.menuStrip_wst.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
      this.menuStrip_wst.Size = new System.Drawing.Size(1240, 60);
      this.menuStrip_wst.TabIndex = 0;
      this.menuStrip_wst.Text = "menuStrip_mat";
      // 
      // hinzufuegenToolStripMenuItem
      // 
      this.hinzufuegenToolStripMenuItem.Image = global::werkstoffe.Properties.Resources.Hinzufügen;
      this.hinzufuegenToolStripMenuItem.Name = "hinzufuegenToolStripMenuItem";
      this.hinzufuegenToolStripMenuItem.Size = new System.Drawing.Size(238, 52);
      this.hinzufuegenToolStripMenuItem.Tag = "addToolStripMenuItem";
      this.hinzufuegenToolStripMenuItem.Text = "Hinzufügen";
      this.hinzufuegenToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.hinzufuegenToolStripMenuItem.Click += new System.EventHandler(this.hinzufuegenToolStripMenuItem_Click);
      // 
      // loeschenToolStripMenuItem
      // 
      this.loeschenToolStripMenuItem.Image = global::werkstoffe.Properties.Resources.Löschen;
      this.loeschenToolStripMenuItem.Name = "loeschenToolStripMenuItem";
      this.loeschenToolStripMenuItem.Size = new System.Drawing.Size(185, 52);
      this.loeschenToolStripMenuItem.Tag = "deleteToolStripMenuItem";
      this.loeschenToolStripMenuItem.Text = "Löschen";
      this.loeschenToolStripMenuItem.Click += new System.EventHandler(this.loeschenToolStripMenuItem_Click);
      // 
      // sortierenToolStripMenuItem
      // 
      this.sortierenToolStripMenuItem.Image = global::werkstoffe.Properties.Resources.Sortieren;
      this.sortierenToolStripMenuItem.Name = "sortierenToolStripMenuItem";
      this.sortierenToolStripMenuItem.Size = new System.Drawing.Size(201, 52);
      this.sortierenToolStripMenuItem.Tag = "sortToolStripMenuItem";
      this.sortierenToolStripMenuItem.Text = "Sortieren";
      this.sortierenToolStripMenuItem.Click += new System.EventHandler(this.sortierenToolStripMenuItem_Click);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Image = global::werkstoffe.Properties.Resources.beenden_2;
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(195, 52);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // splitContainer_werkstoff
      // 
      this.splitContainer_werkstoff.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer_werkstoff.Location = new System.Drawing.Point(0, 60);
      this.splitContainer_werkstoff.Margin = new System.Windows.Forms.Padding(2);
      this.splitContainer_werkstoff.Name = "splitContainer_werkstoff";
      this.splitContainer_werkstoff.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer_werkstoff.Panel1
      // 
      this.splitContainer_werkstoff.Panel1.BackColor = System.Drawing.SystemColors.Control;
      this.splitContainer_werkstoff.Panel1.Controls.Add(this.label_edit);
      this.splitContainer_werkstoff.Panel1.Controls.Add(this.textBox_edit);
      this.splitContainer_werkstoff.Panel1MinSize = 96;
      // 
      // splitContainer_werkstoff.Panel2
      // 
      this.splitContainer_werkstoff.Panel2.Controls.Add(this.label_autput);
      this.splitContainer_werkstoff.Panel2.Controls.Add(this.listBox_output);
      this.splitContainer_werkstoff.Panel2MinSize = 400;
      this.splitContainer_werkstoff.Size = new System.Drawing.Size(1240, 549);
      this.splitContainer_werkstoff.SplitterDistance = 96;
      this.splitContainer_werkstoff.SplitterWidth = 3;
      this.splitContainer_werkstoff.TabIndex = 6;
      // 
      // label_edit
      // 
      this.label_edit.BackColor = System.Drawing.Color.Silver;
      this.label_edit.Dock = System.Windows.Forms.DockStyle.Top;
      this.label_edit.ForeColor = System.Drawing.Color.Black;
      this.label_edit.Location = new System.Drawing.Point(0, 0);
      this.label_edit.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.label_edit.MinimumSize = new System.Drawing.Size(0, 44);
      this.label_edit.Name = "label_edit";
      this.label_edit.Size = new System.Drawing.Size(1240, 44);
      this.label_edit.TabIndex = 6;
      this.label_edit.Text = "Editieren";
      this.label_edit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // textBox_edit
      // 
      this.textBox_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_edit.Location = new System.Drawing.Point(0, 44);
      this.textBox_edit.Margin = new System.Windows.Forms.Padding(7);
      this.textBox_edit.Name = "textBox_edit";
      this.textBox_edit.Size = new System.Drawing.Size(1240, 48);
      this.textBox_edit.TabIndex = 5;
      // 
      // label_autput
      // 
      this.label_autput.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label_autput.Dock = System.Windows.Forms.DockStyle.Top;
      this.label_autput.Location = new System.Drawing.Point(0, 0);
      this.label_autput.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.label_autput.MinimumSize = new System.Drawing.Size(0, 44);
      this.label_autput.Name = "label_autput";
      this.label_autput.Size = new System.Drawing.Size(1240, 45);
      this.label_autput.TabIndex = 10;
      this.label_autput.Text = "Ausgabe";
      // 
      // listBox_output
      // 
      this.listBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.listBox_output.FormattingEnabled = true;
      this.listBox_output.ItemHeight = 40;
      this.listBox_output.Location = new System.Drawing.Point(0, 46);
      this.listBox_output.Margin = new System.Windows.Forms.Padding(2);
      this.listBox_output.Name = "listBox_output";
      this.listBox_output.Size = new System.Drawing.Size(1240, 404);
      this.listBox_output.TabIndex = 9;
      // 
      // Form_werkstoff
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1240, 609);
      this.Controls.Add(this.splitContainer_werkstoff);
      this.Controls.Add(this.menuStrip_wst);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
      this.MainMenuStrip = this.menuStrip_wst;
      this.Margin = new System.Windows.Forms.Padding(7);
      this.Name = "Form_werkstoff";
      this.Text = "Werkstoffe";
      this.Load += new System.EventHandler(this.Form_werkstoff_Load);
      this.menuStrip_wst.ResumeLayout(false);
      this.menuStrip_wst.PerformLayout();
      this.splitContainer_werkstoff.Panel1.ResumeLayout(false);
      this.splitContainer_werkstoff.Panel1.PerformLayout();
      this.splitContainer_werkstoff.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_werkstoff)).EndInit();
      this.splitContainer_werkstoff.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_wst;
        private System.Windows.Forms.ToolStripMenuItem hinzufuegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loeschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer_werkstoff;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.TextBox textBox_edit;
        private System.Windows.Forms.Label label_autput;
        private System.Windows.Forms.ListBox listBox_output;
    }
}

