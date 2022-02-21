namespace Maschinenfaehigkeit
{
    partial class Form_Cmk
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cmk));
      this.textBox_dNenn = new System.Windows.Forms.TextBox();
      this.label_dNenn = new System.Windows.Forms.Label();
      this.label_ddo = new System.Windows.Forms.Label();
      this.label_ddu = new System.Windows.Forms.Label();
      this.label_di = new System.Windows.Forms.Label();
      this.label_Cmk = new System.Windows.Forms.Label();
      this.textBox_ddo = new System.Windows.Forms.TextBox();
      this.textBox_ddu = new System.Windows.Forms.TextBox();
      this.textBox_di = new System.Windows.Forms.TextBox();
      this.textBox_Cmk = new System.Windows.Forms.TextBox();
      this.button_OK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_dNenn
      // 
      this.textBox_dNenn.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_dNenn.Location = new System.Drawing.Point(285, 11);
      this.textBox_dNenn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.textBox_dNenn.Name = "textBox_dNenn";
      this.textBox_dNenn.Size = new System.Drawing.Size(164, 43);
      this.textBox_dNenn.TabIndex = 0;
      this.textBox_dNenn.Text = "40";
      // 
      // label_dNenn
      // 
      this.label_dNenn.AutoSize = true;
      this.label_dNenn.Location = new System.Drawing.Point(23, 19);
      this.label_dNenn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_dNenn.Name = "label_dNenn";
      this.label_dNenn.Size = new System.Drawing.Size(353, 37);
      this.label_dNenn.TabIndex = 1;
      this.label_dNenn.Text = "Nennmaß dnenn in mm";
      // 
      // label_ddo
      // 
      this.label_ddo.AutoSize = true;
      this.label_ddo.Location = new System.Drawing.Point(23, 56);
      this.label_ddo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_ddo.Name = "label_ddo";
      this.label_ddo.Size = new System.Drawing.Size(378, 37);
      this.label_ddo.TabIndex = 2;
      this.label_ddo.Text = "oberes Abmaß ddo in µm";
      // 
      // label_ddu
      // 
      this.label_ddu.AutoSize = true;
      this.label_ddu.Location = new System.Drawing.Point(23, 99);
      this.label_ddu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_ddu.Name = "label_ddu";
      this.label_ddu.Size = new System.Drawing.Size(387, 37);
      this.label_ddu.TabIndex = 3;
      this.label_ddu.Text = "unteres Abmaß ddu in µm";
      // 
      // label_di
      // 
      this.label_di.AutoSize = true;
      this.label_di.Location = new System.Drawing.Point(23, 156);
      this.label_di.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_di.Name = "label_di";
      this.label_di.Size = new System.Drawing.Size(395, 37);
      this.label_di.TabIndex = 4;
      this.label_di.Text = "Durchmesser d[i] für i=0..n";
      // 
      // label_Cmk
      // 
      this.label_Cmk.AutoSize = true;
      this.label_Cmk.Location = new System.Drawing.Point(305, 371);
      this.label_Cmk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label_Cmk.Name = "label_Cmk";
      this.label_Cmk.Size = new System.Drawing.Size(365, 37);
      this.label_Cmk.TabIndex = 5;
      this.label_Cmk.Text = "Maschinenfähigkeit Cmk";
      // 
      // textBox_ddo
      // 
      this.textBox_ddo.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_ddo.Location = new System.Drawing.Point(285, 56);
      this.textBox_ddo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.textBox_ddo.Name = "textBox_ddo";
      this.textBox_ddo.Size = new System.Drawing.Size(164, 43);
      this.textBox_ddo.TabIndex = 6;
      this.textBox_ddo.Text = "30";
      // 
      // textBox_ddu
      // 
      this.textBox_ddu.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_ddu.Location = new System.Drawing.Point(285, 101);
      this.textBox_ddu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.textBox_ddu.Name = "textBox_ddu";
      this.textBox_ddu.Size = new System.Drawing.Size(164, 43);
      this.textBox_ddu.TabIndex = 7;
      this.textBox_ddu.Text = "0";
      // 
      // textBox_di
      // 
      this.textBox_di.BackColor = System.Drawing.Color.LightBlue;
      this.textBox_di.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
      this.textBox_di.Location = new System.Drawing.Point(16, 197);
      this.textBox_di.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.textBox_di.Multiline = true;
      this.textBox_di.Name = "textBox_di";
      this.textBox_di.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox_di.Size = new System.Drawing.Size(259, 436);
      this.textBox_di.TabIndex = 8;
      // 
      // textBox_Cmk
      // 
      this.textBox_Cmk.BackColor = System.Drawing.Color.Silver;
      this.textBox_Cmk.Location = new System.Drawing.Point(310, 403);
      this.textBox_Cmk.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.textBox_Cmk.Name = "textBox_Cmk";
      this.textBox_Cmk.Size = new System.Drawing.Size(242, 43);
      this.textBox_Cmk.TabIndex = 9;
      // 
      // button_OK
      // 
      this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
      this.button_OK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.button_OK.Location = new System.Drawing.Point(310, 197);
      this.button_OK.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(242, 90);
      this.button_OK.TabIndex = 10;
      this.button_OK.Text = "OK";
      this.button_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
      // 
      // Form_Cmk
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(795, 697);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.textBox_Cmk);
      this.Controls.Add(this.textBox_di);
      this.Controls.Add(this.textBox_ddu);
      this.Controls.Add(this.textBox_ddo);
      this.Controls.Add(this.label_Cmk);
      this.Controls.Add(this.label_di);
      this.Controls.Add(this.label_ddu);
      this.Controls.Add(this.label_ddo);
      this.Controls.Add(this.label_dNenn);
      this.Controls.Add(this.textBox_dNenn);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
      this.Name = "Form_Cmk";
      this.Text = "Maschinenfähigkeit Cmk";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dNenn;
        private System.Windows.Forms.Label label_dNenn;
        private System.Windows.Forms.Label label_ddo;
        private System.Windows.Forms.Label label_ddu;
        private System.Windows.Forms.Label label_di;
        private System.Windows.Forms.Label label_Cmk;
        private System.Windows.Forms.TextBox textBox_ddo;
        private System.Windows.Forms.TextBox textBox_ddu;
        private System.Windows.Forms.TextBox textBox_di;
        private System.Windows.Forms.TextBox textBox_Cmk;
        private System.Windows.Forms.Button button_OK;
    }
}

