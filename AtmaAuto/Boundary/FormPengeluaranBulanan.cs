using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmaAuto.Boundary
{
    public partial class FormPengeluaranBulanan : Form
    {
        public string token { get; set; }
        private string url = "https://api1.thekingcorp.org/pengeluaranbulanan/report/";

        public FormPengeluaranBulanan()
        {
            InitializeComponent();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            string tahun = txttahun.Text;
            this.url = String.Concat(this.url, tahun);
            string data = this.getData();
            Console.WriteLine(data.ToString());
            System.Diagnostics.Process.Start(@"F:\LapPengeluaranBulanan.pdf");
            MessageBox.Show("Data Laporan Sparepart Terlaris Berhasil Di Download", "SELAMAT", MessageBoxButtons.OK);


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
                    using (var file = System.IO.File.Create(@"F:\LapPengeluaranBulanan.pdf"))
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
            FormLaporan fl = new FormLaporan();
            fl.Show();
            this.Hide();
        }
    }
}
