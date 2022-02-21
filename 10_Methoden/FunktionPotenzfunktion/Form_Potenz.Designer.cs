namespace methoden
{
    partial class Form_Funktion
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
            this.button_OK = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(19, 101);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(238, 57);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(14, 9);
            this.label_x.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(29, 25);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "x:";
            this.label_x.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(14, 58);
            this.label_y.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(29, 25);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "y:";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(14, 173);
            this.label_z.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(29, 25);
            this.label_z.TabIndex = 3;
            this.label_z.Text = "z:";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_x.Location = new System.Drawing.Point(77, 9);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(180, 31);
            this.textBox_x.TabIndex = 4;
            this.textBox_x.Text = "5,3";
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_y.Location = new System.Drawing.Point(77, 58);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(180, 31);
            this.textBox_y.TabIndex = 5;
            this.textBox_y.Text = "0,9";
            // 
            // textBox_z
            // 
            this.textBox_z.BackColor = System.Drawing.Color.Silver;
            this.textBox_z.Location = new System.Drawing.Point(77, 170);
            this.textBox_z.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(180, 31);
            this.textBox_z.TabIndex = 6;
            // 
            // Form_Funktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 217);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_Funktion";
            this.Text = "Funktionsaufruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
    }
}

