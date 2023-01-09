namespace _02_UrunEklemeOtomasyonu
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stok = new System.Windows.Forms.NumericUpDown();
            this.birimFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listeUrunler = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderurunAdi = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderKategori = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderBirimFiyat = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderstok = new System.Windows.Forms.ColumnHeader();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKategoriEklemeEkranı = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimFiyat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stok);
            this.groupBox1.Controls.Add(this.birimFiyat);
            this.groupBox1.Controls.Add(this.cmbKategoriAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme Paneli";
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(218, 266);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(327, 35);
            this.stok.TabIndex = 10;
            // 
            // birimFiyat
            // 
            this.birimFiyat.Location = new System.Drawing.Point(218, 194);
            this.birimFiyat.Name = "birimFiyat";
            this.birimFiyat.Size = new System.Drawing.Size(327, 35);
            this.birimFiyat.TabIndex = 9;
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(218, 46);
            this.cmbKategoriAdi.Name = "cmbKategoriAdi";
            this.cmbKategoriAdi.Size = new System.Drawing.Size(327, 38);
            this.cmbKategoriAdi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birim Fiyatı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(218, 114);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(327, 35);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listeUrunler);
            this.groupBox2.Location = new System.Drawing.Point(22, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // listeUrunler
            // 
            this.listeUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderurunAdi,
            this.columnHeaderKategori,
            this.columnHeaderBirimFiyat,
            this.columnHeaderstok});
            this.listeUrunler.FullRowSelect = true;
            this.listeUrunler.Location = new System.Drawing.Point(6, 34);
            this.listeUrunler.Name = "listeUrunler";
            this.listeUrunler.Size = new System.Drawing.Size(1064, 454);
            this.listeUrunler.TabIndex = 0;
            this.listeUrunler.UseCompatibleStateImageBehavior = false;
            this.listeUrunler.View = System.Windows.Forms.View.Details;
            this.listeUrunler.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderurunAdi
            // 
            this.columnHeaderurunAdi.Text = "Ürün Adı";
            this.columnHeaderurunAdi.Width = 220;
            // 
            // columnHeaderKategori
            // 
            this.columnHeaderKategori.Text = "Kategori";
            this.columnHeaderKategori.Width = 220;
            // 
            // columnHeaderBirimFiyat
            // 
            this.columnHeaderBirimFiyat.Text = "Birim Fiyatı";
            this.columnHeaderBirimFiyat.Width = 220;
            // 
            // columnHeaderstok
            // 
            this.columnHeaderstok.Text = "Stok Durumu";
            this.columnHeaderstok.Width = 220;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(639, 70);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(259, 119);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(639, 217);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(259, 121);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(639, 366);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(259, 117);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKategoriEklemeEkranı
            // 
            this.btnKategoriEklemeEkranı.Location = new System.Drawing.Point(22, 1053);
            this.btnKategoriEklemeEkranı.Name = "btnKategoriEklemeEkranı";
            this.btnKategoriEklemeEkranı.Size = new System.Drawing.Size(1076, 87);
            this.btnKategoriEklemeEkranı.TabIndex = 5;
            this.btnKategoriEklemeEkranı.Text = "Kategori Ekleme Ekranına Dön";
            this.btnKategoriEklemeEkranı.UseVisualStyleBackColor = true;
            this.btnKategoriEklemeEkranı.Click += new System.EventHandler(this.btnKategoriEklemeEkranı_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 1152);
            this.Controls.Add(this.btnKategoriEklemeEkranı);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimFiyat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKategoriEklemeEkranı;
        private TextBox txtUrunAdi;
        private Label label2;
        private TextBox txtkategori;
        private Label label1;
        private Label label4;
        private Label label3;
        private ListView listView1;
        private NumericUpDown stok;
        private NumericUpDown birimFiyat;
        private ComboBox cmbKategoriAdi;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderurunAdi;
        private ColumnHeader columnHeaderKategori;
        private ColumnHeader columnHeaderBirimFiyat;
        private ColumnHeader columnHeaderstok;
        private ListView listeUrunler;
    }
}