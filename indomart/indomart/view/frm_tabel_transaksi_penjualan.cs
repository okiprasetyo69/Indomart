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
    public partial class frm_tabel_transaksi_penjualan : Form
    {
        public frm_tabel_transaksi_penjualan()
        {
            InitializeComponent();
        }

        public void binding()
        {
            DataSet ds = new transaksi_barang_keluar_dao().tampil_transaksi_penjualan();
            dgv_data_transaksi.DataSource = ds;
            dgv_data_transaksi.DataMember = "tb_transaksi_keluar";
            DataGridViewColumn kolom0 = dgv_data_transaksi.Columns[0];
            kolom0.Width = 140;
            kolom0.HeaderText = "Kode Transaksi";

            DataGridViewColumn kolom1 = dgv_data_transaksi.Columns[1];
            kolom1.Width = 170;
            kolom1.HeaderText = "Nomor Induk Karyawan";

            DataGridViewColumn kolom2 = dgv_data_transaksi.Columns[2];
            kolom2.Width = 180;
            kolom2.HeaderText = "Nama Kasir";

            DataGridViewColumn kolom3 = dgv_data_transaksi.Columns[3];
            kolom3.Width = 150;
            kolom3.HeaderText = "Tanggal Transaksi";

            DataGridViewColumn kolom4 = dgv_data_transaksi.Columns[4];
            kolom4.Width = 160;
            kolom4.HeaderText = "Total harga.(Rp)";

            dgv_tabel_keluar.Hide();
            dgv_data_transaksi.Show();
            btn_transaksi.Hide();
            gb_data.Show();


            //DataGridViewColumn kolom0 = dgv_data_barang.Columns[0];
            //kolom0.Width = 100;
            //kolom0.HeaderText = "Kode Barang";

            


            



        }

        private void frm_tabel_transaksi_penjualan_Load(object sender, EventArgs e)
        {
            binding();
            eventgridclick();
            ambil_kd_transaksi();
        }

        public void ambil_kd_transaksi()
        {
            //cb_nim_mhs.DataSource = ds.Tables[0];
            //cb_nim_mhs.DisplayMember = "nama";
            //cb_nim_mhs.ValueMember = "nim";
            DataSet ds = new transaksi_barang_keluar_dao().tampil_transaksi_penjualan();
            cb_kd_transaksi.DataSource = ds.Tables[0];
            cb_kd_transaksi.DisplayMember = "kd_trans";
        }

        public void eventgridclick()
        {
            try
            {
                txt_kd_trans.Text = Convert.ToString(dgv_data_transaksi.CurrentRow.Cells[0].Value.ToString());
                txt_kd_nik.Text = Convert.ToString(dgv_data_transaksi.CurrentRow.Cells[1].Value.ToString());
                txt_nama_kasir.Text = Convert.ToString(dgv_data_transaksi.CurrentRow.Cells[2].Value.ToString());
                dt_tgl.Text = Convert.ToString(dgv_data_transaksi.CurrentRow.Cells[3].Value.ToString());
                txt_total.Text = Convert.ToString(dgv_data_transaksi.CurrentRow.Cells[4].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Tidak Ada Data Transaksi");
            }

        }

        private void dgv_data_transaksi_MouseClick(object sender, MouseEventArgs e)
        {
            eventgridclick();
        }


        private void dgv_data_transaksi_KeyUp(object sender, KeyEventArgs e)
        {
            eventgridclick();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            transaksi_penjualan tp = new transaksi_penjualan();
            tp.kd_transaksi = cb_kd_transaksi.Text;
            dgv_data_transaksi.Hide();
            dgv_tabel_keluar.Show();
           DataSet dt = new transaksi_barang_keluar_dao().details_transaksi_penjualan(tp);
           dgv_tabel_keluar.DataSource = dt;
           dgv_tabel_keluar.DataMember = "tb_keluar";

           DataGridViewColumn  kolom0 = dgv_tabel_keluar.Columns[0];
           kolom0.Width = 150;
           kolom0.HeaderText = "Kode Transaksi";

           DataGridViewColumn  kolom1 = dgv_tabel_keluar.Columns[1];
           kolom1.Width = 150;
           kolom1.HeaderText = "Kode Barang";

           DataGridViewColumn kolom2 = dgv_tabel_keluar.Columns[2];
           kolom2.Width = 160;
           kolom2.HeaderText = "Tanggal Transaksi";

           DataGridViewColumn kolom3 = dgv_tabel_keluar.Columns[3];
           kolom3.Width = 160;
           kolom3.HeaderText = "Jumlah Beli";

           DataGridViewColumn kolom4 = dgv_tabel_keluar.Columns[4];
           kolom4.Width = 160;
           kolom4.HeaderText = "Total Harga.(Rp)";



           btn_transaksi.Show();
           gb_data.Hide();



        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            binding();
            dgv_tabel_keluar.Hide();
            dgv_data_transaksi.Show();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            transaksi_penjualan tp = new transaksi_penjualan();
            tp.kd_transaksi = txt_kd_trans.Text;

            if (txt_kd_trans.Text == "")
            {
                MessageBox.Show("Kode Transaksi Kosong");
            }
            

            DialogResult dialogresult = MessageBox.Show("Apakah Anda Ingin Menghapus Data ","Pesan",MessageBoxButtons.YesNo);

            if (dialogresult == DialogResult.Yes)
            {
                if (new transaksi_barang_keluar_dao().hapus_transaksi_penjualan(tp))
                {
                    MessageBox.Show("Data Berhasil Di Hapus","pesan");
                }
                binding();
                ambil_kd_transaksi();
            }


        }


        

        

       

       


    }
}
