namespace _108_144_QLCuaHangCafe
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.lbl_nhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LuuCT = new System.Windows.Forms.Button();
            this.btn_GiamKM = new System.Windows.Forms.Button();
            this.btn_themKM = new System.Windows.Forms.Button();
            this.btn_giamSL = new System.Windows.Forms.Button();
            this.btn_tangSL = new System.Windows.Forms.Button();
            this.btn_XoaCT = new System.Windows.Forms.Button();
            this.btn_SuaCT = new System.Windows.Forms.Button();
            this.btn_ThemCT = new System.Windows.Forms.Button();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GiaGoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_XuatHD = new System.Windows.Forms.Button();
            this.txt_KhuyenMai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Size = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_SanPham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.MaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 355);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hoá Đơn";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AllowUserToAddRows = false;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.MaLoaiHD,
            this.MaNV,
            this.TenKhachHang,
            this.TongTien,
            this.TrangThai});
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            this.dgv_DanhSach.RowHeadersWidth = 50;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(616, 326);
            this.dgv_DanhSach.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // MaLoaiHD
            // 
            this.MaLoaiHD.DataPropertyName = "MaLoaiHD";
            this.MaLoaiHD.HeaderText = "Loại Hoá Đơn";
            this.MaLoaiHD.MinimumWidth = 6;
            this.MaLoaiHD.Name = "MaLoaiHD";
            this.MaLoaiHD.ReadOnly = true;
            this.MaLoaiHD.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1526, 48);
            this.label6.TabIndex = 123;
            this.label6.Text = "THÊM HOÁ ĐƠN BÁN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tenKH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_MaHD);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_ThemHD);
            this.groupBox2.Controls.Add(this.cbo_NhanVien);
            this.groupBox2.Controls.Add(this.lbl_nhanVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 245);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoá Đơn";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(155, 108);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(295, 38);
            this.txt_tenKH.TabIndex = 135;
            this.txt_tenKH.TextChanged += new System.EventHandler(this.txt_tenKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 134;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(155, 31);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(295, 38);
            this.txt_MaHD.TabIndex = 133;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Reset.Enabled = false;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Location = new System.Drawing.Point(472, 133);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(82, 38);
            this.btn_Reset.TabIndex = 131;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThemHD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ThemHD.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHD.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemHD.Location = new System.Drawing.Point(472, 31);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(82, 39);
            this.btn_ThemHD.TabIndex = 130;
            this.btn_ThemHD.Text = "Thêm";
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.BackColor = System.Drawing.Color.White;
            this.cbo_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbo_NhanVien.Location = new System.Drawing.Point(155, 180);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(295, 39);
            this.cbo_NhanVien.TabIndex = 127;
            // 
            // lbl_nhanVien
            // 
            this.lbl_nhanVien.AutoSize = true;
            this.lbl_nhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_nhanVien.Location = new System.Drawing.Point(8, 183);
            this.lbl_nhanVien.Name = "lbl_nhanVien";
            this.lbl_nhanVien.Size = new System.Drawing.Size(165, 31);
            this.lbl_nhanVien.TabIndex = 123;
            this.lbl_nhanVien.Text = "Nhân Viên Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 124;
            this.label2.Text = "Mã Hoá Đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_LuuCT);
            this.groupBox3.Controls.Add(this.btn_GiamKM);
            this.groupBox3.Controls.Add(this.btn_themKM);
            this.groupBox3.Controls.Add(this.btn_giamSL);
            this.groupBox3.Controls.Add(this.btn_tangSL);
            this.groupBox3.Controls.Add(this.btn_XoaCT);
            this.groupBox3.Controls.Add(this.btn_SuaCT);
            this.groupBox3.Controls.Add(this.btn_ThemCT);
            this.groupBox3.Controls.Add(this.txt_ThanhTien);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_GiaGoc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_Exit);
            this.groupBox3.Controls.Add(this.btn_XuatHD);
            this.groupBox3.Controls.Add(this.txt_KhuyenMai);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_SoLuong);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbo_Size);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbo_SanPham);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(580, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 245);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết";
            // 
            // btn_LuuCT
            // 
            this.btn_LuuCT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LuuCT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_LuuCT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuCT.ForeColor = System.Drawing.Color.Black;
            this.btn_LuuCT.Location = new System.Drawing.Point(670, 72);
            this.btn_LuuCT.Name = "btn_LuuCT";
            this.btn_LuuCT.Size = new System.Drawing.Size(82, 45);
            this.btn_LuuCT.TabIndex = 152;
            this.btn_LuuCT.Text = "Lưu";
            this.btn_LuuCT.UseVisualStyleBackColor = false;
            this.btn_LuuCT.Click += new System.EventHandler(this.btn_LuuCT_Click);
            // 
            // btn_GiamKM
            // 
            this.btn_GiamKM.Location = new System.Drawing.Point(380, 183);
            this.btn_GiamKM.Name = "btn_GiamKM";
            this.btn_GiamKM.Size = new System.Drawing.Size(55, 38);
            this.btn_GiamKM.TabIndex = 151;
            this.btn_GiamKM.Text = "-";
            this.btn_GiamKM.UseVisualStyleBackColor = true;
            this.btn_GiamKM.Click += new System.EventHandler(this.btn_GiamKM_Click);
            // 
            // btn_themKM
            // 
            this.btn_themKM.Location = new System.Drawing.Point(323, 183);
            this.btn_themKM.Name = "btn_themKM";
            this.btn_themKM.Size = new System.Drawing.Size(55, 38);
            this.btn_themKM.TabIndex = 150;
            this.btn_themKM.Text = "+";
            this.btn_themKM.UseVisualStyleBackColor = true;
            this.btn_themKM.Click += new System.EventHandler(this.btn_themKM_Click);
            // 
            // btn_giamSL
            // 
            this.btn_giamSL.Location = new System.Drawing.Point(380, 133);
            this.btn_giamSL.Name = "btn_giamSL";
            this.btn_giamSL.Size = new System.Drawing.Size(55, 38);
            this.btn_giamSL.TabIndex = 149;
            this.btn_giamSL.Text = "-";
            this.btn_giamSL.UseVisualStyleBackColor = true;
            this.btn_giamSL.Click += new System.EventHandler(this.btn_giamSL_Click);
            // 
            // btn_tangSL
            // 
            this.btn_tangSL.Location = new System.Drawing.Point(323, 133);
            this.btn_tangSL.Name = "btn_tangSL";
            this.btn_tangSL.Size = new System.Drawing.Size(55, 38);
            this.btn_tangSL.TabIndex = 148;
            this.btn_tangSL.Text = "+";
            this.btn_tangSL.UseVisualStyleBackColor = true;
            this.btn_tangSL.Click += new System.EventHandler(this.btn_tangSL_Click);
            // 
            // btn_XoaCT
            // 
            this.btn_XoaCT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XoaCT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_XoaCT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCT.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaCT.Location = new System.Drawing.Point(758, 72);
            this.btn_XoaCT.Name = "btn_XoaCT";
            this.btn_XoaCT.Size = new System.Drawing.Size(82, 45);
            this.btn_XoaCT.TabIndex = 147;
            this.btn_XoaCT.Text = "Xoá";
            this.btn_XoaCT.UseVisualStyleBackColor = false;
            this.btn_XoaCT.Click += new System.EventHandler(this.btn_XoaCT_Click);
            // 
            // btn_SuaCT
            // 
            this.btn_SuaCT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaCT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SuaCT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaCT.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaCT.Location = new System.Drawing.Point(758, 20);
            this.btn_SuaCT.Name = "btn_SuaCT";
            this.btn_SuaCT.Size = new System.Drawing.Size(82, 45);
            this.btn_SuaCT.TabIndex = 146;
            this.btn_SuaCT.Text = "Sửa";
            this.btn_SuaCT.UseVisualStyleBackColor = false;
            this.btn_SuaCT.Click += new System.EventHandler(this.btn_SuaCT_Click);
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThemCT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ThemCT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCT.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemCT.Location = new System.Drawing.Point(670, 20);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(82, 45);
            this.btn_ThemCT.TabIndex = 136;
            this.btn_ThemCT.Text = "Thêm";
            this.btn_ThemCT.UseVisualStyleBackColor = false;
            this.btn_ThemCT.Click += new System.EventHandler(this.btn_ThemCT_Click);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(609, 183);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(292, 38);
            this.txt_ThanhTien.TabIndex = 145;
            this.txt_ThanhTien.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(461, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 144;
            this.label11.Text = "Thành Tiền";
            // 
            // txt_GiaGoc
            // 
            this.txt_GiaGoc.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaGoc.Location = new System.Drawing.Point(609, 130);
            this.txt_GiaGoc.Name = "txt_GiaGoc";
            this.txt_GiaGoc.ReadOnly = true;
            this.txt_GiaGoc.Size = new System.Drawing.Size(292, 38);
            this.txt_GiaGoc.TabIndex = 143;
            this.txt_GiaGoc.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(461, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 31);
            this.label10.TabIndex = 142;
            this.label10.Text = "Giá Gốc";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(846, 72);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 45);
            this.btn_Exit.TabIndex = 127;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_XuatHD
            // 
            this.btn_XuatHD.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XuatHD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_XuatHD.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatHD.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatHD.Location = new System.Drawing.Point(846, 21);
            this.btn_XuatHD.Name = "btn_XuatHD";
            this.btn_XuatHD.Size = new System.Drawing.Size(82, 45);
            this.btn_XuatHD.TabIndex = 126;
            this.btn_XuatHD.Text = "Xuất";
            this.btn_XuatHD.UseVisualStyleBackColor = false;
            this.btn_XuatHD.Click += new System.EventHandler(this.btn_XuatHD_Click);
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KhuyenMai.Location = new System.Drawing.Point(164, 183);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.ReadOnly = true;
            this.txt_KhuyenMai.Size = new System.Drawing.Size(135, 38);
            this.txt_KhuyenMai.TabIndex = 141;
            this.txt_KhuyenMai.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 31);
            this.label9.TabIndex = 140;
            this.label9.Text = "Khuyến mãi %";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(164, 133);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.ReadOnly = true;
            this.txt_SoLuong.Size = new System.Drawing.Size(135, 38);
            this.txt_SoLuong.TabIndex = 137;
            this.txt_SoLuong.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 31);
            this.label8.TabIndex = 136;
            this.label8.Text = "Số Lượng";
            // 
            // cbo_Size
            // 
            this.cbo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Size.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Size.FormattingEnabled = true;
            this.cbo_Size.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbo_Size.Location = new System.Drawing.Point(164, 80);
            this.cbo_Size.Name = "cbo_Size";
            this.cbo_Size.Size = new System.Drawing.Size(271, 39);
            this.cbo_Size.TabIndex = 139;
            this.cbo_Size.SelectionChangeCommitted += new System.EventHandler(this.cbo_SanPham_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 31);
            this.label7.TabIndex = 138;
            this.label7.Text = "Size";
            // 
            // cbo_SanPham
            // 
            this.cbo_SanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SanPham.FormattingEnabled = true;
            this.cbo_SanPham.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbo_SanPham.Location = new System.Drawing.Point(164, 31);
            this.cbo_SanPham.Name = "cbo_SanPham";
            this.cbo_SanPham.Size = new System.Drawing.Size(271, 39);
            this.cbo_SanPham.TabIndex = 137;
            this.cbo_SanPham.SelectionChangeCommitted += new System.EventHandler(this.cbo_SanPham_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 136;
            this.label3.Text = "Sản Phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_CTHD);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(628, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(886, 355);
            this.groupBox4.TabIndex = 116;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Chi Tiết";
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.AllowUserToAddRows = false;
            this.dgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHD,
            this.MaSP,
            this.MaSize,
            this.SoLuong,
            this.DonGia,
            this.GiaGoc,
            this.KhuyenMai,
            this.ThanhTien});
            this.dgv_CTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CTHD.Location = new System.Drawing.Point(3, 26);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.ReadOnly = true;
            this.dgv_CTHD.RowHeadersWidth = 50;
            this.dgv_CTHD.RowTemplate.Height = 24;
            this.dgv_CTHD.Size = new System.Drawing.Size(880, 326);
            this.dgv_CTHD.TabIndex = 0;
            this.dgv_CTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTHD_CellClick);
            // 
            // MaCTHD
            // 
            this.MaCTHD.DataPropertyName = "MaCTHD";
            this.MaCTHD.HeaderText = "Mã CTHD";
            this.MaCTHD.MinimumWidth = 6;
            this.MaCTHD.Name = "MaCTHD";
            this.MaCTHD.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // MaSize
            // 
            this.MaSize.DataPropertyName = "MaSize";
            this.MaSize.HeaderText = "Mã Size";
            this.MaSize.MinimumWidth = 6;
            this.MaSize.Name = "MaSize";
            this.MaSize.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GiaGoc
            // 
            this.GiaGoc.DataPropertyName = "GiaGoc";
            this.GiaGoc.HeaderText = "Giá Gốc";
            this.GiaGoc.MinimumWidth = 6;
            this.GiaGoc.Name = "GiaGoc";
            this.GiaGoc.ReadOnly = true;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 6;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(1222, 669);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(292, 38);
            this.txt_TongTien.TabIndex = 147;
            this.txt_TongTien.Text = "0";
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(1074, 669);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(113, 31);
            this.lbl.TabIndex = 146;
            this.lbl.Text = "Tổng tiền";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1526, 768);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_HoaDon";
            this.Text = "frm_HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.Label lbl_nhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_KhuyenMai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Size;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_SanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GiaGoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_XuatHD;
        private System.Windows.Forms.Button btn_XoaCT;
        private System.Windows.Forms.Button btn_SuaCT;
        private System.Windows.Forms.Button btn_ThemCT;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.Button btn_GiamKM;
        private System.Windows.Forms.Button btn_themKM;
        private System.Windows.Forms.Button btn_giamSL;
        private System.Windows.Forms.Button btn_tangSL;
        private System.Windows.Forms.Button btn_LuuCT;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}