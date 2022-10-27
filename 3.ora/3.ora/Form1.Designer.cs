
namespace _3.ora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nev_tb = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.visszajaro_lbl = new System.Windows.Forms.Label();
            this.penzosszeg_tb = new System.Windows.Forms.TextBox();
            this.menu_lbl = new System.Windows.Forms.Label();
            this.item_lbl = new System.Windows.Forms.Label();
            this.bal_lbl = new System.Windows.Forms.Label();
            this.asd_lbl = new System.Windows.Forms.Label();
            this.work_btn = new System.Windows.Forms.Button();
            this.Time_PB = new System.Windows.Forms.ProgressBar();
            this.workh_TB = new System.Windows.Forms.TrackBar();
            this.trackbarvalue_lbl = new System.Windows.Forms.Label();
            this.progressbar_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hunger_PB = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.day_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.day_count_tb = new System.Windows.Forms.Label();
            this.revive_btn = new System.Windows.Forms.Button();
            this.placeholder_lbl = new System.Windows.Forms.Label();
            this.Work_lbl = new System.Windows.Forms.Label();
            this.worksearch_btn = new System.Windows.Forms.Button();
            this.workplaces_cbx = new System.Windows.Forms.ComboBox();
            this.palinka_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workh_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // nev_tb
            // 
            this.nev_tb.Location = new System.Drawing.Point(78, 62);
            this.nev_tb.Name = "nev_tb";
            this.nev_tb.Size = new System.Drawing.Size(100, 23);
            this.nev_tb.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(78, 104);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // visszajaro_lbl
            // 
            this.visszajaro_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visszajaro_lbl.Location = new System.Drawing.Point(310, 70);
            this.visszajaro_lbl.Name = "visszajaro_lbl";
            this.visszajaro_lbl.Size = new System.Drawing.Size(144, 15);
            this.visszajaro_lbl.TabIndex = 2;
            this.visszajaro_lbl.Text = "0";
            this.visszajaro_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // penzosszeg_tb
            // 
            this.penzosszeg_tb.Enabled = false;
            this.penzosszeg_tb.Location = new System.Drawing.Point(78, 16);
            this.penzosszeg_tb.Name = "penzosszeg_tb";
            this.penzosszeg_tb.Size = new System.Drawing.Size(100, 23);
            this.penzosszeg_tb.TabIndex = 3;
            this.penzosszeg_tb.Text = "0";
            // 
            // menu_lbl
            // 
            this.menu_lbl.Location = new System.Drawing.Point(43, 137);
            this.menu_lbl.Name = "menu_lbl";
            this.menu_lbl.Size = new System.Drawing.Size(110, 107);
            this.menu_lbl.TabIndex = 4;
            this.menu_lbl.Text = "Menü:\r\n\r\n-Pizza: 450 Ft\r\n-Hamburger: 750 Ft\r\n-Kóla: 650 Ft\r\n-Popcorn: 100 Ft\r\n-Sa" +
    "láta: 1000 Ft\r\n\r\n\r\n\r\n\r\n";
            this.menu_lbl.Click += new System.EventHandler(this.menu_lbl_Click);
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.Location = new System.Drawing.Point(12, 65);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(57, 15);
            this.item_lbl.TabIndex = 5;
            this.item_lbl.Text = "Rendelés:";
            this.item_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bal_lbl
            // 
            this.bal_lbl.AutoSize = true;
            this.bal_lbl.Location = new System.Drawing.Point(12, 19);
            this.bal_lbl.Name = "bal_lbl";
            this.bal_lbl.Size = new System.Drawing.Size(58, 15);
            this.bal_lbl.TabIndex = 6;
            this.bal_lbl.Text = "Egyenleg:";
            // 
            // asd_lbl
            // 
            this.asd_lbl.AutoSize = true;
            this.asd_lbl.Location = new System.Drawing.Point(234, 69);
            this.asd_lbl.Name = "asd_lbl";
            this.asd_lbl.Size = new System.Drawing.Size(61, 15);
            this.asd_lbl.TabIndex = 7;
            this.asd_lbl.Text = "Visszajáró:";
            // 
            // work_btn
            // 
            this.work_btn.Location = new System.Drawing.Point(599, 380);
            this.work_btn.Name = "work_btn";
            this.work_btn.Size = new System.Drawing.Size(75, 23);
            this.work_btn.TabIndex = 8;
            this.work_btn.Text = "Dolgozz!!";
            this.work_btn.UseVisualStyleBackColor = true;
            this.work_btn.Click += new System.EventHandler(this.work_btn_Click);
            // 
            // Time_PB
            // 
            this.Time_PB.Location = new System.Drawing.Point(526, 351);
            this.Time_PB.Name = "Time_PB";
            this.Time_PB.Size = new System.Drawing.Size(233, 23);
            this.Time_PB.TabIndex = 9;
            this.Time_PB.Click += new System.EventHandler(this.Time_PB_Click);
            // 
            // workh_TB
            // 
            this.workh_TB.Location = new System.Drawing.Point(526, 305);
            this.workh_TB.Maximum = 24;
            this.workh_TB.Name = "workh_TB";
            this.workh_TB.Size = new System.Drawing.Size(233, 45);
            this.workh_TB.TabIndex = 10;
            this.workh_TB.Tag = "";
            this.workh_TB.Scroll += new System.EventHandler(this.workh_TB_Scroll);
            // 
            // trackbarvalue_lbl
            // 
            this.trackbarvalue_lbl.AutoSize = true;
            this.trackbarvalue_lbl.Location = new System.Drawing.Point(616, 287);
            this.trackbarvalue_lbl.Name = "trackbarvalue_lbl";
            this.trackbarvalue_lbl.Size = new System.Drawing.Size(13, 15);
            this.trackbarvalue_lbl.TabIndex = 11;
            this.trackbarvalue_lbl.Text = "0";
            // 
            // progressbar_lbl
            // 
            this.progressbar_lbl.AutoSize = true;
            this.progressbar_lbl.BackColor = System.Drawing.Color.Transparent;
            this.progressbar_lbl.Location = new System.Drawing.Point(694, 384);
            this.progressbar_lbl.Name = "progressbar_lbl";
            this.progressbar_lbl.Size = new System.Drawing.Size(0, 15);
            this.progressbar_lbl.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "órát fogsz dolgozni.";
            // 
            // hunger_PB
            // 
            this.hunger_PB.Location = new System.Drawing.Point(562, 15);
            this.hunger_PB.Name = "hunger_PB";
            this.hunger_PB.Size = new System.Drawing.Size(226, 23);
            this.hunger_PB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Éhség";
            // 
            // day_btn
            // 
            this.day_btn.Location = new System.Drawing.Point(52, 380);
            this.day_btn.Name = "day_btn";
            this.day_btn.Size = new System.Drawing.Size(126, 23);
            this.day_btn.TabIndex = 16;
            this.day_btn.Text = "Irány az ágy!";
            this.day_btn.UseVisualStyleBackColor = true;
            this.day_btn.Click += new System.EventHandler(this.day_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nap";
            // 
            // day_count_tb
            // 
            this.day_count_tb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day_count_tb.Location = new System.Drawing.Point(184, 384);
            this.day_count_tb.Name = "day_count_tb";
            this.day_count_tb.Size = new System.Drawing.Size(144, 15);
            this.day_count_tb.TabIndex = 19;
            this.day_count_tb.Tag = "";
            this.day_count_tb.Text = "0";
            // 
            // revive_btn
            // 
            this.revive_btn.Location = new System.Drawing.Point(341, 165);
            this.revive_btn.Name = "revive_btn";
            this.revive_btn.Size = new System.Drawing.Size(127, 55);
            this.revive_btn.TabIndex = 20;
            this.revive_btn.Text = "Új élet";
            this.revive_btn.UseVisualStyleBackColor = true;
            this.revive_btn.Visible = false;
            this.revive_btn.Click += new System.EventHandler(this.revive_btn_Click);
            // 
            // placeholder_lbl
            // 
            this.placeholder_lbl.AutoSize = true;
            this.placeholder_lbl.Location = new System.Drawing.Point(524, 262);
            this.placeholder_lbl.Name = "placeholder_lbl";
            this.placeholder_lbl.Size = new System.Drawing.Size(105, 15);
            this.placeholder_lbl.TabIndex = 21;
            this.placeholder_lbl.Text = "Jelenlegi munkád: ";
            this.placeholder_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // Work_lbl
            // 
            this.Work_lbl.AutoSize = true;
            this.Work_lbl.Location = new System.Drawing.Point(655, 261);
            this.Work_lbl.Name = "Work_lbl";
            this.Work_lbl.Size = new System.Drawing.Size(0, 15);
            this.Work_lbl.TabIndex = 22;
            this.Work_lbl.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // worksearch_btn
            // 
            this.worksearch_btn.Location = new System.Drawing.Point(680, 212);
            this.worksearch_btn.Name = "worksearch_btn";
            this.worksearch_btn.Size = new System.Drawing.Size(104, 23);
            this.worksearch_btn.TabIndex = 23;
            this.worksearch_btn.Text = "Keress munkát!";
            this.worksearch_btn.UseVisualStyleBackColor = true;
            this.worksearch_btn.Click += new System.EventHandler(this.worksearch_btn_Click);
            // 
            // workplaces_cbx
            // 
            this.workplaces_cbx.FormattingEnabled = true;
            this.workplaces_cbx.Items.AddRange(new object[] {
            "McDonaldsba takarító",
            "CEO of Tesla",
            "Iráni atomerőmű",
            "Lapát támasztó",
            "Logisztikai Szakasszisztens"});
            this.workplaces_cbx.Location = new System.Drawing.Point(510, 212);
            this.workplaces_cbx.Name = "workplaces_cbx";
            this.workplaces_cbx.Size = new System.Drawing.Size(164, 23);
            this.workplaces_cbx.TabIndex = 24;
            this.workplaces_cbx.SelectedIndexChanged += new System.EventHandler(this.workplaces_cbx_SelectedIndexChanged);
            // 
            // palinka_lbl
            // 
            this.palinka_lbl.AutoSize = true;
            this.palinka_lbl.Location = new System.Drawing.Point(43, 244);
            this.palinka_lbl.Name = "palinka_lbl";
            this.palinka_lbl.Size = new System.Drawing.Size(142, 15);
            this.palinka_lbl.TabIndex = 25;
            this.palinka_lbl.Text = "-Kőműves Actimel: 300 Ft";
            this.palinka_lbl.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palinka_lbl);
            this.Controls.Add(this.workplaces_cbx);
            this.Controls.Add(this.worksearch_btn);
            this.Controls.Add(this.Work_lbl);
            this.Controls.Add(this.placeholder_lbl);
            this.Controls.Add(this.revive_btn);
            this.Controls.Add(this.day_count_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.day_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hunger_PB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressbar_lbl);
            this.Controls.Add(this.trackbarvalue_lbl);
            this.Controls.Add(this.workh_TB);
            this.Controls.Add(this.Time_PB);
            this.Controls.Add(this.work_btn);
            this.Controls.Add(this.asd_lbl);
            this.Controls.Add(this.bal_lbl);
            this.Controls.Add(this.item_lbl);
            this.Controls.Add(this.menu_lbl);
            this.Controls.Add(this.penzosszeg_tb);
            this.Controls.Add(this.visszajaro_lbl);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.nev_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Life sim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workh_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_tb;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label visszajaro_lbl;
        private System.Windows.Forms.TextBox penzosszeg_tb;
        private System.Windows.Forms.Label menu_lbl;
        private System.Windows.Forms.Label item_lbl;
        private System.Windows.Forms.Label bal_lbl;
        private System.Windows.Forms.Label asd_lbl;
        private System.Windows.Forms.Button work_btn;
        private System.Windows.Forms.ProgressBar Time_PB;
        private System.Windows.Forms.TrackBar workh_TB;
        private System.Windows.Forms.Label trackbarvalue_lbl;
        private System.Windows.Forms.Label progressbar_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar hunger_PB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button day_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label day_count_tb;
        private System.Windows.Forms.Button revive_btn;
        private System.Windows.Forms.Label placeholder_lbl;
        private System.Windows.Forms.Label Work_lbl;
        private System.Windows.Forms.Button worksearch_btn;
        private System.Windows.Forms.ComboBox workplaces_cbx;
        private System.Windows.Forms.Label palinka_lbl;
    }
}

