namespace Diagrammvorlage
{
    partial class Form_Diagrammvorlage
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
            this.button_Diagrammvorlage = new System.Windows.Forms.Button();
            this.label_Abzisse = new System.Windows.Forms.Label();
            this.label_Ordinate = new System.Windows.Forms.Label();
            this.textBox_Abzisse = new System.Windows.Forms.TextBox();
            this.textBox_Ordinate = new System.Windows.Forms.TextBox();
            this.panel_diagramm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_Diagrammvorlage
            // 
            this.button_Diagrammvorlage.Location = new System.Drawing.Point(20, 96);
            this.button_Diagrammvorlage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Diagrammvorlage.Name = "button_Diagrammvorlage";
            this.button_Diagrammvorlage.Size = new System.Drawing.Size(462, 52);
            this.button_Diagrammvorlage.TabIndex = 0;
            this.button_Diagrammvorlage.Text = "Diagrammvorlage erstellen";
            this.button_Diagrammvorlage.UseVisualStyleBackColor = true;
            this.button_Diagrammvorlage.Click += new System.EventHandler(this.button_Diagrammvorlage_Click);
            // 
            // label_Abzisse
            // 
            this.label_Abzisse.AutoSize = true;
            this.label_Abzisse.Location = new System.Drawing.Point(15, 17);
            this.label_Abzisse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Abzisse.Name = "label_Abzisse";
            this.label_Abzisse.Size = new System.Drawing.Size(88, 25);
            this.label_Abzisse.TabIndex = 1;
            this.label_Abzisse.Text = "Abzisse";
            // 
            // label_Ordinate
            // 
            this.label_Ordinate.AutoSize = true;
            this.label_Ordinate.Location = new System.Drawing.Point(15, 53);
            this.label_Ordinate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Ordinate.Name = "label_Ordinate";
            this.label_Ordinate.Size = new System.Drawing.Size(94, 25);
            this.label_Ordinate.TabIndex = 2;
            this.label_Ordinate.Text = "Ordinate";
            // 
            // textBox_Abzisse
            // 
            this.textBox_Abzisse.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_Abzisse.Location = new System.Drawing.Point(128, 15);
            this.textBox_Abzisse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Abzisse.Name = "textBox_Abzisse";
            this.textBox_Abzisse.Size = new System.Drawing.Size(354, 31);
            this.textBox_Abzisse.TabIndex = 3;
            this.textBox_Abzisse.Text = "z-Koordinate";
            // 
            // textBox_Ordinate
            // 
            this.textBox_Ordinate.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_Ordinate.Location = new System.Drawing.Point(128, 53);
            this.textBox_Ordinate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Ordinate.Name = "textBox_Ordinate";
            this.textBox_Ordinate.Size = new System.Drawing.Size(354, 31);
            this.textBox_Ordinate.TabIndex = 4;
            this.textBox_Ordinate.Text = "Biegemoment Mb";
            // 
            // panel_diagramm
            // 
            this.panel_diagramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_diagramm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_diagramm.Location = new System.Drawing.Point(0, 171);
            this.panel_diagramm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_diagramm.Name = "panel_diagramm";
            this.panel_diagramm.Size = new System.Drawing.Size(498, 274);
            this.panel_diagramm.TabIndex = 5;
            // 
            // Form_Diagrammvorlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 445);
            this.Controls.Add(this.panel_diagramm);
            this.Controls.Add(this.textBox_Ordinate);
            this.Controls.Add(this.textBox_Abzisse);
            this.Controls.Add(this.label_Ordinate);
            this.Controls.Add(this.label_Abzisse);
            this.Controls.Add(this.button_Diagrammvorlage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Diagrammvorlage";
            this.Text = "Diagrammvorlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Diagrammvorlage;
        private System.Windows.Forms.Label label_Abzisse;
        private System.Windows.Forms.Label label_Ordinate;
        private System.Windows.Forms.TextBox textBox_Abzisse;
        private System.Windows.Forms.TextBox textBox_Ordinate;
        private System.Windows.Forms.Panel panel_diagramm;
    }
}

