namespace _108_144_QLCuaHangCafe
{
    partial class frm_SearchKH
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_SearchKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1002, 99);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 34);
            this.btn_Search.TabIndex = 76;
            this.btn_Search.Text = "TÌM";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DienThoai.Location = new System.Drawing.Point(667, 99);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(299, 34);
            this.txt_DienThoai.TabIndex = 66;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(164, 98);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(299, 34);
            this.txt_TenKH.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nhập Tên";
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
            this.label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_SearchKH
            // 
            this.dgv_SearchKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.DienThoai,
            this.Mail});
            this.dgv_SearchKH.Location = new System.Drawing.Point(6, 31);
            this.dgv_SearchKH.Name = "dgv_SearchKH";
            this.dgv_SearchKH.RowHeadersWidth = 50;
            this.dgv_SearchKH.RowTemplate.Height = 24;
            this.dgv_SearchKH.Size = new System.Drawing.Size(1117, 470);
            this.dgv_SearchKH.TabIndex = 0;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Số Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Email";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SearchKH);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 507);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // frm_SearchKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DienThoai);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_SearchKH";
            this.Text = "frm_SearchKH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_SearchKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}