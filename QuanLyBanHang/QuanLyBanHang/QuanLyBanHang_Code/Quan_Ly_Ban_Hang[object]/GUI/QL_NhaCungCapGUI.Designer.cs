﻿namespace QL_BanHang
{
    partial class QL_NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NhaCungCap));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaNCCSearch = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbMaNcc = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(239, 330);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 47);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(60, 332);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 47);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.SDT,
            this.DiaChi});
            this.dgvHienThi.Location = new System.Drawing.Point(8, 18);
            this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.Size = new System.Drawing.Size(1037, 258);
            this.dgvHienThi.TabIndex = 0;
            this.dgvHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvHienThi);
            this.groupBox2.Location = new System.Drawing.Point(52, 387);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1053, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(412, 331);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 47);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNCC.Location = new System.Drawing.Point(218, 44);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(325, 22);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(218, 151);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(325, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNCC.Location = new System.Drawing.Point(218, 98);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(325, 22);
            this.txtTenNCC.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(218, 208);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(325, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(587, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(592, 332);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 47);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(955, 330);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 48);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(773, 330);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 48);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaNCCSearch);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Controls.Add(this.rbMaNcc);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Location = new System.Drawing.Point(669, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(436, 191);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtMaNCCSearch
            // 
            this.txtMaNCCSearch.Location = new System.Drawing.Point(177, 49);
            this.txtMaNCCSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNCCSearch.Name = "txtMaNCCSearch";
            this.txtMaNCCSearch.Size = new System.Drawing.Size(223, 22);
            this.txtMaNCCSearch.TabIndex = 2;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(28, 96);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(80, 24);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất Cả";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbMaNcc
            // 
            this.rbMaNcc.AutoSize = true;
            this.rbMaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaNcc.Location = new System.Drawing.Point(28, 47);
            this.rbMaNcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaNcc.Name = "rbMaNcc";
            this.rbMaNcc.Size = new System.Drawing.Size(125, 24);
            this.rbMaNcc.TabIndex = 0;
            this.rbMaNcc.TabStop = true;
            this.rbMaNcc.Text = "Mã loại hàng";
            this.rbMaNcc.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(177, 132);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(157, 41);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // QL_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1017, 520);
            this.Name = "QL_NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.QL_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaNCCSearch;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbMaNcc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}