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
    public partial class frm_utama_parent_kasir : Form
    {
        string data_nik;
        public frm_utama_parent_kasir(String data)
        {
            this.data_nik = data;
            InitializeComponent();
        }

        private void frm_utama_parent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frm_utama_child frm_utama_child = new frm_utama_child();

            frm_utama_child.WindowState = FormWindowState.Maximized;
            frm_utama_child.ControlBox = false;
            frm_utama_child.MdiParent = this;
            frm_utama_child.Show();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Program Kasir";
           
            frm_kasir kasir = new frm_kasir( data_nik);
            
            kasir.WindowState = FormWindowState.Maximized;
            kasir.ControlBox = false;
            kasir.MdiParent = this;
            kasir.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Data Transaksi Penjualan";
            frm_tabel_transaksi_penjualan obj_trans = new frm_tabel_transaksi_penjualan();
            obj_trans.WindowState = FormWindowState.Maximized;
            obj_trans.ControlBox = false;
            obj_trans.MdiParent = this;
            obj_trans.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Data Barang";

            frm_data_barang obj_data_barang = new frm_data_barang();

            obj_data_barang.WindowState = FormWindowState.Maximized;
            obj_data_barang.ControlBox = false;
            obj_data_barang.MdiParent = this;
            obj_data_barang.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frm_rpt_transaksi_penjualan trans = new frm_rpt_transaksi_penjualan();
            trans.ShowDialog();
        }

        
    }
}
