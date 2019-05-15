using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.LapSpLarisControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace AtmaAuto.Boundary
{
    public partial class FormLaporan : Form
    {

        public string token { get; set; }
        private string url = "http://127.0.0.1:8000/sparepartTerlaris/report/2019";

        public FormLaporan()
        {
            InitializeComponent();
        }


    

        private void btnLapSpLaris_Click(object sender, EventArgs e)
        {
            string data = this.getData();
            Console.WriteLine(data.ToString());
            System.Diagnostics.Process.Start(@"G:\RekapanTugas\Kuliah\_Semester6\P3L\Project\AA_Desktop\somePathHere.pdf");
        }
       
        public string getData()
        {
            var t = Task.Run(() => GetURI(new Uri(this.url), this.token));
            t.Wait();
            return t.Result;
        }

        static async Task<String> GetURI(Uri u, string token)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                try
                {
                    HttpResponseMessage result = await client.GetAsync(u);
                    result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                    result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                    using (var file = System.IO.File.Create(@"G:\RekapanTugas\Kuliah\_Semester6\P3L\Project\AA_Desktop\somePathHere.pdf"))
                    { // create a new file to write to
                        var contentStream = await result.Content.ReadAsStreamAsync(); // get the actual content stream
                        await contentStream.CopyToAsync(file); // copy that stream to the file stream
                        await file.FlushAsync(); // flush back to disk before disposing
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return "Berhasil";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ingin Keluar Dari Aplikasi Ini ???", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FileHandling wr = new FileHandling();
                wr.WriteData("");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void LapPenBul_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf", @"D:\P3L\Laporan.pdf");
        }

        private void LapSisaStok_Click(object sender, EventArgs e)
        {
            var t = new Task(DownloadPageAsync);
            t.Start();

            Console.WriteLine("Downloading Page");
            Console.ReadLine();

        }

        public static async void DownloadPageAsync()
        {
            var page = "https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf";
           
        }
    }
}
