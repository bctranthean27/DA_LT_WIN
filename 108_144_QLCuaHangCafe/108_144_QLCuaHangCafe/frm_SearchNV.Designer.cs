namespace _108_144_QLCuaHangCafe
{
    partial class frm_SearchNV
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
            this.dtp_MinNgay = new System.Windows.Forms.DateTimePicker();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_HoNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_MaxNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_MinNgay
            // 
            this.dtp_MinNgay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MinNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_MinNgay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MinNgay.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MinNgay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_MinNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_MinNgay.Location = new System.Drawing.Point(207, 209);
            this.dtp_MinNgay.Name = "dtp_MinNgay";
            this.dtp_MinNgay.Size = new System.Drawing.Size(340, 38);
            this.dtp_MinNgay.TabIndex = 61;
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.BackColor = System.Drawing.Color.White;
            this.cbo_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_ChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(4)))), ((int)(((byte)(148)))));
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Location = new System.Drawing.Point(875, 84);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(409, 39);
            this.cbo_ChucVu.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label8.Location = new System.Drawing.Point(685, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 59;
            this.label8.Text = "Chức Vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 346);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSach.ColumnHeadersHeight = 45;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoNV,
            this.TenNV,
            this.DChi,
            this.NgayVaoLam,
            this.MaChucVu,
            this.TrangThai,
            this.roles});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.EnableHeadersVisualStyles = false;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSach.RowHeadersWidth = 20;
            this.dgv_DanhSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1305, 317);
            this.dgv_DanhSach.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoNV
            // 
            this.HoNV.DataPropertyName = "HoNV";
            this.HoNV.HeaderText = "Họ Nhân Viên";
            this.HoNV.MinimumWidth = 6;
            this.HoNV.Name = "HoNV";
            this.HoNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // DChi
            // 
            this.DChi.DataPropertyName = "Dchi";
            this.DChi.HeaderText = "Địa Chỉ";
            this.DChi.MinimumWidth = 6;
            this.DChi.Name = "DChi";
            this.DChi.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày Vào Làm";
            this.NgayVaoLam.MinimumWidth = 6;
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
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
            // roles
            // 
            this.roles.DataPropertyName = "roles";
            this.roles.HeaderText = "roles";
            this.roles.MinimumWidth = 6;
            this.roles.Name = "roles";
            this.roles.ReadOnly = true;
            this.roles.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.btn_Search.Location = new System.Drawing.Point(1169, 209);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 60);
            this.btn_Search.TabIndex = 53;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.Color.White;
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(4)))), ((int)(((byte)(148)))));
            this.txt_MaNV.Location = new System.Drawing.Point(207, 84);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(402, 38);
            this.txt_MaNV.TabIndex = 52;
            // 
            // txt_HoNV
            // 
            this.txt_HoNV.BackColor = System.Drawing.Color.White;
            this.txt_HoNV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(4)))), ((int)(((byte)(148)))));
            this.txt_HoNV.Location = new System.Drawing.Point(207, 141);
            this.txt_HoNV.Name = "txt_HoNV";
            this.txt_HoNV.Size = new System.Drawing.Size(402, 38);
            this.txt_HoNV.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label7.Location = new System.Drawing.Point(26, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Họ Nhân Viên";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BackColor = System.Drawing.Color.White;
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(4)))), ((int)(((byte)(148)))));
            this.txt_TenNV.Location = new System.Drawing.Point(875, 141);
            this.txt_TenNV.Multiline = true;
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(409, 38);
            this.txt_TenNV.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(26, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 31);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ngày Vào Làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(685, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1311, 63);
            this.label1.TabIndex = 44;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(577, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 62;
            this.label4.Text = "Đến";
            // 
            // dtp_MaxNgay
            // 
            this.dtp_MaxNgay.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MaxNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_MaxNgay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MaxNgay.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(1)))), ((int)(((byte)(148)))));
            this.dtp_MaxNgay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_MaxNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_MaxNgay.Location = new System.Drawing.Point(662, 210);
            this.dtp_MaxNgay.Name = "dtp_MaxNgay";
            this.dtp_MaxNgay.Size = new System.Drawing.Size(340, 38);
            this.dtp_MaxNgay.TabIndex = 63;
            // 
            // frm_SearchNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1311, 764);
            this.Controls.Add(this.dtp_MaxNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_MinNgay);
            this.Controls.Add(this.cbo_ChucVu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.txt_HoNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SearchNV";
            this.Text = "frm_SearchNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_SearchNV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_MinNgay;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_HoNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_MaxNgay;
    }
}