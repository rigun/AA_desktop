using System;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;

namespace AtmaAuto.Control
{
    public class UserData
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    class LoginControl
    {
        public string cekLogin(string email, string password)
        {
            if(email == null || password == null)
            {
                return "Mohon untuk mengisi data terlebih dahulu";
            }
            UserData userData = new UserData();
            userData.email = email;
            userData.password = password;


            var payload = JsonConvert.SerializeObject(userData);

            Uri u = new Uri("http://10.53.15.204/auth/login");

            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();
            return t.Result;

        }
        static async Task<string> PostURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage result = await client.PostAsync(u, c);
                    response = await result.Content.ReadAsStringAsync();
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    response = "Pengguna tidak diketahui";
                }
            }
            return response;
        }
    }
}
