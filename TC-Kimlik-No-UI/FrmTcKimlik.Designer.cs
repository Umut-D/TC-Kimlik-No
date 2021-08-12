namespace TcKimlikNoUI
{
    partial class FrmTcKimlik
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTcKimlik));
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.cmsSagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmKes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.lboxListe = new System.Windows.Forms.ListBox();
            this.nupSayi = new System.Windows.Forms.NumericUpDown();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.sfdKaydet = new System.Windows.Forms.SaveFileDialog();
            this.BtnTopluTest = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsSagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSayi)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.ContextMenuStrip = this.cmsSagTik;
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.Location = new System.Drawing.Point(14, 14);
            this.txtTcKimlikNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(148, 33);
            this.txtTcKimlikNo.TabIndex = 0;
            this.txtTcKimlikNo.TextChanged += new System.EventHandler(this.TxtTcKimlikNo_TextChanged);
            // 
            // cmsSagTik
            // 
            this.cmsSagTik.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsSagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKes,
            this.tsmKopyala,
            this.tsmYapistir});
            this.cmsSagTik.Name = "cmsSagTik";
            this.cmsSagTik.Size = new System.Drawing.Size(141, 88);
            // 
            // tsmKes
            // 
            this.tsmKes.Name = "tsmKes";
            this.tsmKes.Size = new System.Drawing.Size(140, 28);
            this.tsmKes.Text = "Kes";
            this.tsmKes.Click += new System.EventHandler(this.TsmKes_Click);
            // 
            // tsmKopyala
            // 
            this.tsmKopyala.Name = "tsmKopyala";
            this.tsmKopyala.Size = new System.Drawing.Size(140, 28);
            this.tsmKopyala.Text = "Kopyala";
            this.tsmKopyala.Click += new System.EventHandler(this.TsmKopyala_Click);
            // 
            // tsmYapistir
            // 
            this.tsmYapistir.Name = "tsmYapistir";
            this.tsmYapistir.Size = new System.Drawing.Size(140, 28);
            this.tsmYapistir.Text = "Yapıştır";
            this.tsmYapistir.Click += new System.EventHandler(this.TsmYapistir_Click);
            // 
            // lboxListe
            // 
            this.lboxListe.ContextMenuStrip = this.cmsSagTik;
            this.lboxListe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lboxListe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxListe.FormattingEnabled = true;
            this.lboxListe.ItemHeight = 18;
            this.lboxListe.Location = new System.Drawing.Point(15, 50);
            this.lboxListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxListe.Name = "lboxListe";
            this.lboxListe.Size = new System.Drawing.Size(211, 274);
            this.lboxListe.TabIndex = 2;
            this.lboxListe.Click += new System.EventHandler(this.LboxListe_Click);
            this.lboxListe.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LboxListe_DrawItem);
            this.lboxListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LboxListe_KeyDown);
            this.lboxListe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LboxListe_MouseDown);
            // 
            // nupSayi
            // 
            this.nupSayi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupSayi.Location = new System.Drawing.Point(169, 14);
            this.nupSayi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupSayi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupSayi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSayi.Name = "nupSayi";
            this.nupSayi.Size = new System.Drawing.Size(57, 33);
            this.nupSayi.TabIndex = 3;
            this.nupSayi.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(233, 14);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(86, 28);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(233, 296);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(86, 28);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(233, 84);
            this.btnKontrolEt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(86, 28);
            this.btnKontrolEt.TabIndex = 6;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.BtnKontrolEt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(233, 49);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 28);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // sfdKaydet
            // 
            this.sfdKaydet.DefaultExt = "*.txt";
            this.sfdKaydet.FileName = "TC Kimlik Numaraları";
            this.sfdKaydet.Filter = "Text Dosyası|*.txt";
            // 
            // BtnTopluTest
            // 
            this.BtnTopluTest.Location = new System.Drawing.Point(233, 119);
            this.BtnTopluTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTopluTest.Name = "BtnTopluTest";
            this.BtnTopluTest.Size = new System.Drawing.Size(86, 28);
            this.BtnTopluTest.TabIndex = 9;
            this.BtnTopluTest.Text = "Toplu Test";
            this.BtnTopluTest.UseVisualStyleBackColor = true;
            this.BtnTopluTest.Click += new System.EventHandler(this.BtnAktar_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBilgi});
            this.statusStrip.Location = new System.Drawing.Point(0, 334);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(331, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslBilgi
            // 
            this.tsslBilgi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsslBilgi.Name = "tsslBilgi";
            this.tsslBilgi.Size = new System.Drawing.Size(0, 15);
            // 
            // FrmTcKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 356);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.BtnTopluTest);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.nupSayi);
            this.Controls.Add(this.lboxListe);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmTcKimlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TC Kimlik No";
            this.cmsSagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupSayi)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.NumericUpDown nupSayi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.ContextMenuStrip cmsSagTik;
        private System.Windows.Forms.ToolStripMenuItem tsmKes;
        private System.Windows.Forms.ToolStripMenuItem tsmKopyala;
        private System.Windows.Forms.ToolStripMenuItem tsmYapistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.SaveFileDialog sfdKaydet;
        private System.Windows.Forms.Button BtnTopluTest;
        public System.Windows.Forms.ListBox lboxListe;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel tsslBilgi;
    }
}

