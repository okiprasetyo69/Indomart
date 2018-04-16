namespace indomart.view
{
    partial class frm_data_barang
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
            this.dgv_data_barang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.cb_cari = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.dt_tgl_exp = new System.Windows.Forms.DateTimePicker();
            this.dt_tgl_masuk = new System.Windows.Forms.DateTimePicker();
            this.cb_jenis_barang = new System.Windows.Forms.ComboBox();
            this.txt_stock_brg = new System.Windows.Forms.TextBox();
            this.txt_no_rak = new System.Windows.Forms.TextBox();
            this.txt_hrg = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.txt_kd_barang = new System.Windows.Forms.TextBox();
            this.txt_hrg_jual = new System.Windows.Forms.TextBox();
            this.hrg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_kadaluarsa = new System.Windows.Forms.RadioButton();
            this.rd_kosong = new System.Windows.Forms.RadioButton();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_cek = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data_barang
            // 
            this.dgv_data_barang.AllowUserToAddRows = false;
            this.dgv_data_barang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_data_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_barang.Location = new System.Drawing.Point(12, 12);
            this.dgv_data_barang.Name = "dgv_data_barang";
            this.dgv_data_barang.ReadOnly = true;
            this.dgv_data_barang.Size = new System.Drawing.Size(1323, 276);
            this.dgv_data_barang.TabIndex = 0;
            this.dgv_data_barang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_data_barang_KeyUp);
            this.dgv_data_barang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_data_barang_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.cb_cari);
            this.groupBox1.Location = new System.Drawing.Point(148, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Barang ";
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(7, 57);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(121, 20);
            this.txt_cari.TabIndex = 2;
            // 
            // cb_cari
            // 
            this.cb_cari.FormattingEnabled = true;
            this.cb_cari.Items.AddRange(new object[] {
            "Kode Barang",
            "Nama Barang",
            "Jenis Barang"});
            this.cb_cari.Location = new System.Drawing.Point(7, 29);
            this.cb_cari.Name = "cb_cari";
            this.cb_cari.Size = new System.Drawing.Size(121, 21);
            this.cb_cari.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tambah);
            this.groupBox2.Controls.Add(this.btn_hapus);
            this.groupBox2.Controls.Add(this.btn_ubah);
            this.groupBox2.Controls.Add(this.dt_tgl_exp);
            this.groupBox2.Controls.Add(this.dt_tgl_masuk);
            this.groupBox2.Controls.Add(this.cb_jenis_barang);
            this.groupBox2.Controls.Add(this.txt_stock_brg);
            this.groupBox2.Controls.Add(this.txt_no_rak);
            this.groupBox2.Controls.Add(this.txt_hrg);
            this.groupBox2.Controls.Add(this.txt_nama_barang);
            this.groupBox2.Controls.Add(this.txt_kd_barang);
            this.groupBox2.Controls.Add(this.txt_hrg_jual);
            this.groupBox2.Controls.Add(this.hrg);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1323, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Barang ";
            // 
            // btn_ubah
            // 
            this.btn_ubah.Image = global::indomart.Properties.Resources.refresh;
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ubah.Location = new System.Drawing.Point(1195, 10);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(119, 49);
            this.btn_ubah.TabIndex = 21;
            this.btn_ubah.Text = "      Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // dt_tgl_exp
            // 
            this.dt_tgl_exp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tgl_exp.Location = new System.Drawing.Point(536, 84);
            this.dt_tgl_exp.Name = "dt_tgl_exp";
            this.dt_tgl_exp.Size = new System.Drawing.Size(156, 20);
            this.dt_tgl_exp.TabIndex = 20;
            // 
            // dt_tgl_masuk
            // 
            this.dt_tgl_masuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tgl_masuk.Location = new System.Drawing.Point(540, 39);
            this.dt_tgl_masuk.Name = "dt_tgl_masuk";
            this.dt_tgl_masuk.Size = new System.Drawing.Size(152, 20);
            this.dt_tgl_masuk.TabIndex = 19;
            // 
            // cb_jenis_barang
            // 
            this.cb_jenis_barang.FormattingEnabled = true;
            this.cb_jenis_barang.Location = new System.Drawing.Point(295, 30);
            this.cb_jenis_barang.Name = "cb_jenis_barang";
            this.cb_jenis_barang.Size = new System.Drawing.Size(121, 21);
            this.cb_jenis_barang.TabIndex = 17;
            // 
            // txt_stock_brg
            // 
            this.txt_stock_brg.Location = new System.Drawing.Point(295, 87);
            this.txt_stock_brg.Name = "txt_stock_brg";
            this.txt_stock_brg.ReadOnly = true;
            this.txt_stock_brg.Size = new System.Drawing.Size(121, 20);
            this.txt_stock_brg.TabIndex = 16;
            // 
            // txt_no_rak
            // 
            this.txt_no_rak.Location = new System.Drawing.Point(782, 39);
            this.txt_no_rak.Name = "txt_no_rak";
            this.txt_no_rak.Size = new System.Drawing.Size(121, 20);
            this.txt_no_rak.TabIndex = 15;
            // 
            // txt_hrg
            // 
            this.txt_hrg.Location = new System.Drawing.Point(1023, 36);
            this.txt_hrg.Name = "txt_hrg";
            this.txt_hrg.ReadOnly = true;
            this.txt_hrg.Size = new System.Drawing.Size(100, 20);
            this.txt_hrg.TabIndex = 14;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(84, 80);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(100, 20);
            this.txt_nama_barang.TabIndex = 13;
            // 
            // txt_kd_barang
            // 
            this.txt_kd_barang.Location = new System.Drawing.Point(84, 36);
            this.txt_kd_barang.Name = "txt_kd_barang";
            this.txt_kd_barang.ReadOnly = true;
            this.txt_kd_barang.Size = new System.Drawing.Size(100, 20);
            this.txt_kd_barang.TabIndex = 12;
            // 
            // txt_hrg_jual
            // 
            this.txt_hrg_jual.Location = new System.Drawing.Point(782, 84);
            this.txt_hrg_jual.Name = "txt_hrg_jual";
            this.txt_hrg_jual.Size = new System.Drawing.Size(121, 20);
            this.txt_hrg_jual.TabIndex = 11;
            // 
            // hrg
            // 
            this.hrg.AutoSize = true;
            this.hrg.Location = new System.Drawing.Point(960, 38);
            this.hrg.Name = "hrg";
            this.hrg.Size = new System.Drawing.Size(36, 13);
            this.hrg.TabIndex = 10;
            this.hrg.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(717, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Harga Jual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal Expire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No Rak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama Barang ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Barang ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_kadaluarsa);
            this.groupBox3.Controls.Add(this.rd_kosong);
            this.groupBox3.Controls.Add(this.btn_cek);
            this.groupBox3.Location = new System.Drawing.Point(733, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cek Data Barang ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rd_kadaluarsa
            // 
            this.rd_kadaluarsa.AutoSize = true;
            this.rd_kadaluarsa.Location = new System.Drawing.Point(30, 60);
            this.rd_kadaluarsa.Name = "rd_kadaluarsa";
            this.rd_kadaluarsa.Size = new System.Drawing.Size(137, 17);
            this.rd_kadaluarsa.TabIndex = 5;
            this.rd_kadaluarsa.TabStop = true;
            this.rd_kadaluarsa.Text = "Cek Barang Kadaluarsa";
            this.rd_kadaluarsa.UseVisualStyleBackColor = true;
            // 
            // rd_kosong
            // 
            this.rd_kosong.AutoSize = true;
            this.rd_kosong.Location = new System.Drawing.Point(30, 29);
            this.rd_kosong.Name = "rd_kosong";
            this.rd_kosong.Size = new System.Drawing.Size(120, 17);
            this.rd_kosong.TabIndex = 4;
            this.rd_kosong.TabStop = true;
            this.rd_kosong.Text = "Cek Barang Kosong";
            this.rd_kosong.UseVisualStyleBackColor = true;
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tanggal.Location = new System.Drawing.Point(1194, 319);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(132, 20);
            this.dtp_tanggal.TabIndex = 5;
            // 
            // btn_tampil
            // 
            this.btn_tampil.Image = global::indomart.Properties.Resources.book;
            this.btn_tampil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tampil.Location = new System.Drawing.Point(514, 319);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(190, 71);
            this.btn_tampil.TabIndex = 3;
            this.btn_tampil.Text = "              Tampilkan Semua";
            this.btn_tampil.UseVisualStyleBackColor = true;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_cek
            // 
            this.btn_cek.Image = global::indomart.Properties.Resources.find;
            this.btn_cek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cek.Location = new System.Drawing.Point(249, 29);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(148, 48);
            this.btn_cek.TabIndex = 3;
            this.btn_cek.Text = "      Cek Barang ";
            this.btn_cek.UseVisualStyleBackColor = true;
            this.btn_cek.Click += new System.EventHandler(this.btn_cek_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Image = global::indomart.Properties.Resources.add;
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(1195, 10);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(119, 49);
            this.btn_tambah.TabIndex = 23;
            this.btn_tambah.Text = "          Tambah Stock";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Image = global::indomart.Properties.Resources.delete;
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(1195, 70);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(119, 59);
            this.btn_hapus.TabIndex = 22;
            this.btn_hapus.Text = "        Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.Image = global::indomart.Properties.Resources.find;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(168, 29);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(133, 48);
            this.btn_cari.TabIndex = 1;
            this.btn_cari.Text = "      Cari Data";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // frm_data_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 592);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_data_barang);
            this.Name = "frm_data_barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data barang ";
            this.Load += new System.EventHandler(this.frm_data_barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data_barang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.ComboBox cb_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label hrg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_tgl_exp;
        private System.Windows.Forms.DateTimePicker dt_tgl_masuk;
        private System.Windows.Forms.ComboBox cb_jenis_barang;
        private System.Windows.Forms.TextBox txt_stock_brg;
        private System.Windows.Forms.TextBox txt_no_rak;
        private System.Windows.Forms.TextBox txt_hrg;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.TextBox txt_kd_barang;
        private System.Windows.Forms.TextBox txt_hrg_jual;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_kadaluarsa;
        private System.Windows.Forms.RadioButton rd_kosong;
        private System.Windows.Forms.Button btn_cek;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.Button btn_tambah;


    }
}