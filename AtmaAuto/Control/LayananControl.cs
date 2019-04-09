using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace AtmaAuto.Control
{   public class userData2
    {
        public string namalayanan { get; set; }
        public string biaya { get; set; }
    }
    class LayananControl
    {
        public string postJson { get; set; }

        public string tambahLayanan()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/service");
            request.Method = "Post";
            request.ContentType = "application/json";

            using (StreamWriter swJsonpayload = new StreamWriter(request.GetRequestStream()))
            {
                swJsonpayload.Write(postJson);
                swJsonpayload.Close();
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.GetResponseStream() != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strResponseValue = reader.ReadToEnd();
                        return strResponseValue.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                strResponseValue = e.Message.ToString();
            }
            return "error";
        }

        public string hapusLayanan()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/service");
            request.Method = "Delete";
            request.ContentType = "application/json";

            using (StreamWriter swJsonpayload = new StreamWriter(request.GetRequestStream()))
            {
                swJsonpayload.Write(postJson);
                swJsonpayload.Close();
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.GetResponseStream() != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strResponseValue = reader.ReadToEnd();
                        return strResponseValue.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                strResponseValue = e.Message.ToString();
            }
            return "error";
        }

        public string tampilLayanan()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/service");
            request.Method = "Delete";
            request.ContentType = "application/json";

            using (StreamWriter swJsonpayload = new StreamWriter(request.GetRequestStream()))
            {
                swJsonpayload.Write(postJson);
                swJsonpayload.Close();
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.GetResponseStream() != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strResponseValue = reader.ReadToEnd();
                        return strResponseValue.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                strResponseValue = e.Message.ToString();
            }
            return "error";
        }

        public string getData()
        {
            var t = Task.Run(() => GetURI(new Uri("")));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            return t.Result;
        }
        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }



        public string updateLayanan()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/service");
            request.Method = "Post";
            request.ContentType = "application/json";

            using (StreamWriter swJsonpayload = new StreamWriter(request.GetRequestStream()))
            {
                swJsonpayload.Write(postJson);
                swJsonpayload.Close();
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.GetResponseStream() != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strResponseValue = reader.ReadToEnd();
                        return strResponseValue.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                strResponseValue = e.Message.ToString();
            }
            return "error";
        }

    }
}
