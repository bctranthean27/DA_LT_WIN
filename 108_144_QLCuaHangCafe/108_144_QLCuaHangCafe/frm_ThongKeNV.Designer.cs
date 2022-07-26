namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeNV
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
            this.dgv_ThongKeNV = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 129;
            this.label2.Text = "CHỌN NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1453, 63);
            this.label1.TabIndex = 128;
            this.label1.Text = "THỐNG KÊ BÁN HÀNG CỦA NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ThongKeNV
            // 
            this.dgv_ThongKeNV.AllowUserToAddRows = false;
            this.dgv_ThongKeNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeNV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKeNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongKeNV.ColumnHeadersHeight = 45;
            this.dgv_ThongKeNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ThongKeNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongKeNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ThongKeNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKeNV.EnableHeadersVisualStyles = false;
            this.dgv_ThongKeNV.Location = new System.Drawing.Point(3, 26);
            this.dgv_ThongKeNV.Name = "dgv_ThongKeNV";
            this.dgv_ThongKeNV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKeNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ThongKeNV.RowHeadersWidth = 50;
            this.dgv_ThongKeNV.RowTemplate.Height = 24;
            this.dgv_ThongKeNV.Size = new System.Drawing.Size(1447, 554);
            this.dgv_ThongKeNV.TabIndex = 0;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
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
            this.TongTien.HeaderText = "Tổng Tiền";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ThongKeNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1453, 583);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thống Kê Hoá Đơn Theo Nhân Viên";
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(693, 89);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(338, 39);
            this.cbo_NhanVien.TabIndex = 131;
            this.cbo_NhanVien.SelectedIndexChanged += new System.EventHandler(this.cbo_NhanVien_SelectedIndexChanged);
            // 
            // frm_ThongKeNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1453, 752);
            this.Controls.Add(this.cbo_NhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.Name = "frm_ThongKeNV";
            this.Text = "frm_ThongKeNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ThongKeNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}