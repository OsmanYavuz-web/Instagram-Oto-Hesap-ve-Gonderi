using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Enums;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;

namespace Insta_Hesap_Açma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Referanslar ve Değişkenler
        /// </summary>
        const string KullaniciAdi_Ek = "seowebgrafik";

        private string Yol_Resimler = Application.StartupPath + @"\Resimler\";
        SabitKodlar c_SabitKod = new SabitKodlar();
        InstaKontrol Insta = new InstaKontrol();
        private static IInstaApi InstaApi;
        const string StateFile = "state.bin";



        ChromeDriver chrome;
        Thread thread;
        string kayit_url = "https://www.instagram.com/";
        string profil_duzenle_url = "https://www.instagram.com/accounts/edit/";
        string hesap_gizle_url = "https://www.instagram.com/accounts/privacy_and_security/";




        #region Bilgi Mesajı Bildirim Sistemi > BilgiMesaji(ifade, mesaj, baslik) > hata, bilgi, soru
        void BilgiMesaji(string ifade, string mesaj, string baslik, bool mesajKutusu = false, bool logEkle = true)
        {
            try
            {
                string zaman = DateTime.Now.ToString("dd/MM/yyyy HH:mm").ToString();
                baslik = this.Text;
                switch (ifade)
                {
                    case "hata":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }

                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkRed;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "bilgi":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkBlue;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "soru":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkBlue;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    case "basarili":
                        // mesaj kutusunda göster
                        if (mesajKutusu == true)
                        {
                            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // işlem penceresine aktar
                        if (logEkle == true)
                        {
                            listBox_Logs.Items.Insert(0, "[" + zaman + "] " + mesaj);
                        }
                        // durum çubuğu
                        Footer_Durum_Mesaj.ForeColor = Color.DarkGreen;
                        Footer_Durum_Mesaj.Text = "[" + zaman + "] " + mesaj;
                        break;

                    default:
                        MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK);
                        break;
                }
            }
            catch (Exception ex)
            {
                // log kaydet
                //c_AnaKodlar.LogKaydiOlustur("Hata", Program.Yol_Loglar, "Bilgi Mesajı sırasında hata oluştu." + " " + KullaniciAdi, ex.Message, ex.StackTrace);
            }
        }
        #endregion


        /// <summary>
        /// Oturum yükleme
        /// </summary>
        void LoadSession()
        {
            InstaApi?.SessionHandler?.Load();
        }


        /// <summary>
        /// Oturum kaydetme
        /// </summary>
        void SaveSession()
        {
            if (InstaApi == null)
                return;
            if (!InstaApi.IsUserAuthenticated)
                return;
            InstaApi.SessionHandler.Save();

        }




        /// <summary>
        /// Form Load
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thread Aktifleştirme
            CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;

            // Klasörleri kontrol et
            c_SabitKod.Klasor_Kontrol(Yol_Resimler);

            thread = new Thread(calistir);
            thread.Start();
        }

        


        /// <summary>
        /// Rastgele Hesap Bilgileri Oluşturma
        /// </summary>
        private void Button_RastgeleBilgi_Click(object sender, EventArgs e)
        {
            var RastgeleHesap = Task.Run(() =>
            {

                try
                {
                    // Bilgi Mesajı
                    BilgiMesaji("bilgi", "Rastgele hesap oluşturuluyor bekleyin.", this.Text);

                    // Siteye bağlan
                    /*
                    WebProxy proxy = new WebProxy();
                    proxy.Address = new Uri("");
                    proxy.Credentials = new NetworkCredential("usernameHere", "pa****rdHere");  //These can be replaced by user input
                    proxy.UseDefaultCredentials = false;
                    proxy.BypassProxyOnLocal = false;  //still use the proxy for local addresses
                    */

                    WebClient webClientBaglanti = new WebClient();
                    webClientBaglanti.Encoding = Encoding.UTF8;
                    //webClientBaglanti.Proxy = proxy;

                    string JsonKod = webClientBaglanti.DownloadString("https://uinames.com/api/?region=turkey&ext");
                    webClientBaglanti.Dispose();

                    // Json Çıktısı
                    JObject JSONParser = JObject.Parse(JsonKod);

                    // Kullanıcı bilgileri
                    string ad = (string)JSONParser["name"];
                    string soyad = (string)JSONParser["surname"];
                    string cinsiyet = (string)JSONParser["gender"];
                    string profil_resmi = (string)JSONParser["photo"];


                    // Oluştur
                    string kadi = c_SabitKod.TurkceToEnglish(ad.ToLower() + "." + soyad.ToLower()) + "." + KullaniciAdi_Ek;
                    string eposta = kadi + "@hotmail.com";
                    string sifre = c_SabitKod.YeniSifreOlusturma(10);

                    // Verileri aktarma
                    textBox_Insta_Eposta.Text = eposta;
                    textBox_Insta_Kadi.Text = kadi;
                    textBox_Insta_Sifre.Text = sifre;
                    textBox_Insta_AdSoyad.Text = ad + " " + soyad;
                    if (cinsiyet == "male")
                    {
                        combo_Insta_Cinsiyet.SelectedIndex = 0;
                    }
                    else
                    {
                        combo_Insta_Cinsiyet.SelectedIndex = 1;
                    }

                    // resim indirme
                    string resimKayitYolu = Yol_Resimler + kadi + ".jpg";
                    if (c_SabitKod.ResimIndir(profil_resmi, resimKayitYolu))
                    {
                        textBox_Insta_SeciliProfilResmiYolu.Text = resimKayitYolu;
                        pictureBox_Insta_ProfilResmi.ImageLocation = resimKayitYolu;
                    }


                }
                catch (Exception ex)
                {
                    // Bilgi Mesajı
                    BilgiMesaji("hata", "Rastgele hesap oluştururken sorun oluştu;\n\n" + ex.Message, this.Text, true);
                }
                finally
                {
                    // Bilgi Mesajı
                    BilgiMesaji("basarili", "Rastgele hesap oluşturuldu.", this.Text);
                }

            });

        }



        /// <summary>
        /// Kutucukları Temizleme Butonu
        /// </summary>
        private void Button_KutucuklariTemizle_Click(object sender, EventArgs e)
        {
            // sor bakalım istiyor mu :)
            DialogResult soru = MessageBox.Show("Kutucuklar temizlensin mi?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                try
                {
                    foreach (Control item in tab_InstaKayit.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox kutu = (TextBox)item;
                            kutu.Clear();
                        }
                        combo_Insta_Cinsiyet.Text = "";
                        pictureBox_Insta_ProfilResmi.InitialImage = null;
                        richTextBox_Insta_Biyografi.Clear();
                        richTextBox_Insta_GonderiAciklamasi.Clear();
                        listView_Insta_GonderiListesi.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    // Bilgi Mesajı
                    BilgiMesaji("hata", "Kutucuklar temizlenirken bir hata oluştu;\n\n" + ex.Message, this.Text, true);
                }
            }

        }



        /// <summary>
        /// Oluşturulacak hesaba profil resmi seçme
        /// </summary>
        private void Button_Insta_ProfilResmiSec_Click(object sender, EventArgs e)
        {
            try
            {
                // Resim seç ve picturebox aktar
                OpenFileDialog resimSec = new OpenFileDialog();
                resimSec.Title = "Instagram Profil Resmi Seç";
                resimSec.Filter = "Resim Dosyası (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    textBox_Insta_SeciliProfilResmiYolu.Text = resimSec.FileName;
                    pictureBox_Insta_ProfilResmi.ImageLocation = resimSec.FileName;
                }
            }
            catch (Exception ex)
            {
                // Bilgi Mesajı
                BilgiMesaji("hata", "Profil resmi seçilirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
            }
        }



        /// <summary>
        /// Gönderi paylaşımı için ekleme yapma
        /// </summary>
        private void Button_Insta_GonderiResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                // Resim seç ve picturebox aktar
                OpenFileDialog resimSec = new OpenFileDialog();
                resimSec.Title = "Instagram Profil Resmi Seç";
                resimSec.Filter = "Resim Dosyası (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    // listeye ekle
                    string[] ekle = { richTextBox_Insta_GonderiAciklamasi.Text, resimSec.FileName };
                    var satir = new ListViewItem(ekle);
                    listView_Insta_GonderiListesi.Items.Add(satir);
                }
            }
            catch (Exception ex)
            {
                // Bilgi Mesajı
                BilgiMesaji("hata", "Profil resmi seçilirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
            }
        }



        /// <summary>
        /// Gönderi listesinden seçili gönderiyi sil
        /// </summary>
        private void SeciliGönderiSil_MenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Insta_GonderiListesi.SelectedItems.Count == 1)
            {
                DialogResult soru = MessageBox.Show("Seçili gönderi silinsin mi?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    // sil
                    try
                    {
                        // listeden silme
                        listView_Insta_GonderiListesi.SelectedItems[0].Remove();

                        // Bilgi Mesajı
                        BilgiMesaji("basarili", "Seçili gönderi başarıyla silindi.", this.Text, false);
                    }
                    catch (Exception ex)
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Seçili gönderi silinirken sorun oluştu;\n\n" + ex.Message, this.Text, true);
                    }
                }
            }
        }



        /// <summary>
        /// Hesap Oluşturma Butonu
        /// </summary>
        private void Button_HesapOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                // Task açıldı
                Task HesapAc = Task.Run(() =>
                {
                    // Bilgi Mesajı
                    BilgiMesaji("bilgi", "Instagram hesabı oluşturuluyor, lütfen bekleyin.", this.Text, false);

                    // Genel Kontroller

                    // Eposta boş mu?
                    if (textBox_Insta_Eposta.Text == "" || textBox_Insta_Eposta.Text == null)
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Epostayı boş bırakamazsınız.", this.Text, true);
                    }

                    // Kullanıcı adı boş mu?
                    else if (textBox_Insta_Kadi.Text == "" || textBox_Insta_Kadi.Text == null)
                    {
                        // Bilgi Mesajı
                        BilgiMesaji("hata", "Kullanıcı adını boş bırakamazsınız.", this.Text, true);
                    }

                    // Hiçbiri değilse devam
                    else
                    {

                        // ADIMLAR

                        /*
                         * 1- Eposta kontrol ettir
                         */
                        string EpostaKontrol = Insta.Insta_EpostaKontrol(textBox_Insta_Eposta.Text);
                        if (EpostaKontrol == "false")
                        {
                            // Bilgi Mesajı
                            BilgiMesaji("hata", "Eposta Instagram için uygun değil.", this.Text, true);
                        }
                        else
                        {
                            /*
                             * 2- Kullanıcı adı uygunkuk kontrol ettir
                             */
                            string KadiKontrol = Insta.Insta_KadiKontrol(textBox_Insta_Kadi.Text);
                            if (KadiKontrol == "false")
                            {
                                // Bilgi Mesajı
                                BilgiMesaji("hata", "Kullanıcı adı Instagram için uygun değil.", this.Text, true);
                            }
                            else
                            {
                                // Bilgi Mesajı
                                BilgiMesaji("bilgi", "Instagram eposta ve kullanıcı adı uygunlukları tamamlandı.", this.Text);


                                /*
                                 * 3- Hesap Oluşturma İşlemi
                                 */

                                #region Proxy
                                /*var proxy = new WebProxy()
                                {
                                    Address = new Uri($"https://165.22.236.64:8080"),
                                    BypassProxyOnLocal = false,
                                    UseDefaultCredentials = false
                                };
                                var httpClientHandler = new HttpClientHandler()
                                {
                                    Proxy = proxy,
                                };*/
                                #endregion


                                // Session Başlatma
                                var kullaniciOturum = new UserSessionData
                                {
                                    UserName = textBox_Insta_Kadi.Text,
                                    Password = textBox_Insta_Sifre.Text
                                };
                                InstaApi = InstaApiBuilder.CreateBuilder()
                                    .SetUser(kullaniciOturum)
                                    //.UseHttpClientHandler(httpClientHandler)
                                    .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                                    .Build();


                                // Hesap oluşturma metodu
                                var hesapOlustur = InstaApi.CreateNewAccountAsync(
                                    textBox_Insta_Kadi.Text,
                                    textBox_Insta_Sifre.Text,
                                    textBox_Insta_Eposta.Text,
                                    textBox_Insta_AdSoyad.Text
                                    );

                                /*
                                MessageBox.Show(hesapOlustur.Status.ToString());
                                MessageBox.Show(hesapOlustur.Result.Info.Message.ToString());
                                MessageBox.Show(hesapOlustur.Result.Succeeded.ToString());
                                */

                                // Hesap açılma durumu
                                if (!hesapOlustur.Result.Succeeded)
                                {
                                    // Başarısız
                                    BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " hesap oluşturulamadı.", this.Text, true);
                                }
                                else
                                {
                                    // Başarılı

                                    /*
                                     * 4- Hesabı Düzenle ve Güncelle
                                     */


                                    string adSoyad = ""; 
                                    string eposta = "";
                                    string site_adresi = textBox_Insta_InternetSitesi.Text;
                                    string telefon = "";
                                    string biyografi = richTextBox_Insta_Biyografi.Text;
                                    string yeniKadi = "";
                                    InstaGenderType? cinsiyet;
                                    if (combo_Insta_Cinsiyet.Text == "Erkek")
                                    {
                                        cinsiyet = InstaGenderType.Male;
                                    }
                                    else if(combo_Insta_Cinsiyet.Text == "Kadın")
                                    {
                                        cinsiyet = InstaGenderType.Female;
                                    }
                                    else
                                    {
                                        cinsiyet = InstaGenderType.Unknown;
                                    }


                                    // Profil Düzenleme
                                    try
                                    {
                                        var profilDuzenle = InstaApi.AccountProcessor
                                                    .EditProfileAsync(adSoyad, biyografi, site_adresi, eposta, telefon, cinsiyet, yeniKadi);

                                        if (!profilDuzenle.Result.Succeeded)
                                        {
                                            // Başarılı
                                            BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " profil güncellendi.", this.Text);
                                        }
                                        else
                                        {
                                            // Başarısız
                                            BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profil güncellenemedi.", this.Text);
                                        }
                                    }
                                    catch
                                    {
                                        BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profil güncellenemedi.", this.Text);
                                    }


                                    // Profil Foto Güncelleme
                                    try
                                    {
                                        if (textBox_Insta_SeciliProfilResmiYolu.Text != "")
                                        {
                                            var picturePath = textBox_Insta_SeciliProfilResmiYolu.Text;
                                            var pictureBytes = File.ReadAllBytes(picturePath);
                                            var changeProfilePicture = InstaApi.AccountProcessor
                                                            .ChangeProfilePictureAsync(pictureBytes);
                                            if (changeProfilePicture.Result.Succeeded)
                                            {
                                                // Başarılı
                                                BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " profil fotoğrafı güncellendi.", this.Text);
                                            }
                                            else
                                            {
                                                // Başarısız
                                                BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profili güncellenemedi.", this.Text);
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profili güncellenemedi.", this.Text);
                                    }


                                    // 2 sn bekle
                                    Task.Delay(2000);


                                    // Gönderileri paylaşma
                                    foreach (ListViewItem gonderi in listView_Insta_GonderiListesi.Items)
                                    {
                                        string mesaj = gonderi.SubItems[0].Text;
                                        string yol = gonderi.SubItems[1].Text;
                                        try
                                        {
                                            string instaUpload = instaResimUploadFonk(yol, mesaj);
                                            if(instaUpload == "true")
                                            {
                                                // Başarılı
                                                BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " gönderi paylaşıldı.", this.Text);
                                            }
                                            else
                                            {
                                                // Başarısız
                                                BilgiMesaji("hata", textBox_Insta_Kadi.Text + " gönderi paylaşılamadı.", this.Text);
                                            }
                                        }
                                        catch
                                        { 
                                            // Başarısız
                                            BilgiMesaji("hata", textBox_Insta_Kadi.Text + " gönderi paylaşılamadı.", this.Text);
                                        }

                                        // 2 sn bekle
                                        Task.Delay(2000);
                                    }


                                    // Bilgi Mesajı
                                    BilgiMesaji("bilgi", "İşlem tamamlandı", this.Text, true);


                                }// end if


                            } // end if

                        } // end if

                    } // end if





                });
            }
            catch (Exception ex)
            {
                // Bilgi Mesajı
                BilgiMesaji("hata", "Instagram hesabı oluşturulurken sorun oluştu;\n\n" + ex.Message, this.Text, true);
            }
        }






        /// <summary>
        /// Instagram Resim Upload
        /// </summary>
        /// <param name="yol"></param>
        /// <param name="mesaj"></param>
        /// <returns></returns>
        private string instaResimUploadFonk(string yol, string mesaj)
        {
            string cikti = null;

            var resimUpload = Task.Run(() =>
            {
                try
                {

                    var mediaImage = new InstaImageUpload
                    {
                        Height = 1080,
                        Width = 1080,
                        Uri = yol
                    };
                    var result = InstaApi.MediaProcessor.UploadPhotoAsync(mediaImage, mesaj);
                    if (result.Result.Succeeded)
                    {
                        cikti = "true";
                    }
                    else
                    {
                        cikti = "false";
                    }
                }
                catch
                {
                    cikti = "Exception";
                }
            });

            resimUpload.Wait();

            if (resimUpload.IsCompleted)
            {
                return cikti;
            }
            else
            {
                return cikti;
            }
        }


        /// <summary>
        /// Test Butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Test_Click(object sender, EventArgs e)
        {
           
        }


        /// <summary>
        /// Insta Giriş Yapma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_InstaGirisYap_Click(object sender, EventArgs e)
        {
            // Session Başlatma
            var userSession = new UserSessionData
            {
                UserName = textBox_InstaGiris_kadi.Text,
                Password = textBox_InstaGiris_Sifre.Text
            };

            string StateYol = StateFile;
            // dosya var mı kontrol et varsa eğer sil
            if (File.Exists(StateYol))
            {
                File.Delete(StateYol);
            }

            // Oturum oluşturma
            InstaApi = InstaApiBuilder.CreateBuilder()
                .SetUser(userSession)
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                .SetSessionHandler(new FileSessionHandler() { FilePath = StateYol })
                .Build();
            LoadSession();


            // Giriş kontrolü
            if (!InstaApi.IsUserAuthenticated)
            {
                // Başarısız

                // Giriş çıktısı
                var logInResult = await InstaApi.LoginAsync();

                // Başarılı mı?
                if (logInResult.Succeeded)
                {
                    // Bilgi Mesajı
                    BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, true);
                    SaveSession();
                }
                else
                {
                    // Bilgi Mesajı
                    BilgiMesaji("basarili", "Giriş yapılamadı.", this.Text, true);
                }


            }
            else
            {
                // Bilgi Mesajı
                BilgiMesaji("basarili", "Giriş yapıldı.", this.Text, true);
                SaveSession();
            }
        }


        private async void Button1_Click(object sender, EventArgs e)
        {
            /*
                                     * 4- Hesabı Düzenle ve Güncelle
                                     */
            // Başarılı
            BilgiMesaji("bilgi", "Başladı", this.Text);

            string adSoyad = "";
            string eposta = "";
            string site_adresi = textBox_Insta_InternetSitesi.Text;
            string telefon = "";
            string biyografi = richTextBox_Insta_Biyografi.Text;
            string yeniKadi = "";
            InstaGenderType? cinsiyet;
            if (combo_Insta_Cinsiyet.Text == "Erkek")
            {
                cinsiyet = InstaGenderType.Male;
            }
            else if (combo_Insta_Cinsiyet.Text == "Kadın")
            {
                cinsiyet = InstaGenderType.Female;
            }
            else
            {
                cinsiyet = InstaGenderType.Unknown;
            }




            // Profil Düzenleme
            /*try
            {
                var profilDuzenle = await InstaApi.AccountProcessor
                            .EditProfileAsync(adSoyad, biyografi, site_adresi, eposta, telefon, cinsiyet, yeniKadi);

                if (profilDuzenle.Succeeded)
                {
                    // Başarılı
                    BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " profil güncellendi.", this.Text);
                }
                else
                {
                    // Başarısız
                    BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profil güncellenemedi.", this.Text);
                }
            }
            catch (Exception ex)
            {
                BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profil güncellenemedi.\n\n" + ex.Message, this.Text);
            }*/


            var setBiography = await InstaApi.AccountProcessor
                            .SetBiographyAsync(biyografi);
            if (setBiography.Succeeded)
            {
                // Başarılı
                BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " profil güncellendi.", this.Text);
            }
            else
            {
                // Başarısız
                BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profil güncellenemedi.", this.Text);
            }

            // Profil Foto Güncelleme
            try
            {
                if (textBox_Insta_SeciliProfilResmiYolu.Text != "")
                {
                    var picturePath = textBox_Insta_SeciliProfilResmiYolu.Text;
                    var pictureBytes = File.ReadAllBytes(picturePath);
                    var changeProfilePicture = await InstaApi.AccountProcessor
                                    .ChangeProfilePictureAsync(pictureBytes);
                    if (changeProfilePicture.Succeeded)
                    {
                        // Başarılı
                        BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " profil fotoğrafı güncellendi.", this.Text);
                    }
                    else
                    {
                        // Başarısız
                        BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profili güncellenemedi.", this.Text);
                    }
                }
            }
            catch
            {
                BilgiMesaji("hata", textBox_Insta_Kadi.Text + " profili güncellenemedi.", this.Text);
            }



            // Gönderileri paylaşma
            foreach (ListViewItem gonderi in listView_Insta_GonderiListesi.Items)
            {
                string mesaj = gonderi.SubItems[0].Text;
                string yol = gonderi.SubItems[1].Text;
                try
                {
                    string instaUpload = instaResimUploadFonk(yol, mesaj);
                    if (instaUpload == "true")
                    {
                        // Başarılı
                        BilgiMesaji("bilgi", textBox_Insta_Kadi.Text + " gönderi paylaşıldı.", this.Text);
                    }
                    else
                    {
                        // Başarısız
                        BilgiMesaji("hata", textBox_Insta_Kadi.Text + " gönderi paylaşılamadı.", this.Text);
                    }
                }
                catch
                {
                    // Başarısız
                    BilgiMesaji("hata", textBox_Insta_Kadi.Text + " gönderi paylaşılamadı.", this.Text);
                }

            }


            // Bilgi Mesajı
            BilgiMesaji("bilgi", "İşlem tamamlandı", this.Text, true);
        }
        

        /// <summary>
        /// HESAP AÇMA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_InstaHesapAc_Click(object sender, EventArgs e)
        {
            thread = new Thread(hesapAc);
            thread.Start();
        }

        /// <summary>
        /// çalıştır metodu
        /// </summary>
        private void calistir()
        {
            var options = new ChromeOptions();
            options.AddArgument("--user-agent=Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.38 (KHTML, like Gecko) Version/11.0 Mobile/15A372 Safari/604.1");
            options.AddArgument("--window-size=350,350");
            //IWebDriver driver = new ChromeDriver(options);

            chrome = new ChromeDriver(options);
            chrome.Navigate().GoToUrl(kayit_url);
        }


        private void hesapAc()
        {
            // Kayıt ol formu
            chrome.FindElement(By.XPath("//input[@name='emailOrPhone']")).SendKeys(textBox_Insta_Eposta.Text);
            chrome.FindElement(By.XPath("//input[@name='fullName']")).SendKeys(textBox_Insta_AdSoyad.Text);
            chrome.FindElement(By.XPath("//input[@name='username']")).SendKeys(textBox_Insta_Kadi.Text);
            chrome.FindElement(By.XPath("//input[@name='password']")).SendKeys(textBox_Insta_Sifre.Text);
            chrome.FindElement(By.XPath("//button[contains(text(), 'Kaydol')]")).Click();
            Thread.Sleep(10000);



            // Hesabı gizle
            chrome.Navigate().GoToUrl(hesap_gizle_url);
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//label[contains(text(),'Gizli Hesap')]")).Click();
            Thread.Sleep(10000);


            // Profil Düzenleme
            chrome.Navigate().GoToUrl(profil_duzenle_url);
            Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//input[@id='pepWebsite']")).SendKeys(textBox_Insta_InternetSitesi.Text);
            chrome.FindElement(By.XPath("//textarea[@id='pepBio']")).SendKeys(richTextBox_Insta_Biyografi.Text);
            chrome.FindElement(By.XPath("//button[contains(text(),'Gönder')]")).Click();


            


        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            chrome.Quit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = chrome.PageSource;
            }
            catch { }
        }
    }
}
