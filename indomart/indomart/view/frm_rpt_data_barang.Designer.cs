namespace indomart.view
{
    partial class frm_rpt_data_barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv_data_barang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_data_barang
            // 
            this.crv_data_barang.ActiveViewIndex = -1;
            this.crv_data_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_data_barang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_data_barang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_data_barang.Location = new System.Drawing.Point(0, 0);
            this.crv_data_barang.Name = "crv_data_barang";
            this.crv_data_barang.Size = new System.Drawing.Size(1129, 510);
            this.crv_data_barang.TabIndex = 0;
            this.crv_data_barang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_data_barang.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_rpt_data_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 510);
            this.Controls.Add(this.crv_data_barang);
            this.Name = "frm_rpt_data_barang";
            this.Text = "Laporan Data Barang";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_data_barang;
    }
}