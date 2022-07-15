namespace _108_144_QLCuaHangCafe
{
    partial class frm_ThongKeLoiNhuan
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
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.lbl_doanhthuMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_thangMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TrungBinhNam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_LoiNhuanNam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ThongKeNam = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNam)).BeginInit();
            this.SuspendLayout();
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
            this.cbo_Nam.TabIndex = 148;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
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
            this.lbl_doanhthuMax.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1054, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 31);
            this.label6.TabIndex = 146;
            this.label6.Text = "Lợi Nhuận Tháng Cao Nhất";
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
            this.lbl_thangMax.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1054, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 31);
            this.label7.TabIndex = 144;
            this.label7.Text = "Tháng Có Lợi Nhuận Cao Nhất";
            // 
            // lbl_TrungBinhNam
            // 
            this.lbl_TrungBinhNam.BackColor = System.Drawing.Color.White;
            this.lbl_TrungBinhNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TrungBinhNam.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrungBinhNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_TrungBinhNam.Location = new System.Drawing.Point(1060, 336);
            this.lbl_TrungBinhNam.Name = "lbl_TrungBinhNam";
            this.lbl_TrungBinhNam.Size = new System.Drawing.Size(350, 45);
            this.lbl_TrungBinhNam.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1054, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 31);
            this.label5.TabIndex = 142;
            this.label5.Text = "Lợi Nhuận Trung Bình Tháng";
            // 
            // lbl_LoiNhuanNam
            // 
            this.lbl_LoiNhuanNam.BackColor = System.Drawing.Color.White;
            this.lbl_LoiNhuanNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LoiNhuanNam.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoiNhuanNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.lbl_LoiNhuanNam.Location = new System.Drawing.Point(1060, 228);
            this.lbl_LoiNhuanNam.Name = "lbl_LoiNhuanNam";
            this.lbl_LoiNhuanNam.Size = new System.Drawing.Size(350, 45);
            this.lbl_LoiNhuanNam.TabIndex = 141;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ThongKeNam);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 583);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thống Kê Hoá Đơn Theo Năm";
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKeNam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongKeNam.ColumnHeadersHeight = 45;
            this.dgv_ThongKeNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ThongKeNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.VonNhapHang,
            this.DoanhThu,
            this.LoiNhuan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1054, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 140;
            this.label3.Text = "Tổng Lợi Nhuận Năm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 138;
            this.label2.Text = "Chọn Năm";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1439, 63);
            this.label1.TabIndex = 137;
            this.label1.Text = "THỐNG KÊ LỢI NHUẬN THEO NĂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // VonNhapHang
            // 
            this.VonNhapHang.DataPropertyName = "VonNhapHang";
            this.VonNhapHang.HeaderText = "Vốn Nhập Hàng";
            this.VonNhapHang.MinimumWidth = 6;
            this.VonNhapHang.Name = "VonNhapHang";
            this.VonNhapHang.ReadOnly = true;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.DataPropertyName = "LoiNhuan";
            this.LoiNhuan.HeaderText = "Lợi Nhuận";
            this.LoiNhuan.MinimumWidth = 6;
            this.LoiNhuan.Name = "LoiNhuan";
            this.LoiNhuan.ReadOnly = true;
            // 
            // frm_ThongKeLoiNhuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1439, 735);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.lbl_doanhthuMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_thangMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_TrungBinhNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_LoiNhuanNam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.Name = "frm_ThongKeLoiNhuan";
            this.Text = "frm_ThongKeLoiNhuan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKeLoiNhuan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.Label lbl_doanhthuMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_thangMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TrungBinhNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_LoiNhuanNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ThongKeNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiNhuan;
    }
}