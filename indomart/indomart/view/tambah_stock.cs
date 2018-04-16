using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using indomart.dao;
using indomart.model;

namespace indomart.view
{
    public partial class tambah_stock : Form
    {
        //tambah_stock tbmh_stock = new tambah_stock(txt_kd_barang.Text , txt_nama_barang.Text , dt_tgl_masuk.Text , dt_tgl_exp.Text , txt_no_rak.Text , txt_hrg.Text , txt_hrg_jual.Text );
        string kode , nama, tanggal_masuk ,  tanggal_exp , nomor_rak , harga , harga_jual, jenis_brg;   
        public tambah_stock(String kd_brg , string nama_brg,  string tgl_masuk , string tgl_exp , string no_rak , string hrg , string hrg_jual,string jenis_barang )
        {
            this.kode = kd_brg;
            this.nama = nama_brg;
            this.tanggal_masuk = tgl_masuk;
            this.tanggal_exp = tgl_exp;
            this.nomor_rak = no_rak;
            this.harga = hrg;
            this.harga_jual = hrg_jual;
            this.jenis_brg = jenis_barang;
            InitializeComponent();
        }

        private void tambah_stock_Load(object sender, EventArgs e)
        {
            
            txt_kd_barang.Text = kode;
            txt_nama_barang.Text = nama;
            dt_tgl_masuk.Text = tanggal_masuk;
            dt_tgl_exp.Text = tanggal_exp;
            txt_no_rak.Text = nomor_rak;
            txt_harga.Text = harga;
            txt_harga_jual.Text = harga_jual;
            jenis_barang.Text = jenis_brg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_barang db = new data_barang();
            db.kd_barang = txt_kd_barang.Text;
            // db.tgl_exp = dt_exp.Value.ToString("yyyy-MM-dd");
            
            db.tgl_masuk = dt_tgl_masuk.Value.ToString("yyyy-MM-dd");
            db.tgl_exp = dt_tgl_exp.Value.ToString("yyyy-MM-dd");
            string tgl_masuk = dt_tgl_masuk.Value.ToString("yyyy-MM-dd");
            string tgl_exp = dt_tgl_exp.Value.ToString("yyyy-MM-dd");

            db.stock = Convert.ToInt16(txt_stock_brg.Text);
            
            if (tgl_masuk == tgl_exp)
            {
                MessageBox.Show("Barang Sudah Kadaluarsa");
            }

            else if (new data_barang_dao().tambah_stock_barang(db))
            {
                MessageBox.Show("Stock Barang berhasil Di Tambahkan", "Pesan");
                
            }

            
        }
    }
}
