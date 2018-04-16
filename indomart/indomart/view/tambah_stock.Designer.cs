namespace indomart.view
{
    partial class tambah_stock
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
            this.dt_tgl_masuk = new System.Windows.Forms.DateTimePicker();
            this.txt_kd_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_barang = new System.Windows.Forms.GroupBox();
            this.jenis_barang = new System.Windows.Forms.ComboBox();
            this.txt_no_rak = new System.Windows.Forms.TextBox();
            this.dt_tgl_exp = new System.Windows.Forms.DateTimePicker();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_harga_jual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_stock_brg = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.input_barang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_tgl_masuk);
            this.groupBox1.Controls.Add(this.txt_kd_barang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Barang Masuk";
            // 
            // dt_tgl_masuk
            // 
            this.dt_tgl_masuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tgl_masuk.Location = new System.Drawing.Point(199, 52);
            this.dt_tgl_masuk.Name = "dt_tgl_masuk";
            this.dt_tgl_masuk.Size = new System.Drawing.Size(147, 20);
            this.dt_tgl_masuk.TabIndex = 3;
            // 
            // txt_kd_barang
            // 
            this.txt_kd_barang.Location = new System.Drawing.Point(199, 25);
            this.txt_kd_barang.Name = "txt_kd_barang";
            this.txt_kd_barang.ReadOnly = true;
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
            this.input_barang.Controls.Add(this.jenis_barang);
            this.input_barang.Controls.Add(this.txt_no_rak);
            this.input_barang.Controls.Add(this.dt_tgl_exp);
            this.input_barang.Controls.Add(this.txt_harga);
            this.input_barang.Controls.Add(this.txt_harga_jual);
            this.input_barang.Controls.Add(this.label11);
            this.input_barang.Controls.Add(this.label10);
            this.input_barang.Controls.Add(this.txt_stock_brg);
            this.input_barang.Controls.Add(this.txt_nama_barang);
            this.input_barang.Controls.Add(this.label8);
            this.input_barang.Controls.Add(this.label7);
            this.input_barang.Controls.Add(this.label6);
            this.input_barang.Controls.Add(this.label4);
            this.input_barang.Controls.Add(this.label3);
            this.input_barang.Location = new System.Drawing.Point(22, 169);
            this.input_barang.Name = "input_barang";
            this.input_barang.Size = new System.Drawing.Size(664, 245);
            this.input_barang.TabIndex = 2;
            this.input_barang.TabStop = false;
            this.input_barang.Text = "Input Barang";
            // 
            // jenis_barang
            // 
            this.jenis_barang.FormattingEnabled = true;
            this.jenis_barang.Items.AddRange(new object[] {
            "Makanan",
            "Obat - Obatan"});
            this.jenis_barang.Location = new System.Drawing.Point(121, 79);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(147, 21);
            this.jenis_barang.TabIndex = 16;
            // 
            // txt_no_rak
            // 
            this.txt_no_rak.Location = new System.Drawing.Point(477, 79);
            this.txt_no_rak.Name = "txt_no_rak";
            this.txt_no_rak.ReadOnly = true;
            this.txt_no_rak.Size = new System.Drawing.Size(147, 20);
            this.txt_no_rak.TabIndex = 14;
            // 
            // dt_tgl_exp
            // 
            this.dt_tgl_exp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tgl_exp.Location = new System.Drawing.Point(477, 26);
            this.dt_tgl_exp.Name = "dt_tgl_exp";
            this.dt_tgl_exp.Size = new System.Drawing.Size(147, 20);
            this.dt_tgl_exp.TabIndex = 4;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(121, 121);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.ReadOnly = true;
            this.txt_harga.Size = new System.Drawing.Size(147, 20);
            this.txt_harga.TabIndex = 13;
            // 
            // txt_harga_jual
            // 
            this.txt_harga_jual.Location = new System.Drawing.Point(121, 172);
            this.txt_harga_jual.Name = "txt_harga_jual";
            this.txt_harga_jual.ReadOnly = true;
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
            // txt_stock_brg
            // 
            this.txt_stock_brg.Location = new System.Drawing.Point(477, 114);
            this.txt_stock_brg.Name = "txt_stock_brg";
            this.txt_stock_brg.Size = new System.Drawing.Size(147, 20);
            this.txt_stock_brg.TabIndex = 8;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(121, 44);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.ReadOnly = true;
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
            // button1
            // 
            this.button1.Image = global::indomart.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(312, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "       Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tambah_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_barang);
            this.Controls.Add(this.groupBox1);
            this.Name = "tambah_stock";
            this.Text = "Tambah Stock Barang ";
            this.Load += new System.EventHandler(this.tambah_stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.input_barang.ResumeLayout(false);
            this.input_barang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_tgl_masuk;
        private System.Windows.Forms.TextBox txt_kd_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox input_barang;
        private System.Windows.Forms.ComboBox jenis_barang;
        private System.Windows.Forms.TextBox txt_no_rak;
        private System.Windows.Forms.DateTimePicker dt_tgl_exp;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_harga_jual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_stock_brg;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}