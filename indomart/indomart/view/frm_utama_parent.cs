using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace indomart.view
{
    public partial class frm_utama_parent : Form
    {
        string kd_nik;
        public frm_utama_parent(string data)

        {
            this.kd_nik = data;
            InitializeComponent();
        }

        private void frm_utama_parent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frm_utama_child frm_child = new frm_utama_child();
            frm_child.WindowState = FormWindowState.Maximized;
            frm_child.ControlBox = false;
            frm_child.MdiParent = this;
            frm_child.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Data Barang";
            frm_data_barang frm_data_brg = new frm_data_barang();
            
            frm_data_brg.WindowState = FormWindowState.Maximized;
            frm_data_brg.ControlBox = false;
            frm_data_brg.MdiParent = this;
            frm_data_brg.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            tambah_barang_masuk obj_tmbh_brg = new tambah_barang_masuk();
            obj_tmbh_brg.ShowDialog();
            
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tabel Transaksi Penjualan";
            frm_tabel_transaksi_penjualan obj_tb_transaksi = new frm_tabel_transaksi_penjualan();
           
            obj_tb_transaksi.WindowState = FormWindowState.Maximized;
            obj_tb_transaksi.ControlBox = false;
            obj_tb_transaksi.MdiParent = this;
            obj_tb_transaksi.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tabel Transaksi Penjualan";
            frm_gaji gaji = new  frm_gaji();
            gaji.WindowState = FormWindowState.Maximized;
            gaji.ControlBox = false;
            gaji.MdiParent = this;
            gaji.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Data Karyawan";
            frm_karyawan kry = new frm_karyawan();
            kry.WindowState = FormWindowState.Maximized;
            kry.ControlBox = false;
            kry.MdiParent = this;
            kry.Show();
            
        }

        private void listingDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_data_barang rpt_data = new frm_rpt_data_barang();
            rpt_data.ShowDialog();
        }

        private void laporanPenggajianKeryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_penggajian rpt_gaji = new frm_rpt_penggajian();
            rpt_gaji.ShowDialog();
        }

        private void laporanDataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_karyawan rpt_kar = new frm_rpt_karyawan();
            rpt_kar.ShowDialog();
        }

        private void laporanTransaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_transaksi_penjualan rpt_trans = new frm_rpt_transaksi_penjualan();
            rpt_trans.ShowDialog();
        }

    }
}
