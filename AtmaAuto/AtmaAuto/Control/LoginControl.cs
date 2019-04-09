using System;
using System.Net;
using System.IO;

namespace AtmaAuto.Control
{
    public class UserData
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    class LoginControl
    {
        public string postJson { get; set; }

        public string cekLogin()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api1.thekingcorp.org/auth/login");
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
                if(response.GetResponseStream() != null)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strResponseValue = reader.ReadToEnd();
                        return strResponseValue.ToString();
                    }
                }
            }catch(Exception e)
            {
                strResponseValue = e.Message.ToString();
            }
            return "error";
        }

        public void upPass(string acc, string lama, string baru)
        {
        }
    }
}
