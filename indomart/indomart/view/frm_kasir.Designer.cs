namespace indomart.view
{
    partial class frm_kasir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nama_kasir = new System.Windows.Forms.Label();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kd_brg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_tangal = new System.Windows.Forms.DateTimePicker();
            this.lbl_kd_kasir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_kd_berikut = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_barang_keluar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kembalian = new System.Windows.Forms.Label();
            this.txt_bayar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_psoses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang_keluar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nama_kasir);
            this.groupBox1.Controls.Add(this.btn_tambah);
            this.groupBox1.Controls.Add(this.txt_jumlah);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kd_brg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_tangal);
            this.groupBox1.Controls.Add(this.lbl_kd_kasir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kasir";
            // 
            // lbl_nama_kasir
            // 
            this.lbl_nama_kasir.AutoSize = true;
            this.lbl_nama_kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama_kasir.Location = new System.Drawing.Point(189, 33);
            this.lbl_nama_kasir.Name = "lbl_nama_kasir";
            this.lbl_nama_kasir.Size = new System.Drawing.Size(0, 13);
            this.lbl_nama_kasir.TabIndex = 10;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(192, 126);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(81, 20);
            this.txt_jumlah.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah";
            // 
            // txt_kd_brg
            // 
            this.txt_kd_brg.Location = new System.Drawing.Point(192, 96);
            this.txt_kd_brg.Name = "txt_kd_brg";
            this.txt_kd_brg.Size = new System.Drawing.Size(172, 20);
            this.txt_kd_brg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kode Barang";
            // 
            // dt_tangal
            // 
            this.dt_tangal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tangal.Location = new System.Drawing.Point(192, 61);
            this.dt_tangal.Name = "dt_tangal";
            this.dt_tangal.Size = new System.Drawing.Size(172, 20);
            this.dt_tangal.TabIndex = 4;
            // 
            // lbl_kd_kasir
            // 
            this.lbl_kd_kasir.AutoSize = true;
            this.lbl_kd_kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kd_kasir.Location = new System.Drawing.Point(189, 31);
            this.lbl_kd_kasir.Name = "lbl_kd_kasir";
            this.lbl_kd_kasir.Size = new System.Drawing.Size(0, 15);
            this.lbl_kd_kasir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kasir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_kd_berikut);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txt_kd_berikut
            // 
            this.txt_kd_berikut.Location = new System.Drawing.Point(296, 124);
            this.txt_kd_berikut.Name = "txt_kd_berikut";
            this.txt_kd_berikut.Size = new System.Drawing.Size(100, 24);
            this.txt_kd_berikut.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(169, 51);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(54, 73);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 73);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rp.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_barang_keluar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1020, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Penjualan";
            // 
            // dgv_barang_keluar
            // 
            this.dgv_barang_keluar.AllowUserToAddRows = false;
            this.dgv_barang_keluar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_barang_keluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_barang_keluar.Location = new System.Drawing.Point(21, 40);
            this.dgv_barang_keluar.Name = "dgv_barang_keluar";
            this.dgv_barang_keluar.Size = new System.Drawing.Size(972, 161);
            this.dgv_barang_keluar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_nama);
            this.groupBox4.Location = new System.Drawing.Point(12, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 121);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nama Barang";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(157, 48);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(0, 33);
            this.lbl_nama.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.lbl_kembalian);
            this.groupBox5.Controls.Add(this.txt_bayar);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(457, 439);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 121);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bayar";
            // 
            // lbl_kembalian
            // 
            this.lbl_kembalian.AutoSize = true;
            this.lbl_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kembalian.Location = new System.Drawing.Point(116, 80);
            this.lbl_kembalian.Name = "lbl_kembalian";
            this.lbl_kembalian.Size = new System.Drawing.Size(0, 24);
            this.lbl_kembalian.TabIndex = 12;
            // 
            // txt_bayar
            // 
            this.txt_bayar.Location = new System.Drawing.Point(119, 33);
            this.txt_bayar.Name = "txt_bayar";
            this.txt_bayar.Size = new System.Drawing.Size(115, 20);
            this.txt_bayar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kembalian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pembayaran";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_psoses);
            this.groupBox6.Location = new System.Drawing.Point(832, 447);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 113);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Proses";
            // 
            // btn_psoses
            // 
            this.btn_psoses.Image = global::indomart.Properties.Resources.save_all;
            this.btn_psoses.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_psoses.Location = new System.Drawing.Point(48, 40);
            this.btn_psoses.Name = "btn_psoses";
            this.btn_psoses.Size = new System.Drawing.Size(105, 50);
            this.btn_psoses.TabIndex = 0;
            this.btn_psoses.Text = "         Simpan";
            this.btn_psoses.UseVisualStyleBackColor = true;
            this.btn_psoses.Click += new System.EventHandler(this.btn_psoses_Click);
            // 
            // button1
            // 
            this.button1.Image = global::indomart.Properties.Resources._1279683712_106168825_1_Gambar__Software_Toko_POS_dan_Minimarket_sangat_mudah_lengkap_dan_murah_1279683712;
            this.button1.Location = new System.Drawing.Point(257, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 71);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Image = global::indomart.Properties.Resources.add1;
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_tambah.Location = new System.Drawing.Point(289, 126);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(91, 39);
            this.btn_tambah.TabIndex = 9;
            this.btn_tambah.Text = "        Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // frm_kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1058, 607);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Kasir ";
            this.Load += new System.EventHandler(this.frm_kasir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang_keluar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_kd_brg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_tangal;
        private System.Windows.Forms.Label lbl_kd_kasir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_barang_keluar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_kembalian;
        private System.Windows.Forms.TextBox txt_bayar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_psoses;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.TextBox txt_kd_berikut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nama_kasir;
    }
}