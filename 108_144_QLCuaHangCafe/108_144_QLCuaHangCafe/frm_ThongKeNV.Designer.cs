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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ThongKeNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ThongKeNam = new System.Windows.Forms.TextBox();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 129;
            this.label2.Text = "NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1129, 63);
            this.label1.TabIndex = 128;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ThongKeNV
            // 
            this.dgv_ThongKeNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.SoLuongDon,
            this.TongTien,
            this.TrungBinh});
            this.dgv_ThongKeNV.Location = new System.Drawing.Point(15, 31);
            this.dgv_ThongKeNV.Name = "dgv_ThongKeNV";
            this.dgv_ThongKeNV.RowHeadersWidth = 50;
            this.dgv_ThongKeNV.RowTemplate.Height = 24;
            this.dgv_ThongKeNV.Size = new System.Drawing.Size(1088, 546);
            this.dgv_ThongKeNV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ThongKeNV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 583);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thống Kê Hoá Đơn Theo Nhân Viên";
            // 
            // txt_ThongKeNam
            // 
            this.txt_ThongKeNam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThongKeNam.Location = new System.Drawing.Point(509, 94);
            this.txt_ThongKeNam.Name = "txt_ThongKeNam";
            this.txt_ThongKeNam.Size = new System.Drawing.Size(279, 34);
            this.txt_ThongKeNam.TabIndex = 131;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // SoLuongDon
            // 
            this.SoLuongDon.HeaderText = "Số Lượng Đơn";
            this.SoLuongDon.MinimumWidth = 6;
            this.SoLuongDon.Name = "SoLuongDon";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrungBinh
            // 
            this.TrungBinh.HeaderText = "Trung Bình";
            this.TrungBinh.MinimumWidth = 6;
            this.TrungBinh.Name = "TrungBinh";
            // 
            // frm_ThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_ThongKeNam);
            this.Name = "frm_ThongKeNV";
            this.Text = "frm_ThongKeNV";
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
        private System.Windows.Forms.TextBox txt_ThongKeNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}