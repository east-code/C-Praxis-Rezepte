﻿namespace Bubblesort
{
    partial class Form_Bubblesort
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
            this.button_zufallszahlen = new System.Windows.Forms.Button();
            this.button_aufwaertsSortieren = new System.Windows.Forms.Button();
            this.listBox_unsort = new System.Windows.Forms.ListBox();
            this.listBox_sort = new System.Windows.Forms.ListBox();
            this.listBox_upSort = new System.Windows.Forms.ListBox();
            this.button_abwaertsSortieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_zufallszahlen
            // 
            this.button_zufallszahlen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_zufallszahlen.Location = new System.Drawing.Point(4, 10);
            this.button_zufallszahlen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_zufallszahlen.Name = "button_zufallszahlen";
            this.button_zufallszahlen.Size = new System.Drawing.Size(154, 72);
            this.button_zufallszahlen.TabIndex = 0;
            this.button_zufallszahlen.Text = "Zufallszahlen";
            this.button_zufallszahlen.UseVisualStyleBackColor = false;
            this.button_zufallszahlen.Click += new System.EventHandler(this.button_zufallszahlen_Click);
            // 
            // button_aufwaertsSortieren
            // 
            this.button_aufwaertsSortieren.BackColor = System.Drawing.Color.Silver;
            this.button_aufwaertsSortieren.Location = new System.Drawing.Point(170, 10);
            this.button_aufwaertsSortieren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_aufwaertsSortieren.Name = "button_aufwaertsSortieren";
            this.button_aufwaertsSortieren.Size = new System.Drawing.Size(154, 73);
            this.button_aufwaertsSortieren.TabIndex = 1;
            this.button_aufwaertsSortieren.Text = "aufwärts sortieren";
            this.button_aufwaertsSortieren.UseVisualStyleBackColor = false;
            this.button_aufwaertsSortieren.Click += new System.EventHandler(this.button_aufwaertsSortieren_Click);
            // 
            // listBox_unsort
            // 
            this.listBox_unsort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox_unsort.FormattingEnabled = true;
            this.listBox_unsort.ItemHeight = 25;
            this.listBox_unsort.Location = new System.Drawing.Point(4, 94);
            this.listBox_unsort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_unsort.Name = "listBox_unsort";
            this.listBox_unsort.Size = new System.Drawing.Size(154, 329);
            this.listBox_unsort.TabIndex = 2;
            // 
            // listBox_sort
            // 
            this.listBox_sort.BackColor = System.Drawing.Color.Silver;
            this.listBox_sort.FormattingEnabled = true;
            this.listBox_sort.ItemHeight = 25;
            this.listBox_sort.Location = new System.Drawing.Point(170, 94);
            this.listBox_sort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_sort.Name = "listBox_sort";
            this.listBox_sort.Size = new System.Drawing.Size(154, 329);
            this.listBox_sort.TabIndex = 3;
            // 
            // listBox_upSort
            // 
            this.listBox_upSort.BackColor = System.Drawing.Color.LightGray;
            this.listBox_upSort.FormattingEnabled = true;
            this.listBox_upSort.ItemHeight = 25;
            this.listBox_upSort.Location = new System.Drawing.Point(336, 94);
            this.listBox_upSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_upSort.Name = "listBox_upSort";
            this.listBox_upSort.Size = new System.Drawing.Size(154, 329);
            this.listBox_upSort.TabIndex = 4;
            // 
            // button_abwaertsSortieren
            // 
            this.button_abwaertsSortieren.BackColor = System.Drawing.Color.LightGray;
            this.button_abwaertsSortieren.Location = new System.Drawing.Point(336, 10);
            this.button_abwaertsSortieren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_abwaertsSortieren.Name = "button_abwaertsSortieren";
            this.button_abwaertsSortieren.Size = new System.Drawing.Size(154, 73);
            this.button_abwaertsSortieren.TabIndex = 5;
            this.button_abwaertsSortieren.Text = "abwärts sortieren";
            this.button_abwaertsSortieren.UseVisualStyleBackColor = false;
            this.button_abwaertsSortieren.Click += new System.EventHandler(this.button_abwaertsSortieren_Click);
            // 
            // Form_Bubblesort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 432);
            this.Controls.Add(this.button_abwaertsSortieren);
            this.Controls.Add(this.listBox_upSort);
            this.Controls.Add(this.listBox_sort);
            this.Controls.Add(this.listBox_unsort);
            this.Controls.Add(this.button_aufwaertsSortieren);
            this.Controls.Add(this.button_zufallszahlen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Bubblesort";
            this.Text = "Bubblesort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_zufallszahlen;
        private System.Windows.Forms.Button button_aufwaertsSortieren;
        private System.Windows.Forms.ListBox listBox_unsort;
        private System.Windows.Forms.ListBox listBox_sort;
        private System.Windows.Forms.ListBox listBox_upSort;
        private System.Windows.Forms.Button button_abwaertsSortieren;
    }
}

