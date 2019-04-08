namespace AtmaAuto.Boundary
{
    partial class UC_Kendaraan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTipeKendaraan = new System.Windows.Forms.MaskedTextBox();
            this.txtBiaya = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtMerkKendaraan = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTipeKendaraan
            // 
            this.txtTipeKendaraan.Location = new System.Drawing.Point(106, 79);
            this.txtTipeKendaraan.Name = "txtTipeKendaraan";
            this.txtTipeKendaraan.Size = new System.Drawing.Size(156, 20);
            this.txtTipeKendaraan.TabIndex = 18;
            this.txtTipeKendaraan.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTipeKendaraan_MaskInputRejected);
            // 
            // txtBiaya
            // 
            this.txtBiaya.AutoSize = true;
            this.txtBiaya.Location = new System.Drawing.Point(14, 79);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(83, 13);
            this.txtBiaya.TabIndex = 17;
            this.txtBiaya.Text = "Tipe Kendaraan";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(187, 124);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(106, 124);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // txtMerkKendaraan
            // 
            this.txtMerkKendaraan.Location = new System.Drawing.Point(106, 49);
            this.txtMerkKendaraan.Name = "txtMerkKendaraan";
            this.txtMerkKendaraan.Size = new System.Drawing.Size(156, 20);
            this.txtMerkKendaraan.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Merk Kendaraan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tambah Kendaraan";
            // 
            // UC_Kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTipeKendaraan);
            this.Controls.Add(this.txtBiaya);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtMerkKendaraan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Kendaraan";
            this.Size = new System.Drawing.Size(279, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTipeKendaraan;
        private System.Windows.Forms.Label txtBiaya;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.MaskedTextBox txtMerkKendaraan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
