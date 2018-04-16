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
    public partial class frm_rpt_karyawan : Form
    {
        public frm_rpt_karyawan()
        {
            InitializeComponent();
        }

        private void crv_karyawan_Load(object sender, EventArgs e)
        {
            DataSet data = new karyawan_dao().tampil_karyawan();      

            DataTable dt = new DataTable();
            dt = data.Tables[0];

            cr_karyawan obj_rpt = new cr_karyawan();
            obj_rpt.SetDataSource(dt);
            crv_karyawan.ReportSource = obj_rpt;
            crv_karyawan.Refresh();

        }
    }
}
