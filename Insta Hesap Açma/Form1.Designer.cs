namespace Insta_Hesap_Açma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
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
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Insta_Eposta = new System.Windows.Forms.TextBox();
            this.textBox_Insta_Kadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Insta_Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Insta_AdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_KutucuklariTemizle = new System.Windows.Forms.Button();
            this.textBox_Insta_InternetSitesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_Insta_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox_Insta_Biyografi = new System.Windows.Forms.RichTextBox();
            this.button_Insta_ProfilResmiSec = new System.Windows.Forms.Button();
            this.textBox_Insta_SeciliProfilResmiYolu = new System.Windows.Forms.TextBox();
            this.pictureBox_Insta_ProfilResmi = new System.Windows.Forms.PictureBox();
            this.button_RastgeleBilgi = new System.Windows.Forms.Button();
            this.groupBox_GonderiPaylas = new System.Windows.Forms.GroupBox();
            this.listView_Insta_GonderiListesi = new System.Windows.Forms.ListView();
            this.col_GonderiAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GonderiResimYol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_GonderiListesi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seciliGönderiSil_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_Insta_GonderiAciklamasi = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Insta_GonderiResimSec = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_InstaKayit = new System.Windows.Forms.TabPage();
            this.button_InstaHesapAc = new System.Windows.Forms.Button();
            this.button_HesapOlustur = new System.Windows.Forms.Button();
            this.tab_KayitliHesaplar = new System.Windows.Forms.TabPage();
            this.tab_ProfilDuzenleme = new System.Windows.Forms.TabPage();
            this.button_InstaGirisYap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_InstaGiris_Sifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_InstaGiris_kadi = new System.Windows.Forms.TextBox();
            this.tab_Loglar = new System.Windows.Forms.TabPage();
            this.listBox_Logs = new System.Windows.Forms.ListBox();
            this.Footer_Durum = new System.Windows.Forms.StatusStrip();
            this.Footer_Durum_Baslik = new System.Windows.Forms.ToolStripStatusLabel();
            this.Footer_Durum_Mesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta_ProfilResmi)).BeginInit();
            this.groupBox_GonderiPaylas.SuspendLayout();
            this.menu_GonderiListesi.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_InstaKayit.SuspendLayout();
            this.tab_ProfilDuzenleme.SuspendLayout();
            this.tab_Loglar.SuspendLayout();
            this.Footer_Durum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eposta";
            // 
            // textBox_Insta_Eposta
            // 
            this.textBox_Insta_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_Eposta.Location = new System.Drawing.Point(13, 29);
            this.textBox_Insta_Eposta.Name = "textBox_Insta_Eposta";
            this.textBox_Insta_Eposta.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_Eposta.TabIndex = 2;
            // 
            // textBox_Insta_Kadi
            // 
            this.textBox_Insta_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_Kadi.Location = new System.Drawing.Point(199, 29);
            this.textBox_Insta_Kadi.Name = "textBox_Insta_Kadi";
            this.textBox_Insta_Kadi.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_Kadi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(196, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // textBox_Insta_Sifre
            // 
            this.textBox_Insta_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_Sifre.Location = new System.Drawing.Point(385, 29);
            this.textBox_Insta_Sifre.Name = "textBox_Insta_Sifre";
            this.textBox_Insta_Sifre.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_Sifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(382, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // textBox_Insta_AdSoyad
            // 
            this.textBox_Insta_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_AdSoyad.Location = new System.Drawing.Point(13, 81);
            this.textBox_Insta_AdSoyad.Name = "textBox_Insta_AdSoyad";
            this.textBox_Insta_AdSoyad.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_AdSoyad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad/Soyad";
            // 
            // button_Test
            // 
            this.button_Test.AutoSize = true;
            this.button_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Test.Location = new System.Drawing.Point(740, 18);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(115, 39);
            this.button_Test.TabIndex = 9;
            this.button_Test.Text = "Test Butonu";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // button_KutucuklariTemizle
            // 
            this.button_KutucuklariTemizle.AutoSize = true;
            this.button_KutucuklariTemizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_KutucuklariTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_KutucuklariTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_KutucuklariTemizle.FlatAppearance.BorderSize = 2;
            this.button_KutucuklariTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_KutucuklariTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_KutucuklariTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KutucuklariTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KutucuklariTemizle.ForeColor = System.Drawing.Color.White;
            this.button_KutucuklariTemizle.Location = new System.Drawing.Point(379, 12);
            this.button_KutucuklariTemizle.Name = "button_KutucuklariTemizle";
            this.button_KutucuklariTemizle.Size = new System.Drawing.Size(217, 36);
            this.button_KutucuklariTemizle.TabIndex = 11;
            this.button_KutucuklariTemizle.Text = "Kutucukları Temizle";
            this.button_KutucuklariTemizle.UseVisualStyleBackColor = false;
            this.button_KutucuklariTemizle.Click += new System.EventHandler(this.Button_KutucuklariTemizle_Click);
            // 
            // textBox_Insta_InternetSitesi
            // 
            this.textBox_Insta_InternetSitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Insta_InternetSitesi.Location = new System.Drawing.Point(199, 81);
            this.textBox_Insta_InternetSitesi.Name = "textBox_Insta_InternetSitesi";
            this.textBox_Insta_InternetSitesi.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_InternetSitesi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(196, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "İnternet Sitesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(382, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cinsiyet";
            // 
            // combo_Insta_Cinsiyet
            // 
            this.combo_Insta_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Insta_Cinsiyet.FormattingEnabled = true;
            this.combo_Insta_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Söylememeyi Tercih Ediyorum"});
            this.combo_Insta_Cinsiyet.Location = new System.Drawing.Point(385, 81);
            this.combo_Insta_Cinsiyet.Name = "combo_Insta_Cinsiyet";
            this.combo_Insta_Cinsiyet.Size = new System.Drawing.Size(180, 24);
            this.combo_Insta_Cinsiyet.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Biyografi";
            // 
            // richTextBox_Insta_Biyografi
            // 
            this.richTextBox_Insta_Biyografi.Location = new System.Drawing.Point(13, 130);
            this.richTextBox_Insta_Biyografi.Name = "richTextBox_Insta_Biyografi";
            this.richTextBox_Insta_Biyografi.Size = new System.Drawing.Size(366, 133);
            this.richTextBox_Insta_Biyografi.TabIndex = 14;
            this.richTextBox_Insta_Biyografi.Text = "";
            // 
            // button_Insta_ProfilResmiSec
            // 
            this.button_Insta_ProfilResmiSec.AutoSize = true;
            this.button_Insta_ProfilResmiSec.Location = new System.Drawing.Point(385, 130);
            this.button_Insta_ProfilResmiSec.Name = "button_Insta_ProfilResmiSec";
            this.button_Insta_ProfilResmiSec.Size = new System.Drawing.Size(180, 28);
            this.button_Insta_ProfilResmiSec.TabIndex = 15;
            this.button_Insta_ProfilResmiSec.Text = "Profil Resmi Seç";
            this.button_Insta_ProfilResmiSec.UseVisualStyleBackColor = true;
            this.button_Insta_ProfilResmiSec.Click += new System.EventHandler(this.Button_Insta_ProfilResmiSec_Click);
            // 
            // textBox_Insta_SeciliProfilResmiYolu
            // 
            this.textBox_Insta_SeciliProfilResmiYolu.Location = new System.Drawing.Point(385, 164);
            this.textBox_Insta_SeciliProfilResmiYolu.Name = "textBox_Insta_SeciliProfilResmiYolu";
            this.textBox_Insta_SeciliProfilResmiYolu.ReadOnly = true;
            this.textBox_Insta_SeciliProfilResmiYolu.Size = new System.Drawing.Size(180, 22);
            this.textBox_Insta_SeciliProfilResmiYolu.TabIndex = 16;
            // 
            // pictureBox_Insta_ProfilResmi
            // 
            this.pictureBox_Insta_ProfilResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Insta_ProfilResmi.Location = new System.Drawing.Point(385, 195);
            this.pictureBox_Insta_ProfilResmi.Name = "pictureBox_Insta_ProfilResmi";
            this.pictureBox_Insta_ProfilResmi.Size = new System.Drawing.Size(180, 68);
            this.pictureBox_Insta_ProfilResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Insta_ProfilResmi.TabIndex = 17;
            this.pictureBox_Insta_ProfilResmi.TabStop = false;
            // 
            // button_RastgeleBilgi
            // 
            this.button_RastgeleBilgi.AutoSize = true;
            this.button_RastgeleBilgi.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_RastgeleBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RastgeleBilgi.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button_RastgeleBilgi.FlatAppearance.BorderSize = 2;
            this.button_RastgeleBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_RastgeleBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_RastgeleBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RastgeleBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_RastgeleBilgi.ForeColor = System.Drawing.Color.White;
            this.button_RastgeleBilgi.Location = new System.Drawing.Point(12, 12);
            this.button_RastgeleBilgi.Name = "button_RastgeleBilgi";
            this.button_RastgeleBilgi.Size = new System.Drawing.Size(244, 36);
            this.button_RastgeleBilgi.TabIndex = 13;
            this.button_RastgeleBilgi.Text = "Rastgele Hesap Bilgileri Oluştur";
            this.button_RastgeleBilgi.UseVisualStyleBackColor = false;
            this.button_RastgeleBilgi.Click += new System.EventHandler(this.Button_RastgeleBilgi_Click);
            // 
            // groupBox_GonderiPaylas
            // 
            this.groupBox_GonderiPaylas.Controls.Add(this.listView_Insta_GonderiListesi);
            this.groupBox_GonderiPaylas.Controls.Add(this.richTextBox_Insta_GonderiAciklamasi);
            this.groupBox_GonderiPaylas.Controls.Add(this.label8);
            this.groupBox_GonderiPaylas.Controls.Add(this.button_Insta_GonderiResimSec);
            this.groupBox_GonderiPaylas.Location = new System.Drawing.Point(13, 269);
            this.groupBox_GonderiPaylas.Name = "groupBox_GonderiPaylas";
            this.groupBox_GonderiPaylas.Size = new System.Drawing.Size(552, 209);
            this.groupBox_GonderiPaylas.TabIndex = 18;
            this.groupBox_GonderiPaylas.TabStop = false;
            this.groupBox_GonderiPaylas.Text = "Gönderi Paylaş";
            // 
            // listView_Insta_GonderiListesi
            // 
            this.listView_Insta_GonderiListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_GonderiAciklama,
            this.col_GonderiResimYol});
            this.listView_Insta_GonderiListesi.ContextMenuStrip = this.menu_GonderiListesi;
            this.listView_Insta_GonderiListesi.FullRowSelect = true;
            this.listView_Insta_GonderiListesi.HideSelection = false;
            this.listView_Insta_GonderiListesi.LabelEdit = true;
            this.listView_Insta_GonderiListesi.Location = new System.Drawing.Point(11, 111);
            this.listView_Insta_GonderiListesi.Name = "listView_Insta_GonderiListesi";
            this.listView_Insta_GonderiListesi.Size = new System.Drawing.Size(528, 81);
            this.listView_Insta_GonderiListesi.TabIndex = 16;
            this.listView_Insta_GonderiListesi.UseCompatibleStateImageBehavior = false;
            this.listView_Insta_GonderiListesi.View = System.Windows.Forms.View.Details;
            // 
            // col_GonderiAciklama
            // 
            this.col_GonderiAciklama.Text = "Açıklama";
            this.col_GonderiAciklama.Width = 300;
            // 
            // col_GonderiResimYol
            // 
            this.col_GonderiResimYol.Text = "Resim Yolu";
            this.col_GonderiResimYol.Width = 200;
            // 
            // menu_GonderiListesi
            // 
            this.menu_GonderiListesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seciliGönderiSil_MenuItem});
            this.menu_GonderiListesi.Name = "menu_GonderiListesi";
            this.menu_GonderiListesi.Size = new System.Drawing.Size(162, 26);
            // 
            // seciliGönderiSil_MenuItem
            // 
            this.seciliGönderiSil_MenuItem.Name = "seciliGönderiSil_MenuItem";
            this.seciliGönderiSil_MenuItem.Size = new System.Drawing.Size(161, 22);
            this.seciliGönderiSil_MenuItem.Text = "Seçili Gönderi Sil";
            this.seciliGönderiSil_MenuItem.Click += new System.EventHandler(this.SeciliGönderiSil_MenuItem_Click);
            // 
            // richTextBox_Insta_GonderiAciklamasi
            // 
            this.richTextBox_Insta_GonderiAciklamasi.Location = new System.Drawing.Point(11, 41);
            this.richTextBox_Insta_GonderiAciklamasi.Name = "richTextBox_Insta_GonderiAciklamasi";
            this.richTextBox_Insta_GonderiAciklamasi.Size = new System.Drawing.Size(401, 64);
            this.richTextBox_Insta_GonderiAciklamasi.TabIndex = 14;
            this.richTextBox_Insta_GonderiAciklamasi.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gönderi Açıklaması";
            // 
            // button_Insta_GonderiResimSec
            // 
            this.button_Insta_GonderiResimSec.AutoSize = true;
            this.button_Insta_GonderiResimSec.Location = new System.Drawing.Point(418, 41);
            this.button_Insta_GonderiResimSec.Name = "button_Insta_GonderiResimSec";
            this.button_Insta_GonderiResimSec.Size = new System.Drawing.Size(132, 64);
            this.button_Insta_GonderiResimSec.TabIndex = 14;
            this.button_Insta_GonderiResimSec.Text = "Resim Seç ve Ekle";
            this.button_Insta_GonderiResimSec.UseVisualStyleBackColor = true;
            this.button_Insta_GonderiResimSec.Click += new System.EventHandler(this.Button_Insta_GonderiResimSec_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_InstaKayit);
            this.tabControl1.Controls.Add(this.tab_KayitliHesaplar);
            this.tabControl1.Controls.Add(this.tab_ProfilDuzenleme);
            this.tabControl1.Controls.Add(this.tab_Loglar);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 562);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_InstaKayit
            // 
            this.tab_InstaKayit.Controls.Add(this.button_InstaHesapAc);
            this.tab_InstaKayit.Controls.Add(this.button_HesapOlustur);
            this.tab_InstaKayit.Controls.Add(this.groupBox_GonderiPaylas);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_Eposta);
            this.tab_InstaKayit.Controls.Add(this.pictureBox_Insta_ProfilResmi);
            this.tab_InstaKayit.Controls.Add(this.label3);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_SeciliProfilResmiYolu);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_Sifre);
            this.tab_InstaKayit.Controls.Add(this.button_Insta_ProfilResmiSec);
            this.tab_InstaKayit.Controls.Add(this.label4);
            this.tab_InstaKayit.Controls.Add(this.richTextBox_Insta_Biyografi);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_AdSoyad);
            this.tab_InstaKayit.Controls.Add(this.label7);
            this.tab_InstaKayit.Controls.Add(this.label2);
            this.tab_InstaKayit.Controls.Add(this.combo_Insta_Cinsiyet);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_Kadi);
            this.tab_InstaKayit.Controls.Add(this.label6);
            this.tab_InstaKayit.Controls.Add(this.label1);
            this.tab_InstaKayit.Controls.Add(this.textBox_Insta_InternetSitesi);
            this.tab_InstaKayit.Controls.Add(this.label5);
            this.tab_InstaKayit.Location = new System.Drawing.Point(4, 25);
            this.tab_InstaKayit.Name = "tab_InstaKayit";
            this.tab_InstaKayit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InstaKayit.Size = new System.Drawing.Size(580, 533);
            this.tab_InstaKayit.TabIndex = 0;
            this.tab_InstaKayit.Text = "Instagram Kayıt";
            this.tab_InstaKayit.UseVisualStyleBackColor = true;
            // 
            // button_InstaHesapAc
            // 
            this.button_InstaHesapAc.AutoSize = true;
            this.button_InstaHesapAc.BackColor = System.Drawing.Color.DarkGreen;
            this.button_InstaHesapAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InstaHesapAc.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button_InstaHesapAc.FlatAppearance.BorderSize = 2;
            this.button_InstaHesapAc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_InstaHesapAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button_InstaHesapAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InstaHesapAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_InstaHesapAc.ForeColor = System.Drawing.Color.White;
            this.button_InstaHesapAc.Location = new System.Drawing.Point(13, 484);
            this.button_InstaHesapAc.Name = "button_InstaHesapAc";
            this.button_InstaHesapAc.Size = new System.Drawing.Size(180, 36);
            this.button_InstaHesapAc.TabIndex = 19;
            this.button_InstaHesapAc.Text = "Hesap Oluştur";
            this.button_InstaHesapAc.UseVisualStyleBackColor = false;
            this.button_InstaHesapAc.Click += new System.EventHandler(this.Button_InstaHesapAc_Click);
            // 
            // button_HesapOlustur
            // 
            this.button_HesapOlustur.AutoSize = true;
            this.button_HesapOlustur.BackColor = System.Drawing.Color.DarkGreen;
            this.button_HesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HesapOlustur.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button_HesapOlustur.FlatAppearance.BorderSize = 2;
            this.button_HesapOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_HesapOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button_HesapOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_HesapOlustur.ForeColor = System.Drawing.Color.White;
            this.button_HesapOlustur.Location = new System.Drawing.Point(383, 484);
            this.button_HesapOlustur.Name = "button_HesapOlustur";
            this.button_HesapOlustur.Size = new System.Drawing.Size(180, 36);
            this.button_HesapOlustur.TabIndex = 15;
            this.button_HesapOlustur.Text = "Hesap Oluştur";
            this.button_HesapOlustur.UseVisualStyleBackColor = false;
            this.button_HesapOlustur.Visible = false;
            this.button_HesapOlustur.Click += new System.EventHandler(this.Button_HesapOlustur_Click);
            // 
            // tab_KayitliHesaplar
            // 
            this.tab_KayitliHesaplar.Location = new System.Drawing.Point(4, 25);
            this.tab_KayitliHesaplar.Name = "tab_KayitliHesaplar";
            this.tab_KayitliHesaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_KayitliHesaplar.Size = new System.Drawing.Size(580, 533);
            this.tab_KayitliHesaplar.TabIndex = 1;
            this.tab_KayitliHesaplar.Text = "Kayıtlı Hesaplar";
            this.tab_KayitliHesaplar.UseVisualStyleBackColor = true;
            // 
            // tab_ProfilDuzenleme
            // 
            this.tab_ProfilDuzenleme.Controls.Add(this.button_InstaGirisYap);
            this.tab_ProfilDuzenleme.Controls.Add(this.label9);
            this.tab_ProfilDuzenleme.Controls.Add(this.textBox_InstaGiris_Sifre);
            this.tab_ProfilDuzenleme.Controls.Add(this.label10);
            this.tab_ProfilDuzenleme.Controls.Add(this.textBox_InstaGiris_kadi);
            this.tab_ProfilDuzenleme.Location = new System.Drawing.Point(4, 25);
            this.tab_ProfilDuzenleme.Name = "tab_ProfilDuzenleme";
            this.tab_ProfilDuzenleme.Size = new System.Drawing.Size(580, 533);
            this.tab_ProfilDuzenleme.TabIndex = 3;
            this.tab_ProfilDuzenleme.Text = "Profil Düzenleme";
            this.tab_ProfilDuzenleme.UseVisualStyleBackColor = true;
            // 
            // button_InstaGirisYap
            // 
            this.button_InstaGirisYap.AutoSize = true;
            this.button_InstaGirisYap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_InstaGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InstaGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_InstaGirisYap.FlatAppearance.BorderSize = 2;
            this.button_InstaGirisYap.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_InstaGirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_InstaGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InstaGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_InstaGirisYap.ForeColor = System.Drawing.Color.White;
            this.button_InstaGirisYap.Location = new System.Drawing.Point(388, 38);
            this.button_InstaGirisYap.Name = "button_InstaGirisYap";
            this.button_InstaGirisYap.Size = new System.Drawing.Size(180, 32);
            this.button_InstaGirisYap.TabIndex = 12;
            this.button_InstaGirisYap.Text = "Giriş Yap";
            this.button_InstaGirisYap.UseVisualStyleBackColor = false;
            this.button_InstaGirisYap.Click += new System.EventHandler(this.Button_InstaGirisYap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(199, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Şifre";
            // 
            // textBox_InstaGiris_Sifre
            // 
            this.textBox_InstaGiris_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_InstaGiris_Sifre.Location = new System.Drawing.Point(202, 42);
            this.textBox_InstaGiris_Sifre.Name = "textBox_InstaGiris_Sifre";
            this.textBox_InstaGiris_Sifre.Size = new System.Drawing.Size(180, 22);
            this.textBox_InstaGiris_Sifre.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Kullanıcı Adı";
            // 
            // textBox_InstaGiris_kadi
            // 
            this.textBox_InstaGiris_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_InstaGiris_kadi.Location = new System.Drawing.Point(16, 42);
            this.textBox_InstaGiris_kadi.Name = "textBox_InstaGiris_kadi";
            this.textBox_InstaGiris_kadi.Size = new System.Drawing.Size(180, 22);
            this.textBox_InstaGiris_kadi.TabIndex = 8;
            // 
            // tab_Loglar
            // 
            this.tab_Loglar.Controls.Add(this.listBox_Logs);
            this.tab_Loglar.Location = new System.Drawing.Point(4, 25);
            this.tab_Loglar.Name = "tab_Loglar";
            this.tab_Loglar.Size = new System.Drawing.Size(580, 533);
            this.tab_Loglar.TabIndex = 2;
            this.tab_Loglar.Text = "İşlem Logları";
            this.tab_Loglar.UseVisualStyleBackColor = true;
            // 
            // listBox_Logs
            // 
            this.listBox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Logs.FormattingEnabled = true;
            this.listBox_Logs.ItemHeight = 16;
            this.listBox_Logs.Location = new System.Drawing.Point(0, 0);
            this.listBox_Logs.Name = "listBox_Logs";
            this.listBox_Logs.Size = new System.Drawing.Size(580, 533);
            this.listBox_Logs.TabIndex = 0;
            // 
            // Footer_Durum
            // 
            this.Footer_Durum.BackColor = System.Drawing.Color.LightGray;
            this.Footer_Durum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Footer_Durum_Baslik,
            this.Footer_Durum_Mesaj});
            this.Footer_Durum.Location = new System.Drawing.Point(0, 644);
            this.Footer_Durum.Name = "Footer_Durum";
            this.Footer_Durum.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.Footer_Durum.Size = new System.Drawing.Size(869, 22);
            this.Footer_Durum.SizingGrip = false;
            this.Footer_Durum.TabIndex = 15;
            // 
            // Footer_Durum_Baslik
            // 
            this.Footer_Durum_Baslik.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Footer_Durum_Baslik.Name = "Footer_Durum_Baslik";
            this.Footer_Durum_Baslik.Size = new System.Drawing.Size(48, 17);
            this.Footer_Durum_Baslik.Text = "Durum:";
            // 
            // Footer_Durum_Mesaj
            // 
            this.Footer_Durum_Mesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Footer_Durum_Mesaj.Name = "Footer_Durum_Mesaj";
            this.Footer_Durum_Mesaj.Size = new System.Drawing.Size(67, 17);
            this.Footer_Durum_Mesaj.Text = "Bekleniyor..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(639, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 121);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 666);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Footer_Durum);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_RastgeleBilgi);
            this.Controls.Add(this.button_KutucuklariTemizle);
            this.Controls.Add(this.button_Test);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Hesap Açma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta_ProfilResmi)).EndInit();
            this.groupBox_GonderiPaylas.ResumeLayout(false);
            this.groupBox_GonderiPaylas.PerformLayout();
            this.menu_GonderiListesi.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_InstaKayit.ResumeLayout(false);
            this.tab_InstaKayit.PerformLayout();
            this.tab_ProfilDuzenleme.ResumeLayout(false);
            this.tab_ProfilDuzenleme.PerformLayout();
            this.tab_Loglar.ResumeLayout(false);
            this.Footer_Durum.ResumeLayout(false);
            this.Footer_Durum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Insta_Eposta;
        private System.Windows.Forms.TextBox textBox_Insta_Kadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Insta_Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Insta_AdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_KutucuklariTemizle;
        private System.Windows.Forms.ComboBox combo_Insta_Cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Insta_InternetSitesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_Insta_Biyografi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Insta_SeciliProfilResmiYolu;
        private System.Windows.Forms.Button button_Insta_ProfilResmiSec;
        private System.Windows.Forms.PictureBox pictureBox_Insta_ProfilResmi;
        private System.Windows.Forms.Button button_RastgeleBilgi;
        private System.Windows.Forms.GroupBox groupBox_GonderiPaylas;
        private System.Windows.Forms.Button button_Insta_GonderiResimSec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox_Insta_GonderiAciklamasi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_InstaKayit;
        private System.Windows.Forms.TabPage tab_KayitliHesaplar;
        private System.Windows.Forms.Button button_HesapOlustur;
        private System.Windows.Forms.TabPage tab_Loglar;
        private System.Windows.Forms.ListBox listBox_Logs;
        private System.Windows.Forms.StatusStrip Footer_Durum;
        private System.Windows.Forms.ToolStripStatusLabel Footer_Durum_Baslik;
        private System.Windows.Forms.ToolStripStatusLabel Footer_Durum_Mesaj;
        private System.Windows.Forms.ListView listView_Insta_GonderiListesi;
        private System.Windows.Forms.ColumnHeader col_GonderiAciklama;
        private System.Windows.Forms.ColumnHeader col_GonderiResimYol;
        private System.Windows.Forms.ContextMenuStrip menu_GonderiListesi;
        private System.Windows.Forms.ToolStripMenuItem seciliGönderiSil_MenuItem;
        private System.Windows.Forms.TabPage tab_ProfilDuzenleme;
        private System.Windows.Forms.Button button_InstaGirisYap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_InstaGiris_Sifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_InstaGiris_kadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_InstaHesapAc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

