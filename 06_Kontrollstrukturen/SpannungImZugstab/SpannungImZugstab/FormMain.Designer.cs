namespace SpannungImZugstab
{
    partial class Form_SpannungImZugstab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SpannungImZugstab));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_MeSigmma = new System.Windows.Forms.Label();
            this.labelMed = new System.Windows.Forms.Label();
            this.label_MeF = new System.Windows.Forms.Label();
            this.textBox_Sigma = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.panel_Bild = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.Location = new System.Drawing.Point(224, 157);
            this.button_OK.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(150, 56);
            this.button_OK.TabIndex = 13;
            this.button_OK.Text = "OK";
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_MeSigmma
            // 
            this.label_MeSigmma.AutoSize = true;
            this.label_MeSigmma.Location = new System.Drawing.Point(388, 236);
            this.label_MeSigmma.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_MeSigmma.Name = "label_MeSigmma";
            this.label_MeSigmma.Size = new System.Drawing.Size(66, 24);
            this.label_MeSigmma.TabIndex = 12;
            this.label_MeSigmma.Text = "N/mm²";
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(388, 118);
            this.labelMed.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(42, 24);
            this.labelMed.TabIndex = 11;
            this.labelMed.Text = "mm";
            // 
            // label_MeF
            // 
            this.label_MeF.AutoSize = true;
            this.label_MeF.Location = new System.Drawing.Point(388, 25);
            this.label_MeF.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_MeF.Name = "label_MeF";
            this.label_MeF.Size = new System.Drawing.Size(24, 24);
            this.label_MeF.TabIndex = 10;
            this.label_MeF.Text = "N";
            // 
            // textBox_Sigma
            // 
            this.textBox_Sigma.BackColor = System.Drawing.Color.Silver;
            this.textBox_Sigma.Location = new System.Drawing.Point(224, 228);
            this.textBox_Sigma.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox_Sigma.Name = "textBox_Sigma";
            this.textBox_Sigma.Size = new System.Drawing.Size(150, 29);
            this.textBox_Sigma.TabIndex = 9;
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_d.Location = new System.Drawing.Point(224, 110);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(150, 29);
            this.textBox_d.TabIndex = 8;
            this.textBox_d.Text = "10";
            // 
            // textBox_F
            // 
            this.textBox_F.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_F.Location = new System.Drawing.Point(224, 17);
            this.textBox_F.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(150, 29);
            this.textBox_F.TabIndex = 7;
            this.textBox_F.Text = "1000";
            // 
            // panel_Bild
            // 
            this.panel_Bild.BackgroundImage = global::SpannungImZugstab.Properties.Resources.SpannungImZugstab300DPI;
            this.panel_Bild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Bild.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Bild.Location = new System.Drawing.Point(0, 0);
            this.panel_Bild.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bild.Name = "panel_Bild";
            this.panel_Bild.Size = new System.Drawing.Size(198, 386);
            this.panel_Bild.TabIndex = 14;
            // 
            // Form_SpannungImZugstab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(463, 386);
            this.Controls.Add(this.panel_Bild);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_MeSigmma);
            this.Controls.Add(this.labelMed);
            this.Controls.Add(this.label_MeF);
            this.Controls.Add(this.textBox_Sigma);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_F);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form_SpannungImZugstab";
            this.Text = "Spannung im Zugstab";
            this.Load += new System.EventHandler(this.Form_SpannungImZugstab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_MeSigmma;
        private System.Windows.Forms.Label labelMed;
        private System.Windows.Forms.Label label_MeF;
        private System.Windows.Forms.TextBox textBox_Sigma;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.Panel panel_Bild;

    }
}

