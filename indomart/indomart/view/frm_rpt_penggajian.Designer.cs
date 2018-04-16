namespace indomart.view
{
    partial class frm_rpt_penggajian
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
            this.crv_penggajian = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_penggajian
            // 
            this.crv_penggajian.ActiveViewIndex = -1;
            this.crv_penggajian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_penggajian.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_penggajian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_penggajian.Location = new System.Drawing.Point(0, 0);
            this.crv_penggajian.Name = "crv_penggajian";
            this.crv_penggajian.Size = new System.Drawing.Size(1129, 510);
            this.crv_penggajian.TabIndex = 0;
            this.crv_penggajian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_penggajian.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_rpt_penggajian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 510);
            this.Controls.Add(this.crv_penggajian);
            this.Name = "frm_rpt_penggajian";
            this.Text = "Form Penggajian Karyawan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_penggajian;
    }
}