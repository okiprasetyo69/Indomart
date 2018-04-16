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
using MySql.Data.MySqlClient;
namespace indomart.view
{
    public partial class tambah_barang_masuk : Form
    {
        public tambah_barang_masuk()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (txt_kd_barang.Text == "")
            {
                MessageBox.Show("Kode Barang Tidak Boleh Kosong");
            }

            else
            {
                data_barang db = new data_barang();

                db.kd_barang = txt_kd_barang.Text;

                DataSet ds = new data_barang_dao().cari_kode_barang(db);

                //txtFname.Text = dsView.Tables[0].Rows[3][0].ToString();

                try
                {
                    btn_simpan.Hide();
                    btn_update.Show();
                    db.kd_barang = txt_kd_barang.Text;
                    txt_nama_barang.Text = ds.Tables[0].Rows[0][1].ToString();
                    txt_harga.Text = ds.Tables[0].Rows[0][8].ToString();
                    dt_tanggal_masuk.Text = ds.Tables[0].Rows[0][4].ToString();
                    dt_exp.Text = ds.Tables[0].Rows[0][5].ToString();
                    txt_no_rak.Text = ds.Tables[0].Rows[0][6].ToString();
                    txt_harga_jual.Text = ds.Tables[0].Rows[0][9].ToString();
                    jenis_barang.Text = ds.Tables[0].Rows[0][2].ToString();
                    stock.Text = ds.Tables[0].Rows[0][3].ToString();



                }

                catch (Exception)
                {
                    btn_simpan.Show();
                    btn_update.Hide();
                    MessageBox.Show("Data Tidak Di Temukan ");

                }


            }
        }
        private void simpan_Click(object sender, EventArgs e)
        {
            if ((txt_no_rak.Text == "") || (txt_nama_barang.Text == "") || (txt_jumlah.Text == "") || (txt_harga_jual.Text == "") || (txt_harga.Text == ""))
            {
                MessageBox.Show("Data Kurang Lengkap");
            }
            else
            {
                data_barang db = new data_barang();

                db.kd_barang = txt_kd_barang.Text;
                db.nama_barang = txt_nama_barang.Text;
                db.jenis_barang = jenis_barang.Text;
                db.tgl_masuk = dt_tanggal_masuk.Value.ToString("yyyy-MM-dd");
                db.tgl_exp = dt_exp.Value.ToString("yyyy-MM-dd");
                db.no_rak = txt_no_rak.Text;
                db.harga = Convert.ToDouble(txt_harga.Text);
                db.harga_jual = Convert.ToDouble(txt_harga_jual.Text);
                db.jumlah_masuk = Convert.ToInt16(txt_jumlah.Text);
                string tgl_masuk = dt_tanggal_masuk.Value.ToString("yyyy-MM-dd");
                string tgl_exp = dt_exp.Value.ToString("yyyy-MM-dd");


                if (tgl_masuk == tgl_exp)
                {
                    MessageBox.Show("Barang Sudah Kadaluarsa");
                }



                else if (new data_barang_dao().tambah_barang(db))
                {
                    MessageBox.Show("Input Barang Sukses");
                    DialogResult dialogresult = MessageBox.Show("Apakah Anda Akan Menambahkan Data Lagi ? ", "Pesan", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        txt_kd_barang.Text = "";
                        txt_kd_barang.Text = "";
                        txt_nama_barang.Text = "";
                        txt_jumlah.Text = "";
                        txt_harga_jual.Text = "";
                        txt_harga.Text = "";

                        dt_exp.Text = "";
                        txt_no_rak.Text = "";
                        jenis_barang.Text = "";

                    }
                    else
                    {
                        this.Close();
                    }

                }


            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
                 data_barang db = new data_barang();
                 db.kd_barang = txt_kd_barang.Text;
                 db._stock = Convert.ToInt16(stock.Text);
                 db.jumlah_masuk = Convert.ToInt16(txt_jumlah.Text);

                 if (new data_barang_dao().update_data(db))
                 {
                     MessageBox.Show("Update  Data Barang Sukses");
                 }

                

        }

            
               

        private void tambah_barang_masuk_Load(object sender, EventArgs e)
        {
            btn_update.Hide();
            btn_simpan.Hide();
            
            stock.Hide();
        }

        private void tambah_barang_masuk_Load_1(object sender, EventArgs e)
        {
            btn_update.Hide();
            btn_simpan.Hide();

            stock.Hide();
        }

        
    }
}
