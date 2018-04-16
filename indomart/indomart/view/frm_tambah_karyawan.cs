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
    public partial class frm_tambah_karyawan : Form
    {

        public frm_tambah_karyawan()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpan_Click_1(object sender, EventArgs e)
        {
            
           
            karyawan k = new karyawan();

            k.nik = txt_nik.Text;
            k.nama = txt_nama.Text;
            k.jenis_kelamin = cmb_jenis_kelamin.Text;
            k.agama = cmb_agama.Text;
            k.pendidikan = cmb_pendidikan.Text;
            k.jabatan = cmb_jabatan.Text;
            k.ttl = txt_ttl.Text;
            k.tgl_lahir = dtp_tgl_lahir.Value.ToString("yyyy-MM-dd");
            k.pass = txt_pass.Text;

            if (k.nik == "")
            {
                MessageBox.Show("Nomor Induk Karyawan Kosong", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if ((k.nama == "") || (k.tgl_lahir == "") || (k.jabatan == "") || (k.jenis_kelamin == "") || (k.pass == "") || (k.pendidikan == "") || (k.ttl == ""))
            {
                MessageBox.Show("Teks Kosong, Isikan Kembali", "PESAN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (new karyawan_dao().insertdata(k))
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void frm_tambah_karyawan_Load(object sender, EventArgs e)
        {
            txt_nik.Text = "";
            txt_nama.Text = "";
            txt_pass.Text = "";
            txt_ttl.Text = "";
            cmb_agama.Text = "";
            cmb_jabatan.Text = "";
            cmb_jabatan.Text = "";
            cmb_pendidikan.Text = "";
        }


    }
    
}
