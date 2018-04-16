namespace indomart.view
{
    partial class frm_rpt_transaksi_penjualan
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
            this.crv_laporan_transaksi_penjualan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_laporan_transaksi_penjualan
            // 
            this.crv_laporan_transaksi_penjualan.ActiveViewIndex = -1;
            this.crv_laporan_transaksi_penjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_laporan_transaksi_penjualan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_laporan_transaksi_penjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_laporan_transaksi_penjualan.Location = new System.Drawing.Point(0, 0);
            this.crv_laporan_transaksi_penjualan.Name = "crv_laporan_transaksi_penjualan";
            this.crv_laporan_transaksi_penjualan.Size = new System.Drawing.Size(1113, 472);
            this.crv_laporan_transaksi_penjualan.TabIndex = 0;
            this.crv_laporan_transaksi_penjualan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_laporan_transaksi_penjualan.Load += new System.EventHandler(this.crv_laporan_transaksi_penjualan_Load);
            // 
            // frm_rpt_transaksi_penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 472);
            this.Controls.Add(this.crv_laporan_transaksi_penjualan);
            this.Name = "frm_rpt_transaksi_penjualan";
            this.Text = "From Transaksi Penjualan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_laporan_transaksi_penjualan;
    }
}