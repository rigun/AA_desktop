using System;
using System.Net;
using System.IO;

namespace AtmaAuto.Control
{
    public class UserData1
    {
        public string cabang { get; set; }
    }

    class CabangControl
    {
        public string postJson { get; set; }

        public string tambahCabang()
            {
                string strResponseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/branch");
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

        public string hapusCabang()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/branch");
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

        public string tampilCabang()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/branch");
            request.Method = "show";
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

        public string updateCabang()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/branch");
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