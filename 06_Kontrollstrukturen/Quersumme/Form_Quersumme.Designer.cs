namespace Quersumme
{
    partial class Form_Quersumme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Quersumme));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_n = new System.Windows.Forms.Label();
            this.label_qs = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_qs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.Location = new System.Drawing.Point(21, 58);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(359, 82);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(16, 23);
            this.label_n.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(172, 25);
            this.label_n.TabIndex = 1;
            this.label_n.Text = "natürliche Zahl n";
            // 
            // label_qs
            // 
            this.label_qs.AutoSize = true;
            this.label_qs.Location = new System.Drawing.Point(16, 154);
            this.label_qs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_qs.Name = "label_qs";
            this.label_qs.Size = new System.Drawing.Size(157, 25);
            this.label_qs.TabIndex = 2;
            this.label_qs.Text = "Quersumme qs";
            // 
            // textBox_n
            // 
            this.textBox_n.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_n.Location = new System.Drawing.Point(212, 17);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(168, 31);
            this.textBox_n.TabIndex = 3;
            // 
            // textBox_qs
            // 
            this.textBox_qs.BackColor = System.Drawing.Color.Silver;
            this.textBox_qs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qs.Location = new System.Drawing.Point(212, 154);
            this.textBox_qs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_qs.Name = "textBox_qs";
            this.textBox_qs.Size = new System.Drawing.Size(168, 31);
            this.textBox_qs.TabIndex = 4;
            // 
            // Form_Quersumme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 207);
            this.Controls.Add(this.textBox_qs);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label_qs);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Quersumme";
            this.Text = "Quersumme einer natürlichen Zahl n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_qs;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_qs;
    }
}

