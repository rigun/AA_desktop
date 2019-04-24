namespace AtmaAuto.Boundary
{
    partial class FormPegawai
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelp = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtPencarian = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCabang = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(618, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.Location = new System.Drawing.Point(720, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 39);
            this.btnLogout.TabIndex = 45;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pengelolahan Data Pegawai\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 180);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCabang);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtKota);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTelp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(-15, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 572);
            this.panel1.TabIndex = 42;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DarkGray;
            this.btnHapus.Location = new System.Drawing.Point(225, 417);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(68, 34);
            this.btnHapus.TabIndex = 49;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Kota Pegawai";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(29, 321);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(266, 20);
            this.txtKota.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Alamat Pegawai";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(30, 266);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(266, 20);
            this.txtAlamat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "No Telp Pegawai";
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(30, 208);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(266, 20);
            this.txtTelp.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pekerjaan Pegawai";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(30, 93);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(266, 20);
            this.txtRole.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gaji Pegawai";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(29, 379);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(266, 20);
            this.txtSalary.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nama Pegawai";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.DarkGray;
            this.btnTambah.Location = new System.Drawing.Point(77, 417);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(68, 34);
            this.btnTambah.TabIndex = 25;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.Location = new System.Drawing.Point(151, 417);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 20);
            this.txtName.TabIndex = 2;
            this.txtName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtName_MaskInputRejected);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(716, 78);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(100, 20);
            this.txtPencarian.TabIndex = 48;
            this.txtPencarian.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPencarian_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Pencarian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "ID Cabang";
            // 
            // txtCabang
            // 
            this.txtCabang.Location = new System.Drawing.Point(27, 47);
            this.txtCabang.Name = "txtCabang";
            this.txtCabang.Size = new System.Drawing.Size(266, 20);
            this.txtCabang.TabIndex = 50;
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(823, 554);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPegawai";
            this.Text = "FormPegawai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtPencarian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtKota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCabang;
    }
}