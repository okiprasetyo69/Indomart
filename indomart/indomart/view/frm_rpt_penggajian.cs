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
    public partial class frm_rpt_penggajian : Form
    {
        public frm_rpt_penggajian()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet data = new gaji_dao().tampilgaji();
            DataTable dt = new DataTable();
            dt = data.Tables[0];
            cr_penggajian obj_rpt_gaji = new cr_penggajian();
            obj_rpt_gaji.SetDataSource(dt);
            crv_penggajian.ReportSource = obj_rpt_gaji;
            crv_penggajian.Refresh();


        }
    }
}
