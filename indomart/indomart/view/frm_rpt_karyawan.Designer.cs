namespace indomart.view
{
    partial class frm_rpt_karyawan
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
            this.crv_karyawan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_karyawan
            // 
            this.crv_karyawan.ActiveViewIndex = -1;
            this.crv_karyawan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_karyawan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_karyawan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_karyawan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crv_karyawan.Location = new System.Drawing.Point(0, 0);
            this.crv_karyawan.Name = "crv_karyawan";
            this.crv_karyawan.Size = new System.Drawing.Size(881, 261);
            this.crv_karyawan.TabIndex = 0;
            this.crv_karyawan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_karyawan.ToolPanelWidth = 400;
            this.crv_karyawan.Load += new System.EventHandler(this.crv_karyawan_Load);
            // 
            // frm_rpt_karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 261);
            this.Controls.Add(this.crv_karyawan);
            this.Name = "frm_rpt_karyawan";
            this.Text = "frm_rpt_karyawan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_karyawan;
    }
}