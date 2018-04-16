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
    public partial class frm_tmbh_gaji : Form
    {
        public frm_tmbh_gaji()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                gaji g = new gaji();
                g.nik = cb_nik.Text;
                g.gajipokok = Convert.ToString(txt_gajipokok.Text);
                g.tunjangan = Convert.ToString(txt_tunjangan.Text);

                if (new gaji_dao().insertdata(g))
                {
                    this.DialogResult = DialogResult.OK;

                }
            }

            catch
            {
                MessageBox.Show("Nik Sudah Ada");
            }

        }

        public void ambil_nik()
        {
            DataSet data = new karyawan_dao().tampil_karyawan();
            cb_nik.DataSource = data.Tables[0];
            cb_nik.DisplayMember = "Nik";
            
        }

        private void frm_tmbh_gaji_Load(object sender, EventArgs e)
        {

            ambil_nik();
        }


    }
}
