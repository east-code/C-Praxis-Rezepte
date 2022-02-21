namespace LambdaExpression
{
    partial class Form_Polygon
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
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.button_polygon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_x.Location = new System.Drawing.Point(15, 40);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(117, 31);
            this.textBox_x.TabIndex = 0;
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.Silver;
            this.textBox_y.Location = new System.Drawing.Point(387, 40);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(112, 31);
            this.textBox_y.TabIndex = 1;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(15, 9);
            this.label_x.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(29, 25);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "x:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(387, 9);
            this.label_y.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(29, 25);
            this.label_y.TabIndex = 3;
            this.label_y.Text = "y:";
            // 
            // button_polygon
            // 
            this.button_polygon.Location = new System.Drawing.Point(144, 9);
            this.button_polygon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_polygon.Name = "button_polygon";
            this.button_polygon.Size = new System.Drawing.Size(231, 62);
            this.button_polygon.TabIndex = 4;
            this.button_polygon.Text = "y = 5 + 2 * x + 0,5 * x²";
            this.button_polygon.UseVisualStyleBackColor = true;
            this.button_polygon.Click += new System.EventHandler(this.button_polygon_Click);
            // 
            // Form_Polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 98);
            this.Controls.Add(this.button_polygon);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Polygon";
            this.Text = "Lambda Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Button button_polygon;
    }
}

