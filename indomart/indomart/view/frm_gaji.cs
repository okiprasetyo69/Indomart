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
    public partial class frm_gaji : Form
    {
        public frm_gaji()
        {
            InitializeComponent();
        }
        public void binding()
        {
            DataSet data = new gaji_dao().tampilgaji();
            dgv_gaji.DataSource = data;
            dgv_gaji.DataMember = "t_penggajian";

            DataGridViewColumn kolom0 = dgv_gaji.Columns[0];
            kolom0.Width = 180;
            kolom0.HeaderText = "NIK";

            DataGridViewColumn kolom1 = dgv_gaji.Columns[1];
            kolom1.Width = 230;
            kolom1.HeaderText = "Nama Karyawan";

            DataGridViewColumn kolom2 = dgv_gaji.Columns[2];
            kolom2.Width = 170;
            kolom2.HeaderText = "Jabatan";

            DataGridViewColumn kolom3 = dgv_gaji.Columns[3];
            kolom3.Width = 180;
            kolom3.HeaderText = "Gaji Pokok.(Rp)";

            DataGridViewColumn kolom4 = dgv_gaji.Columns[4];
            kolom4.Width = 210;
            kolom4.HeaderText = "Tunjangan.(Rp)";
        }

        private void frm_gaji_Load(object sender, EventArgs e)
        {
            
            binding();
            eventclickgrid();
            //eventclickgrid();
            txt_nik.Text = "";
            txt_tunjangan.Text = "";
            txt_gajipokok.Text = "";
        }

        public void eventclickgrid()
        {
            txt_nik.Text = Convert.ToString(dgv_gaji.CurrentRow.Cells[0].Value);
            txt_nama.Text = Convert.ToString(dgv_gaji.CurrentRow.Cells[1].Value);
            cb_jabatan.Text = Convert.ToString(dgv_gaji.CurrentRow.Cells[2].Value);
            txt_gajipokok.Text = Convert.ToString(dgv_gaji.CurrentRow.Cells[3].Value);
            txt_tunjangan.Text = Convert.ToString(dgv_gaji.CurrentRow.Cells[4].Value);
        }

        private void dgv_gaji_MouseClick(object sender, MouseEventArgs e)
        {
            eventclickgrid();
        }

        private void dgv_gaji_KeyUp(object sender, KeyEventArgs e)
        {
            eventclickgrid();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            frm_tmbh_gaji frm_tmbh = new frm_tmbh_gaji();

            if (frm_tmbh.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data berhasil ditambahkan", "pesan");
                binding();
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            gaji g = new gaji();
            g.nik = txt_nik.Text;
            g.gajipokok = txt_gajipokok.Text;
            g.tunjangan = txt_tunjangan.Text;

            if (new gaji_dao().updatedata(g))
            {
                MessageBox.Show("Data Berhasil di ubah");
                binding();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_nik.Text == "")
            {
                MessageBox.Show("NIK Kosong", "pesan", MessageBoxButtons.OK);
                return;
            }

            DialogResult dialodResult = MessageBox.Show("Apakah data akan di hapus?",
                                                        "pesan",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Error);
            if (dialodResult == DialogResult.Yes)
            {
                gaji g = new gaji();
                g.nik = txt_nik.Text;
                if (new gaji_dao().hapusdata(g))
                {
                    MessageBox.Show("Data berhasil di Hapus");
                    binding();
                }
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (txt_cari.Text == "")
            {
                MessageBox.Show("Kata Kunci Tidak Boleh Kosong");
            }

            gaji g = new gaji();

            if (cb_cari.Text == "NIK")
            {
                try
                {
                    g.nik = txt_cari.Text;
                    DataSet ds = new gaji_dao().caridata_nik(g);

                    dgv_gaji.DataSource = ds;
                    dgv_gaji.DataMember = "db_indomart";
                    DataGridViewColumn kolom0 = dgv_gaji.Columns[0];
                    kolom0.Width = 180;
                    kolom0.HeaderText = "NIK";

                    DataGridViewColumn kolom1 = dgv_gaji.Columns[1];
                    kolom1.Width = 230;
                    kolom1.HeaderText = "Nama Karyawan";

                    DataGridViewColumn kolom2 = dgv_gaji.Columns[2];
                    kolom2.Width = 170;
                    kolom2.HeaderText = "Jabatan";

                    DataGridViewColumn kolom3 = dgv_gaji.Columns[3];
                    kolom3.Width = 180;
                    kolom3.HeaderText = "Gaji Pokok.(Rp)";

                    DataGridViewColumn kolom4 = dgv_gaji.Columns[4];
                    kolom4.Width = 210;
                    kolom4.HeaderText = "Tunjangan.(Rp)";


                }
                catch
                {
                    MessageBox.Show("Tidak Ketemu");
                }
            }
             else if (cb_cari.Text == "Gaji Pokok")
             {
                 g.gajipokok = txt_cari.Text;
                 DataSet ds = new gaji_dao().caridata_gajipokok(g);

                 dgv_gaji.DataSource = ds;
                 dgv_gaji.DataMember = "db_indomart";

                 DataGridViewColumn kolom0 = dgv_gaji.Columns[0];
                 kolom0.Width = 180;
                 kolom0.HeaderText = "NIK";

                 DataGridViewColumn kolom1 = dgv_gaji.Columns[1];
                 kolom1.Width = 230;
                 kolom1.HeaderText = "Nama Karyawan";

                 DataGridViewColumn kolom2 = dgv_gaji.Columns[2];
                 kolom2.Width = 170;
                 kolom2.HeaderText = "Jabatan";

                 DataGridViewColumn kolom3 = dgv_gaji.Columns[3];
                 kolom3.Width = 180;
                 kolom3.HeaderText = "Gaji Pokok.(Rp)";

                 DataGridViewColumn kolom4 = dgv_gaji.Columns[4];
                 kolom4.Width = 210;
                 kolom4.HeaderText = "Tunjangan.(Rp)";
             }
             else if (cb_cari.Text == "Tunjangan")
             {
                 g.tunjangan = txt_cari.Text;
                 DataSet ds = new gaji_dao().caridata_tunjangan(g);

                 dgv_gaji.DataSource = ds;
                 dgv_gaji.DataMember = "db_indomart";

                 DataGridViewColumn kolom0 = dgv_gaji.Columns[0];
                 kolom0.Width = 180;
                 kolom0.HeaderText = "NIK";

                 DataGridViewColumn kolom1 = dgv_gaji.Columns[1];
                 kolom1.Width = 230;
                 kolom1.HeaderText = "Nama Karyawan";

                 DataGridViewColumn kolom2 = dgv_gaji.Columns[2];
                 kolom2.Width = 170;
                 kolom2.HeaderText = "Jabatan";

                 DataGridViewColumn kolom3 = dgv_gaji.Columns[3];
                 kolom3.Width = 180;
                 kolom3.HeaderText = "Gaji Pokok.(Rp)";

                 DataGridViewColumn kolom4 = dgv_gaji.Columns[4];
                 kolom4.Width = 210;
                 kolom4.HeaderText = "Tunjangan.(Rp)";
             }

            
        }

        private void btn_tambah_Click_1(object sender, EventArgs e)
        {
            
            if ((txt_gajipokok.Text == "") || (txt_tunjangan.Text == ""))
            {
                MessageBox.Show("Data Harus Terisi Semua ");
            }

            frm_tmbh_gaji tmbh_gj = new frm_tmbh_gaji();
            
             if (tmbh_gj.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Input Data Barang Sukses");
                binding();

            }

             DialogResult dialogresult = MessageBox.Show("Apakah Anda Akan Menambah Data Lagi", "Pesan", MessageBoxButtons.YesNo);

             if (dialogresult == DialogResult.Yes)
             {
                 if (tmbh_gj.ShowDialog() == DialogResult.OK)
                 {
                     MessageBox.Show("Input Data Barang Sukses");
                     binding();

                 }
             }


            
        }

        private void btn_ubah_Click_1(object sender, EventArgs e)
        {
            gaji obj_gj = new gaji();
            obj_gj.nik = txt_nik.Text;
            obj_gj.gajipokok = Convert.ToString(txt_gajipokok.Text);
            obj_gj.tunjangan = Convert.ToString(txt_tunjangan.Text);

            if (new gaji_dao().updatedata(obj_gj))
            {
                MessageBox.Show("Ubah Data Berhasil ");
                binding();
            }

        }

        private void btn_hapus_Click_1(object sender, EventArgs e)
        {
            gaji g = new gaji();
            g.nik = txt_nik.Text;
            if (txt_nik.Text == "")
            {
                MessageBox.Show("Nik Tidak Boleh Kosong");
            }

            DialogResult dialogresult = MessageBox.Show("Apakah Anda Akan Menghapus Data","Pesan",MessageBoxButtons.YesNo);

            if (dialogresult == DialogResult.Yes)
            {
                if (new gaji_dao().hapusdata(g))
                {
                    MessageBox.Show("Hapus Data Berhasil");
                    binding();
                }


            }


        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            binding();
        }

        

        

       
    }
}
