namespace _108_144_QLCuaHangCafe
{
    partial class frm_SearchHD
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaxNgayLapHD = new System.Windows.Forms.TextBox();
            this.txt_MinNgayLapHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_SearchHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(681, 160);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(299, 37);
            this.btn_Search.TabIndex = 76;
            this.btn_Search.Text = "TÌM";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(212, 160);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(299, 37);
            this.cbo_TrangThai.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "Đến";
            // 
            // txt_MaxNgayLapHD
            // 
            this.txt_MaxNgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaxNgayLapHD.Location = new System.Drawing.Point(681, 99);
            this.txt_MaxNgayLapHD.Name = "txt_MaxNgayLapHD";
            this.txt_MaxNgayLapHD.Size = new System.Drawing.Size(299, 34);
            this.txt_MaxNgayLapHD.TabIndex = 66;
            // 
            // txt_MinNgayLapHD
            // 
            this.txt_MinNgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MinNgayLapHD.Location = new System.Drawing.Point(212, 99);
            this.txt_MinNgayLapHD.Name = "txt_MinNgayLapHD";
            this.txt_MinNgayLapHD.Size = new System.Drawing.Size(299, 34);
            this.txt_MinNgayLapHD.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 65;
            this.label2.Text = "Ngày Lập Từ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 63);
            this.label1.TabIndex = 62;
            this.label1.Text = "TÌM KIẾM HOÁ ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 31);
            this.label7.TabIndex = 70;
            this.label7.Text = "Trạng Thái";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_SearchHD
            // 
            this.dgv_SearchHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenLoaiHD,
            this.KhachHang,
            this.NgayLap,
            this.TrangThai});
            this.dgv_SearchHD.Location = new System.Drawing.Point(6, 31);
            this.dgv_SearchHD.Name = "dgv_SearchHD";
            this.dgv_SearchHD.RowHeadersWidth = 50;
            this.dgv_SearchHD.RowTemplate.Height = 24;
            this.dgv_SearchHD.Size = new System.Drawing.Size(1142, 411);
            this.dgv_SearchHD.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // TenLoaiHD
            // 
            this.TenLoaiHD.HeaderText = "Loại Hoá Đơn";
            this.TenLoaiHD.MinimumWidth = 6;
            this.TenLoaiHD.Name = "TenLoaiHD";
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SearchHD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 448);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hoá Đơn";
            // 
            // frm_SearchHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaxNgayLapHD);
            this.Controls.Add(this.txt_MinNgayLapHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SearchHD";
            this.Text = "frm_SearchHD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaxNgayLapHD;
        private System.Windows.Forms.TextBox txt_MinNgayLapHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_SearchHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}