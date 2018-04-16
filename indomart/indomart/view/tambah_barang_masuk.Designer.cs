namespace indomart.view
{
    partial class tambah_barang_masuk
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
            this.dt_tanggal_masuk = new System.Windows.Forms.DateTimePicker();
            this.txt_kd_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_barang = new System.Windows.Forms.GroupBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.jenis_barang = new System.Windows.Forms.ComboBox();
            this.txt_no_rak = new System.Windows.Forms.TextBox();
            this.dt_exp = new System.Windows.Forms.DateTimePicker();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_harga_jual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.input_barang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.dt_tanggal_masuk);
            this.groupBox1.Controls.Add(this.txt_kd_barang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Barang Masuk";
            // 
            // dt_tanggal_masuk
            // 
            this.dt_tanggal_masuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tanggal_masuk.Location = new System.Drawing.Point(199, 52);
            this.dt_tanggal_masuk.Name = "dt_tanggal_masuk";
            this.dt_tanggal_masuk.Size = new System.Drawing.Size(147, 20);
            this.dt_tanggal_masuk.TabIndex = 3;
            // 
            // txt_kd_barang
            // 
            this.txt_kd_barang.Location = new System.Drawing.Point(199, 25);
            this.txt_kd_barang.Name = "txt_kd_barang";
            this.txt_kd_barang.Size = new System.Drawing.Size(147, 20);
            this.txt_kd_barang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // input_barang
            // 
            this.input_barang.Controls.Add(this.stock);
            this.input_barang.Controls.Add(this.jenis_barang);
            this.input_barang.Controls.Add(this.txt_no_rak);
            this.input_barang.Controls.Add(this.dt_exp);
            this.input_barang.Controls.Add(this.txt_harga);
            this.input_barang.Controls.Add(this.txt_harga_jual);
            this.input_barang.Controls.Add(this.label11);
            this.input_barang.Controls.Add(this.label10);
            this.input_barang.Controls.Add(this.txt_jumlah);
            this.input_barang.Controls.Add(this.txt_nama_barang);
            this.input_barang.Controls.Add(this.label8);
            this.input_barang.Controls.Add(this.label7);
            this.input_barang.Controls.Add(this.label6);
            this.input_barang.Controls.Add(this.label4);
            this.input_barang.Controls.Add(this.label3);
            this.input_barang.Location = new System.Drawing.Point(36, 179);
            this.input_barang.Name = "input_barang";
            this.input_barang.Size = new System.Drawing.Size(664, 245);
            this.input_barang.TabIndex = 1;
            this.input_barang.TabStop = false;
            this.input_barang.Text = "Input Barang";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(477, 172);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(100, 20);
            this.stock.TabIndex = 17;
            // 
            // jenis_barang
            // 
            this.jenis_barang.FormattingEnabled = true;
            this.jenis_barang.Items.AddRange(new object[] {
            "Makanan / Minuman",
            "Obat - Obatan",
            "Kosmetik",
            "Peralatan Mandi",
            "Peralatan Dapur",
            "Perlengkapan Baby"});
            this.jenis_barang.Location = new System.Drawing.Point(121, 79);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(147, 21);
            this.jenis_barang.TabIndex = 16;
            // 
            // txt_no_rak
            // 
            this.txt_no_rak.Location = new System.Drawing.Point(477, 79);
            this.txt_no_rak.Name = "txt_no_rak";
            this.txt_no_rak.Size = new System.Drawing.Size(147, 20);
            this.txt_no_rak.TabIndex = 14;
            // 
            // dt_exp
            // 
            this.dt_exp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_exp.Location = new System.Drawing.Point(477, 26);
            this.dt_exp.Name = "dt_exp";
            this.dt_exp.Size = new System.Drawing.Size(147, 20);
            this.dt_exp.TabIndex = 4;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(121, 121);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(147, 20);
            this.txt_harga.TabIndex = 13;
            // 
            // txt_harga_jual
            // 
            this.txt_harga_jual.Location = new System.Drawing.Point(121, 172);
            this.txt_harga_jual.Name = "txt_harga_jual";
            this.txt_harga_jual.Size = new System.Drawing.Size(147, 20);
            this.txt_harga_jual.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Harga ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Harga Jual";
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(477, 114);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(147, 20);
            this.txt_jumlah.TabIndex = 8;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(121, 44);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(147, 20);
            this.txt_nama_barang.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nama Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Jenis Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Jumlah Barang Masuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tanggal Expire Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "No Rak";
            // 
            // btn_update
            // 
            this.btn_update.Image = global::indomart.Properties.Resources.refresh;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_update.Location = new System.Drawing.Point(284, 430);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 51);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "       Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Image = global::indomart.Properties.Resources.save_all;
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_simpan.Location = new System.Drawing.Point(284, 437);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(98, 37);
            this.btn_simpan.TabIndex = 2;
            this.btn_simpan.Text = "       Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // check
            // 
            this.check.Image = global::indomart.Properties.Resources.find;
            this.check.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.check.Location = new System.Drawing.Point(509, 32);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(83, 40);
            this.check.TabIndex = 4;
            this.check.Text = "           Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // tambah_barang_masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.input_barang);
            this.Controls.Add(this.groupBox1);
            this.Name = "tambah_barang_masuk";
            this.Text = "Form Input Barang Masuk";
            this.Load += new System.EventHandler(this.tambah_barang_masuk_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.input_barang.ResumeLayout(false);
            this.input_barang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_tanggal_masuk;
        private System.Windows.Forms.TextBox txt_kd_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox input_barang;
        private System.Windows.Forms.TextBox txt_no_rak;
        private System.Windows.Forms.DateTimePicker dt_exp;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_harga_jual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ComboBox jenis_barang;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Button btn_update;
    }
}