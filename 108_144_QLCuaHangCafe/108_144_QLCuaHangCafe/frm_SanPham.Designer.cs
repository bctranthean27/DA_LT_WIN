namespace _108_144_QLCuaHangCafe
{
    partial class frm_SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.pic_HinhAnh = new System.Windows.Forms.PictureBox();
            this.cbo_NCC = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.cbo_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.cbo_Size = new System.Windows.Forms.ComboBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_CTSP = new System.Windows.Forms.DataGridView();
            this.MaCTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1540, 63);
            this.label1.TabIndex = 43;
            this.label1.Text = "NHẬP SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_AddImage.Location = new System.Drawing.Point(871, 79);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(170, 42);
            this.btn_AddImage.TabIndex = 68;
            this.btn_AddImage.Text = "Nhập Hình Ảnh";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // pic_HinhAnh
            // 
            this.pic_HinhAnh.Location = new System.Drawing.Point(871, 137);
            this.pic_HinhAnh.Name = "pic_HinhAnh";
            this.pic_HinhAnh.Size = new System.Drawing.Size(219, 228);
            this.pic_HinhAnh.TabIndex = 69;
            this.pic_HinhAnh.TabStop = false;
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.BackColor = System.Drawing.Color.White;
            this.cbo_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_NCC.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.cbo_NCC.FormattingEnabled = true;
            this.cbo_NCC.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_NCC.Location = new System.Drawing.Point(589, 79);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Size = new System.Drawing.Size(263, 39);
            this.cbo_NCC.TabIndex = 87;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_Exit.Location = new System.Drawing.Point(745, 310);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(107, 55);
            this.btn_Exit.TabIndex = 86;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(439, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nhà Cung Cấp";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(165, 249);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(266, 38);
            this.txt_SoLuong.TabIndex = 94;
            // 
            // cbo_LoaiSanPham
            // 
            this.cbo_LoaiSanPham.BackColor = System.Drawing.Color.White;
            this.cbo_LoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.cbo_LoaiSanPham.FormattingEnabled = true;
            this.cbo_LoaiSanPham.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_LoaiSanPham.Location = new System.Drawing.Point(165, 191);
            this.cbo_LoaiSanPham.Name = "cbo_LoaiSanPham";
            this.cbo_LoaiSanPham.Size = new System.Drawing.Size(266, 39);
            this.cbo_LoaiSanPham.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(10, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 92;
            this.label9.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 78;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.txt_TenSP.Location = new System.Drawing.Point(165, 134);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(266, 38);
            this.txt_TenSP.TabIndex = 81;
            // 
            // cbo_Size
            // 
            this.cbo_Size.BackColor = System.Drawing.Color.White;
            this.cbo_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Size.Enabled = false;
            this.cbo_Size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Size.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.cbo_Size.FormattingEnabled = true;
            this.cbo_Size.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_Size.Location = new System.Drawing.Point(589, 247);
            this.cbo_Size.Name = "cbo_Size";
            this.cbo_Size.Size = new System.Drawing.Size(263, 39);
            this.cbo_Size.TabIndex = 88;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.BackColor = System.Drawing.Color.White;
            this.txt_MaSP.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.txt_MaSP.Location = new System.Drawing.Point(165, 76);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.ReadOnly = true;
            this.txt_MaSP.Size = new System.Drawing.Size(266, 38);
            this.txt_MaSP.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Location = new System.Drawing.Point(574, 310);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 55);
            this.btn_Xoa.TabIndex = 83;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(439, 252);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 31);
            this.label.TabIndex = 98;
            this.label.Text = "Size";
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_Them.Location = new System.Drawing.Point(12, 310);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 55);
            this.btn_Them.TabIndex = 82;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // btn_Luu
            // 
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_Luu.Location = new System.Drawing.Point(192, 310);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(107, 55);
            this.btn_Luu.TabIndex = 85;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.txt_GiaBan.Location = new System.Drawing.Point(589, 194);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(263, 38);
            this.txt_GiaBan.TabIndex = 97;
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_Sua.Location = new System.Drawing.Point(381, 310);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 55);
            this.btn_Sua.TabIndex = 84;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(439, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 31);
            this.label7.TabIndex = 96;
            this.label7.Text = "Giá Bán";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.txt_GiaNhap.Location = new System.Drawing.Point(589, 137);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(263, 38);
            this.txt_GiaNhap.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(439, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 93;
            this.label5.Text = "Giá Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(1096, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 636);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AllowUserToAddRows = false;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSach.ColumnHeadersHeight = 80;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaLoai,
            this.MaNCC,
            this.TrangThai,
            this.MaHinh});
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.EnableHeadersVisualStyles = false;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSach.RowHeadersWidth = 30;
            this.dgv_DanhSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(426, 607);
            this.dgv_DanhSach.TabIndex = 0;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            this.dgv_DanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellValueChanged);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Loại Sản Phẩm";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Nhà Cung Cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            // 
            // MaHinh
            // 
            this.MaHinh.DataPropertyName = "MaHinh";
            this.MaHinh.HeaderText = "Mã Hình";
            this.MaHinh.MinimumWidth = 6;
            this.MaHinh.Name = "MaHinh";
            this.MaHinh.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_CTSP);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 321);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // dgv_CTSP
            // 
            this.dgv_CTSP.AllowUserToAddRows = false;
            this.dgv_CTSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTSP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CTSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CTSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CTSP.ColumnHeadersHeight = 40;
            this.dgv_CTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_CTSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTSP,
            this.MaSanPham,
            this.MaSize,
            this.SoLuong,
            this.GiaBan,
            this.GiaNhap,
            this.TinhTrang});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CTSP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CTSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CTSP.EnableHeadersVisualStyles = false;
            this.dgv_CTSP.Location = new System.Drawing.Point(3, 26);
            this.dgv_CTSP.Name = "dgv_CTSP";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CTSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CTSP.RowHeadersWidth = 30;
            this.dgv_CTSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CTSP.RowTemplate.Height = 24;
            this.dgv_CTSP.Size = new System.Drawing.Size(1076, 292);
            this.dgv_CTSP.TabIndex = 1;
            this.dgv_CTSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTSP_CellClick);
            this.dgv_CTSP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTSP_CellValueChanged);
            // 
            // MaCTSP
            // 
            this.MaCTSP.DataPropertyName = "MaCTSP";
            this.MaCTSP.HeaderText = "Mã CTSP";
            this.MaCTSP.MinimumWidth = 6;
            this.MaCTSP.Name = "MaCTSP";
            this.MaCTSP.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
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
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = false;
            // 
            // frm_SanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1540, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbo_NCC);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.cbo_LoaiSanPham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.cbo_Size);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_HinhAnh);
            this.Controls.Add(this.btn_AddImage);
            this.Controls.Add(this.label1);
            this.Name = "frm_SanPham";
            this.Text = "SanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox pic_HinhAnh;
        private System.Windows.Forms.ComboBox cbo_NCC;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ComboBox cbo_LoaiSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.ComboBox cbo_Size;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_CTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}