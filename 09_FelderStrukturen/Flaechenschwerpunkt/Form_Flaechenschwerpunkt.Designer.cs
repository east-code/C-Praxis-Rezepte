namespace Flaechenschwerpunkt
{
    partial class Form_Flaechenschwerpunkt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Flaechenschwerpunkt));
            this.dataGridView_Schwerpkt = new System.Windows.Forms.DataGridView();
            this.Column_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Xs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Flächenschwerpunkte = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_Ages = new System.Windows.Forms.Label();
            this.label_Schwerpunkt = new System.Windows.Forms.Label();
            this.label_Xges = new System.Windows.Forms.Label();
            this.label_Yges = new System.Windows.Forms.Label();
            this.textBox_gesamtA = new System.Windows.Forms.TextBox();
            this.textBox_gesamtXs = new System.Windows.Forms.TextBox();
            this.textBox_gesamtYs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schwerpkt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Schwerpkt
            // 
            this.dataGridView_Schwerpkt.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView_Schwerpkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Schwerpkt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_A,
            this.Column_Xs,
            this.Column_Ys});
            this.dataGridView_Schwerpkt.Location = new System.Drawing.Point(15, 40);
            this.dataGridView_Schwerpkt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_Schwerpkt.Name = "dataGridView_Schwerpkt";
            this.dataGridView_Schwerpkt.RowTemplate.Height = 24;
            this.dataGridView_Schwerpkt.Size = new System.Drawing.Size(427, 406);
            this.dataGridView_Schwerpkt.TabIndex = 0;
            // 
            // Column_A
            // 
            this.Column_A.HeaderText = "Fläche A";
            this.Column_A.Name = "Column_A";
            this.Column_A.Width = 120;
            // 
            // Column_Xs
            // 
            this.Column_Xs.FillWeight = 120F;
            this.Column_Xs.HeaderText = "Koordinate X";
            this.Column_Xs.Name = "Column_Xs";
            this.Column_Xs.Width = 120;
            // 
            // Column_Ys
            // 
            this.Column_Ys.HeaderText = "Koordinate Y";
            this.Column_Ys.Name = "Column_Ys";
            this.Column_Ys.Width = 120;
            // 
            // label_Flächenschwerpunkte
            // 
            this.label_Flächenschwerpunkte.AutoSize = true;
            this.label_Flächenschwerpunkte.ForeColor = System.Drawing.Color.Blue;
            this.label_Flächenschwerpunkte.Location = new System.Drawing.Point(15, 9);
            this.label_Flächenschwerpunkte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Flächenschwerpunkte.Name = "label_Flächenschwerpunkte";
            this.label_Flächenschwerpunkte.Size = new System.Drawing.Size(382, 25);
            this.label_Flächenschwerpunkte.TabIndex = 1;
            this.label_Flächenschwerpunkte.Text = "Eingabe der Teilflächen-Schwerpunkte";
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(454, 40);
            this.button_OK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(244, 87);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_Ages
            // 
            this.label_Ages.AutoSize = true;
            this.label_Ages.Location = new System.Drawing.Point(472, 176);
            this.label_Ages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Ages.Name = "label_Ages";
            this.label_Ages.Size = new System.Drawing.Size(199, 25);
            this.label_Ages.TabIndex = 3;
            this.label_Ages.Text = "Gesamtfläche Ages";
            // 
            // label_Schwerpunkt
            // 
            this.label_Schwerpunkt.AutoSize = true;
            this.label_Schwerpunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Schwerpunkt.Location = new System.Drawing.Point(449, 274);
            this.label_Schwerpunkt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Schwerpunkt.Name = "label_Schwerpunkt";
            this.label_Schwerpunkt.Size = new System.Drawing.Size(249, 25);
            this.label_Schwerpunkt.TabIndex = 4;
            this.label_Schwerpunkt.Text = "Schwerpunktkoordinaten";
            // 
            // label_Xges
            // 
            this.label_Xges.AutoSize = true;
            this.label_Xges.Location = new System.Drawing.Point(472, 309);
            this.label_Xges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Xges.Name = "label_Xges";
            this.label_Xges.Size = new System.Drawing.Size(137, 25);
            this.label_Xges.TabIndex = 5;
            this.label_Xges.Text = "X-Koordinate";
            // 
            // label_Yges
            // 
            this.label_Yges.AutoSize = true;
            this.label_Yges.Location = new System.Drawing.Point(472, 384);
            this.label_Yges.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Yges.Name = "label_Yges";
            this.label_Yges.Size = new System.Drawing.Size(138, 25);
            this.label_Yges.TabIndex = 6;
            this.label_Yges.Text = "Y-Koordinate";
            // 
            // textBox_gesamtA
            // 
            this.textBox_gesamtA.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtA.Location = new System.Drawing.Point(477, 217);
            this.textBox_gesamtA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_gesamtA.Name = "textBox_gesamtA";
            this.textBox_gesamtA.Size = new System.Drawing.Size(193, 31);
            this.textBox_gesamtA.TabIndex = 7;
            // 
            // textBox_gesamtXs
            // 
            this.textBox_gesamtXs.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtXs.Location = new System.Drawing.Point(465, 340);
            this.textBox_gesamtXs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_gesamtXs.Name = "textBox_gesamtXs";
            this.textBox_gesamtXs.Size = new System.Drawing.Size(180, 31);
            this.textBox_gesamtXs.TabIndex = 8;
            // 
            // textBox_gesamtYs
            // 
            this.textBox_gesamtYs.BackColor = System.Drawing.Color.Silver;
            this.textBox_gesamtYs.Location = new System.Drawing.Point(465, 415);
            this.textBox_gesamtYs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_gesamtYs.Name = "textBox_gesamtYs";
            this.textBox_gesamtYs.Size = new System.Drawing.Size(180, 31);
            this.textBox_gesamtYs.TabIndex = 9;
            // 
            // Form_Flaechenschwerpunkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 459);
            this.Controls.Add(this.textBox_gesamtYs);
            this.Controls.Add(this.textBox_gesamtXs);
            this.Controls.Add(this.textBox_gesamtA);
            this.Controls.Add(this.label_Yges);
            this.Controls.Add(this.label_Xges);
            this.Controls.Add(this.label_Schwerpunkt);
            this.Controls.Add(this.label_Ages);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Flächenschwerpunkte);
            this.Controls.Add(this.dataGridView_Schwerpkt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Flaechenschwerpunkt";
            this.Text = "Flächenschwerpunkt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schwerpkt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Schwerpkt;
        private System.Windows.Forms.Label label_Flächenschwerpunkte;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_Ages;
        private System.Windows.Forms.Label label_Schwerpunkt;
        private System.Windows.Forms.Label label_Xges;
        private System.Windows.Forms.Label label_Yges;
        private System.Windows.Forms.TextBox textBox_gesamtA;
        private System.Windows.Forms.TextBox textBox_gesamtXs;
        private System.Windows.Forms.TextBox textBox_gesamtYs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Xs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ys;
    }
}

