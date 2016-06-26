namespace WinSayisalLoto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnUret = new System.Windows.Forms.Button();
            this.lstTahminler = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuFarkli = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFarkliAc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Adedi :";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(147, 67);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAdet.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(116, 27);
            this.nudAdet.TabIndex = 1;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(270, 58);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(115, 40);
            this.btnUret.TabIndex = 2;
            this.btnUret.Text = "Tahmin Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lstTahminler
            // 
            this.lstTahminler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTahminler.FormattingEnabled = true;
            this.lstTahminler.ItemHeight = 19;
            this.lstTahminler.Location = new System.Drawing.Point(147, 101);
            this.lstTahminler.Name = "lstTahminler";
            this.lstTahminler.Size = new System.Drawing.Size(238, 156);
            this.lstTahminler.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuFarkli});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAc,
            this.mnuKaydet,
            this.toolStripMenuItem1,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Enabled = false;
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.Size = new System.Drawing.Size(152, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.mnuKaydet_Click);
            // 
            // mnuAc
            // 
            this.mnuAc.Name = "mnuAc";
            this.mnuAc.Size = new System.Drawing.Size(152, 22);
            this.mnuAc.Text = "Aç";
            this.mnuAc.Click += new System.EventHandler(this.mnuAc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(152, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(270, 27);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(115, 27);
            this.txtDosyaAdi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dosya Adı :";
            // 
            // mnuFarkli
            // 
            this.mnuFarkli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFarkliAc,
            this.mnuFarkliKaydet});
            this.mnuFarkli.Name = "mnuFarkli";
            this.mnuFarkli.Size = new System.Drawing.Size(105, 20);
            this.mnuFarkli.Text = "Farklı Aç/Kaydet";
            // 
            // mnuFarkliAc
            // 
            this.mnuFarkliAc.Name = "mnuFarkliAc";
            this.mnuFarkliAc.Size = new System.Drawing.Size(152, 22);
            this.mnuFarkliAc.Text = "Farklı Aç";
            this.mnuFarkliAc.Click += new System.EventHandler(this.mnuFarkliAc_Click);
            // 
            // mnuFarkliKaydet
            // 
            this.mnuFarkliKaydet.Enabled = false;
            this.mnuFarkliKaydet.Name = "mnuFarkliKaydet";
            this.mnuFarkliKaydet.Size = new System.Drawing.Size(152, 22);
            this.mnuFarkliKaydet.Text = "Farklı Kaydet";
            this.mnuFarkliKaydet.Click += new System.EventHandler(this.mnuFarkliKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 274);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.lstTahminler);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sayısal Loto Tahmin Üretici";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.ListBox lstTahminler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuAc;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuFarkli;
        private System.Windows.Forms.ToolStripMenuItem mnuFarkliAc;
        private System.Windows.Forms.ToolStripMenuItem mnuFarkliKaydet;
    }
}

