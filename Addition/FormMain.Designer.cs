namespace Addition
{
    partial class Form_Addition
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
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.button_addition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_x.Location = new System.Drawing.Point(66, 37);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(248, 29);
            this.textBox_x.TabIndex = 0;
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_y.Location = new System.Drawing.Point(66, 83);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(248, 29);
            this.textBox_y.TabIndex = 1;
            // 
            // textBox_z
            // 
            this.textBox_z.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_z.Location = new System.Drawing.Point(66, 244);
            this.textBox_z.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(254, 29);
            this.textBox_z.TabIndex = 2;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.Location = new System.Drawing.Point(31, 40);
            this.label_x.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(25, 24);
            this.label_x.TabIndex = 3;
            this.label_x.Text = "x:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_y.Location = new System.Drawing.Point(32, 88);
            this.label_y.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(24, 24);
            this.label_y.TabIndex = 4;
            this.label_y.Text = "y:";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_z.Location = new System.Drawing.Point(32, 247);
            this.label_z.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(24, 24);
            this.label_z.TabIndex = 5;
            this.label_z.Text = "z:";
            // 
            // button_addition
            // 
            this.button_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addition.Location = new System.Drawing.Point(66, 130);
            this.button_addition.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(254, 82);
            this.button_addition.TabIndex = 6;
            this.button_addition.Text = "Addition +";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button_addition_Click);
            // 
            // Form_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 315);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form_Addition";
            this.Text = "Addition zweier Zahlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.Button button_addition;
    }
}

