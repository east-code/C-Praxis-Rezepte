namespace MinimumVonDreiZahlen
{
    partial class Form_Main
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
      this.textBox_z1 = new System.Windows.Forms.TextBox();
      this.textBox_z2 = new System.Windows.Forms.TextBox();
      this.textBox_z3 = new System.Windows.Forms.TextBox();
      this.textBox_zMin = new System.Windows.Forms.TextBox();
      this.label_z1 = new System.Windows.Forms.Label();
      this.label_z2 = new System.Windows.Forms.Label();
      this.label_z3 = new System.Windows.Forms.Label();
      this.label_zMin = new System.Windows.Forms.Label();
      this.button_OK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_z1
      // 
      this.textBox_z1.BackColor = System.Drawing.Color.LightSteelBlue;
      this.textBox_z1.Location = new System.Drawing.Point(155, 15);
      this.textBox_z1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.textBox_z1.Name = "textBox_z1";
      this.textBox_z1.Size = new System.Drawing.Size(190, 30);
      this.textBox_z1.TabIndex = 0;
      // 
      // textBox_z2
      // 
      this.textBox_z2.BackColor = System.Drawing.Color.LightSteelBlue;
      this.textBox_z2.Location = new System.Drawing.Point(155, 57);
      this.textBox_z2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.textBox_z2.Name = "textBox_z2";
      this.textBox_z2.Size = new System.Drawing.Size(190, 30);
      this.textBox_z2.TabIndex = 1;
      // 
      // textBox_z3
      // 
      this.textBox_z3.BackColor = System.Drawing.Color.LightSteelBlue;
      this.textBox_z3.Location = new System.Drawing.Point(155, 99);
      this.textBox_z3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.textBox_z3.Name = "textBox_z3";
      this.textBox_z3.Size = new System.Drawing.Size(190, 30);
      this.textBox_z3.TabIndex = 2;
      // 
      // textBox_zMin
      // 
      this.textBox_zMin.BackColor = System.Drawing.Color.Silver;
      this.textBox_zMin.Location = new System.Drawing.Point(155, 199);
      this.textBox_zMin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.textBox_zMin.Name = "textBox_zMin";
      this.textBox_zMin.Size = new System.Drawing.Size(190, 30);
      this.textBox_zMin.TabIndex = 3;
      // 
      // label_z1
      // 
      this.label_z1.AutoSize = true;
      this.label_z1.Location = new System.Drawing.Point(57, 22);
      this.label_z1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_z1.Name = "label_z1";
      this.label_z1.Size = new System.Drawing.Size(30, 23);
      this.label_z1.TabIndex = 4;
      this.label_z1.Text = "z1";
      // 
      // label_z2
      // 
      this.label_z2.AutoSize = true;
      this.label_z2.Location = new System.Drawing.Point(57, 64);
      this.label_z2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_z2.Name = "label_z2";
      this.label_z2.Size = new System.Drawing.Size(30, 23);
      this.label_z2.TabIndex = 5;
      this.label_z2.Text = "z2";
      // 
      // label_z3
      // 
      this.label_z3.AutoSize = true;
      this.label_z3.Location = new System.Drawing.Point(57, 106);
      this.label_z3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_z3.Name = "label_z3";
      this.label_z3.Size = new System.Drawing.Size(30, 23);
      this.label_z3.TabIndex = 6;
      this.label_z3.Text = "z3";
      // 
      // label_zMin
      // 
      this.label_zMin.AutoSize = true;
      this.label_zMin.Location = new System.Drawing.Point(57, 206);
      this.label_zMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label_zMin.Name = "label_zMin";
      this.label_zMin.Size = new System.Drawing.Size(50, 23);
      this.label_zMin.TabIndex = 7;
      this.label_zMin.Text = "zMin";
      // 
      // button_OK
      // 
      this.button_OK.Location = new System.Drawing.Point(61, 141);
      this.button_OK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(284, 46);
      this.button_OK.TabIndex = 8;
      this.button_OK.Text = "OK";
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
      // 
      // Form_Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 256);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.label_zMin);
      this.Controls.Add(this.label_z3);
      this.Controls.Add(this.label_z2);
      this.Controls.Add(this.label_z1);
      this.Controls.Add(this.textBox_zMin);
      this.Controls.Add(this.textBox_z3);
      this.Controls.Add(this.textBox_z2);
      this.Controls.Add(this.textBox_z1);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Form_Main";
      this.Text = "Minimum von drei Zahlen";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_z1;
        private System.Windows.Forms.TextBox textBox_z2;
        private System.Windows.Forms.TextBox textBox_z3;
        private System.Windows.Forms.TextBox textBox_zMin;
        private System.Windows.Forms.Label label_z1;
        private System.Windows.Forms.Label label_z2;
        private System.Windows.Forms.Label label_z3;
        private System.Windows.Forms.Label label_zMin;
        private System.Windows.Forms.Button button_OK;
    }
}

