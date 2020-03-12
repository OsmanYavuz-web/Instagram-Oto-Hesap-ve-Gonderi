using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Hesap_Açma
{
    public class Hesaplar
    {
        public IList HesapListesi { get; set; }
    }

    public class HesapDetaylarList
    {
        public string kadi { get; set; }
        public string sifre { get; set; }
        public string eposta { get; set; }
        public string adsoyad { get; set; }
    }


    public class SabitKodlar
    {

        #region UserAgent Değiştirme
        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
        const int URLMON_OPTION_USERAGENT = 0x10000001;
        public bool ChangeUserAgent(string Agent)
        {
            try
            {
                UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, Agent, Agent.Length, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion


        #region WebBrowser Cookie Bilgisi
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
        const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

        public string GetGlobalCookies(string uri)
        {
            uint datasize = 2024;
            StringBuilder cookieData = new StringBuilder((int)datasize);
            if (InternetGetCookieEx(uri, null, cookieData, ref datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero)
            && cookieData.Length > 0)
            {
                string GelenCookie = cookieData.ToString();

                return GelenCookie;
            }
            else
            {
                return null;
            }
        }
        #endregion


        /// <summary>
        /// İki değer arasındaki veriyi ayırma fonksiyonu
        /// VeriAyiklama(HtmlKod, "<title>", "</title>");
        /// </summary>
        /// <param name="kaynakKod">Metnin tümü</param>
        /// <param name="ilkVeri">İlk veri değeri</param>
        /// <param name="sonVeri">Son veri değeri</param>
        /// <returns></returns>
        #region Veri Ayıklama Fonksiyon - VeriAyiklama(kaynakKod, ilkVeri, sonVeri)
        public string VeriAyiklama(string kaynakKod, string ilkVeri, string sonVeri)
        {
            string ayiklananVeri;
            try
            {
                string gelen = kaynakKod;
                int titleIndexBaslangici = gelen.IndexOf(ilkVeri) + ilkVeri.Length;
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf(sonVeri);
                ayiklananVeri = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);
                return ayiklananVeri;
            }
            catch
            {
                return "False";
            }
        }
        #endregion


        /// <summary>
        /// İlk seçilen zaman ve şimdiki zaman arasındaki farkı hesaplama fonksiyonu
        /// </summary>
        /// <param name="ilkZaman">Seçilen ilk zaman</param>
        /// <returns></returns>
        #region Zaman Farkı > zamanFarki(ilkZaman, sonZaman)
        public string ZamanFarki(string ilkZaman)
        {
            try
            {
                string sonZaman = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").ToString();

                TimeSpan ts = (Convert.ToDateTime(sonZaman) - Convert.ToDateTime(ilkZaman));

                string gun = ts.Days > 0 ? string.Format("{0} gün ", ts.Days) : "";
                string saat = ts.Hours > 0 ? string.Format("{0} saat ", ts.Hours) : "";
                string dakika = ts.Minutes > 0 ? string.Format("{0} dakika ", ts.Minutes) : "";
                string saniye = ts.Seconds > 0 ? string.Format("{0} Saniye ", ts.Seconds) : "";

                return gun + saat + dakika + saniye;
            }
            catch
            {
                return "false";
            }
        }
        #endregion


        /// <summary>
        /// Instagram URL adresleri için query oluşturma
        /// </summary>
        /// <param name="Params"></param>
        /// <returns></returns>
        public string Query_Olusturucu(NameValueCollection Params)
        {
            string query = string.Join("&",
                    Params.AllKeys.Where(key => !string.IsNullOrWhiteSpace(Params[key]))
                        .Select(
                            key => string.Join("&", Params.GetValues(key).Select(val => string.Format("{0}={1}", key, val)))));
            return query;
        }


        /// <summary>
        /// Türkçe karakterleri ingilizce çevirme
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string TurkceToEnglish(string kelime)
        {
            string mesaj = kelime;
            char[] oldValue = new char[] { 'ö', 'Ö', 'ü', 'Ü', 'ç', 'Ç', 'İ', 'ı', 'Ğ', 'ğ', 'Ş', 'ş' };
            char[] newValue = new char[] { 'o', 'O', 'u', 'U', 'c', 'C', 'I', 'i', 'G', 'g', 'S', 's' };
            for (int sayac = 0; sayac < oldValue.Length; sayac++)
            {
                mesaj = mesaj.Replace(oldValue[sayac], newValue[sayac]);
            }
            return mesaj;
        }

        /// <summary>
        /// Şifre Oluşturucu
        /// </summary>
        /// <param name="uzunluk">Şifre uzunluğu</param>
        /// <returns></returns>
        public string YeniSifreOlusturma(int uzunluk)
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < uzunluk; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }


        /// <summary>
        /// rastgele kod
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string RastgeleKod(Byte length)
        {
            var bytes = new byte[length];
            var rnd = new Random();
            rnd.NextBytes(bytes);
            return Convert.ToBase64String(bytes).Replace("=", "").Replace("+", "").Replace("/", "");
        }


        /// <summary>
        /// Json Dosyası Kaydetme Fonksiyonu
        /// </summary>
        /// <param name="yol">Dosya yolu</param>
        /// <param name="list">Json verileri</param>
        /// <returns></returns>
        public bool Json_Kaydet(string yol, object list)
        {
            try
            {
                File.WriteAllText(yol, JsonConvert.SerializeObject(list));
                using (StreamWriter file = File.CreateText(yol))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, list);
                    file.Close();
                    file.Dispose();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// Klasör kontrolü yapan ve yoksa oluşturan fonksiyon
        /// </summary>
        /// <param name="Yol">Klasörün oluşturulacağı yol</param>
        /// <param name="gizliKlasor">True/False klasör yoksa yeniden oluştururken gizli klasör yapar</param>
        /// <returns></returns>
        public bool Klasor_Kontrol(string Yol, bool gizliKlasor = false)
        {
            // Log klasörü var mı?
            try
            {
                // var mı?
                string varmi = Yol;
                if (Directory.Exists(varmi) == false)
                {
                    // yoksa oluştur
                    string path = Yol;
                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);

                        if (gizliKlasor)
                        {
                            // gizli klasör oluştur
                            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                        }
                        else
                        {
                            // normal klasör oluştur
                            di.Attributes = FileAttributes.Directory;
                        }

                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Resim indirme fonksiyonu
        /// </summary>
        /// <param name="resimUrl"></param>
        /// <param name="kayitYol"></param>
        /// <returns></returns>
        public bool ResimIndir(string resimUrl, string kayitYol)
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(resimUrl);
                Bitmap bitmap; bitmap = new Bitmap(stream);

                if (bitmap != null)
                {
                    bitmap.Save(kayitYol, ImageFormat.Jpeg);
                }

                stream.Flush();
                stream.Close();
                client.Dispose();

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
