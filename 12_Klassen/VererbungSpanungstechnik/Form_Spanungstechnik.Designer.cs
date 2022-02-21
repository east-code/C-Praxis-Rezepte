namespace Spanungstechnik
{
    partial class Form_Spanung
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
            this.splitContainer_Spanungstechnik = new System.Windows.Forms.SplitContainer();
            this.tabControl_Spanungstechnik = new System.Windows.Forms.TabControl();
            this.tabPage_Drehen = new System.Windows.Forms.TabPage();
            this.button_FcTurn = new System.Windows.Forms.Button();
            this.label_Fc = new System.Windows.Forms.Label();
            this.label_kappa = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            this.label_ap = new System.Windows.Forms.Label();
            this.textBox_Fc = new System.Windows.Forms.TextBox();
            this.textBox_kappa = new System.Windows.Forms.TextBox();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_ap = new System.Windows.Forms.TextBox();
            this.tabPage_Fraesen = new System.Windows.Forms.TabPage();
            this.label_zMill = new System.Windows.Forms.Label();
            this.textBox_zMill = new System.Windows.Forms.TextBox();
            this.groupBox_Werkzeuglage = new System.Windows.Forms.GroupBox();
            this.radioButton_links = new System.Windows.Forms.RadioButton();
            this.radioButton_mittig = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FczMill = new System.Windows.Forms.TextBox();
            this.label_Dwz = new System.Windows.Forms.Label();
            this.textBox_DwzMill = new System.Windows.Forms.TextBox();
            this.label_aeF = new System.Windows.Forms.Label();
            this.textBox_aeMill = new System.Windows.Forms.TextBox();
            this.button_FcMill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_fz = new System.Windows.Forms.Label();
            this.label_apF = new System.Windows.Forms.Label();
            this.textBox_FcMill = new System.Windows.Forms.TextBox();
            this.textBox_kappaMill = new System.Windows.Forms.TextBox();
            this.textBox_fzMill = new System.Windows.Forms.TextBox();
            this.textBox_apMill = new System.Windows.Forms.TextBox();
            this.groupBox_Wst = new System.Windows.Forms.GroupBox();
            this.dataGridView_WSt = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_kc11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zerspanungskraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fräsenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Spanungstechnik)).BeginInit();
            this.splitContainer_Spanungstechnik.Panel1.SuspendLayout();
            this.splitContainer_Spanungstechnik.Panel2.SuspendLayout();
            this.splitContainer_Spanungstechnik.SuspendLayout();
            this.tabControl_Spanungstechnik.SuspendLayout();
            this.tabPage_Drehen.SuspendLayout();
            this.tabPage_Fraesen.SuspendLayout();
            this.groupBox_Werkzeuglage.SuspendLayout();
            this.groupBox_Wst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Spanungstechnik
            // 
            this.splitContainer_Spanungstechnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Spanungstechnik.Location = new System.Drawing.Point(0, 38);
            this.splitContainer_Spanungstechnik.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.splitContainer_Spanungstechnik.Name = "splitContainer_Spanungstechnik";
            // 
            // splitContainer_Spanungstechnik.Panel1
            // 
            this.splitContainer_Spanungstechnik.Panel1.Controls.Add(this.tabControl_Spanungstechnik);
            this.splitContainer_Spanungstechnik.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer_Spanungstechnik.Panel2
            // 
            this.splitContainer_Spanungstechnik.Panel2.Controls.Add(this.groupBox_Wst);
            this.splitContainer_Spanungstechnik.Size = new System.Drawing.Size(964, 463);
            this.splitContainer_Spanungstechnik.SplitterDistance = 564;
            this.splitContainer_Spanungstechnik.SplitterWidth = 8;
            this.splitContainer_Spanungstechnik.TabIndex = 1;
            // 
            // tabControl_Spanungstechnik
            // 
            this.tabControl_Spanungstechnik.Controls.Add(this.tabPage_Drehen);
            this.tabControl_Spanungstechnik.Controls.Add(this.tabPage_Fraesen);
            this.tabControl_Spanungstechnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Spanungstechnik.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Spanungstechnik.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.tabControl_Spanungstechnik.Name = "tabControl_Spanungstechnik";
            this.tabControl_Spanungstechnik.SelectedIndex = 0;
            this.tabControl_Spanungstechnik.Size = new System.Drawing.Size(564, 463);
            this.tabControl_Spanungstechnik.TabIndex = 1;
            // 
            // tabPage_Drehen
            // 
            this.tabPage_Drehen.Controls.Add(this.button_FcTurn);
            this.tabPage_Drehen.Controls.Add(this.label_Fc);
            this.tabPage_Drehen.Controls.Add(this.label_kappa);
            this.tabPage_Drehen.Controls.Add(this.label_f);
            this.tabPage_Drehen.Controls.Add(this.label_ap);
            this.tabPage_Drehen.Controls.Add(this.textBox_Fc);
            this.tabPage_Drehen.Controls.Add(this.textBox_kappa);
            this.tabPage_Drehen.Controls.Add(this.textBox_f);
            this.tabPage_Drehen.Controls.Add(this.textBox_ap);
            this.tabPage_Drehen.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Drehen.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.tabPage_Drehen.Name = "tabPage_Drehen";
            this.tabPage_Drehen.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.tabPage_Drehen.Size = new System.Drawing.Size(556, 425);
            this.tabPage_Drehen.TabIndex = 0;
            this.tabPage_Drehen.Text = "Drehen";
            this.tabPage_Drehen.UseVisualStyleBackColor = true;
            // 
            // button_FcTurn
            // 
            this.button_FcTurn.Location = new System.Drawing.Point(20, 134);
            this.button_FcTurn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_FcTurn.Name = "button_FcTurn";
            this.button_FcTurn.Size = new System.Drawing.Size(523, 48);
            this.button_FcTurn.TabIndex = 8;
            this.button_FcTurn.Text = "Schnittkraft beim Drehen Fc ";
            this.button_FcTurn.UseVisualStyleBackColor = true;
            this.button_FcTurn.Click += new System.EventHandler(this.drehenToolStripMenuItem_Click);
            // 
            // label_Fc
            // 
            this.label_Fc.AutoSize = true;
            this.label_Fc.Location = new System.Drawing.Point(15, 205);
            this.label_Fc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Fc.Name = "label_Fc";
            this.label_Fc.Size = new System.Drawing.Size(205, 25);
            this.label_Fc.TabIndex = 7;
            this.label_Fc.Text = "Schnittkraft Fc in kN";
            // 
            // label_kappa
            // 
            this.label_kappa.AutoSize = true;
            this.label_kappa.Location = new System.Drawing.Point(15, 87);
            this.label_kappa.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_kappa.Name = "label_kappa";
            this.label_kappa.Size = new System.Drawing.Size(244, 25);
            this.label_kappa.TabIndex = 6;
            this.label_kappa.Text = "Einstellwinkel kappa in °";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(15, 51);
            this.label_f.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(352, 25);
            this.label_f.TabIndex = 5;
            this.label_f.Text = "Vorschubgeschwindigkeit f in mm/U";
            // 
            // label_ap
            // 
            this.label_ap.AutoSize = true;
            this.label_ap.Location = new System.Drawing.Point(15, 17);
            this.label_ap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ap.Name = "label_ap";
            this.label_ap.Size = new System.Drawing.Size(212, 25);
            this.label_ap.TabIndex = 4;
            this.label_ap.Text = "Schnitttiefe ap in mm";
            // 
            // textBox_Fc
            // 
            this.textBox_Fc.BackColor = System.Drawing.Color.Silver;
            this.textBox_Fc.Location = new System.Drawing.Point(422, 198);
            this.textBox_Fc.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_Fc.Name = "textBox_Fc";
            this.textBox_Fc.Size = new System.Drawing.Size(121, 31);
            this.textBox_Fc.TabIndex = 3;
            // 
            // textBox_kappa
            // 
            this.textBox_kappa.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_kappa.Location = new System.Drawing.Point(422, 87);
            this.textBox_kappa.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_kappa.Name = "textBox_kappa";
            this.textBox_kappa.Size = new System.Drawing.Size(121, 31);
            this.textBox_kappa.TabIndex = 2;
            this.textBox_kappa.Text = "90";
            // 
            // textBox_f
            // 
            this.textBox_f.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_f.Location = new System.Drawing.Point(422, 51);
            this.textBox_f.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(121, 31);
            this.textBox_f.TabIndex = 1;
            this.textBox_f.Text = "0,5";
            // 
            // textBox_ap
            // 
            this.textBox_ap.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_ap.Location = new System.Drawing.Point(422, 14);
            this.textBox_ap.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_ap.Name = "textBox_ap";
            this.textBox_ap.Size = new System.Drawing.Size(121, 31);
            this.textBox_ap.TabIndex = 0;
            this.textBox_ap.Text = "2";
            // 
            // tabPage_Fraesen
            // 
            this.tabPage_Fraesen.Controls.Add(this.label_zMill);
            this.tabPage_Fraesen.Controls.Add(this.textBox_zMill);
            this.tabPage_Fraesen.Controls.Add(this.groupBox_Werkzeuglage);
            this.tabPage_Fraesen.Controls.Add(this.label3);
            this.tabPage_Fraesen.Controls.Add(this.textBox_FczMill);
            this.tabPage_Fraesen.Controls.Add(this.label_Dwz);
            this.tabPage_Fraesen.Controls.Add(this.textBox_DwzMill);
            this.tabPage_Fraesen.Controls.Add(this.label_aeF);
            this.tabPage_Fraesen.Controls.Add(this.textBox_aeMill);
            this.tabPage_Fraesen.Controls.Add(this.button_FcMill);
            this.tabPage_Fraesen.Controls.Add(this.label1);
            this.tabPage_Fraesen.Controls.Add(this.label2);
            this.tabPage_Fraesen.Controls.Add(this.label_fz);
            this.tabPage_Fraesen.Controls.Add(this.label_apF);
            this.tabPage_Fraesen.Controls.Add(this.textBox_FcMill);
            this.tabPage_Fraesen.Controls.Add(this.textBox_kappaMill);
            this.tabPage_Fraesen.Controls.Add(this.textBox_fzMill);
            this.tabPage_Fraesen.Controls.Add(this.textBox_apMill);
            this.tabPage_Fraesen.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Fraesen.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.tabPage_Fraesen.Name = "tabPage_Fraesen";
            this.tabPage_Fraesen.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.tabPage_Fraesen.Size = new System.Drawing.Size(556, 425);
            this.tabPage_Fraesen.TabIndex = 1;
            this.tabPage_Fraesen.Text = "Fräsen";
            this.tabPage_Fraesen.UseVisualStyleBackColor = true;
            // 
            // label_zMill
            // 
            this.label_zMill.AutoSize = true;
            this.label_zMill.Location = new System.Drawing.Point(16, 162);
            this.label_zMill.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_zMill.Name = "label_zMill";
            this.label_zMill.Size = new System.Drawing.Size(193, 25);
            this.label_zMill.TabIndex = 28;
            this.label_zMill.Text = "Zähnezahl des WZ";
            // 
            // textBox_zMill
            // 
            this.textBox_zMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_zMill.Location = new System.Drawing.Point(402, 159);
            this.textBox_zMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_zMill.Name = "textBox_zMill";
            this.textBox_zMill.Size = new System.Drawing.Size(142, 31);
            this.textBox_zMill.TabIndex = 27;
            this.textBox_zMill.Text = "2";
            // 
            // groupBox_Werkzeuglage
            // 
            this.groupBox_Werkzeuglage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox_Werkzeuglage.Controls.Add(this.radioButton_links);
            this.groupBox_Werkzeuglage.Controls.Add(this.radioButton_mittig);
            this.groupBox_Werkzeuglage.Location = new System.Drawing.Point(21, 243);
            this.groupBox_Werkzeuglage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox_Werkzeuglage.Name = "groupBox_Werkzeuglage";
            this.groupBox_Werkzeuglage.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox_Werkzeuglage.Size = new System.Drawing.Size(365, 85);
            this.groupBox_Werkzeuglage.TabIndex = 26;
            this.groupBox_Werkzeuglage.TabStop = false;
            this.groupBox_Werkzeuglage.Text = "Werkzeuglage in Bezug zur Kontur";
            // 
            // radioButton_links
            // 
            this.radioButton_links.AutoSize = true;
            this.radioButton_links.Checked = true;
            this.radioButton_links.Location = new System.Drawing.Point(50, 46);
            this.radioButton_links.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.radioButton_links.Name = "radioButton_links";
            this.radioButton_links.Size = new System.Drawing.Size(74, 29);
            this.radioButton_links.TabIndex = 1;
            this.radioButton_links.TabStop = true;
            this.radioButton_links.Text = "links";
            this.radioButton_links.UseVisualStyleBackColor = true;
            this.radioButton_links.CheckedChanged += new System.EventHandler(this.radioButton_links_CheckedChanged);
            // 
            // radioButton_mittig
            // 
            this.radioButton_mittig.AutoSize = true;
            this.radioButton_mittig.Location = new System.Drawing.Point(264, 46);
            this.radioButton_mittig.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.radioButton_mittig.Name = "radioButton_mittig";
            this.radioButton_mittig.Size = new System.Drawing.Size(81, 29);
            this.radioButton_mittig.TabIndex = 0;
            this.radioButton_mittig.Text = "mittig";
            this.radioButton_mittig.UseVisualStyleBackColor = true;
            this.radioButton_mittig.CheckedChanged += new System.EventHandler(this.radioButton_mittig_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Schnittkraft je Zahn Fcz in kN";
            // 
            // textBox_FczMill
            // 
            this.textBox_FczMill.BackColor = System.Drawing.Color.Silver;
            this.textBox_FczMill.Location = new System.Drawing.Point(340, 344);
            this.textBox_FczMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_FczMill.Name = "textBox_FczMill";
            this.textBox_FczMill.Size = new System.Drawing.Size(208, 31);
            this.textBox_FczMill.TabIndex = 24;
            // 
            // label_Dwz
            // 
            this.label_Dwz.AutoSize = true;
            this.label_Dwz.Location = new System.Drawing.Point(16, 125);
            this.label_Dwz.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Dwz.Name = "label_Dwz";
            this.label_Dwz.Size = new System.Drawing.Size(343, 25);
            this.label_Dwz.TabIndex = 21;
            this.label_Dwz.Text = "Werkzeugdurchmesser Dwz in mm";
            // 
            // textBox_DwzMill
            // 
            this.textBox_DwzMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_DwzMill.Location = new System.Drawing.Point(402, 122);
            this.textBox_DwzMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_DwzMill.Name = "textBox_DwzMill";
            this.textBox_DwzMill.Size = new System.Drawing.Size(146, 31);
            this.textBox_DwzMill.TabIndex = 20;
            this.textBox_DwzMill.Text = "30";
            this.textBox_DwzMill.TextChanged += new System.EventHandler(this.textBox_DwzMill_TextChanged);
            // 
            // label_aeF
            // 
            this.label_aeF.AutoSize = true;
            this.label_aeF.Location = new System.Drawing.Point(14, 51);
            this.label_aeF.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_aeF.Name = "label_aeF";
            this.label_aeF.Size = new System.Drawing.Size(237, 25);
            this.label_aeF.TabIndex = 19;
            this.label_aeF.Text = "Eingriffsbreite ae in mm";
            // 
            // textBox_aeMill
            // 
            this.textBox_aeMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_aeMill.Location = new System.Drawing.Point(402, 45);
            this.textBox_aeMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_aeMill.Name = "textBox_aeMill";
            this.textBox_aeMill.Size = new System.Drawing.Size(146, 31);
            this.textBox_aeMill.TabIndex = 18;
            this.textBox_aeMill.Text = "20";
            // 
            // button_FcMill
            // 
            this.button_FcMill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_FcMill.Location = new System.Drawing.Point(402, 243);
            this.button_FcMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_FcMill.Name = "button_FcMill";
            this.button_FcMill.Size = new System.Drawing.Size(146, 85);
            this.button_FcMill.TabIndex = 17;
            this.button_FcMill.Text = "Schnittkräfte beim Fräsen Fc";
            this.button_FcMill.UseVisualStyleBackColor = true;
            this.button_FcMill.Click += new System.EventHandler(this.fräsenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "effektive Schnittkraft Fc in kN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Einstellwinkel kappa in °";
            // 
            // label_fz
            // 
            this.label_fz.AutoSize = true;
            this.label_fz.Location = new System.Drawing.Point(13, 91);
            this.label_fz.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_fz.Name = "label_fz";
            this.label_fz.Size = new System.Drawing.Size(311, 25);
            this.label_fz.TabIndex = 14;
            this.label_fz.Text = "Zahnvorschub fz in mm/Zahn/U";
            // 
            // label_apF
            // 
            this.label_apF.AutoSize = true;
            this.label_apF.Location = new System.Drawing.Point(16, 18);
            this.label_apF.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_apF.Name = "label_apF";
            this.label_apF.Size = new System.Drawing.Size(212, 25);
            this.label_apF.TabIndex = 13;
            this.label_apF.Text = "Schnitttiefe ap in mm";
            // 
            // textBox_FcMill
            // 
            this.textBox_FcMill.BackColor = System.Drawing.Color.Silver;
            this.textBox_FcMill.Location = new System.Drawing.Point(340, 381);
            this.textBox_FcMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_FcMill.Name = "textBox_FcMill";
            this.textBox_FcMill.Size = new System.Drawing.Size(204, 31);
            this.textBox_FcMill.TabIndex = 12;
            // 
            // textBox_kappaMill
            // 
            this.textBox_kappaMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_kappaMill.Location = new System.Drawing.Point(402, 194);
            this.textBox_kappaMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_kappaMill.Name = "textBox_kappaMill";
            this.textBox_kappaMill.Size = new System.Drawing.Size(146, 31);
            this.textBox_kappaMill.TabIndex = 11;
            this.textBox_kappaMill.Text = "90";
            // 
            // textBox_fzMill
            // 
            this.textBox_fzMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_fzMill.Location = new System.Drawing.Point(402, 85);
            this.textBox_fzMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_fzMill.Name = "textBox_fzMill";
            this.textBox_fzMill.Size = new System.Drawing.Size(146, 31);
            this.textBox_fzMill.TabIndex = 10;
            this.textBox_fzMill.Text = "0,15";
            // 
            // textBox_apMill
            // 
            this.textBox_apMill.BackColor = System.Drawing.Color.LightBlue;
            this.textBox_apMill.Location = new System.Drawing.Point(402, 10);
            this.textBox_apMill.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_apMill.Name = "textBox_apMill";
            this.textBox_apMill.Size = new System.Drawing.Size(146, 31);
            this.textBox_apMill.TabIndex = 9;
            this.textBox_apMill.Text = "3";
            // 
            // groupBox_Wst
            // 
            this.groupBox_Wst.Controls.Add(this.dataGridView_WSt);
            this.groupBox_Wst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Wst.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Wst.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.groupBox_Wst.Name = "groupBox_Wst";
            this.groupBox_Wst.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.groupBox_Wst.Size = new System.Drawing.Size(392, 463);
            this.groupBox_Wst.TabIndex = 0;
            this.groupBox_Wst.TabStop = false;
            this.groupBox_Wst.Text = "Werkstoffe";
            // 
            // dataGridView_WSt
            // 
            this.dataGridView_WSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WSt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.Column_m,
            this.Column_kc11});
            this.dataGridView_WSt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_WSt.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_WSt.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.dataGridView_WSt.Name = "dataGridView_WSt";
            this.dataGridView_WSt.RowTemplate.Height = 24;
            this.dataGridView_WSt.Size = new System.Drawing.Size(380, 435);
            this.dataGridView_WSt.TabIndex = 1;
            this.dataGridView_WSt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WSt_CellClick);
            this.dataGridView_WSt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WSt_CellContentClick);
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Name";
            this.Column_name.Name = "Column_name";
            // 
            // Column_m
            // 
            this.Column_m.HeaderText = "m";
            this.Column_m.Name = "Column_m";
            // 
            // Column_kc11
            // 
            this.Column_kc11.HeaderText = "kc1.1";
            this.Column_kc11.Name = "Column_kc11";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zerspanungskraftToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(964, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zerspanungskraftToolStripMenuItem
            // 
            this.zerspanungskraftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drehenToolStripMenuItem,
            this.fräsenToolStripMenuItem});
            this.zerspanungskraftToolStripMenuItem.Name = "zerspanungskraftToolStripMenuItem";
            this.zerspanungskraftToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.zerspanungskraftToolStripMenuItem.Text = "Schnittkraft";
            this.zerspanungskraftToolStripMenuItem.Click += new System.EventHandler(this.zerspanungskraftToolStripMenuItem_Click);
            // 
            // drehenToolStripMenuItem
            // 
            this.drehenToolStripMenuItem.Name = "drehenToolStripMenuItem";
            this.drehenToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.drehenToolStripMenuItem.Text = "Drehen";
            this.drehenToolStripMenuItem.Click += new System.EventHandler(this.drehenToolStripMenuItem_Click);
            // 
            // fräsenToolStripMenuItem
            // 
            this.fräsenToolStripMenuItem.Name = "fräsenToolStripMenuItem";
            this.fräsenToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fräsenToolStripMenuItem.Text = "Fräsen";
            this.fräsenToolStripMenuItem.Click += new System.EventHandler(this.fräsenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // Form_Spanung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 501);
            this.Controls.Add(this.splitContainer_Spanungstechnik);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.Name = "Form_Spanung";
            this.Text = "Spanungstechnik";
            this.Load += new System.EventHandler(this.Form_Spanung_Load);
            this.splitContainer_Spanungstechnik.Panel1.ResumeLayout(false);
            this.splitContainer_Spanungstechnik.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Spanungstechnik)).EndInit();
            this.splitContainer_Spanungstechnik.ResumeLayout(false);
            this.tabControl_Spanungstechnik.ResumeLayout(false);
            this.tabPage_Drehen.ResumeLayout(false);
            this.tabPage_Drehen.PerformLayout();
            this.tabPage_Fraesen.ResumeLayout(false);
            this.tabPage_Fraesen.PerformLayout();
            this.groupBox_Werkzeuglage.ResumeLayout(false);
            this.groupBox_Werkzeuglage.PerformLayout();
            this.groupBox_Wst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WSt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Spanungstechnik;
        private System.Windows.Forms.TabControl tabControl_Spanungstechnik;
        private System.Windows.Forms.TabPage tabPage_Drehen;
        private System.Windows.Forms.TabPage tabPage_Fraesen;
        private System.Windows.Forms.GroupBox groupBox_Wst;
        private System.Windows.Forms.DataGridView dataGridView_WSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_kc11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zerspanungskraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drehenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fräsenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_ap;
        private System.Windows.Forms.Button button_FcTurn;
        private System.Windows.Forms.Label label_Fc;
        private System.Windows.Forms.Label label_kappa;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.Label label_ap;
        private System.Windows.Forms.TextBox textBox_Fc;
        private System.Windows.Forms.TextBox textBox_kappa;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.Button button_FcMill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_fz;
        private System.Windows.Forms.Label label_apF;
        private System.Windows.Forms.TextBox textBox_FcMill;
        private System.Windows.Forms.TextBox textBox_kappaMill;
        private System.Windows.Forms.TextBox textBox_fzMill;
        private System.Windows.Forms.TextBox textBox_apMill;
        private System.Windows.Forms.Label label_aeF;
        private System.Windows.Forms.TextBox textBox_aeMill;
        private System.Windows.Forms.Label label_Dwz;
        private System.Windows.Forms.TextBox textBox_DwzMill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FczMill;
        private System.Windows.Forms.GroupBox groupBox_Werkzeuglage;
        private System.Windows.Forms.RadioButton radioButton_links;
        private System.Windows.Forms.RadioButton radioButton_mittig;
        private System.Windows.Forms.Label label_zMill;
        private System.Windows.Forms.TextBox textBox_zMill;

    }
}

