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
            this.label_zDoubleHochDouble = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_zDoubleHochDouble = new System.Windows.Forms.TextBox();
            this.textBox_zDoubleHochInt = new System.Windows.Forms.TextBox();
            this.label_zDoubleHochInt = new System.Windows.Forms.Label();
            this.textBox_Hinweis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(173, 15);
            this.button_OK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(133, 140);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(15, 53);
            this.label_x.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(29, 25);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "x:";
            this.label_x.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(15, 127);
            this.label_y.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(29, 25);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "y:";
            // 
            // label_zDoubleHochDouble
            // 
            this.label_zDoubleHochDouble.AutoSize = true;
            this.label_zDoubleHochDouble.Location = new System.Drawing.Point(341, 14);
            this.label_zDoubleHochDouble.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_zDoubleHochDouble.Name = "label_zDoubleHochDouble";
            this.label_zDoubleHochDouble.Size = new System.Drawing.Size(232, 25);
            this.label_zDoubleHochDouble.TabIndex = 3;
            this.label_zDoubleHochDouble.Text = "z (double hoch double)";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_x.Location = new System.Drawing.Point(56, 47);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(105, 31);
            this.textBox_x.TabIndex = 4;
            this.textBox_x.Text = "5,3";
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_y.Location = new System.Drawing.Point(56, 124);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(105, 31);
            this.textBox_y.TabIndex = 5;
            this.textBox_y.Text = "0,9";
            // 
            // textBox_zDoubleHochDouble
            // 
            this.textBox_zDoubleHochDouble.BackColor = System.Drawing.Color.Silver;
            this.textBox_zDoubleHochDouble.Location = new System.Drawing.Point(335, 47);
            this.textBox_zDoubleHochDouble.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_zDoubleHochDouble.Name = "textBox_zDoubleHochDouble";
            this.textBox_zDoubleHochDouble.Size = new System.Drawing.Size(238, 31);
            this.textBox_zDoubleHochDouble.TabIndex = 6;
            // 
            // textBox_zDoubleHochInt
            // 
            this.textBox_zDoubleHochInt.BackColor = System.Drawing.Color.Silver;
            this.textBox_zDoubleHochInt.Location = new System.Drawing.Point(335, 124);
            this.textBox_zDoubleHochInt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_zDoubleHochInt.Name = "textBox_zDoubleHochInt";
            this.textBox_zDoubleHochInt.Size = new System.Drawing.Size(238, 31);
            this.textBox_zDoubleHochInt.TabIndex = 7;
            // 
            // label_zDoubleHochInt
            // 
            this.label_zDoubleHochInt.AutoSize = true;
            this.label_zDoubleHochInt.Location = new System.Drawing.Point(341, 93);
            this.label_zDoubleHochInt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_zDoubleHochInt.Name = "label_zDoubleHochInt";
            this.label_zDoubleHochInt.Size = new System.Drawing.Size(190, 25);
            this.label_zDoubleHochInt.TabIndex = 8;
            this.label_zDoubleHochInt.Text = "z (double hoch int)";
            // 
            // textBox_Hinweis
            // 
            this.textBox_Hinweis.BackColor = System.Drawing.Color.Silver;
            this.textBox_Hinweis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Hinweis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Hinweis.Location = new System.Drawing.Point(0, 211);
            this.textBox_Hinweis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Hinweis.Name = "textBox_Hinweis";
            this.textBox_Hinweis.Size = new System.Drawing.Size(586, 31);
            this.textBox_Hinweis.TabIndex = 9;
            // 
            // Form_Funktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 242);
            this.Controls.Add(this.textBox_Hinweis);
            this.Controls.Add(this.label_zDoubleHochInt);
            this.Controls.Add(this.textBox_zDoubleHochInt);
            this.Controls.Add(this.textBox_zDoubleHochDouble);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_zDoubleHochDouble);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Funktion";
            this.Text = "Funktionsaufruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_zDoubleHochDouble;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_zDoubleHochDouble;
        private System.Windows.Forms.TextBox textBox_zDoubleHochInt;
        private System.Windows.Forms.Label label_zDoubleHochInt;
        private System.Windows.Forms.TextBox textBox_Hinweis;
    }
}

