using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using indomart.dao;
using indomart.model;
using System.Windows.Forms;

namespace indomart.view
{
    public partial class frm_data_barang : Form
    {
        public frm_data_barang()
        {
            InitializeComponent();
        }

        public void binding()
        {
            DataSet ds = new data_barang_dao().tampildatabarang();
            dgv_data_barang.DataSource = ds;
            dgv_data_barang.DataMember = "tb_barang";
            //dgv_data_barang.Dock = DockStyle.Fill;
            dgv_data_barang.BackgroundColor = Color.LightGray;
           

            DataGridViewColumn kolom0 = dgv_data_barang.Columns[0];
            kolom0.Width = 100;
            kolom0.HeaderText = "Kode Barang";
         
            DataGridViewColumn kolom1 = dgv_data_barang.Columns[1];
            kolom1.Width = 150;
            kolom1.HeaderText = "Nama Barang";

            DataGridViewColumn kolom2 = dgv_data_barang.Columns[2];
            kolom2.Width = 150;
            kolom2.HeaderText = "Jenis Barang";

            DataGridViewColumn kolom3 = dgv_data_barang.Columns[3];
            kolom3.Width = 130;
            kolom3.HeaderText = "Stock Barang.(pcs)";

            DataGridViewColumn kolom4 = dgv_data_barang.Columns[4];
            kolom4.Width = 120;
            kolom4.HeaderText = "Tanggal Masuk";

            DataGridViewColumn kolom5 = dgv_data_barang.Columns[5];
            kolom5.Width = 140;
            kolom5.HeaderText = "Tanggal Expire Date";

            DataGridViewColumn kolom6 = dgv_data_barang.Columns[6];
            kolom6.Width = 120;
            kolom6.HeaderText = "Nomor Rak";

            

            DataGridViewColumn kolom7= dgv_data_barang.Columns[7];
            kolom7.Width = 120;
            kolom7.HeaderText = "Harga.(Rp)";

            DataGridViewColumn kolom8 = dgv_data_barang.Columns[8];
            kolom8.Width = 130;
            kolom8.HeaderText = "Harga Akhir.(Rp)";

            DataGridViewColumn kolom9 = dgv_data_barang.Columns[9];
            kolom9.Width = 120;
            kolom9.HeaderText = "Harga Akhir.(Rp)";
        }

        private void frm_data_barang_Load(object sender, EventArgs e)
        {
            dtp_tanggal.Hide();
            binding();
            btn_tambah.Hide();
            eventclickgrid();
            btn_tambah.Hide();
        }

        private void dgv_data_barang_MouseClick(object sender, MouseEventArgs e)
        {
            eventclickgrid();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (txt_cari.Text ==  "")
            {
                MessageBox.Show("Masukan Kata Kunci Cari");
            }

            data_barang db = new data_barang();
            
            if (cb_cari.Text == "Kode Barang")
            {
                try
                {
                    db.kd_barang = txt_cari.Text;
                    DataSet ds = new data_barang_dao().cari_kode_barang(db);

                    dgv_data_barang.DataSource = ds;
                    dgv_data_barang.DataMember = "tb_barang";
                    eventclickgrid();
                    
                    
                }
                catch (DataException)
                {
                    MessageBox.Show("Data Tidak Di Temukan");
                    
                }

            }

            else if (cb_cari.Text == "Nama Barang")
            {
                try
                {
                    db.nama_barang = txt_cari.Text;
                    DataSet ds = new data_barang_dao().cari_nama_barang(db);

                    dgv_data_barang.DataSource = ds;
                    dgv_data_barang.DataMember = "tb_barang";
                    eventclickgrid();
                }

                catch
                {
                    MessageBox.Show("Data Tidak Di Temukan");
                }

            }
            else if (cb_cari.Text == "Jenis Barang")
            {
                try
                {
                    db.jenis_barang = txt_cari.Text;
                    DataSet ds = new data_barang_dao().cari_jenis_barang(db);

                    dgv_data_barang.DataSource = ds;
                    dgv_data_barang.DataMember = "tb_barang";
                }
                catch
                {
                    MessageBox.Show("Data Tidak Di Temukan");
                }
            }

        }

