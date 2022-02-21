namespace Mittelwert
{
    partial class Form_Mittelwert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mittelwert));
            this.label_x = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_xm = new System.Windows.Forms.Label();
            this.textBox_xm = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(14, 9);
            this.label_x.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(75, 24);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "Werte x";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_x.Location = new System.Drawing.Point(14, 38);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_x.Multiline = true;
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_x.Size = new System.Drawing.Size(223, 255);
            this.textBox_x.TabIndex = 3;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            // 
            // label_xm
            // 
            this.label_xm.AutoSize = true;
            this.label_xm.Location = new System.Drawing.Point(269, 235);
            this.label_xm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_xm.Name = "label_xm";
            this.label_xm.Size = new System.Drawing.Size(119, 24);
            this.label_xm.TabIndex = 4;
            this.label_xm.Text = "Mittelwert xm";
            // 
            // textBox_xm
            // 
            this.textBox_xm.BackColor = System.Drawing.Color.Silver;
            this.textBox_xm.Location = new System.Drawing.Point(273, 264);
            this.textBox_xm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_xm.Name = "textBox_xm";
            this.textBox_xm.Size = new System.Drawing.Size(231, 29);
            this.textBox_xm.TabIndex = 5;
            // 
            // button_ok
            // 
            this.button_ok.Image = ((System.Drawing.Image)(resources.GetObject("button_ok.Image")));
            this.button_ok.Location = new System.Drawing.Point(273, 38);
            this.button_ok.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(231, 80);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form_Mittelwert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 310);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_xm);
            this.Controls.Add(this.label_xm);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_x);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Mittelwert";
            this.Text = "Arithmetischer Mittelwert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_xm;
        private System.Windows.Forms.TextBox textBox_xm;
        private System.Windows.Forms.Button button_ok;
    }
}

