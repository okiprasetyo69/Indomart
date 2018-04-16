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
    public partial class frm_login_karyawan : Form
    {
        public frm_login_karyawan()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((txt_nik.Text == "") || (txt_pass.Text == ""))
            {
                MessageBox.Show(" User Dan Password Tidak Boleh Kosong");
            }

            login_karyawan obj_login = new login_karyawan();
            obj_login.nik = txt_nik.Text;
            obj_login.pass = txt_pass.Text;

            if (new login_dao().login_karyawan(obj_login) == "sukses")
            {
                MessageBox.Show("Login Berhasil");

                if (new status_karyawan().status(obj_login) == "kepala")
                {
                    frm_utama_parent frm_utama = new frm_utama_parent(txt_nik.Text);
                    frm_utama.Show();
                }

                else if (new status_karyawan().status(obj_login) == "ass_kepala")
                {
                    frm_utama_parent frm_utama = new frm_utama_parent(txt_nik.Text);
                    frm_utama.Show();
                }

                

                else if (new status_karyawan().status(obj_login) == "kasir")
                {
                   // frm_kasir kasir = new frm_kasir(txt_nik.Text);
                    //karyawan kry = new karyawan();

                    frm_utama_parent_kasir frm_utama_kasir = new frm_utama_parent_kasir(txt_nik.Text);
                    frm_utama_kasir.Show();
                    

                }


                
            }

            else
            {
                MessageBox.Show("Login Gagal ");
            }




            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_nik.Text = "";
            txt_pass.Text = "";
        }

        

        
    }
}
