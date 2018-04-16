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
    public partial class frm_rpt_data_barang : Form
    {
        public frm_rpt_data_barang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet data = new data_barang_dao().tampildatabarang();
            DataTable dt = new DataTable();
            dt = data.Tables[0];

            cr_data_barang obj_report = new cr_data_barang();
            obj_report.SetDataSource(dt);
            crv_data_barang.ReportSource = obj_report;
            crv_data_barang.Refresh();
        }
    }
}
