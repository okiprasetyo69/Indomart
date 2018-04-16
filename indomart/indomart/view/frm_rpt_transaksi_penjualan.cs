using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using indomart.dao;
using indomart.report;

namespace indomart.view
{
    public partial class frm_rpt_transaksi_penjualan : Form
    {
        public frm_rpt_transaksi_penjualan()
        {
            InitializeComponent();
        }

        private void crv_laporan_transaksi_penjualan_Load(object sender, EventArgs e)
        {
            DataSet data = new transaksi_barang_keluar_dao().tampil_transaksi_penjualan();
            DataTable dt = new DataTable();

            dt = data.Tables[0];
            cr_laporan_transansaksi_penjualan rpt_transaksi = new cr_laporan_transansaksi_penjualan();

            rpt_transaksi.SetDataSource(dt);
            crv_laporan_transaksi_penjualan.ReportSource = rpt_transaksi;
            crv_laporan_transaksi_penjualan.Refresh();
        }
    }
}
