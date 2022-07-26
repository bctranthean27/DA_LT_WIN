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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ThongKeThang = new System.Windows.Forms.ComboBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongKeNgay = new System.Windows.Forms.GroupBox();
            this.lbl_TrungBinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_DoanhThuNgay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_SoHoaDon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.grp_ThongKeNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 38);
            this.label2.TabIndex = 118;
            this.label2.Text = "Chọn tháng";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1455, 63);
            this.label1.TabIndex = 117;
            this.label1.Text = "THỐNG KÊ BÁN HÀNG - THÁNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_ThongKeThang
            // 
            this.cbo_ThongKeThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ThongKeThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_ThongKeThang.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ThongKeThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.cbo_ThongKeThang.FormattingEnabled = true;
            this.cbo_ThongKeThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_ThongKeThang.Location = new System.Drawing.Point(377, 87);
            this.cbo_ThongKeThang.Name = "cbo_ThongKeThang";
            this.cbo_ThongKeThang.Size = new System.Drawing.Size(299, 45);
            this.cbo_ThongKeThang.TabIndex = 114;
            this.cbo_ThongKeThang.SelectedIndexChanged += new System.EventHandler(this.cbo_ThongKeThang_SelectedIndexChanged);
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSach.ColumnHeadersHeight = 45;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.EnableHeadersVisualStyles = false;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSach.RowHeadersWidth = 20;
            this.dgv_DanhSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1046, 554);
            this.dgv_DanhSach.TabIndex = 0;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // SoLuongDon
            // 
            this.SoLuongDon.DataPropertyName = "SoLuongDon";
            this.SoLuongDon.HeaderText = "Số Lượng Đơn";
            this.SoLuongDon.MinimumWidth = 6;
            this.SoLuongDon.Name = "SoLuongDon";
            this.SoLuongDon.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Doanh Thu Ngày";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TrungBinh
            // 
            this.TrungBinh.DataPropertyName = "TrungBinh";
            this.TrungBinh.HeaderText = "Trung Bình";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            this.TrungBinh.ReadOnly = true;
            // 
            // grp_ThongKeNgay
            // 
            this.grp_ThongKeNgay.Controls.Add(this.dgv_DanhSach);
            this.grp_ThongKeNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKeNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.grp_ThongKeNgay.Location = new System.Drawing.Point(0, 164);
            this.grp_ThongKeNgay.Name = "grp_ThongKeNgay";
            this.grp_ThongKeNgay.Size = new System.Drawing.Size(1052, 583);
            this.grp_ThongKeNgay.TabIndex = 122;
            this.grp_ThongKeNgay.TabStop = false;
            this.grp_ThongKeNgay.Text = "Bảng Thống Kế Hoá Đơn Theo Tháng";
            // 
            // lbl_TrungBinh
            // 
            this.lbl_TrungBinh.BackColor = System.Drawing.Color.White;
            this.lbl_TrungBinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TrungBinh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrungBinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_TrungBinh.Location = new System.Drawing.Point(1058, 470);
            this.lbl_TrungBinh.Name = "lbl_TrungBinh";
            this.lbl_TrungBinh.Size = new System.Drawing.Size(350, 45);
            this.lbl_TrungBinh.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1052, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 31);
            this.label7.TabIndex = 127;
            this.label7.Text = "Trung bình/ngày";
            // 
            // lbl_DoanhThuNgay
            // 
            this.lbl_DoanhThuNgay.BackColor = System.Drawing.Color.White;
            this.lbl_DoanhThuNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DoanhThuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhThuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_DoanhThuNgay.Location = new System.Drawing.Point(1058, 339);
            this.lbl_DoanhThuNgay.Name = "lbl_DoanhThuNgay";
            this.lbl_DoanhThuNgay.Size = new System.Drawing.Size(350, 45);
            this.lbl_DoanhThuNgay.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1052, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 31);
            this.label5.TabIndex = 125;
            this.label5.Text = "Tổng doanh thu tháng";
            // 
            // lbl_SoHoaDon
            // 
            this.lbl_SoHoaDon.BackColor = System.Drawing.Color.White;
            this.lbl_SoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SoHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_SoHoaDon.Location = new System.Drawing.Point(1058, 231);
            this.lbl_SoHoaDon.Name = "lbl_SoHoaDon";
            this.lbl_SoHoaDon.Size = new System.Drawing.Size(350, 45);
            this.lbl_SoHoaDon.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1052, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 123;
            this.label3.Text = "Tổng số hoá đơn";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Nam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_Nam.Location = new System.Drawing.Point(886, 87);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(299, 45);
            this.cbo_Nam.TabIndex = 129;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 38);
            this.label4.TabIndex = 130;
            this.label4.Text = "Chọn năm";
            // 
            // frm_ThongKeThang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1455, 747);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_TrungBinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_DoanhThuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_SoHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_ThongKeThang);
            this.Controls.Add(this.grp_ThongKeNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.Name = "frm_ThongKeThang";
            this.Text = "frm_ThongKeThang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.grp_ThongKeNgay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ThongKeThang;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox grp_ThongKeNgay;
        private System.Windows.Forms.Label lbl_TrungBinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_DoanhThuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_SoHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}