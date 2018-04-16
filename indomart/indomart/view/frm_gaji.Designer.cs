namespace indomart.view
{
    partial class frm_gaji
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
            this.dgv_gaji = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_cari = new System.Windows.Forms.ComboBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tunjangan = new System.Windows.Forms.TextBox();
            this.txt_gajipokok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_jabatan = new System.Windows.Forms.TextBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gaji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_gaji
            // 
            this.dgv_gaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gaji.Location = new System.Drawing.Point(74, 14);
            this.dgv_gaji.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_gaji.Name = "dgv_gaji";
            this.dgv_gaji.ReadOnly = true;
            this.dgv_gaji.Size = new System.Drawing.Size(1014, 263);
            this.dgv_gaji.TabIndex = 0;
            this.dgv_gaji.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_gaji_KeyUp);
            this.dgv_gaji.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_gaji_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tampil);
            this.groupBox1.Controls.Add(this.cb_cari);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(238, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Penggajian";
            // 
            // cb_cari
            // 
            this.cb_cari.FormattingEnabled = true;
            this.cb_cari.Items.AddRange(new object[] {
            "NIK",
            "Gaji Pokok",
            "Tunjangan"});
            this.cb_cari.Location = new System.Drawing.Point(223, 28);
            this.cb_cari.Name = "cb_cari";
            this.cb_cari.Size = new System.Drawing.Size(109, 25);
            this.cb_cari.TabIndex = 4;
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(223, 58);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(100, 25);
            this.txt_cari.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ketikan Masukan : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cari data berdasarkan :";
            // 
            // txt_tunjangan
            // 
            this.txt_tunjangan.Location = new System.Drawing.Point(850, 21);
            this.txt_tunjangan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tunjangan.Name = "txt_tunjangan";
            this.txt_tunjangan.Size = new System.Drawing.Size(164, 24);
            this.txt_tunjangan.TabIndex = 24;
            // 
            // txt_gajipokok
            // 
            this.txt_gajipokok.Location = new System.Drawing.Point(544, 69);
            this.txt_gajipokok.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gajipokok.Name = "txt_gajipokok";
            this.txt_gajipokok.Size = new System.Drawing.Size(164, 24);
            this.txt_gajipokok.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tunjangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gaji Pokok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jabatan";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(190, 69);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.ReadOnly = true;
            this.txt_nama.Size = new System.Drawing.Size(164, 24);
            this.txt_nama.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nama";
            // 
            // txt_nik
            // 
            this.txt_nik.Location = new System.Drawing.Point(190, 24);
            this.txt_nik.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.ReadOnly = true;
            this.txt_nik.Size = new System.Drawing.Size(164, 24);
            this.txt_nik.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_tambah);
            this.groupBox3.Location = new System.Drawing.Point(1141, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 244);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_jabatan);
            this.groupBox2.Controls.Add(this.txt_nik);
            this.groupBox2.Controls.Add(this.txt_tunjangan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nama);
            this.groupBox2.Controls.Add(this.txt_gajipokok);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(74, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampil Data Gaji Karyawan";
            // 
            // cb_jabatan
            // 
            this.cb_jabatan.Location = new System.Drawing.Point(544, 24);
            this.cb_jabatan.Margin = new System.Windows.Forms.Padding(4);
            this.cb_jabatan.Name = "cb_jabatan";
            this.cb_jabatan.ReadOnly = true;
            this.cb_jabatan.Size = new System.Drawing.Size(164, 24);
            this.cb_jabatan.TabIndex = 26;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Image = global::indomart.Properties.Resources.delete;
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_hapus.Location = new System.Drawing.Point(38, 170);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(124, 59);
            this.btn_hapus.TabIndex = 6;
            this.btn_hapus.Text = "     Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click_1);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Image = global::indomart.Properties.Resources.refresh;
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ubah.Location = new System.Drawing.Point(38, 92);
            this.btn_ubah.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(124, 60);
            this.btn_ubah.TabIndex = 5;
            this.btn_ubah.Text = "        Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click_1);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Image = global::indomart.Properties.Resources.add1;
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(38, 24);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(124, 60);
            this.btn_tambah.TabIndex = 4;
            this.btn_tambah.Text = "     Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click_1);
            // 
            // btn_tampil
            // 
            this.btn_tampil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tampil.Image = global::indomart.Properties.Resources.book;
            this.btn_tampil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tampil.Location = new System.Drawing.Point(573, 14);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(188, 80);
            this.btn_tampil.TabIndex = 12;
            this.btn_tampil.Text = "                   Tampilkan Semua";
            this.btn_tampil.UseVisualStyleBackColor = true;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.Image = global::indomart.Properties.Resources.find;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(384, 23);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(134, 71);
            this.btn_cari.TabIndex = 11;
            this.btn_cari.Text = "    Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // frm_gaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_gaji);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_gaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penggajian";
            this.Load += new System.EventHandler(this.frm_gaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gaji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_gaji;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.ComboBox cb_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox txt_tunjangan;
        private System.Windows.Forms.TextBox txt_gajipokok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cb_jabatan;
    }
}