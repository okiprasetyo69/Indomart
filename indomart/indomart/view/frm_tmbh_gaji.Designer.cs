namespace indomart.view
{
    partial class frm_tmbh_gaji
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gajipokok = new System.Windows.Forms.TextBox();
            this.txt_tunjangan = new System.Windows.Forms.TextBox();
            this.cb_nik = new System.Windows.Forms.ComboBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "TAMBAH DATA PENGGAJIAN KARYAWAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gaji Pokok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tunjangan";
            // 
            // txt_gajipokok
            // 
            this.txt_gajipokok.Location = new System.Drawing.Point(139, 132);
            this.txt_gajipokok.Name = "txt_gajipokok";
            this.txt_gajipokok.Size = new System.Drawing.Size(120, 20);
            this.txt_gajipokok.TabIndex = 7;
            // 
            // txt_tunjangan
            // 
            this.txt_tunjangan.Location = new System.Drawing.Point(139, 159);
            this.txt_tunjangan.Name = "txt_tunjangan";
            this.txt_tunjangan.Size = new System.Drawing.Size(120, 20);
            this.txt_tunjangan.TabIndex = 8;
            // 
            // cb_nik
            // 
            this.cb_nik.FormattingEnabled = true;
            this.cb_nik.Location = new System.Drawing.Point(139, 105);
            this.cb_nik.Name = "cb_nik";
            this.cb_nik.Size = new System.Drawing.Size(120, 21);
            this.cb_nik.TabIndex = 9;
            // 
            // btn_batal
            // 
            this.btn_batal.Image = global::indomart.Properties.Resources.delete;
            this.btn_batal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_batal.Location = new System.Drawing.Point(259, 283);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(93, 60);
            this.btn_batal.TabIndex = 1;
            this.btn_batal.Text = "             Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Image = global::indomart.Properties.Resources.save_all;
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_simpan.Location = new System.Drawing.Point(139, 283);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(100, 60);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "          Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // frm_tmbh_gaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 369);
            this.Controls.Add(this.cb_nik);
            this.Controls.Add(this.txt_tunjangan);
            this.Controls.Add(this.txt_gajipokok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_simpan);
            this.Name = "frm_tmbh_gaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tambah Gaji Karyawan";
            this.Load += new System.EventHandler(this.frm_tmbh_gaji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gajipokok;
        private System.Windows.Forms.TextBox txt_tunjangan;
        private System.Windows.Forms.ComboBox cb_nik;
    }
}