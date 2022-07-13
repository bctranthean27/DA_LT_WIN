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
            this.cbo_ThongKeThang = new System.Windows.Forms.ComboBox();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.grp_ThongKeNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeThang)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_ThongKeNgay
            // 
            this.grp_ThongKeNgay.Controls.Add(this.dgv_ThongKeThang);
            this.grp_ThongKeNgay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_ThongKeNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKeNgay.Location = new System.Drawing.Point(0, 164);
            this.grp_ThongKeNgay.Name = "grp_ThongKeNgay";
            this.grp_ThongKeNgay.Size = new System.Drawing.Size(1455, 583);
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
            this.dgv_ThongKeThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKeThang.Location = new System.Drawing.Point(3, 26);
            this.dgv_ThongKeThang.Name = "dgv_ThongKeThang";
            this.dgv_ThongKeThang.RowHeadersWidth = 50;
            this.dgv_ThongKeThang.RowTemplate.Height = 24;
            this.dgv_ThongKeThang.Size = new System.Drawing.Size(1449, 554);
            this.dgv_ThongKeThang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
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
            this.label1.Size = new System.Drawing.Size(1455, 63);
            this.label1.TabIndex = 117;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - THÁNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_ThongKeThang
            // 
            this.cbo_ThongKeThang.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbo_ThongKeThang.Location = new System.Drawing.Point(288, 92);
            this.cbo_ThongKeThang.Name = "cbo_ThongKeThang";
            this.cbo_ThongKeThang.Size = new System.Drawing.Size(299, 45);
            this.cbo_ThongKeThang.TabIndex = 114;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayLap";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // SoLuongDon
            // 
            this.SoLuongDon.DataPropertyName = "SoLuongDon";
            this.SoLuongDon.HeaderText = "Số Lượng Đơn";
            this.SoLuongDon.MinimumWidth = 6;
            this.SoLuongDon.Name = "SoLuongDon";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrungBinh
            // 
            this.TrungBinh.DataPropertyName = "TrungBinh";
            this.TrungBinh.HeaderText = "Trung Bình";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 118;
            this.label3.Text = "NĂM";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbo_Nam.Location = new System.Drawing.Point(885, 88);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(299, 45);
            this.cbo_Nam.TabIndex = 114;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(1249, 88);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(144, 44);
            this.btn_ThongKe.TabIndex = 123;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // frm_ThongKeThang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1455, 747);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.cbo_ThongKeThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grp_ThongKeNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongKeThang";
            this.Text = "frm_ThongKeThang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeThang_Load);
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
        private System.Windows.Forms.ComboBox cbo_ThongKeThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}