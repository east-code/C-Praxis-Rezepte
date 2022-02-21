namespace MinimumVonZahlen
{
    partial class FormMinimum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinimum));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(192, 13);
            this.button_OK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(101, 160);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(31, 19);
            this.label_a.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(30, 25);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "a:";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(30, 62);
            this.label_b.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(30, 25);
            this.label_b.TabIndex = 2;
            this.label_b.Text = "b:";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(31, 105);
            this.label_c.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(29, 25);
            this.label_c.TabIndex = 3;
            this.label_c.Text = "c:";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(30, 148);
            this.label_d.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(30, 25);
            this.label_d.TabIndex = 4;
            this.label_d.Text = "d:";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(310, 71);
            this.label_min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(98, 25);
            this.label_min.TabIndex = 5;
            this.label_min.Text = "Minimum";
            // 
            // textBox_a
            // 
            this.textBox_a.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_a.Location = new System.Drawing.Point(82, 13);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(98, 31);
            this.textBox_a.TabIndex = 6;
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_b.Location = new System.Drawing.Point(82, 56);
            this.textBox_b.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(98, 31);
            this.textBox_b.TabIndex = 7;
            // 
            // textBox_c
            // 
            this.textBox_c.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_c.Location = new System.Drawing.Point(82, 99);
            this.textBox_c.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(98, 31);
            this.textBox_c.TabIndex = 8;
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_d.Location = new System.Drawing.Point(82, 142);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(98, 31);
            this.textBox_d.TabIndex = 9;
            // 
            // textBox_min
            // 
            this.textBox_min.BackColor = System.Drawing.Color.Silver;
            this.textBox_min.Location = new System.Drawing.Point(305, 102);
            this.textBox_min.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(103, 31);
            this.textBox_min.TabIndex = 10;
            // 
            // FormMinimum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 189);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMinimum";
            this.Text = "Minimum von Zahlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_min;
    }
}

