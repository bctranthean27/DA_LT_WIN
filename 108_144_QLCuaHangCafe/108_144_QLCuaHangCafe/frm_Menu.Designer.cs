namespace _108_144_QLCuaHangCafe
{
    partial class frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_NhapThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LoaiSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LoaiHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Size = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SearchKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SearchSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SearchHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongKeNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongKeThang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongKeNam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongKeNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1737, 63);
            this.label1.TabIndex = 65;
            this.label1.Text = "QUẢN LÍ CỬA HÀNG CAFE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_NhapThongTin,
            this.mnu_TimKiem,
            this.mnu_ThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1737, 36);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_NhapThongTin
            // 
            this.mnu_NhapThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_LoaiSP,
            this.mnu_LoaiHD,
            this.mnu_ChucVu,
            this.mnu_NCC,
            this.mnu_Size,
            this.mnu_NhanVien,
            this.mnu_SanPham,
            this.mnu_KhachHang,
            this.mnu_HoaDon});
            this.mnu_NhapThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_NhapThongTin.Name = "mnu_NhapThongTin";
            this.mnu_NhapThongTin.Size = new System.Drawing.Size(166, 32);
            this.mnu_NhapThongTin.Text = "Nhập thông tin";
            // 
            // mnu_LoaiSP
            // 
            this.mnu_LoaiSP.Name = "mnu_LoaiSP";
            this.mnu_LoaiSP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnu_LoaiSP.Size = new System.Drawing.Size(298, 32);
            this.mnu_LoaiSP.Text = "Loại Sản Phẩm";
            this.mnu_LoaiSP.Click += new System.EventHandler(this.mnu_LoaiSP_Click);
            // 
            // mnu_LoaiHD
            // 
            this.mnu_LoaiHD.Name = "mnu_LoaiHD";
            this.mnu_LoaiHD.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnu_LoaiHD.Size = new System.Drawing.Size(298, 32);
            this.mnu_LoaiHD.Text = "Loại Hoá Đơn";
            this.mnu_LoaiHD.Click += new System.EventHandler(this.mnuLoaiHD_Click);
            // 
            // mnu_ChucVu
            // 
            this.mnu_ChucVu.Name = "mnu_ChucVu";
            this.mnu_ChucVu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnu_ChucVu.Size = new System.Drawing.Size(298, 32);
            this.mnu_ChucVu.Text = "Chức Vụ";
            this.mnu_ChucVu.Click += new System.EventHandler(this.mnu_ChucVu_Click);
            // 
            // mnu_NCC
            // 
            this.mnu_NCC.Name = "mnu_NCC";
            this.mnu_NCC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.mnu_NCC.Size = new System.Drawing.Size(298, 32);
            this.mnu_NCC.Text = "Nhà Cung Cấp";
            this.mnu_NCC.Click += new System.EventHandler(this.mnu_NCC_Click);
            // 
            // mnu_Size
            // 
            this.mnu_Size.Name = "mnu_Size";
            this.mnu_Size.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.mnu_Size.Size = new System.Drawing.Size(298, 32);
            this.mnu_Size.Text = "Size";
            this.mnu_Size.Click += new System.EventHandler(this.mnu_Size_Click);
            // 
            // mnu_NhanVien
            // 
            this.mnu_NhanVien.Name = "mnu_NhanVien";
            this.mnu_NhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.mnu_NhanVien.Size = new System.Drawing.Size(298, 32);
            this.mnu_NhanVien.Text = "Nhân Viên";
            this.mnu_NhanVien.Click += new System.EventHandler(this.mnu_NhanVien_Click);
            // 
            // mnu_SanPham
            // 
            this.mnu_SanPham.Name = "mnu_SanPham";
            this.mnu_SanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.mnu_SanPham.Size = new System.Drawing.Size(298, 32);
            this.mnu_SanPham.Text = "Sản Phẩm";
            this.mnu_SanPham.Click += new System.EventHandler(this.mnu_SanPham_Click);
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.mnu_KhachHang.Size = new System.Drawing.Size(298, 32);
            this.mnu_KhachHang.Text = "Khách Hàng";
            this.mnu_KhachHang.Click += new System.EventHandler(this.mnu_KhachHang_Click);
            // 
            // mnu_HoaDon
            // 
            this.mnu_HoaDon.Name = "mnu_HoaDon";
            this.mnu_HoaDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.mnu_HoaDon.Size = new System.Drawing.Size(298, 32);
            this.mnu_HoaDon.Text = "Hoá Đơn";
            this.mnu_HoaDon.Click += new System.EventHandler(this.mnu_HoaDon_Click);
            // 
            // mnu_TimKiem
            // 
            this.mnu_TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SearchKH,
            this.mnu_SearchSP,
            this.mnu_SearchHD});
            this.mnu_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_TimKiem.Name = "mnu_TimKiem";
            this.mnu_TimKiem.Size = new System.Drawing.Size(111, 32);
            this.mnu_TimKiem.Text = "Tìm kiếm";
            // 
            // mnu_SearchKH
            // 
            this.mnu_SearchKH.Name = "mnu_SearchKH";
            this.mnu_SearchKH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.mnu_SearchKH.Size = new System.Drawing.Size(267, 32);
            this.mnu_SearchKH.Text = "Khách Hàng";
            this.mnu_SearchKH.Click += new System.EventHandler(this.mnu_SearchKH_Click);
            // 
            // mnu_SearchSP
            // 
            this.mnu_SearchSP.Name = "mnu_SearchSP";
            this.mnu_SearchSP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.mnu_SearchSP.Size = new System.Drawing.Size(267, 32);
            this.mnu_SearchSP.Text = "Sản Phẩm";
            this.mnu_SearchSP.Click += new System.EventHandler(this.mnu_SearchSP_Click);
            // 
            // mnu_SearchHD
            // 
            this.mnu_SearchHD.Name = "mnu_SearchHD";
            this.mnu_SearchHD.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.mnu_SearchHD.Size = new System.Drawing.Size(267, 32);
            this.mnu_SearchHD.Text = "Hoá Đơn";
            this.mnu_SearchHD.Click += new System.EventHandler(this.mnu_SearchHD_Click);
            // 
            // mnu_ThongKe
            // 
            this.mnu_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ThongKeNgay,
            this.mnu_ThongKeThang,
            this.mnu_ThongKeNam,
            this.mnu_ThongKeNV});
            this.mnu_ThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_ThongKe.Name = "mnu_ThongKe";
            this.mnu_ThongKe.Size = new System.Drawing.Size(113, 32);
            this.mnu_ThongKe.Text = "Thống kê";
            // 
            // mnu_ThongKeNgay
            // 
            this.mnu_ThongKeNgay.Name = "mnu_ThongKeNgay";
            this.mnu_ThongKeNgay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.mnu_ThongKeNgay.Size = new System.Drawing.Size(256, 32);
            this.mnu_ThongKeNgay.Text = "Ngày";
            this.mnu_ThongKeNgay.Click += new System.EventHandler(this.mnu_ThongKeNgay_Click);
            // 
            // mnu_ThongKeThang
            // 
            this.mnu_ThongKeThang.Name = "mnu_ThongKeThang";
            this.mnu_ThongKeThang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.mnu_ThongKeThang.Size = new System.Drawing.Size(256, 32);
            this.mnu_ThongKeThang.Text = "Tháng";
            this.mnu_ThongKeThang.Click += new System.EventHandler(this.mnu_ThongKeThang_Click);
            // 
            // mnu_ThongKeNam
            // 
            this.mnu_ThongKeNam.Name = "mnu_ThongKeNam";
            this.mnu_ThongKeNam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.mnu_ThongKeNam.Size = new System.Drawing.Size(256, 32);
            this.mnu_ThongKeNam.Text = "Năm";
            this.mnu_ThongKeNam.Click += new System.EventHandler(this.mnu_ThongKeNam_Click);
            // 
            // mnu_ThongKeNV
            // 
            this.mnu_ThongKeNV.Name = "mnu_ThongKeNV";
            this.mnu_ThongKeNV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D7)));
            this.mnu_ThongKeNV.Size = new System.Drawing.Size(256, 32);
            this.mnu_ThongKeNV.Text = "Nhân Viên";
            this.mnu_ThongKeNV.Click += new System.EventHandler(this.mnu_ThongKeNV_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 909);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu";
            this.Text = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_NhapThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnu_LoaiSP;
        private System.Windows.Forms.ToolStripMenuItem mnu_LoaiHD;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnu_NCC;
        private System.Windows.Forms.ToolStripMenuItem mnu_Size;
        private System.Windows.Forms.ToolStripMenuItem mnu_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnu_SanPham;
        private System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnu_SearchKH;
        private System.Windows.Forms.ToolStripMenuItem mnu_SearchSP;
        private System.Windows.Forms.ToolStripMenuItem mnu_SearchHD;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongKeNgay;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongKeThang;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongKeNam;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongKeNV;
    }
}