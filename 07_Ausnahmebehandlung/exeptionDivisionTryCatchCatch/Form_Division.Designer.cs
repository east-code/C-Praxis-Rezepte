namespace exeptionDivision
{
    partial class Form_Division
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
            this.button_division = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.textBox_Hinweis = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(37, 106);
            this.button_division.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(330, 58);
            this.button_division.TabIndex = 0;
            this.button_division.Text = "Division";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // textBox_a
            // 
            this.textBox_a.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_a.Location = new System.Drawing.Point(187, 16);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(180, 31);
            this.textBox_a.TabIndex = 1;
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_b.Location = new System.Drawing.Point(187, 61);
            this.textBox_b.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(180, 31);
            this.textBox_b.TabIndex = 2;
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.Silver;
            this.textBox_x.Location = new System.Drawing.Point(187, 192);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(180, 31);
            this.textBox_x.TabIndex = 3;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(32, 22);
            this.label_a.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(114, 25);
            this.label_a.TabIndex = 4;
            this.label_a.Text = "Dividend a";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(50, 67);
            this.label_b.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(96, 25);
            this.label_b.TabIndex = 5;
            this.label_b.Text = "Divisor b";
            // 
            // textBox_Hinweis
            // 
            this.textBox_Hinweis.BackColor = System.Drawing.Color.Silver;
            this.textBox_Hinweis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Hinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox_Hinweis.ForeColor = System.Drawing.Color.Maroon;
            this.textBox_Hinweis.Location = new System.Drawing.Point(0, 258);
            this.textBox_Hinweis.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBox_Hinweis.Name = "textBox_Hinweis";
            this.textBox_Hinweis.Size = new System.Drawing.Size(577, 31);
            this.textBox_Hinweis.TabIndex = 7;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(36, 192);
            this.label_x.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(110, 25);
            this.label_x.TabIndex = 8;
            this.label_x.Text = "Quotient x";
            this.label_x.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 289);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_Hinweis);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.button_division);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form_Division";
            this.Text = "Division - exception handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox textBox_Hinweis;
        private System.Windows.Forms.Label label_x;
    }
}

