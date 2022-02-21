namespace Reihe_e
{
    partial class Form_Reihe_e
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reihe_e));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_deZul = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.textBox_deZul = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(13, 89);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(440, 69);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_deZul
            // 
            this.label_deZul.AutoSize = true;
            this.label_deZul.Location = new System.Drawing.Point(23, 19);
            this.label_deZul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deZul.Name = "label_deZul";
            this.label_deZul.Size = new System.Drawing.Size(286, 25);
            this.label_deZul.TabIndex = 1;
            this.label_deZul.Text = "zulässige Abweichung deZul";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(23, 181);
            this.label_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(174, 25);
            this.label_e.TabIndex = 2;
            this.label_e.Text = "Eulersche Zahl e";
            // 
            // textBox_deZul
            // 
            this.textBox_deZul.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_deZul.Location = new System.Drawing.Point(13, 50);
            this.textBox_deZul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_deZul.Name = "textBox_deZul";
            this.textBox_deZul.Size = new System.Drawing.Size(440, 31);
            this.textBox_deZul.TabIndex = 3;
            // 
            // textBox_e
            // 
            this.textBox_e.BackColor = System.Drawing.Color.Silver;
            this.textBox_e.Location = new System.Drawing.Point(13, 214);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(440, 31);
            this.textBox_e.TabIndex = 4;
            // 
            // Form_Reihe_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.textBox_deZul);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label_deZul);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Reihe_e";
            this.Text = "Reihe e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_deZul;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.TextBox textBox_deZul;
        private System.Windows.Forms.TextBox textBox_e;
    }
}

