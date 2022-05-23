namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeNgay
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_MinNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grp_ThongKeNgay = new System.Windows.Forms.GroupBox();
            this.dgv_ThongKeNgay = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongKeNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ HOÁ ĐƠN - NGÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Ngày Từ";
            // 
            // dtp_MinNgay
            // 
            this.dtp_MinNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_MinNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_MinNgay.Location = new System.Drawing.Point(288, 89);
            this.dtp_MinNgay.Name = "dtp_MinNgay";
            this.dtp_MinNgay.Size = new System.Drawing.Size(333, 34);
            this.dtp_MinNgay.TabIndex = 11;
            this.dtp_MinNgay.Value = new System.DateTime(2000, 1, 1, 16, 23, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(722, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 34);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 23, 16, 23, 46, 0);
            // 
            // grp_ThongKeNgay
            // 
            this.grp_ThongKeNgay.Controls.Add(this.dgv_ThongKeNgay);
            this.grp_ThongKeNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongKeNgay.Location = new System.Drawing.Point(12, 138);
            this.grp_ThongKeNgay.Name = "grp_ThongKeNgay";
            this.grp_ThongKeNgay.Size = new System.Drawing.Size(1154, 526);
            this.grp_ThongKeNgay.TabIndex = 116;
            this.grp_ThongKeNgay.TabStop = false;
            this.grp_ThongKeNgay.Text = "Bảng Thống Kê Hoá Đơn Theo Ngày";
            // 
            // dgv_ThongKeNgay
            // 
            this.dgv_ThongKeNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgv_ThongKeNgay.Location = new System.Drawing.Point(6, 31);
            this.dgv_ThongKeNgay.Name = "dgv_ThongKeNgay";
            this.dgv_ThongKeNgay.RowHeadersWidth = 50;
            this.dgv_ThongKeNgay.RowTemplate.Height = 24;
            this.dgv_ThongKeNgay.Size = new System.Drawing.Size(1142, 489);
            this.dgv_ThongKeNgay.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // frm_ThongKeNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 676);
            this.Controls.Add(this.grp_ThongKeNgay);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtp_MinNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongKeNgay";
            this.Text = "ThongKeNgay";
            this.grp_ThongKeNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_MinNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grp_ThongKeNgay;
        private System.Windows.Forms.DataGridView dgv_ThongKeNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}