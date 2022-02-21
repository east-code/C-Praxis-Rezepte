namespace StrukturFeld
{
  partial class Form_Schrauben
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
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.hinzufuegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ausgabeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.textBox_Gewinde = new System.Windows.Forms.TextBox();
      this.textBox_Laenge = new System.Windows.Forms.TextBox();
      this.textBox_Stueck = new System.Windows.Forms.TextBox();
      this.label_Gewinde = new System.Windows.Forms.Label();
      this.label_Laenge = new System.Windows.Forms.Label();
      this.label_Stueck = new System.Windows.Forms.Label();
      this.textBox_Schrauben = new System.Windows.Forms.TextBox();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufuegenToolStripMenuItem,
            this.ausgabeToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 24);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 6, 0, 6);
      this.menuStrip1.Size = new System.Drawing.Size(750, 61);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // hinzufuegenToolStripMenuItem
      // 
      this.hinzufuegenToolStripMenuItem.Name = "hinzufuegenToolStripMenuItem";
      this.hinzufuegenToolStripMenuItem.Size = new System.Drawing.Size(212, 49);
      this.hinzufuegenToolStripMenuItem.Text = "Hinzufuegen";
      this.hinzufuegenToolStripMenuItem.Click += new System.EventHandler(this.hinzufuegenToolStripMenuItem_Click);
      // 
      // ausgabeToolStripMenuItem
      // 
      this.ausgabeToolStripMenuItem.Name = "ausgabeToolStripMenuItem";
      this.ausgabeToolStripMenuItem.Size = new System.Drawing.Size(156, 49);
      this.ausgabeToolStripMenuItem.Text = "Ausgabe";
      this.ausgabeToolStripMenuItem.Click += new System.EventHandler(this.ausgabeToolStripMenuItem_Click);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(156, 49);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // textBox_Gewinde
      // 
      this.textBox_Gewinde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Gewinde.Location = new System.Drawing.Point(31, 142);
      this.textBox_Gewinde.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
      this.textBox_Gewinde.Name = "textBox_Gewinde";
      this.textBox_Gewinde.Size = new System.Drawing.Size(154, 44);
      this.textBox_Gewinde.TabIndex = 1;
      // 
      // textBox_Laenge
      // 
      this.textBox_Laenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Laenge.Location = new System.Drawing.Point(31, 249);
      this.textBox_Laenge.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
      this.textBox_Laenge.Name = "textBox_Laenge";
      this.textBox_Laenge.Size = new System.Drawing.Size(154, 44);
      this.textBox_Laenge.TabIndex = 2;
      // 
      // textBox_Stueck
      // 
      this.textBox_Stueck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.textBox_Stueck.Location = new System.Drawing.Point(31, 361);
      this.textBox_Stueck.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
      this.textBox_Stueck.Name = "textBox_Stueck";
      this.textBox_Stueck.Size = new System.Drawing.Size(154, 44);
      this.textBox_Stueck.TabIndex = 3;
      // 
      // label_Gewinde
      // 
      this.label_Gewinde.AutoSize = true;
      this.label_Gewinde.Location = new System.Drawing.Point(24, 96);
      this.label_Gewinde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_Gewinde.Name = "label_Gewinde";
      this.label_Gewinde.Size = new System.Drawing.Size(142, 37);
      this.label_Gewinde.TabIndex = 4;
      this.label_Gewinde.Text = "Gewinde";
      // 
      // label_Laenge
      // 
      this.label_Laenge.AutoSize = true;
      this.label_Laenge.Location = new System.Drawing.Point(24, 203);
      this.label_Laenge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_Laenge.Name = "label_Laenge";
      this.label_Laenge.Size = new System.Drawing.Size(106, 37);
      this.label_Laenge.TabIndex = 5;
      this.label_Laenge.Text = "Länge";
      // 
      // label_Stueck
      // 
      this.label_Stueck.AutoSize = true;
      this.label_Stueck.Location = new System.Drawing.Point(24, 315);
      this.label_Stueck.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_Stueck.Name = "label_Stueck";
      this.label_Stueck.Size = new System.Drawing.Size(173, 37);
      this.label_Stueck.TabIndex = 6;
      this.label_Stueck.Text = "Stueckzahl";
      // 
      // textBox_Schrauben
      // 
      this.textBox_Schrauben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.textBox_Schrauben.Dock = System.Windows.Forms.DockStyle.Right;
      this.textBox_Schrauben.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_Schrauben.ForeColor = System.Drawing.Color.Navy;
      this.textBox_Schrauben.Location = new System.Drawing.Point(200, 85);
      this.textBox_Schrauben.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBox_Schrauben.Multiline = true;
      this.textBox_Schrauben.Name = "textBox_Schrauben";
      this.textBox_Schrauben.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox_Schrauben.Size = new System.Drawing.Size(550, 340);
      this.textBox_Schrauben.TabIndex = 7;
      // 
      // menuStrip2
      // 
      this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
      this.menuStrip2.Size = new System.Drawing.Size(750, 24);
      this.menuStrip2.TabIndex = 8;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // Form_Schrauben
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(750, 425);
      this.Controls.Add(this.textBox_Schrauben);
      this.Controls.Add(this.label_Stueck);
      this.Controls.Add(this.label_Laenge);
      this.Controls.Add(this.label_Gewinde);
      this.Controls.Add(this.textBox_Stueck);
      this.Controls.Add(this.textBox_Laenge);
      this.Controls.Add(this.textBox_Gewinde);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.menuStrip2);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
      this.Name = "Form_Schrauben";
      this.Text = "Sechskantschrauben";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox_Gewinde;
    private System.Windows.Forms.TextBox textBox_Laenge;
    private System.Windows.Forms.TextBox textBox_Stueck;
    private System.Windows.Forms.ToolStripMenuItem hinzufuegenToolStripMenuItem;
    private System.Windows.Forms.Label label_Gewinde;
    private System.Windows.Forms.Label label_Laenge;
    private System.Windows.Forms.Label label_Stueck;
    private System.Windows.Forms.TextBox textBox_Schrauben;
    private System.Windows.Forms.ToolStripMenuItem ausgabeToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip2;
  }
}

