namespace Maschinenbau
{
    partial class Form_wörterbuch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_wörterbuch));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label_key = new System.Windows.Forms.Label();
      this.label_value = new System.Windows.Forms.Label();
      this.textBox_key = new System.Windows.Forms.TextBox();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.listBox_keys = new System.Windows.Forms.ListBox();
      this.richTextBox_value = new System.Windows.Forms.RichTextBox();
      this.label_keys = new System.Windows.Forms.Label();
      this.button_clear = new System.Windows.Forms.Button();
      this.textBox_Hint = new System.Windows.Forms.TextBox();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      resources.ApplyResources(this.menuStrip, "menuStrip");
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.menuStrip.Name = "menuStrip";
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
      this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
      // 
      // updateToolStripMenuItem
      // 
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
      this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
      this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // label_key
      // 
      resources.ApplyResources(this.label_key, "label_key");
      this.label_key.Name = "label_key";
      // 
      // label_value
      // 
      resources.ApplyResources(this.label_value, "label_value");
      this.label_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.label_value.Name = "label_value";
      // 
      // textBox_key
      // 
      resources.ApplyResources(this.textBox_key, "textBox_key");
      this.textBox_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_key.Name = "textBox_key";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "dic";
      this.saveFileDialog.FileName = "Engineering";
      resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
      this.saveFileDialog.InitialDirectory = "C:\\temp";
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "dic";
      this.openFileDialog.FileName = "Engineering";
      resources.ApplyResources(this.openFileDialog, "openFileDialog");
      this.openFileDialog.InitialDirectory = "C:\\temp";
      // 
      // listBox_keys
      // 
      this.listBox_keys.BackColor = System.Drawing.SystemColors.Info;
      this.listBox_keys.FormattingEnabled = true;
      resources.ApplyResources(this.listBox_keys, "listBox_keys");
      this.listBox_keys.Name = "listBox_keys";
      this.listBox_keys.SelectedIndexChanged += new System.EventHandler(this.listBox_keys_SelectedIndexChanged);
      // 
      // richTextBox_value
      // 
      resources.ApplyResources(this.richTextBox_value, "richTextBox_value");
      this.richTextBox_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.richTextBox_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.richTextBox_value.Name = "richTextBox_value";
      this.richTextBox_value.TextChanged += new System.EventHandler(this.richTextBox_value_TextChanged);
      // 
      // label_keys
      // 
      resources.ApplyResources(this.label_keys, "label_keys");
      this.label_keys.Name = "label_keys";
      // 
      // button_clear
      // 
      resources.ApplyResources(this.button_clear, "button_clear");
      this.button_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.button_clear.Name = "button_clear";
      this.button_clear.UseVisualStyleBackColor = true;
      this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
      // 
      // textBox_Hint
      // 
      this.textBox_Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.textBox_Hint, "textBox_Hint");
      this.textBox_Hint.ForeColor = System.Drawing.Color.Maroon;
      this.textBox_Hint.Name = "textBox_Hint";
      // 
      // Form_wörterbuch
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.textBox_Hint);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.label_keys);
      this.Controls.Add(this.richTextBox_value);
      this.Controls.Add(this.listBox_keys);
      this.Controls.Add(this.textBox_key);
      this.Controls.Add(this.label_value);
      this.Controls.Add(this.label_key);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "Form_wörterbuch";
      this.Load += new System.EventHandler(this.Form_wörterbuch_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ListBox listBox_keys;
    private System.Windows.Forms.RichTextBox richTextBox_value;
    private System.Windows.Forms.Label label_keys;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    private System.Windows.Forms.Button button_clear;
    private System.Windows.Forms.TextBox textBox_Hint;
  }
}

