namespace Aufzaehlung
{
    partial class Form_feldwerte
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
            this.textBox_WstNr = new System.Windows.Forms.TextBox();
            this.listBox_Wst = new System.Windows.Forms.ListBox();
            this.label_Wst = new System.Windows.Forms.Label();
            this.label_WstNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_WstNr
            // 
            this.textBox_WstNr.BackColor = System.Drawing.Color.Silver;
            this.textBox_WstNr.Location = new System.Drawing.Point(270, 145);
            this.textBox_WstNr.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_WstNr.Name = "textBox_WstNr";
            this.textBox_WstNr.Size = new System.Drawing.Size(258, 31);
            this.textBox_WstNr.TabIndex = 2;
            // 
            // listBox_Wst
            // 
            this.listBox_Wst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Wst.FormattingEnabled = true;
            this.listBox_Wst.ItemHeight = 25;
            this.listBox_Wst.Location = new System.Drawing.Point(7, 48);
            this.listBox_Wst.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.listBox_Wst.Name = "listBox_Wst";
            this.listBox_Wst.Size = new System.Drawing.Size(247, 279);
            this.listBox_Wst.TabIndex = 3;
            this.listBox_Wst.SelectedIndexChanged += new System.EventHandler(this.listBox_Wst_SelectedIndexChanged);
            // 
            // label_Wst
            // 
            this.label_Wst.AutoSize = true;
            this.label_Wst.Location = new System.Drawing.Point(7, 15);
            this.label_Wst.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Wst.Name = "label_Wst";
            this.label_Wst.Size = new System.Drawing.Size(247, 25);
            this.label_Wst.TabIndex = 4;
            this.label_Wst.Text = "Werkstoff Wst (Auswahl)";
            // 
            // label_WstNr
            // 
            this.label_WstNr.AutoSize = true;
            this.label_WstNr.Location = new System.Drawing.Point(276, 112);
            this.label_WstNr.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_WstNr.Name = "label_WstNr";
            this.label_WstNr.Size = new System.Drawing.Size(252, 25);
            this.label_WstNr.TabIndex = 5;
            this.label_WstNr.Text = "Werkstoffnummer Wst-Nr";
            // 
            // Form_feldwerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 359);
            this.Controls.Add(this.label_WstNr);
            this.Controls.Add(this.label_Wst);
            this.Controls.Add(this.listBox_Wst);
            this.Controls.Add(this.textBox_WstNr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form_feldwerte";
            this.Text = "Aufzählung";
            this.Load += new System.EventHandler(this.Form_feldwerte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_WstNr;
        private System.Windows.Forms.ListBox listBox_Wst;
        private System.Windows.Forms.Label label_Wst;
        private System.Windows.Forms.Label label_WstNr;
    }
}

