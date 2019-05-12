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
            this.SuspendLayout();
            // 
            // btnLapSpLaris
            // 
            this.btnLapSpLaris.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLapSpLaris.Location = new System.Drawing.Point(132, 84);
            this.btnLapSpLaris.Name = "btnLapSpLaris";
            this.btnLapSpLaris.Size = new System.Drawing.Size(209, 122);
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
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}