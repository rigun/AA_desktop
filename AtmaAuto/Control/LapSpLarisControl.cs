﻿using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using AtmaAuto.Entity;
using System.Net.Http.Headers;

namespace AtmaAuto.Control
{
    class LapSpLarisControl
    {
        public string token { get; set; }
        private string url = "http://10.53.1.192/files/report/sparepartTerlaris/09-2019.pdf";

        public string getData()
        {
            var t = Task.Run(() => GetURI(new Uri(this.url), this.token));
            t.Wait();
            return t.Result;
        }

        public string deleteData(int id)
        {
            string deleteUrl = String.Concat(this.url, "/", id);
            var t = Task.Run(() => DeleteUri(new Uri(deleteUrl), this.token));
            t.Wait();
            return t.Result;
        }

        public string sendData(Cabang cabang)
        {
            var payload = JsonConvert.SerializeObject(cabang);

            Uri u = new Uri(this.url);
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c, this.token));
            t.Wait();
            return t.Result;
        }

        public string updateData(Cabang cabang, int id)
        {
            var payload = JsonConvert.SerializeObject(cabang);
            string deleteUrl = String.Concat(this.url, "/", id);
            Uri u = new Uri(deleteUrl);
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c, this.token));
            t.Wait();
            return t.Result;
        }

        static async Task<string> PostURI(Uri u, HttpContent c, string token)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    HttpResponseMessage result = await client.PostAsync(u, c);
                    response = await result.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    response = "Cabang gagal dimasukkan";
                }
            }
            return response;
        }
        static async Task<string> GetURI(Uri u, string token)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                try
                {
                    HttpResponseMessage result = await client.GetAsync(u);
                    response = await result.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    response = "Cabang gagal dimasukkan";
                }
            }
            return response;
        }
        static async Task<string> DeleteUri(Uri u, string token)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    HttpResponseMessage result = await client.DeleteAsync(u);
                    response = await result.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    response = "Cabang gagal dihapus";
                }
            }
            return response;
        }
    }
}