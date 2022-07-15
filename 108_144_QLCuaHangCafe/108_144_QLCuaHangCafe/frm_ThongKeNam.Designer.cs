namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeNam
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
            this.dgv_ThongKeNam = new System.Windows.Forms.DataGridView();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_thangMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TrungBinhThang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_DoanhThuNam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_doanhthuMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 125;
            this.label2.Text = "Chọn Năm";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1439, 63);
            this.label1.TabIndex = 124;
            this.label1.Text = "THỐNG KÊ BÁN HÀNG - NĂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ThongKeNam
            // 
            this.dgv_ThongKeNam.AllowUserToAddRows = false;
            this.dgv_ThongKeNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeNam.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongKeNam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKeNam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongKeNam.ColumnHeadersHeight = 45;
            this.dgv_ThongKeNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ThongKeNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongKeNam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ThongKeNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKeNam.EnableHeadersVisualStyles = false;
            this.dgv_ThongKeNam.Location = new System.Drawing.Point(3, 26);
            this.dgv_ThongKeNam.Name = "dgv_ThongKeNam";
            this.dgv_ThongKeNam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKeNam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ThongKeNam.RowHeadersWidth = 20;
            this.dgv_ThongKeNam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ThongKeNam.RowTemplate.Height = 24;
            this.dgv_ThongKeNam.Size = new System.Drawing.Size(1037, 554);
            this.dgv_ThongKeNam.TabIndex = 0;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
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
            this.TongTien.HeaderText = "Doanh Thu Tháng";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TrungBinh
            // 
            this.TrungBinh.DataPropertyName = "TrungBinh";
            this.TrungBinh.HeaderText = "Trung Bình Tháng";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            this.TrungBinh.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ThongKeNam);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 583);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thống Kê Hoá Đơn Theo Năm";
            // 
            // lbl_thangMax
            // 
            this.lbl_thangMax.BackColor = System.Drawing.Color.White;
            this.lbl_thangMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_thangMax.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thangMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_thangMax.Location = new System.Drawing.Point(1060, 467);
            this.lbl_thangMax.Name = "lbl_thangMax";
            this.lbl_thangMax.Size = new System.Drawing.Size(350, 45);
            this.lbl_thangMax.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1054, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 31);
            this.label7.TabIndex = 132;
            this.label7.Text = "Tháng có doanh thu TOP 1";
            // 
            // lbl_TrungBinhThang
            // 
            this.lbl_TrungBinhThang.BackColor = System.Drawing.Color.White;
            this.lbl_TrungBinhThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TrungBinhThang.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrungBinhThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_TrungBinhThang.Location = new System.Drawing.Point(1060, 336);
            this.lbl_TrungBinhThang.Name = "lbl_TrungBinhThang";
            this.lbl_TrungBinhThang.Size = new System.Drawing.Size(350, 45);
            this.lbl_TrungBinhThang.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1054, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 31);
            this.label5.TabIndex = 130;
            this.label5.Text = "Trung Bình/Tháng";
            // 
            // lbl_DoanhThuNam
            // 
            this.lbl_DoanhThuNam.BackColor = System.Drawing.Color.White;
            this.lbl_DoanhThuNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DoanhThuNam.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhThuNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_DoanhThuNam.Location = new System.Drawing.Point(1060, 228);
            this.lbl_DoanhThuNam.Name = "lbl_DoanhThuNam";
            this.lbl_DoanhThuNam.Size = new System.Drawing.Size(350, 45);
            this.lbl_DoanhThuNam.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1054, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tổng doanh thu năm";
            // 
            // lbl_doanhthuMax
            // 
            this.lbl_doanhthuMax.BackColor = System.Drawing.Color.White;
            this.lbl_doanhthuMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_doanhthuMax.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doanhthuMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_doanhthuMax.Location = new System.Drawing.Point(1060, 588);
            this.lbl_doanhthuMax.Name = "lbl_doanhthuMax";
            this.lbl_doanhthuMax.Size = new System.Drawing.Size(350, 45);
            this.lbl_doanhthuMax.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1054, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 31);
            this.label6.TabIndex = 134;
            this.label6.Text = "Doanh Thu Tháng Cao Nhất";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.BackColor = System.Drawing.Color.White;
            this.cbo_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Nam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Location = new System.Drawing.Point(669, 89);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(371, 39);
            this.cbo_Nam.TabIndex = 136;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // frm_ThongKeNam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1439, 735);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.lbl_doanhthuMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_thangMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_TrungBinhThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_DoanhThuNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.Name = "frm_ThongKeNam";
            this.Text = "frm_ThongKeNam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ThongKeNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_thangMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TrungBinhThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_DoanhThuNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_doanhthuMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}