﻿namespace AtmaAuto.Boundary
{
    partial class FormCabang
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtNamaCabang = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.Location = new System.Drawing.Point(510, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 39);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.txtNamaCabang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(-14, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 470);
            this.panel1.TabIndex = 14;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DarkGray;
            this.btnHapus.Location = new System.Drawing.Point(168, 153);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(68, 34);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // txtNamaCabang
            // 
            this.txtNamaCabang.Location = new System.Drawing.Point(30, 127);
            this.txtNamaCabang.Name = "txtNamaCabang";
            this.txtNamaCabang.Size = new System.Drawing.Size(204, 20);
            this.txtNamaCabang.TabIndex = 2;
            this.txtNamaCabang.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNamaCabang_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Cabang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.DarkGray;
            this.btnTambah.Location = new System.Drawing.Point(21, 153);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(68, 34);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.Location = new System.Drawing.Point(95, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 34);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 180);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pengelolahan Data Cabang";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(408, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pencarian";
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(506, 57);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(100, 20);
            this.txtPencarian.TabIndex = 27;
            this.txtPencarian.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPencarian_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID Cabang";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 20);
            this.txtID.TabIndex = 26;
            this.txtID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtID_MaskInputRejected);
            // 
            // FormCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "FormCabang";
            this.Text = "Cabang";
            this.Load += new System.EventHandler(this.FormCabang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.MaskedTextBox txtNamaCabang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPencarian;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}