namespace indomart.view
{
    partial class frm_karyawan
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
            this.dgv_karyawan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ttl = new System.Windows.Forms.TextBox();
            this.dtp_tanggal_lahir = new System.Windows.Forms.DateTimePicker();
            this.cmb_agama = new System.Windows.Forms.ComboBox();
            this.cmb_jabatan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.cmb_cari = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_pendidikan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_jenis_kelamin = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_karyawan
            // 
            this.dgv_karyawan.AllowUserToAddRows = false;
            this.dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_karyawan.Location = new System.Drawing.Point(53, 79);
            this.dgv_karyawan.Name = "dgv_karyawan";
            this.dgv_karyawan.ReadOnly = true;
            this.dgv_karyawan.Size = new System.Drawing.Size(1280, 166);
            this.dgv_karyawan.TabIndex = 0;
            this.dgv_karyawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_karyawan_CellContentClick);
            this.dgv_karyawan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_karyawan_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIK";
            // 
            // txt_nik
            // 
            this.txt_nik.Location = new System.Drawing.Point(140, 23);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.ReadOnly = true;
            this.txt_nik.Size = new System.Drawing.Size(121, 20);
            this.txt_nik.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(140, 64);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(121, 20);
            this.txt_nama.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Agama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(980, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jabatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(347, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 43);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Karyawan Indomaret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tempat Lahir ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(661, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tanggal Llahir ";
            // 
            // txt_ttl
            // 
            this.txt_ttl.Location = new System.Drawing.Point(454, 62);
            this.txt_ttl.Name = "txt_ttl";
            this.txt_ttl.Size = new System.Drawing.Size(121, 20);
            this.txt_ttl.TabIndex = 25;
            // 
            // dtp_tanggal_lahir
            // 
            this.dtp_tanggal_lahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tanggal_lahir.Location = new System.Drawing.Point(794, 65);
            this.dtp_tanggal_lahir.Name = "dtp_tanggal_lahir";
            this.dtp_tanggal_lahir.Size = new System.Drawing.Size(121, 20);
            this.dtp_tanggal_lahir.TabIndex = 26;
            // 
            // cmb_agama
            // 
            this.cmb_agama.FormattingEnabled = true;
            this.cmb_agama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Hindu",
            "Budha",
            "Konghucu"});
            this.cmb_agama.Location = new System.Drawing.Point(783, 25);
            this.cmb_agama.Name = "cmb_agama";
            this.cmb_agama.Size = new System.Drawing.Size(121, 21);
            this.cmb_agama.TabIndex = 28;
            // 
            // cmb_jabatan
            // 
            this.cmb_jabatan.FormattingEnabled = true;
            this.cmb_jabatan.Items.AddRange(new object[] {
            "Kepala Toko",
            "Assisten Kepala Toko",
            "MD 1",
            "MD 2",
            "Kasir",
            "Pramu"});
            this.cmb_jabatan.Location = new System.Drawing.Point(1115, 25);
            this.cmb_jabatan.Name = "cmb_jabatan";
            this.cmb_jabatan.Size = new System.Drawing.Size(121, 21);
            this.cmb_jabatan.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tampil);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.cmb_cari);
            this.groupBox1.Location = new System.Drawing.Point(969, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 124);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Karyawan";
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(15, 68);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(124, 20);
            this.txt_cari.TabIndex = 1;
            // 
            // cmb_cari
            // 
            this.cmb_cari.FormattingEnabled = true;
            this.cmb_cari.Items.AddRange(new object[] {
            "NIK",
            "Nama",
            "Jabatan"});
            this.cmb_cari.Location = new System.Drawing.Point(15, 30);
            this.cmb_cari.Name = "cmb_cari";
            this.cmb_cari.Size = new System.Drawing.Size(124, 21);
            this.cmb_cari.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_nik);
            this.groupBox2.Controls.Add(this.cmb_jabatan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_pendidikan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nama);
            this.groupBox2.Controls.Add(this.cmb_agama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtp_tanggal_lahir);
            this.groupBox2.Controls.Add(this.cmb_jenis_kelamin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ttl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(40, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1293, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Karyawan";
            // 
            // cmb_pendidikan
            // 
            this.cmb_pendidikan.FormattingEnabled = true;
            this.cmb_pendidikan.Items.AddRange(new object[] {
            "SMA",
            "SMK",
            "D I",
            "D II",
            "D III",
            "D IV",
            "S1",
            "S2",
            "S3"});
            this.cmb_pendidikan.Location = new System.Drawing.Point(1115, 64);
            this.cmb_pendidikan.Name = "cmb_pendidikan";
            this.cmb_pendidikan.Size = new System.Drawing.Size(121, 21);
            this.cmb_pendidikan.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(976, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pendidikan";
            // 
            // cmb_jenis_kelamin
            // 
            this.cmb_jenis_kelamin.FormattingEnabled = true;
            this.cmb_jenis_kelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmb_jenis_kelamin.Location = new System.Drawing.Point(445, 25);
            this.cmb_jenis_kelamin.Name = "cmb_jenis_kelamin";
            this.cmb_jenis_kelamin.Size = new System.Drawing.Size(121, 21);
            this.cmb_jenis_kelamin.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_tambah);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Location = new System.Drawing.Point(53, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 100);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu Pilihan";
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Image = global::indomart.Properties.Resources.add1;
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_tambah.Location = new System.Drawing.Point(54, 28);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(100, 60);
            this.btn_tambah.TabIndex = 1;
            this.btn_tambah.Text = "      Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Image = global::indomart.Properties.Resources.refresh;
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ubah.Location = new System.Drawing.Point(186, 30);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(100, 58);
            this.btn_ubah.TabIndex = 2;
            this.btn_ubah.Text = "         Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Image = global::indomart.Properties.Resources.delete;
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_hapus.Location = new System.Drawing.Point(311, 30);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(112, 58);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "        Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click_1);
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_tampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tampil.Image = global::indomart.Properties.Resources.book;
            this.btn_tampil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_tampil.Location = new System.Drawing.Point(176, 49);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(162, 69);
            this.btn_tampil.TabIndex = 3;
            this.btn_tampil.Text = "                    Tampilkan Semua";
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.Image = global::indomart.Properties.Resources.find;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cari.Location = new System.Drawing.Point(176, 12);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(162, 39);
            this.btn_cari.TabIndex = 2;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // frm_karyawan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_karyawan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_karyawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Karyawan";
            this.Load += new System.EventHandler(this.frm_karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_karyawan;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ttl;
        private System.Windows.Forms.DateTimePicker dtp_tanggal_lahir;
        private System.Windows.Forms.ComboBox cmb_agama;
        private System.Windows.Forms.ComboBox cmb_jabatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.ComboBox cmb_cari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_pendidikan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_jenis_kelamin;
    }
}