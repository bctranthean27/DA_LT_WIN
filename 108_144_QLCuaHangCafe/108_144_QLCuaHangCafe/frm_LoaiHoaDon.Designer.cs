namespace _108_144_QLCuaHangCafe
{
    partial class frm_LoaiHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TenLoaiHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaLoaiHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1335, 330);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hoá Đơn";
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSach.ColumnHeadersHeight = 45;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiHD,
            this.TenLoaiHD,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.EnableHeadersVisualStyles = false;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 26);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSach.RowHeadersWidth = 50;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1329, 301);
            this.dgv_DanhSach.TabIndex = 0;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            this.dgv_DanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellValueChanged);
            // 
            // MaLoaiHD
            // 
            this.MaLoaiHD.DataPropertyName = "MaLoaiHD";
            this.MaLoaiHD.HeaderText = "Mã Loại Hoá Đơn";
            this.MaLoaiHD.MinimumWidth = 6;
            this.MaLoaiHD.Name = "MaLoaiHD";
            this.MaLoaiHD.ReadOnly = true;
            // 
            // TenLoaiHD
            // 
            this.TenLoaiHD.DataPropertyName = "TenLoaiHD";
            this.TenLoaiHD.HeaderText = "Tên Loại Hoá Đơn";
            this.TenLoaiHD.MinimumWidth = 6;
            this.TenLoaiHD.Name = "TenLoaiHD";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // txt_TenLoaiHD
            // 
            this.txt_TenLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.txt_TenLoaiHD.Location = new System.Drawing.Point(255, 242);
            this.txt_TenLoaiHD.Name = "txt_TenLoaiHD";
            this.txt_TenLoaiHD.Size = new System.Drawing.Size(299, 34);
            this.txt_TenLoaiHD.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(32, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 31);
            this.label10.TabIndex = 94;
            this.label10.Text = "Tên Loại Hoá Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 31);
            this.label2.TabIndex = 91;
            this.label2.Text = "Mã Loại Hoá Đơn";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btn_Exit.Location = new System.Drawing.Point(1122, 154);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 55);
            this.btn_Exit.TabIndex = 80;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.White;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btn_Luu.Location = new System.Drawing.Point(895, 101);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(150, 55);
            this.btn_Luu.TabIndex = 79;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btn_Sua.Location = new System.Drawing.Point(664, 221);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(150, 55);
            this.btn_Sua.TabIndex = 78;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btn_Xoa.Location = new System.Drawing.Point(895, 221);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 55);
            this.btn_Xoa.TabIndex = 77;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btn_Them.Location = new System.Drawing.Point(664, 100);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(150, 55);
            this.btn_Them.TabIndex = 76;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaLoaiHD
            // 
            this.txt_MaLoaiHD.BackColor = System.Drawing.Color.White;
            this.txt_MaLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.txt_MaLoaiHD.Location = new System.Drawing.Point(255, 103);
            this.txt_MaLoaiHD.Name = "txt_MaLoaiHD";
            this.txt_MaLoaiHD.ReadOnly = true;
            this.txt_MaLoaiHD.Size = new System.Drawing.Size(299, 34);
            this.txt_MaLoaiHD.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1335, 63);
            this.label6.TabIndex = 125;
            this.label6.Text = "CẬP NHẬT LOẠI HOÁ ĐƠN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_LoaiHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(250)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1335, 683);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_MaLoaiHD);
            this.Controls.Add(this.txt_TenLoaiHD);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.Name = "frm_LoaiHoaDon";
            this.Text = "frm_LoaiHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_LoaiHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.TextBox txt_TenLoaiHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaLoaiHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}