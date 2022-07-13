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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ThongKeNam = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TopDoanhThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 38);
            this.label2.TabIndex = 125;
            this.label2.Text = "NĂM";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1439, 63);
            this.label1.TabIndex = 124;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - NĂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ThongKeNam
            // 
            this.dgv_ThongKeNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            this.dgv_ThongKeNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKeNam.Location = new System.Drawing.Point(3, 26);
            this.dgv_ThongKeNam.Name = "dgv_ThongKeNam";
            this.dgv_ThongKeNam.RowHeadersWidth = 50;
            this.dgv_ThongKeNam.RowTemplate.Height = 24;
            this.dgv_ThongKeNam.Size = new System.Drawing.Size(1433, 554);
            this.dgv_ThongKeNam.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ThongKeNam);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1439, 583);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thống Kê Hoá Đơn Theo Năm";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.ItemHeight = 16;
            this.cbo_Nam.Location = new System.Drawing.Point(730, 103);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(299, 24);
            this.cbo_Nam.TabIndex = 127;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
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
            // btn_TopDoanhThu
            // 
            this.btn_TopDoanhThu.Location = new System.Drawing.Point(1095, 91);
            this.btn_TopDoanhThu.Name = "btn_TopDoanhThu";
            this.btn_TopDoanhThu.Size = new System.Drawing.Size(145, 55);
            this.btn_TopDoanhThu.TabIndex = 128;
            this.btn_TopDoanhThu.Text = "Tháng có doanh thu cao nhất";
            this.btn_TopDoanhThu.UseVisualStyleBackColor = true;
            this.btn_TopDoanhThu.Click += new System.EventHandler(this.btn_TopDoanhThu_Click);
            // 
            // frm_ThongKeNam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1439, 735);
            this.Controls.Add(this.btn_TopDoanhThu);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.Button btn_TopDoanhThu;
    }
}