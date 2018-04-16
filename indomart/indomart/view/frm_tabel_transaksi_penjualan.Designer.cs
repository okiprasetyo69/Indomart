namespace indomart.view
{
    partial class frm_tabel_transaksi_penjualan
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
            this.btn_details = new System.Windows.Forms.Button();
            this.cb_kd_transaksi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.txt_nama_kasir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kd_nik = new System.Windows.Forms.TextBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.dt_tgl = new System.Windows.Forms.DateTimePicker();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_kd_trans = new System.Windows.Forms.TextBox();
            this.labrl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_tabel_keluar = new System.Windows.Forms.DataGridView();
            this.dgv_data_transaksi = new System.Windows.Forms.DataGridView();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabel_keluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_details);
            this.groupBox1.Controls.Add(this.cb_kd_transaksi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 276);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Penjualan";
            // 
            // btn_details
            // 
            this.btn_details.Image = global::indomart.Properties.Resources.book;
            this.btn_details.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_details.Location = new System.Drawing.Point(15, 173);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(121, 66);
            this.btn_details.TabIndex = 4;
            this.btn_details.Text = "                 Details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // cb_kd_transaksi
            // 
            this.cb_kd_transaksi.FormattingEnabled = true;
            this.cb_kd_transaksi.Location = new System.Drawing.Point(15, 116);
            this.cb_kd_transaksi.Name = "cb_kd_transaksi";
            this.cb_kd_transaksi.Size = new System.Drawing.Size(121, 21);
            this.cb_kd_transaksi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Transaksi";
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.txt_nama_kasir);
            this.gb_data.Controls.Add(this.label2);
            this.gb_data.Controls.Add(this.txt_kd_nik);
            this.gb_data.Controls.Add(this.btn_hapus);
            this.gb_data.Controls.Add(this.dt_tgl);
            this.gb_data.Controls.Add(this.txt_total);
            this.gb_data.Controls.Add(this.txt_kd_trans);
            this.gb_data.Controls.Add(this.labrl);
            this.gb_data.Controls.Add(this.label4);
            this.gb_data.Controls.Add(this.label9);
            this.gb_data.Controls.Add(this.label10);
            this.gb_data.Location = new System.Drawing.Point(22, 398);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(1323, 123);
            this.gb_data.TabIndex = 4;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Data Barang ";
            // 
            // txt_nama_kasir
            // 
            this.txt_nama_kasir.Location = new System.Drawing.Point(447, 27);
            this.txt_nama_kasir.Name = "txt_nama_kasir";
            this.txt_nama_kasir.ReadOnly = true;
            this.txt_nama_kasir.Size = new System.Drawing.Size(152, 20);
            this.txt_nama_kasir.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama Kasir";
            // 
            // txt_kd_nik
            // 
            this.txt_kd_nik.Location = new System.Drawing.Point(102, 84);
            this.txt_kd_nik.Name = "txt_kd_nik";
            this.txt_kd_nik.ReadOnly = true;
            this.txt_kd_nik.Size = new System.Drawing.Size(100, 20);
            this.txt_kd_nik.TabIndex = 24;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Image = global::indomart.Properties.Resources.delete;
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_hapus.Location = new System.Drawing.Point(1177, 33);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(93, 58);
            this.btn_hapus.TabIndex = 22;
            this.btn_hapus.Text = "              Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // dt_tgl
            // 
            this.dt_tgl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tgl.Location = new System.Drawing.Point(447, 71);
            this.dt_tgl.Name = "dt_tgl";
            this.dt_tgl.Size = new System.Drawing.Size(152, 20);
            this.dt_tgl.TabIndex = 19;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(909, 31);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 14;
            // 
            // txt_kd_trans
            // 
            this.txt_kd_trans.Location = new System.Drawing.Point(102, 35);
            this.txt_kd_trans.Name = "txt_kd_trans";
            this.txt_kd_trans.ReadOnly = true;
            this.txt_kd_trans.Size = new System.Drawing.Size(100, 20);
            this.txt_kd_trans.TabIndex = 12;
            // 
            // labrl
            // 
            this.labrl.AutoSize = true;
            this.labrl.Location = new System.Drawing.Point(846, 33);
            this.labrl.Name = "labrl";
            this.labrl.Size = new System.Drawing.Size(31, 13);
            this.labrl.TabIndex = 10;
            this.labrl.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode NIK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tanggal Masuk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kode transaksi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_tabel_keluar);
            this.groupBox4.Controls.Add(this.dgv_data_transaksi);
            this.groupBox4.Location = new System.Drawing.Point(353, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(992, 294);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tabel Transaksi Penjualan";
            // 
            // dgv_tabel_keluar
            // 
            this.dgv_tabel_keluar.AllowUserToAddRows = false;
            this.dgv_tabel_keluar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_tabel_keluar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tabel_keluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabel_keluar.Location = new System.Drawing.Point(23, 19);
            this.dgv_tabel_keluar.Name = "dgv_tabel_keluar";
            this.dgv_tabel_keluar.ReadOnly = true;
            this.dgv_tabel_keluar.Size = new System.Drawing.Size(935, 238);
            this.dgv_tabel_keluar.TabIndex = 3;
            // 
            // dgv_data_transaksi
            // 
            this.dgv_data_transaksi.AllowUserToAddRows = false;
            this.dgv_data_transaksi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_data_transaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_transaksi.Location = new System.Drawing.Point(23, 30);
            this.dgv_data_transaksi.Name = "dgv_data_transaksi";
            this.dgv_data_transaksi.ReadOnly = true;
            this.dgv_data_transaksi.Size = new System.Drawing.Size(949, 249);
            this.dgv_data_transaksi.TabIndex = 2;
            this.dgv_data_transaksi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_data_transaksi_KeyUp);
            this.dgv_data_transaksi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_data_transaksi_MouseClick);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaksi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_transaksi.Location = new System.Drawing.Point(588, 351);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Size = new System.Drawing.Size(184, 51);
            this.btn_transaksi.TabIndex = 7;
            this.btn_transaksi.Text = "Data Transaksi Penjualan";
            this.btn_transaksi.UseVisualStyleBackColor = true;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // frm_tabel_transaksi_penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 592);
            this.Controls.Add(this.btn_transaksi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gb_data);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tabel_transaksi_penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabel Transaksi Penjualan";
            this.Load += new System.EventHandler(this.frm_tabel_transaksi_penjualan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabel_keluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_transaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.ComboBox cb_kd_transaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_data;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DateTimePicker dt_tgl;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_kd_trans;
        private System.Windows.Forms.Label labrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_data_transaksi;
        private System.Windows.Forms.TextBox txt_nama_kasir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kd_nik;
        private System.Windows.Forms.DataGridView dgv_tabel_keluar;
        private System.Windows.Forms.Button btn_transaksi;
    }
}