        public void eventclickgrid()
        {
            try
            {
                //txt_nik.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[0].Value);
                txt_kd_barang.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[0].Value);
                txt_nama_barang.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[1].Value);
                cb_jenis_barang.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[2].Value);
                txt_stock_brg.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[3].Value);
                dt_tgl_masuk.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[4].Value);
                dt_tgl_exp.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[5].Value);
                txt_no_rak.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[6].Value);
                txt_hrg.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[7].Value);
                txt_hrg_jual.Text = Convert.ToString(dgv_data_barang.CurrentRow.Cells[8].Value);

            }
            catch
            {

                MessageBox.Show("Data Barang Tidak Ada");
                
                
                btn_tambah.Hide();
                txt_kd_barang.Text = "";
                txt_nama_barang.Text = "";
                cb_jenis_barang.Text = "";
                txt_stock_brg.Text = "";
                txt_no_rak.Text = "";
                txt_hrg.Text = "";
                txt_hrg_jual.Text = "";
                MessageBox.Show("Kembali Ke Awal","Pesan",MessageBoxButtons.OK);
                binding();
            }

        }
        private void dgv_data_barang_KeyUp(object sender, KeyEventArgs e)
        {
            eventclickgrid();
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            btn_tambah.Hide();
            binding();
            eventclickgrid();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_kd_barang.Text == "")
            {
                MessageBox.Show("Kode Barang Kosong","Pesan",MessageBoxButtons.OK);
            }

            DialogResult dialogresult = MessageBox.Show("Apakah Anda Akan Menghapus ","Pesan",MessageBoxButtons.YesNo);

            if (dialogresult == DialogResult.Yes)
            {
                data_barang db = new data_barang();
                db.kd_barang = txt_kd_barang.Text;

                if (new data_barang_dao().hapus_data_barang(db))
                {
                    MessageBox.Show("Data Berhasil Di Hapus");
                    binding();
                }

                


            }


        }

        
       

        private void btn_ubah_Click(object sender, EventArgs e)
        {
           
                data_barang db = new data_barang();

                db.kd_barang = txt_kd_barang.Text;
                db.nama_barang = txt_nama_barang.Text;
                db.jenis_barang = cb_jenis_barang.Text;
                db.harga_jual = Convert.ToDouble( txt_hrg_jual.Text);
                
                if (new data_barang_dao().update_barang(db))
                {
                    MessageBox.Show("Data Berhasil Di Ubah");
                    binding();
                }

            

        }

        private void btn_cek_Click(object sender, EventArgs e)
        {
            btn_tambah.Show();
        
            if (rd_kosong.Checked)
            {
                
                DataSet ds = new data_barang_dao().tampildatabarang_kosong();
                dgv_data_barang.DataSource = ds;
                dgv_data_barang.DataMember = "db_indomart";
                eventclickgrid();
                DataGridViewColumn kolom0 = dgv_data_barang.Columns[0];
                kolom0.Width = 100;
                kolom0.HeaderText = "Kode Barang";

                DataGridViewColumn kolom1 = dgv_data_barang.Columns[1];
                kolom1.Width = 150;
                kolom1.HeaderText = "Nama Barang";

                DataGridViewColumn kolom2 = dgv_data_barang.Columns[2];
                kolom2.Width = 150;
                kolom2.HeaderText = "Jenis Barang";

                DataGridViewColumn kolom3 = dgv_data_barang.Columns[3];
                kolom3.Width = 120;
                kolom3.HeaderText = "Stock Barang";

                DataGridViewColumn kolom4 = dgv_data_barang.Columns[4];
                kolom4.Width = 120;
                kolom4.HeaderText = "Tanggal Masuk";

                DataGridViewColumn kolom5 = dgv_data_barang.Columns[5];
                kolom5.Width = 140;
                kolom5.HeaderText = "Tanggal Expire Date";

                DataGridViewColumn kolom6 = dgv_data_barang.Columns[6];
                kolom6.Width = 120;
                kolom6.HeaderText = "Nomor Rak";



                DataGridViewColumn kolom7 = dgv_data_barang.Columns[7];
                kolom7.Width = 120;
                kolom7.HeaderText = "Harga";

                DataGridViewColumn kolom8 = dgv_data_barang.Columns[8];
                kolom8.Width = 130;
                kolom8.HeaderText = "Harga Akhir";

                DataGridViewColumn kolom9 = dgv_data_barang.Columns[9];
                kolom9.Width = 130;
                kolom9.HeaderText = "Harga Akhir";
                
               
            }

            else if (rd_kadaluarsa.Checked)
            {
                btn_tambah.Hide();
                data_barang db = new data_barang();
                db.tgl_sekarang = dtp_tanggal.Value.ToString("yyyy-MM-dd");
                DataSet ds = new data_barang_dao().cari_barang_kadaluarsa(db);
                dgv_data_barang.DataSource = ds;
                dgv_data_barang.DataMember = "tb_barang";

                eventclickgrid();
                DataGridViewColumn kolom0 = dgv_data_barang.Columns[0];
                kolom0.Width = 100;
                kolom0.HeaderText = "Kode Barang";

                DataGridViewColumn kolom1 = dgv_data_barang.Columns[1];
                kolom1.Width = 150;
                kolom1.HeaderText = "Nama Barang";

                DataGridViewColumn kolom2 = dgv_data_barang.Columns[2];
                kolom2.Width = 150;
                kolom2.HeaderText = "Jenis Barang";

                DataGridViewColumn kolom3 = dgv_data_barang.Columns[3];
                kolom3.Width = 120;
                kolom3.HeaderText = "Stock Barang";

                DataGridViewColumn kolom4 = dgv_data_barang.Columns[4];
                kolom4.Width = 120;
                kolom4.HeaderText = "Tanggal Masuk";

                DataGridViewColumn kolom5 = dgv_data_barang.Columns[5];
                kolom5.Width = 140;
                kolom5.HeaderText = "Tanggal Expire Date";

                DataGridViewColumn kolom6 = dgv_data_barang.Columns[6];
                kolom6.Width = 120;
                kolom6.HeaderText = "Nomor Rak";



                DataGridViewColumn kolom7 = dgv_data_barang.Columns[7];
                kolom7.Width = 120;
                kolom7.HeaderText = "Harga";

                DataGridViewColumn kolom8 = dgv_data_barang.Columns[8];
                kolom8.Width = 130;
                kolom8.HeaderText = "Harga Akhir";

                DataGridViewColumn kolom9 = dgv_data_barang.Columns[9];
                kolom9.Width = 130;
                kolom9.HeaderText = "Harga Akhir";

            }

            else
            {
                btn_tambah.Hide();
                MessageBox.Show("Pilih Salah Satu Pilihan");
            }



        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            tambah_stock tbmh_stock = new tambah_stock(txt_kd_barang.Text , txt_nama_barang.Text , dt_tgl_masuk.Text ,  dt_tgl_exp.Text , txt_no_rak.Text , txt_hrg.Text , txt_hrg_jual.Text, cb_jenis_barang.Text );
            tbmh_stock.ShowDialog();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        

       
       

        

        

       

        
    }
}
