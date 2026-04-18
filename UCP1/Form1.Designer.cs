namespace UCP1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.lblAsalDaerah = new System.Windows.Forms.Label();
            this.textBoxAsalDaerah = new System.Windows.Forms.TextBox();
            this.lblTujuan = new System.Windows.Forms.Label();
            this.textBoxTujuan = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMenampilkanData = new System.Windows.Forms.Button();
            this.btnMenambahkanData = new System.Windows.Forms.Button();
            this.btnMengubahData = new System.Windows.Forms.Button();
            this.btnMenghapusData = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMembukaKoneksi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 628);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1596, 380);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(104, 212);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(68, 25);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(290, 212);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(425, 75);
            this.textBoxNama.TabIndex = 9;
            // 
            // lblAsalDaerah
            // 
            this.lblAsalDaerah.AutoSize = true;
            this.lblAsalDaerah.Location = new System.Drawing.Point(104, 320);
            this.lblAsalDaerah.Name = "lblAsalDaerah";
            this.lblAsalDaerah.Size = new System.Drawing.Size(130, 25);
            this.lblAsalDaerah.TabIndex = 10;
            this.lblAsalDaerah.Text = "Asal Daerah";
            // 
            // textBoxAsalDaerah
            // 
            this.textBoxAsalDaerah.Location = new System.Drawing.Point(290, 317);
            this.textBoxAsalDaerah.Multiline = true;
            this.textBoxAsalDaerah.Name = "textBoxAsalDaerah";
            this.textBoxAsalDaerah.Size = new System.Drawing.Size(425, 75);
            this.textBoxAsalDaerah.TabIndex = 11;
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Location = new System.Drawing.Point(104, 423);
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(78, 25);
            this.lblTujuan.TabIndex = 12;
            this.lblTujuan.Text = "Tujuan";
            // 
            // textBoxTujuan
            // 
            this.textBoxTujuan.Location = new System.Drawing.Point(290, 423);
            this.textBoxTujuan.Multiline = true;
            this.textBoxTujuan.Name = "textBoxTujuan";
            this.textBoxTujuan.Size = new System.Drawing.Size(425, 75);
            this.textBoxTujuan.TabIndex = 13;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(104, 542);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(90, 25);
            this.lblTanggal.TabIndex = 14;
            this.lblTanggal.Text = "Tanggal";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(290, 537);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(425, 31);
            this.dateTimePicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 51);
            this.label7.TabIndex = 16;
            this.label7.Text = "Petugas";
            // 
            // btnMenampilkanData
            // 
            this.btnMenampilkanData.Location = new System.Drawing.Point(815, 289);
            this.btnMenampilkanData.Name = "btnMenampilkanData";
            this.btnMenampilkanData.Size = new System.Drawing.Size(425, 57);
            this.btnMenampilkanData.TabIndex = 20;
            this.btnMenampilkanData.Text = "Menampilkan Data";
            this.btnMenampilkanData.UseVisualStyleBackColor = true;
            this.btnMenampilkanData.Click += new System.EventHandler(this.MenampilkanData_Click);
            // 
            // btnMenambahkanData
            // 
            this.btnMenambahkanData.Location = new System.Drawing.Point(815, 366);
            this.btnMenambahkanData.Name = "btnMenambahkanData";
            this.btnMenambahkanData.Size = new System.Drawing.Size(425, 54);
            this.btnMenambahkanData.TabIndex = 21;
            this.btnMenambahkanData.Text = "Menambahkan Data";
            this.btnMenambahkanData.UseVisualStyleBackColor = true;
            this.btnMenambahkanData.Click += new System.EventHandler(this.MenambahkanData_Click);
            // 
            // btnMengubahData
            // 
            this.btnMengubahData.Location = new System.Drawing.Point(815, 441);
            this.btnMengubahData.Name = "btnMengubahData";
            this.btnMengubahData.Size = new System.Drawing.Size(425, 54);
            this.btnMengubahData.TabIndex = 22;
            this.btnMengubahData.Text = "Mengubah Data";
            this.btnMengubahData.UseVisualStyleBackColor = true;
            this.btnMengubahData.Click += new System.EventHandler(this.MengubahData_Click);
            // 
            // btnMenghapusData
            // 
            this.btnMenghapusData.Location = new System.Drawing.Point(815, 513);
            this.btnMenghapusData.Name = "btnMenghapusData";
            this.btnMenghapusData.Size = new System.Drawing.Size(425, 54);
            this.btnMenghapusData.TabIndex = 23;
            this.btnMenghapusData.Text = "Menghapus Data";
            this.btnMenghapusData.UseVisualStyleBackColor = true;
            this.btnMenghapusData.Click += new System.EventHandler(this.MenghapusData_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1280, 212);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(425, 54);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnMembukaKoneksi
            // 
            this.btnMembukaKoneksi.Location = new System.Drawing.Point(815, 212);
            this.btnMembukaKoneksi.Name = "btnMembukaKoneksi";
            this.btnMembukaKoneksi.Size = new System.Drawing.Size(425, 57);
            this.btnMembukaKoneksi.TabIndex = 25;
            this.btnMembukaKoneksi.Text = "Membuka Koneksi";
            this.btnMembukaKoneksi.UseVisualStyleBackColor = true;
            this.btnMembukaKoneksi.Click += new System.EventHandler(this.MembukaKoneksi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3076, 1879);
            this.Controls.Add(this.btnMembukaKoneksi);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenghapusData);
            this.Controls.Add(this.btnMengubahData);
            this.Controls.Add(this.btnMenambahkanData);
            this.Controls.Add(this.btnMenampilkanData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.textBoxTujuan);
            this.Controls.Add(this.lblTujuan);
            this.Controls.Add(this.textBoxAsalDaerah);
            this.Controls.Add(this.lblAsalDaerah);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label lblAsalDaerah;
        private System.Windows.Forms.TextBox textBoxAsalDaerah;
        private System.Windows.Forms.Label lblTujuan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMenampilkanData;
        private System.Windows.Forms.Button btnMenambahkanData;
        private System.Windows.Forms.Button btnMengubahData;
        private System.Windows.Forms.Button btnMenghapusData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMembukaKoneksi;
        private System.Windows.Forms.TextBox textBoxTujuan;
    }
}

