using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using indomart.model;
using indomart.dao;

namespace indomart.view
{
    public partial class frm_kasir : Form
    {
        String kd_nik;
        public frm_kasir(string nik)
        {
            this.kd_nik = nik;
            InitializeComponent();
            
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
              // Cari Data
            try
            {
                data_barang_keluar dbk = new data_barang_keluar();
                data_barang db = new data_barang();
                db.kd_barang = txt_kd_brg.Text;
                DataSet ds = new data_barang_dao().cari_kode_barang(db);


                lbl_nama.Text = ds.Tables[0].Rows[0][1].ToString();

                // Proses 
                dbk.jumlah = Convert.ToInt16(txt_jumlah.Text);
                string str_harga_jual = ds.Tables[0].Rows[0][9].ToString();
                dbk.harga_jual = Convert.ToDouble(str_harga_jual);

                lbl_total.Text = str_harga_jual;
                // Input Data 

                dbk.kd_barang = txt_kd_brg.Text;
                dbk.tanggal = dt_tangal.Value.ToString("yyyy-MM-dd");
                dbk.jumlah = Convert.ToInt16(txt_jumlah.Text);
                //Simpan barang Keluar 
                int stock_brg = Convert.ToInt16(ds.Tables[0].Rows[0][3].ToString());
                db.stock = stock_brg;
                db.jml_keluar = Convert.ToInt16(txt_jumlah.Text);

                //ambil kode transaksi barang keluar
                DataSet dk = new data_barang_keluar_dao().tampil_jmlah_data();
                int jml_data = Convert.ToInt16(dk.Tables[0].Rows[0][0].ToString());
                if (jml_data == 0)
                {
                    txt_kd_berikut.Text = "1001";
                }

                else
                {

                    int jml_dt = jml_data - 1;

                    DataSet kd_tr = new data_barang_keluar_dao().tampil_transaksi_barang_keluar();
                    string kd = kd_tr.Tables[0].Rows[jml_dt][0].ToString();
                    int kd_berikut;
                    kd_berikut = Convert.ToInt16(kd_tr.Tables[0].Rows[jml_dt][0].ToString()) + 1;

                    txt_kd_berikut.Text = Convert.ToString(kd_berikut);

                }

                dbk.kode_transaksi = txt_kd_berikut.Text;
                if (new data_barang_keluar_dao().input_temp_keluar(dbk))
                {
                    DataSet dt = new data_barang_keluar_dao().total_harga();
                    lbl_total.Text = dt.Tables[0].Rows[0][0].ToString();

                    if (new data_barang_dao().update_barang_keluar(db))
                    {

                    }


                }
                binding();
                txt_kd_brg.Text = "";
                txt_jumlah.Text = "";
            }
            catch
            {
                MessageBox.Show("Kode Barang Kosong");
            }

        }

        public void binding()
        {

            DataSet ds = new data_barang_keluar_dao().tampil_temp_barang_keluar();
            
            
            dgv_barang_keluar.DataSource = ds;
            dgv_barang_keluar.DataMember = "tb_temp_keluar";

            DataGridViewColumn kolom0 = dgv_barang_keluar.Columns[0];
            kolom0.Width = 160;
            kolom0.HeaderText = "Kode Barang";

            DataGridViewColumn kolom1 = dgv_barang_keluar.Columns[1];
            kolom1.Width = 220;
            kolom1.HeaderText = "Nama Barang";

            DataGridViewColumn kolom2 = dgv_barang_keluar.Columns[2];
            kolom2.Width = 190;
            kolom2.HeaderText = "Harga";

            DataGridViewColumn kolom3 = dgv_barang_keluar.Columns[3];
            kolom3.Width = 210;
            kolom3.HeaderText = "Tanggal";

            DataGridViewColumn kolom4 = dgv_barang_keluar.Columns[4];
            kolom4.Width = 150;
            kolom4.HeaderText = "Jumlah";

           // txt_nama_barang.Text = ds.Tables[0].Rows[0][1].ToString();
            
        }

        private void frm_kasir_Load(object sender, EventArgs e)
        {
            lbl_kd_kasir.Text = kd_nik;
           
            binding();
            txt_kd_berikut.Hide();

            karyawan k = new karyawan();
            k.nik = lbl_kd_kasir.Text;
            DataSet ds = new karyawan_dao().carinama_kasir(k);

            lbl_nama_kasir.Text = ds.Tables[0].Rows[0][0].ToString();
            lbl_kd_kasir.Hide();
            
        }

        private void btn_psoses_Click(object sender, EventArgs e)
        {
            data_barang_keluar dbk = new data_barang_keluar();

            dbk.kode_transaksi = Convert.ToString(txt_kd_berikut.Text);
            dbk.nik = lbl_kd_kasir.Text;
            dbk.tanggal = dt_tangal.Value.ToString("yyyy-MM-dd");
            dbk.total_bayar = Convert.ToDouble( lbl_total.Text);
            dbk.kd_berikut = txt_kd_berikut.Text;
            if (new data_barang_keluar_dao().input_transaksi_penjualan(dbk))
            {
                if (new data_barang_keluar_dao().input_barang_keluar())
                {

                    if (new data_barang_keluar_dao().hapus_temp_keluar())
                    {
                        MessageBox.Show("Sukses");
                        
                    }
                }
            }

            binding();

            lbl_total.Text = "0";
            lbl_nama.Text = "";
           // txt_bayar.Text = "";
            lbl_kembalian.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tot_har = Convert.ToDouble(lbl_total.Text);
            double bayar = Convert.ToDouble(txt_bayar.Text);

            if (txt_bayar.Text == "")
            {

            }

            double kembalian = bayar - tot_har;

            lbl_kembalian.Text = Convert.ToString(kembalian);
        }      
    }
}
