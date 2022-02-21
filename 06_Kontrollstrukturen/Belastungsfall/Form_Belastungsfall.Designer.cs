namespace Belastungsfall
{
    partial class Form_Belastungsfall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Belastungsfall));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_Re = new System.Windows.Forms.Label();
            this.label_Belastungsfall = new System.Windows.Forms.Label();
            this.label_sigZul = new System.Windows.Forms.Label();
            this.label_tauZul = new System.Windows.Forms.Label();
            this.textBox_Re = new System.Windows.Forms.TextBox();
            this.textBox_sigZul = new System.Windows.Forms.TextBox();
            this.textBox_tauZul = new System.Windows.Forms.TextBox();
            this.comboBox_BF = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.Location = new System.Drawing.Point(37, 114);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(559, 75);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_Re
            // 
            this.label_Re.AutoSize = true;
            this.label_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Re.Location = new System.Drawing.Point(51, 33);
            this.label_Re.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Re.Name = "label_Re";
            this.label_Re.Size = new System.Drawing.Size(231, 24);
            this.label_Re.TabIndex = 1;
            this.label_Re.Text = "Streckgrenze Re in N/mm²";
            // 
            // label_Belastungsfall
            // 
            this.label_Belastungsfall.AutoSize = true;
            this.label_Belastungsfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Belastungsfall.Location = new System.Drawing.Point(129, 75);
            this.label_Belastungsfall.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Belastungsfall.Name = "label_Belastungsfall";
            this.label_Belastungsfall.Size = new System.Drawing.Size(153, 24);
            this.label_Belastungsfall.TabIndex = 2;
            this.label_Belastungsfall.Text = "Belastungsfall BF";
            // 
            // label_sigZul
            // 
            this.label_sigZul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_sigZul.Image = ((System.Drawing.Image)(resources.GetObject("label_sigZul.Image")));
            this.label_sigZul.Location = new System.Drawing.Point(55, 214);
            this.label_sigZul.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_sigZul.Name = "label_sigZul";
            this.label_sigZul.Size = new System.Drawing.Size(227, 101);
            this.label_sigZul.TabIndex = 3;
            this.label_sigZul.Text = "zulässige Biegespannung";
            this.label_sigZul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_sigZul.Click += new System.EventHandler(this.label_SigZul_Click);
            // 
            // label_tauZul
            // 
            this.label_tauZul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_tauZul.Image = ((System.Drawing.Image)(resources.GetObject("label_tauZul.Image")));
            this.label_tauZul.Location = new System.Drawing.Point(52, 315);
            this.label_tauZul.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_tauZul.Name = "label_tauZul";
            this.label_tauZul.Size = new System.Drawing.Size(230, 107);
            this.label_tauZul.TabIndex = 4;
            this.label_tauZul.Text = "zulässige Scherspannung";
            // 
            // textBox_Re
            // 
            this.textBox_Re.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_Re.Location = new System.Drawing.Point(324, 33);
            this.textBox_Re.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_Re.Name = "textBox_Re";
            this.textBox_Re.Size = new System.Drawing.Size(272, 29);
            this.textBox_Re.TabIndex = 5;
            // 
            // textBox_sigZul
            // 
            this.textBox_sigZul.BackColor = System.Drawing.Color.Silver;
            this.textBox_sigZul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_sigZul.Location = new System.Drawing.Point(324, 211);
            this.textBox_sigZul.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_sigZul.Name = "textBox_sigZul";
            this.textBox_sigZul.Size = new System.Drawing.Size(272, 29);
            this.textBox_sigZul.TabIndex = 6;
            // 
            // textBox_tauZul
            // 
            this.textBox_tauZul.BackColor = System.Drawing.Color.Silver;
            this.textBox_tauZul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_tauZul.Location = new System.Drawing.Point(324, 315);
            this.textBox_tauZul.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_tauZul.Name = "textBox_tauZul";
            this.textBox_tauZul.Size = new System.Drawing.Size(272, 29);
            this.textBox_tauZul.TabIndex = 7;
            // 
            // comboBox_BF
            // 
            this.comboBox_BF.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBox_BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox_BF.FormattingEnabled = true;
            this.comboBox_BF.Items.AddRange(new object[] {
            "ruhend",
            "schwellend",
            "wechselnd"});
            this.comboBox_BF.Location = new System.Drawing.Point(324, 72);
            this.comboBox_BF.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox_BF.Name = "comboBox_BF";
            this.comboBox_BF.Size = new System.Drawing.Size(272, 32);
            this.comboBox_BF.TabIndex = 9;
            this.comboBox_BF.Text = "ruhend";
            // 
            // Form_Belastungsfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 423);
            this.Controls.Add(this.comboBox_BF);
            this.Controls.Add(this.textBox_tauZul);
            this.Controls.Add(this.textBox_sigZul);
            this.Controls.Add(this.textBox_Re);
            this.Controls.Add(this.label_tauZul);
            this.Controls.Add(this.label_sigZul);
            this.Controls.Add(this.label_Belastungsfall);
            this.Controls.Add(this.label_Re);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Belastungsfall";
            this.Text = "Belastungsfall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_Re;
        private System.Windows.Forms.Label label_Belastungsfall;
        private System.Windows.Forms.Label label_sigZul;
        private System.Windows.Forms.Label label_tauZul;
        private System.Windows.Forms.TextBox textBox_Re;
        private System.Windows.Forms.TextBox textBox_sigZul;
        private System.Windows.Forms.TextBox textBox_tauZul;
        private System.Windows.Forms.ComboBox comboBox_BF;
    }
}

