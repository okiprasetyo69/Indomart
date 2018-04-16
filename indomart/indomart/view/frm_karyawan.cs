using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using indomart.dao;
using indomart.view;
using indomart.model;

namespace indomart.view
{
    public partial class frm_karyawan : Form
    {
        
        public frm_karyawan()
        {
            InitializeComponent();
        }

        public void binding()
        {
            DataSet data = new karyawan_dao().tampil_karyawan();

            dgv_karyawan.DataSource = data;
            dgv_karyawan.DataMember = "t_karyawan";

            DataGridViewColumn kolom1 = dgv_karyawan.Columns[0];
            kolom1.Width = 120;
            kolom1.HeaderText = "NIK";

            DataGridViewColumn kolom2 = dgv_karyawan.Columns[1];
            kolom2.Width = 170;
            kolom2.HeaderText = "Nama";

            DataGridViewColumn kolom3 = dgv_karyawan.Columns[2];
            kolom3.Width = 190;
            kolom3.HeaderText = "Jenis Kelamin ";

            DataGridViewColumn kolom4 = dgv_karyawan.Columns[3];
            kolom4.Width = 160;
            kolom4.HeaderText = "Tempat Lahir ";


            DataGridViewColumn kolom5 = dgv_karyawan.Columns[4];
            kolom5.Width = 170;
            kolom5.HeaderText = "Tanggal Lahir";

            DataGridViewColumn kolom6 = dgv_karyawan.Columns[5];
            kolom6.Width = 150;
            kolom6.HeaderText = "Agama";

            DataGridViewColumn kolom7 = dgv_karyawan.Columns[6];
            kolom7.Width = 130;
            kolom7.HeaderText = "Pendidikan";

            DataGridViewColumn kolom8 = dgv_karyawan.Columns[7];
            kolom8.Width = 130;
            kolom8.HeaderText = "Jabatan";

        }


        private void frm_karyawan_Load(object sender, EventArgs e)
        {
            binding();
            eventclickgrid();
        }



        public void eventclickgrid()
        {
            txt_nik.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[0].Value);
            txt_nama.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[1].Value);
            cmb_jenis_kelamin.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[2].Value);
            txt_ttl.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[3].Value);
            dtp_tanggal_lahir.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[4].Value);
            cmb_agama.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[5].Value);
            cmb_pendidikan.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[6].Value);
            cmb_jabatan.Text = Convert.ToString(dgv_karyawan.CurrentRow.Cells[7].Value);
           
        }

        private void dgv_karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eventclickgrid();
        }

        private void dgv_karyawan_KeyUp(object sender, KeyEventArgs e)
        {
            eventclickgrid();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            frm_tambah_karyawan frm_tmbh_kry = new frm_tambah_karyawan();

            if (frm_tmbh_kry.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data Berhasil Ditambah","PESAN");
                binding();
            }

            DialogResult dialogresult = MessageBox.Show("Apakah Anda Akan Menambah Data Lagi ? ","Pesan",MessageBoxButtons.YesNo);

            if (dialogresult == DialogResult.Yes)
            {
                if (frm_tmbh_kry.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Data Berhasil Ditambah", "PESAN");
                    binding();
                }
            }

        }

       
   

       private void btn_ubah_Click(object sender, EventArgs e)
        {
            karyawan kry = new karyawan();

            kry.nik = txt_nik.Text;
            kry.nama = txt_nama.Text;
            kry.jenis_kelamin = cmb_jenis_kelamin.Text;
            kry.ttl = txt_ttl.Text;
            kry.tgl_lahir = dtp_tanggal_lahir.Value.ToString("yyyy-MM-dd");
            kry.agama = cmb_agama.Text;
            kry.pendidikan = cmb_pendidikan.Text;
            kry.jabatan = cmb_jabatan.Text;

           if(new karyawan_dao().updatedata(kry))
           {
               MessageBox.Show("Data Berhasil Dirubah");
               binding();
           }
        }

       private void btn_hapus_Click_1(object sender, EventArgs e)
       {
           if (txt_nik.Text == "")
           {
               MessageBox.Show("NIK Kosong", "PESAN", MessageBoxButtons.OK);
               return;
           }

           DialogResult dialogresult = MessageBox.Show("Apakah Data Akan Dihapus ?", "PESAN", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

           if (dialogresult == DialogResult.Yes)
           {
               karyawan k = new karyawan();

               k.nik = txt_nik.Text;
               if (new karyawan_dao().hapusdata(k))
               {
                   MessageBox.Show("Data Berhasil Dihapus");
                   binding();
               }
           }

       }

       private void btn_cari_Click(object sender, EventArgs e)
       {
           karyawan k = new karyawan();

           if (cmb_cari.Text == "NIK")
           {
               try
               {
                   k.nik = txt_cari.Text;
                   DataSet ds = new karyawan_dao().carikode(k);

                   dgv_karyawan.DataSource = ds;
                   dgv_karyawan.DataMember = "db_indomart";
               }
               catch
               {
                   MessageBox.Show("Not Found");
               }
           }
           
           else if (cmb_cari.Text == "Nama")
           {
               k.nama = txt_cari.Text;
               DataSet ds = new karyawan_dao().carinama(k);

               dgv_karyawan.DataSource = ds;
               dgv_karyawan.DataMember = "db_indomart";
           }

           else if (cmb_cari.Text == "Jabatan")
           {
               k.jabatan = txt_cari.Text;
               DataSet ds = new karyawan_dao().carijabatan(k);

               dgv_karyawan.DataSource = ds;
               dgv_karyawan.DataMember = "db_indomart";
           }
       }

       private void btn_tampil_Click(object sender, EventArgs e)
       {
           binding();
       }

        
       

    }
}
