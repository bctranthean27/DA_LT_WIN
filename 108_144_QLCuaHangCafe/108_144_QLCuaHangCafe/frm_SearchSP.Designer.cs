namespace _108_144_QLCuaHangCafe
{
    partial class frm_SearchSP
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MinGiaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaxGiaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.dgv_SearchSP = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbo_LoaiSP = new System.Windows.Forms.ComboBox();
            this.cbo_Size = new System.Windows.Forms.ComboBox();
            this.cbo_NCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchSP)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Giá Từ";
            // 
            // txt_MinGiaSP
            // 
            this.txt_MinGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MinGiaSP.Location = new System.Drawing.Point(212, 89);
            this.txt_MinGiaSP.Name = "txt_MinGiaSP";
            this.txt_MinGiaSP.Size = new System.Drawing.Size(299, 34);
            this.txt_MinGiaSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến";
            // 
            // txt_MaxGiaSP
            // 
            this.txt_MaxGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaxGiaSP.Location = new System.Drawing.Point(681, 89);
            this.txt_MaxGiaSP.Name = "txt_MaxGiaSP";
            this.txt_MaxGiaSP.Size = new System.Drawing.Size(299, 34);
            this.txt_MaxGiaSP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng Thái";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(681, 208);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(299, 37);
            this.cbo_TrangThai.TabIndex = 8;
            // 
            // dgv_SearchSP
            // 
            this.dgv_SearchSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenLoaiSP,
            this.TenNCC,
            this.TrangThai});
            this.dgv_SearchSP.Location = new System.Drawing.Point(6, 31);
            this.dgv_SearchSP.Name = "dgv_SearchSP";
            this.dgv_SearchSP.RowHeadersWidth = 50;
            this.dgv_SearchSP.RowTemplate.Height = 24;
            this.dgv_SearchSP.Size = new System.Drawing.Size(1146, 369);
            this.dgv_SearchSP.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.HeaderText = "Loại Sản Phẩm";
            this.TenLoaiSP.MinimumWidth = 6;
            this.TenLoaiSP.Name = "TenLoaiSP";
            // 
            // TenNCC
            // 
            this.TenNCC.HeaderText = "Nhà Cung Cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SearchSP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 406);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1002, 89);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 156);
            this.btn_Search.TabIndex = 61;
            this.btn_Search.Text = "TÌM";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // cbo_LoaiSP
            // 
            this.cbo_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiSP.FormattingEnabled = true;
            this.cbo_LoaiSP.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_LoaiSP.Location = new System.Drawing.Point(212, 142);
            this.cbo_LoaiSP.Name = "cbo_LoaiSP";
            this.cbo_LoaiSP.Size = new System.Drawing.Size(299, 37);
            this.cbo_LoaiSP.TabIndex = 8;
            // 
            // cbo_Size
            // 
            this.cbo_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Size.FormattingEnabled = true;
            this.cbo_Size.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_Size.Location = new System.Drawing.Point(681, 147);
            this.cbo_Size.Name = "cbo_Size";
            this.cbo_Size.Size = new System.Drawing.Size(299, 37);
            this.cbo_Size.TabIndex = 8;
            // 
            // cbo_NCC
            // 
            this.cbo_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NCC.FormattingEnabled = true;
            this.cbo_NCC.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbo_NCC.Location = new System.Drawing.Point(212, 208);
            this.cbo_NCC.Name = "cbo_NCC";
            this.cbo_NCC.Size = new System.Drawing.Size(299, 37);
            this.cbo_NCC.TabIndex = 8;
            // 
            // frm_SearchSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 676);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_NCC);
            this.Controls.Add(this.cbo_LoaiSP);
            this.Controls.Add(this.cbo_Size);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaxGiaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MinGiaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SearchSP";
            this.Text = "frm_SearchSP";
            this.Load += new System.EventHandler(this.frm_SearchSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MinGiaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaxGiaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.DataGridView dgv_SearchSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_LoaiSP;
        private System.Windows.Forms.ComboBox cbo_Size;
        private System.Windows.Forms.ComboBox cbo_NCC;
    }
}