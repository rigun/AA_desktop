namespace AtmaAuto.Boundary
{
    partial class FormLaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLapSpLaris = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LapPenBul = new System.Windows.Forms.Button();
            this.LapPenTahun = new System.Windows.Forms.Button();
            this.LapPengeluaranBul = new System.Windows.Forms.Button();
            this.LapJualJasa = new System.Windows.Forms.Button();
            this.LapSisaStok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLapSpLaris
            // 
            this.btnLapSpLaris.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLapSpLaris.Location = new System.Drawing.Point(84, 99);
            this.btnLapSpLaris.Name = "btnLapSpLaris";
            this.btnLapSpLaris.Size = new System.Drawing.Size(164, 80);
            this.btnLapSpLaris.TabIndex = 26;
            this.btnLapSpLaris.Text = "Sparepart Terlaris";
            this.btnLapSpLaris.UseVisualStyleBackColor = false;
            this.btnLapSpLaris.Click += new System.EventHandler(this.btnLapSpLaris_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(590, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.Location = new System.Drawing.Point(692, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 39);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LapPenBul
            // 
            this.LapPenBul.BackColor = System.Drawing.Color.SteelBlue;
            this.LapPenBul.Location = new System.Drawing.Point(307, 99);
            this.LapPenBul.Name = "LapPenBul";
            this.LapPenBul.Size = new System.Drawing.Size(164, 80);
            this.LapPenBul.TabIndex = 29;
            this.LapPenBul.Text = "Pendapatan Bulanan";
            this.LapPenBul.UseVisualStyleBackColor = false;
            this.LapPenBul.Click += new System.EventHandler(this.LapPenBul_Click);
            // 
            // LapPenTahun
            // 
            this.LapPenTahun.BackColor = System.Drawing.Color.SteelBlue;
            this.LapPenTahun.Location = new System.Drawing.Point(522, 99);
            this.LapPenTahun.Name = "LapPenTahun";
            this.LapPenTahun.Size = new System.Drawing.Size(164, 80);
            this.LapPenTahun.TabIndex = 30;
            this.LapPenTahun.Text = "Pendapatan Tahunan";
            this.LapPenTahun.UseVisualStyleBackColor = false;
            // 
            // LapPengeluaranBul
            // 
            this.LapPengeluaranBul.BackColor = System.Drawing.Color.SteelBlue;
            this.LapPengeluaranBul.Location = new System.Drawing.Point(307, 201);
            this.LapPengeluaranBul.Name = "LapPengeluaranBul";
            this.LapPengeluaranBul.Size = new System.Drawing.Size(164, 80);
            this.LapPengeluaranBul.TabIndex = 31;
            this.LapPengeluaranBul.Text = "Pengeluaran Bulanan";
            this.LapPengeluaranBul.UseVisualStyleBackColor = false;
            // 
            // LapJualJasa
            // 
            this.LapJualJasa.BackColor = System.Drawing.Color.SteelBlue;
            this.LapJualJasa.Location = new System.Drawing.Point(522, 201);
            this.LapJualJasa.Name = "LapJualJasa";
            this.LapJualJasa.Size = new System.Drawing.Size(164, 80);
            this.LapJualJasa.TabIndex = 32;
            this.LapJualJasa.Text = "Penjualan Jasa";
            this.LapJualJasa.UseVisualStyleBackColor = false;
            // 
            // LapSisaStok
            // 
            this.LapSisaStok.BackColor = System.Drawing.Color.SteelBlue;
            this.LapSisaStok.Location = new System.Drawing.Point(84, 201);
            this.LapSisaStok.Name = "LapSisaStok";
            this.LapSisaStok.Size = new System.Drawing.Size(164, 80);
            this.LapSisaStok.TabIndex = 33;
            this.LapSisaStok.Text = "Sisa Stok";
            this.LapSisaStok.UseVisualStyleBackColor = false;
            this.LapSisaStok.Click += new System.EventHandler(this.LapSisaStok_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LapSisaStok);
            this.Controls.Add(this.LapJualJasa);
            this.Controls.Add(this.LapPengeluaranBul);
            this.Controls.Add(this.LapPenTahun);
            this.Controls.Add(this.LapPenBul);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLapSpLaris);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapSpLaris;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button LapPenBul;
        private System.Windows.Forms.Button LapPenTahun;
        private System.Windows.Forms.Button LapPengeluaranBul;
        private System.Windows.Forms.Button LapJualJasa;
        private System.Windows.Forms.Button LapSisaStok;
    }
}