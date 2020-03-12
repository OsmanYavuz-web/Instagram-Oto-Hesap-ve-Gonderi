using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Hesap_Açma
{
    public class InstaKontrol
    {

        /// <summary>
        /// Değişkenler ve Referanslar
        /// </summary>
        SabitKodlar sabitKod = new SabitKodlar();
        string Insta_UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 11_0_1 like Mac OS X) AppleWebKit/604.1.38 (KHTML, like Gecko) Version/11.0 Mobile/15A402 Safari/604.1";


        // instagram için veri ayırıcılar
        private string JsonAyrac_1 = "window._sharedData =";
        private string JsonAyrac_2 = ";</script>";



        /// <summary>
        /// CSRF Token Oluşturma
        /// </summary>
        /// <returns></returns>
        private string CSRFTokenOlustur()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string HTML_Kod = webClient.DownloadString("https://www.instagram.com/");
                string JSON_Kod = sabitKod.VeriAyiklama(HTML_Kod, JsonAyrac_1, JsonAyrac_2);

                JObject JSONParser = JObject.Parse(JSON_Kod);
                string gelen_veri = (string)JSONParser["config"]["csrf_token"];

                webClient.Dispose();

                return gelen_veri;
            }
            catch
            {
                return null;
            }
        }



        /// <summary>
        /// Instagram eposta kullanılabilir kontrol kontrolü
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="first_name"></param>
        /// <returns></returns>
        public string Insta_EpostaKontrol(string email)
        {
            try
            {
                string CSRF = CSRFTokenOlustur();

                var deger = new NameValueCollection();
                deger["email"] = email;
                deger["password"] = "";
                deger["username"] = "";
                deger["first_name"] = "";
                deger["opt_into_one_tap"] = "false";

                string post = sabitKod.Query_Olusturucu(deger);

                HttpWebRequest istek = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/accounts/web_create_ajax/attempt/");
                istek.Method = "POST";
                istek.Host = "www.instagram.com";
                istek.KeepAlive = true;
                istek.UserAgent = Insta_UserAgent;
                istek.ContentType = "application/x-www-form-urlencoded";
                istek.Accept = "*/*";
                istek.Referer = "https://www.instagram.com/accounts/emailsignup/";
                istek.Headers.Add("Origin", "https://www.instagram.com");
                istek.Headers.Add("x-instagram-ajax", "1");
                istek.Headers.Add("x-requested-with", "XMLHttpRequest");
                istek.Headers.Add("x-csrftoken", CSRF);
                istek.Headers.Add("accept-language", "en-US,en;q=0.8");
                istek.Headers.Add("Cookie", "mid=WFTOrAAEAAGeFe3by_c5bY_ODw_U; ig_pr=1; ig_vw=1366; csrftoken=" + CSRF);


                byte[] postBytes = Encoding.ASCII.GetBytes(post);
                istek.ContentLength = postBytes.Length;
                Stream requestStream = istek.GetRequestStream();

                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)istek.GetResponse();

                string html = new StreamReader(response.GetResponseStream()).ReadToEnd();

                // Json Çıktısı
                JObject JSONParser = JObject.Parse(html);

                try
                {
                    string cikti = (string)JSONParser["errors"]["email"][0]["message"];
                    //return cikti;
                    if (cikti == "false")
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }
                catch
                {
                    return "true";
                }

            }
            catch
            {
                return "false"; // bu kalması lazım
            }
        }


        /// <summary>
        /// Instagram eposta kullanılabilir kontrol kontrolü
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="first_name"></param>
        /// <returns></returns>
        public string Insta_KadiKontrol(string username)
        {
            try
            {
                string CSRF = CSRFTokenOlustur();

                var deger = new NameValueCollection();
                deger["email"] = "";
                deger["password"] = "";
                deger["username"] = username;
                deger["first_name"] = "";
                deger["opt_into_one_tap"] = "false";

                string post = sabitKod.Query_Olusturucu(deger);

                HttpWebRequest istek = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/accounts/web_create_ajax/attempt/");
                istek.Method = "POST";
                istek.Host = "www.instagram.com";
                istek.KeepAlive = true;
                istek.UserAgent = Insta_UserAgent;
                istek.ContentType = "application/x-www-form-urlencoded";
                istek.Accept = "*/*";
                istek.Referer = "https://www.instagram.com/accounts/emailsignup/";
                istek.Headers.Add("Origin", "https://www.instagram.com");
                istek.Headers.Add("x-instagram-ajax", "1");
                istek.Headers.Add("x-requested-with", "XMLHttpRequest");
                istek.Headers.Add("x-csrftoken", CSRF);
                istek.Headers.Add("accept-language", "en-US,en;q=0.8");
                istek.Headers.Add("Cookie", "mid=WFTOrAAEAAGeFe3by_c5bY_ODw_U; ig_pr=1; ig_vw=1366; csrftoken=" + CSRF);


                byte[] postBytes = Encoding.ASCII.GetBytes(post);
                istek.ContentLength = postBytes.Length;
                Stream requestStream = istek.GetRequestStream();

                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)istek.GetResponse();

                string html = new StreamReader(response.GetResponseStream()).ReadToEnd();

                // Json Çıktısı
                JObject JSONParser = JObject.Parse(html);

                try
                {
                    string cikti = (string)JSONParser["errors"]["username"][0]["message"];
                    //return cikti;
                    if (cikti == "false")
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }
                catch
                {
                    return "true";
                }

            }
            catch
            {
                return "false"; // bu kalması lazım
            }
        }










    }
}
