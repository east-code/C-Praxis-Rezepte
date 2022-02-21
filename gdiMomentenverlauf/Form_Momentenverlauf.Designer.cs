namespace Momentenverlauf
{
    partial class Form_Momentenverlauf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Momentenverlauf));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_l = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.textBox_l = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.panel_BildTraeger = new System.Windows.Forms.Panel();
            this.panel_diagramm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(471, 306);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(248, 74);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_l
            // 
            this.label_l.AutoSize = true;
            this.label_l.Location = new System.Drawing.Point(9, 312);
            this.label_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(250, 25);
            this.label_l.TabIndex = 1;
            this.label_l.Text = "Länge des Trägers l in m";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Location = new System.Drawing.Point(9, 355);
            this.label_q.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(241, 25);
            this.label_q.TabIndex = 2;
            this.label_q.Text = "Streckenlast q(z) in N/m";
            // 
            // textBox_l
            // 
            this.textBox_l.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_l.Location = new System.Drawing.Point(269, 306);
            this.textBox_l.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_l.Name = "textBox_l";
            this.textBox_l.Size = new System.Drawing.Size(180, 31);
            this.textBox_l.TabIndex = 3;
            this.textBox_l.Text = "2";
            // 
            // textBox_q
            // 
            this.textBox_q.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_q.Location = new System.Drawing.Point(269, 349);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(180, 31);
            this.textBox_q.TabIndex = 4;
            this.textBox_q.Text = "100";
            // 
            // panel_BildTraeger
            // 
            this.panel_BildTraeger.BackColor = System.Drawing.SystemColors.Window;
            this.panel_BildTraeger.BackgroundImage = global::Momentenverlauf.Properties.Resources.EingespannterTrägerOnly200dpi;
            this.panel_BildTraeger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_BildTraeger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BildTraeger.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BildTraeger.Location = new System.Drawing.Point(0, 0);
            this.panel_BildTraeger.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel_BildTraeger.Name = "panel_BildTraeger";
            this.panel_BildTraeger.Size = new System.Drawing.Size(733, 284);
            this.panel_BildTraeger.TabIndex = 6;
            // 
            // panel_diagramm
            // 
            this.panel_diagramm.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_diagramm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_diagramm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_diagramm.Location = new System.Drawing.Point(0, 394);
            this.panel_diagramm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel_diagramm.Name = "panel_diagramm";
            this.panel_diagramm.Size = new System.Drawing.Size(733, 370);
            this.panel_diagramm.TabIndex = 7;
            this.panel_diagramm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Dag_Paint);
            this.panel_diagramm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Dag_MouseClick);
            // 
            // Form_Momentenverlauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 764);
            this.Controls.Add(this.panel_diagramm);
            this.Controls.Add(this.panel_BildTraeger);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_l);
            this.Controls.Add(this.label_q);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_Momentenverlauf";
            this.Text = "Momentenverlauf: Eingespannter Träger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.TextBox textBox_l;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Panel panel_BildTraeger;
        private System.Windows.Forms.Panel panel_diagramm;
    }
}

