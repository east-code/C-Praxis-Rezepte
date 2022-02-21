namespace ohmascherWiderstand
{
    partial class Form_Widerstand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Widerstand));
            this.label_U = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label_I = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.textBox_U = new System.Windows.Forms.TextBox();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_I = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_U
            // 
            this.label_U.AutoSize = true;
            this.label_U.Location = new System.Drawing.Point(12, 18);
            this.label_U.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_U.Name = "label_U";
            this.label_U.Size = new System.Drawing.Size(174, 25);
            this.label_U.TabIndex = 0;
            this.label_U.Text = "Spannung U in V";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(14, 96);
            this.label_R.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(316, 25);
            this.label_R.TabIndex = 1;
            this.label_R.Text = "ohmscher Widerstand R in Ohm";
            // 
            // label_I
            // 
            this.label_I.AutoSize = true;
            this.label_I.Location = new System.Drawing.Point(519, 18);
            this.label_I.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_I.Name = "label_I";
            this.label_I.Size = new System.Drawing.Size(122, 25);
            this.label_I.TabIndex = 2;
            this.label_I.Text = "Strom I in A";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(519, 96);
            this.label_P.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(163, 25);
            this.label_P.TabIndex = 3;
            this.label_P.Text = "Leistung P in W";
            // 
            // textBox_U
            // 
            this.textBox_U.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_U.Location = new System.Drawing.Point(17, 49);
            this.textBox_U.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_U.Name = "textBox_U";
            this.textBox_U.Size = new System.Drawing.Size(279, 31);
            this.textBox_U.TabIndex = 5;
            // 
            // textBox_R
            // 
            this.textBox_R.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_R.Location = new System.Drawing.Point(17, 127);
            this.textBox_R.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(279, 31);
            this.textBox_R.TabIndex = 6;
            // 
            // textBox_I
            // 
            this.textBox_I.BackColor = System.Drawing.Color.Silver;
            this.textBox_I.Location = new System.Drawing.Point(524, 49);
            this.textBox_I.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_I.Name = "textBox_I";
            this.textBox_I.Size = new System.Drawing.Size(176, 31);
            this.textBox_I.TabIndex = 7;
            // 
            // textBox_P
            // 
            this.textBox_P.BackColor = System.Drawing.Color.Silver;
            this.textBox_P.Location = new System.Drawing.Point(524, 127);
            this.textBox_P.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(176, 31);
            this.textBox_P.TabIndex = 8;
            // 
            // textBox_error
            // 
            this.textBox_error.BackColor = System.Drawing.Color.Silver;
            this.textBox_error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_error.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_error.Location = new System.Drawing.Point(0, 183);
            this.textBox_error.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.Size = new System.Drawing.Size(726, 31);
            this.textBox_error.TabIndex = 9;
            this.textBox_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(349, 18);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(147, 140);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Widerstand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 214);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_error);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.textBox_I);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.textBox_U);
            this.Controls.Add(this.label_P);
            this.Controls.Add(this.label_I);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_U);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_Widerstand";
            this.Text = "ohmscher Widerstand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_U;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_I;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.TextBox textBox_U;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_I;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.Button button_OK;
    }
}

