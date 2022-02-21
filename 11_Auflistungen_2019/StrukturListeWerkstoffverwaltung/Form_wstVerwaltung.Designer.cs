namespace werkstoffverwaltung
{
    partial class Form_matManagement
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_matManagement));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label_matName = new System.Windows.Forms.Label();
      this.label_matTension = new System.Windows.Forms.Label();
      this.label_matDescription = new System.Windows.Forms.Label();
      this.label_mat = new System.Windows.Forms.Label();
      this.textBox_matName = new System.Windows.Forms.TextBox();
      this.textBox_matTension = new System.Windows.Forms.TextBox();
      this.textBox_matDescription = new System.Windows.Forms.TextBox();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.listBox_materials = new System.Windows.Forms.ListBox();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      resources.ApplyResources(this.menuStrip, "menuStrip");
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.menuStrip.Name = "menuStrip";
      // 
      // addToolStripMenuItem
      // 
      resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
      // 
      // deleteToolStripMenuItem
      // 
      resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
      // 
      // loadToolStripMenuItem
      // 
      resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // label_matName
      // 
      resources.ApplyResources(this.label_matName, "label_matName");
      this.label_matName.ForeColor = System.Drawing.Color.Navy;
      this.label_matName.Name = "label_matName";
      // 
      // label_matTension
      // 
      resources.ApplyResources(this.label_matTension, "label_matTension");
      this.label_matTension.ForeColor = System.Drawing.Color.Navy;
      this.label_matTension.Name = "label_matTension";
      // 
      // label_matDescription
      // 
      resources.ApplyResources(this.label_matDescription, "label_matDescription");
      this.label_matDescription.ForeColor = System.Drawing.Color.Navy;
      this.label_matDescription.Name = "label_matDescription";
      // 
      // label_mat
      // 
      resources.ApplyResources(this.label_mat, "label_mat");
      this.label_mat.Name = "label_mat";
      // 
      // textBox_matName
      // 
      resources.ApplyResources(this.textBox_matName, "textBox_matName");
      this.textBox_matName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_matName.Name = "textBox_matName";
      // 
      // textBox_matTension
      // 
      resources.ApplyResources(this.textBox_matTension, "textBox_matTension");
      this.textBox_matTension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_matTension.Name = "textBox_matTension";
      // 
      // textBox_matDescription
      // 
      resources.ApplyResources(this.textBox_matDescription, "textBox_matDescription");
      this.textBox_matDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_matDescription.Name = "textBox_matDescription";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "mat";
      this.saveFileDialog.FileName = "Materials";
      resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
      this.saveFileDialog.InitialDirectory = "C:\\temp";
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "mat";
      this.openFileDialog.FileName = "Materials";
      resources.ApplyResources(this.openFileDialog, "openFileDialog");
      this.openFileDialog.InitialDirectory = "C:\\temp";
      // 
      // listBox_materials
      // 
      resources.ApplyResources(this.listBox_materials, "listBox_materials");
      this.listBox_materials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.listBox_materials.FormattingEnabled = true;
      this.listBox_materials.Name = "listBox_materials";
      this.listBox_materials.SelectedIndexChanged += new System.EventHandler(this.listBox_materials_SelectedIndexChanged);
      // 
      // Form_matManagement
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.listBox_materials);
      this.Controls.Add(this.textBox_matDescription);
      this.Controls.Add(this.textBox_matTension);
      this.Controls.Add(this.textBox_matName);
      this.Controls.Add(this.label_mat);
      this.Controls.Add(this.label_matDescription);
      this.Controls.Add(this.label_matTension);
      this.Controls.Add(this.label_matName);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "Form_matManagement";
      this.Load += new System.EventHandler(this.Form_matManagement_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_matName;
        private System.Windows.Forms.Label label_matTension;
        private System.Windows.Forms.Label label_matDescription;
        private System.Windows.Forms.Label label_mat;
        private System.Windows.Forms.TextBox textBox_matName;
        private System.Windows.Forms.TextBox textBox_matTension;
        private System.Windows.Forms.TextBox textBox_matDescription;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ListBox listBox_materials;
  }
}

