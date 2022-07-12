namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeNgay
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
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.grp_ThongKeNgay = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.lbl_SoHoaDon = new System.Windows.Forms.Label();
            this.lbl_DoanhThuNgay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_TrungBinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongKeNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1448, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - NGÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1062, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng số hoá đơn";
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(638, 83);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(333, 38);
            this.dtp_Ngay.TabIndex = 11;
            this.dtp_Ngay.Value = new System.DateTime(2000, 1, 1, 16, 23, 0, 0);
            this.dtp_Ngay.ValueChanged += new System.EventHandler(this.dtp_MinNgay_ValueChanged);
            // 
            // grp_ThongKeNgay
            // 
            this.grp_ThongKeNgay.Controls.Add(this.dgv_DanhSach);
            this.grp_ThongKeNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKeNgay.Location = new System.Drawing.Point(0, 173);
            this.grp_ThongKeNgay.Name = "grp_ThongKeNgay";
            this.grp_ThongKeNgay.Size = new System.Drawing.Size(1059, 563);
            this.grp_ThongKeNgay.TabIndex = 116;
            this.grp_ThongKeNgay.TabStop = false;
            this.grp_ThongKeNgay.Text = "Bảng Thống Kê Hoá Đơn Theo Ngày";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AllowUserToAddRows = false;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.TenKhachHang,
            this.MaLoaiHD,
            this.NgayLap,
            this.TrangThai,
            this.TongTien});
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 50;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1053, 534);
            this.dgv_DanhSach.TabIndex = 0;
            // 
            // lbl_SoHoaDon
            // 
            this.lbl_SoHoaDon.BackColor = System.Drawing.Color.White;
            this.lbl_SoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SoHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoHoaDon.Location = new System.Drawing.Point(1068, 240);
            this.lbl_SoHoaDon.Name = "lbl_SoHoaDon";
            this.lbl_SoHoaDon.Size = new System.Drawing.Size(350, 45);
            this.lbl_SoHoaDon.TabIndex = 117;
            // 
            // lbl_DoanhThuNgay
            // 
            this.lbl_DoanhThuNgay.BackColor = System.Drawing.Color.White;
            this.lbl_DoanhThuNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DoanhThuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhThuNgay.Location = new System.Drawing.Point(1068, 348);
            this.lbl_DoanhThuNgay.Name = "lbl_DoanhThuNgay";
            this.lbl_DoanhThuNgay.Size = new System.Drawing.Size(350, 45);
            this.lbl_DoanhThuNgay.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1062, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 31);
            this.label5.TabIndex = 118;
            this.label5.Text = "Tổng doanh thu ngày";
            // 
            // lbl_TrungBinh
            // 
            this.lbl_TrungBinh.BackColor = System.Drawing.Color.White;
            this.lbl_TrungBinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TrungBinh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrungBinh.Location = new System.Drawing.Point(1068, 479);
            this.lbl_TrungBinh.Name = "lbl_TrungBinh";
            this.lbl_TrungBinh.Size = new System.Drawing.Size(350, 45);
            this.lbl_TrungBinh.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1062, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 31);
            this.label7.TabIndex = 120;
            this.label7.Text = "Trung bình/hoá đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 31);
            this.label8.TabIndex = 122;
            this.label8.Text = "Chọn ngày";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên Lập";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // MaLoaiHD
            // 
            this.MaLoaiHD.DataPropertyName = "MaLoaiHD";
            this.MaLoaiHD.HeaderText = "Mã Loại HD";
            this.MaLoaiHD.MinimumWidth = 6;
            this.MaLoaiHD.Name = "MaLoaiHD";
            this.MaLoaiHD.Visible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // frm_ThongKeNgay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1448, 736);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_TrungBinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_DoanhThuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_SoHoaDon);
            this.Controls.Add(this.grp_ThongKeNgay);
            this.Controls.Add(this.dtp_Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongKeNgay";
            this.Text = "ThongKeNgay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeNgay_Load);
            this.grp_ThongKeNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.GroupBox grp_ThongKeNgay;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Label lbl_SoHoaDon;
        private System.Windows.Forms.Label lbl_DoanhThuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_TrungBinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}