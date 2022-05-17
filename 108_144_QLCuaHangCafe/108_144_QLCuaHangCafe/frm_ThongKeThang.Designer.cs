namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeThang
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
            this.grp_ThongKeNgay = new System.Windows.Forms.GroupBox();
            this.dgv_ThongKeThang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_ThongKeThang = new System.Windows.Forms.ComboBox();
            this.grp_ThongKeNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeThang)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_ThongKeNgay
            // 
            this.grp_ThongKeNgay.Controls.Add(this.dgv_ThongKeThang);
            this.grp_ThongKeNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKeNgay.Location = new System.Drawing.Point(8, 140);
            this.grp_ThongKeNgay.Name = "grp_ThongKeNgay";
            this.grp_ThongKeNgay.Size = new System.Drawing.Size(1109, 583);
            this.grp_ThongKeNgay.TabIndex = 122;
            this.grp_ThongKeNgay.TabStop = false;
            this.grp_ThongKeNgay.Text = "Bảng Thống Kế Hoá Đơn Theo Tháng";
            // 
            // dgv_ThongKeThang
            // 
            this.dgv_ThongKeThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            this.dgv_ThongKeThang.Location = new System.Drawing.Point(15, 31);
            this.dgv_ThongKeThang.Name = "dgv_ThongKeThang";
            this.dgv_ThongKeThang.RowHeadersWidth = 50;
            this.dgv_ThongKeThang.RowTemplate.Height = 24;
            this.dgv_ThongKeThang.Size = new System.Drawing.Size(1088, 546);
            this.dgv_ThongKeThang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 118;
            this.label2.Text = "THÁNG";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1129, 63);
            this.label1.TabIndex = 117;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - THÁNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // SoLuongDon
            // 
            this.SoLuongDon.HeaderText = "Số Lượng Đơn";
            this.SoLuongDon.MinimumWidth = 6;
            this.SoLuongDon.Name = "SoLuongDon";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrungBinh
            // 
            this.TrungBinh.HeaderText = "Trung Bình";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            // 
            // cbo_ThongKeThang
            // 
            this.cbo_ThongKeThang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ThongKeThang.FormattingEnabled = true;
            this.cbo_ThongKeThang.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_ThongKeThang.Location = new System.Drawing.Point(501, 89);
            this.cbo_ThongKeThang.Name = "cbo_ThongKeThang";
            this.cbo_ThongKeThang.Size = new System.Drawing.Size(299, 31);
            this.cbo_ThongKeThang.TabIndex = 114;
            // 
            // frm_ThongKeThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 735);
            this.Controls.Add(this.cbo_ThongKeThang);
            this.Controls.Add(this.grp_ThongKeNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongKeThang";
            this.Text = "frm_ThongKeThang";
            this.grp_ThongKeNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ThongKeNgay;
        private System.Windows.Forms.DataGridView dgv_ThongKeThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.ComboBox cbo_ThongKeThang;
    }
}