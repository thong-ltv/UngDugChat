
namespace UngDungChat
{
    partial class frmAdmmin
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
            this.lbDanhSachTaiKhoan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.GroupBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lbPhanQuyen = new System.Windows.Forms.Label();
            this.txbPhanQuyen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDanhSachTaiKhoan
            // 
            this.lbDanhSachTaiKhoan.AutoSize = true;
            this.lbDanhSachTaiKhoan.Location = new System.Drawing.Point(219, 42);
            this.lbDanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDanhSachTaiKhoan.Name = "lbDanhSachTaiKhoan";
            this.lbDanhSachTaiKhoan.Size = new System.Drawing.Size(172, 20);
            this.lbDanhSachTaiKhoan.TabIndex = 1;
            this.lbDanhSachTaiKhoan.Text = "Danh Sách Tài Khoàn";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(692, 218);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 56);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(692, 297);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 62);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(59, 381);
            this.lbTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(125, 20);
            this.lbTenDangNhap.TabIndex = 4;
            this.lbTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(59, 441);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(80, 20);
            this.lbMatKhau.TabIndex = 5;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(209, 378);
            this.txbTenDangNhap.Multiline = true;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(171, 36);
            this.txbTenDangNhap.TabIndex = 6;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(209, 438);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(171, 32);
            this.txbMatKhau.TabIndex = 7;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(747, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(125, 61);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // g
            // 
            this.g.AccessibleDescription = "gbThongTin";
            this.g.Controls.Add(this.dgvThongTin);
            this.g.Location = new System.Drawing.Point(32, 80);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(629, 279);
            this.g.TabIndex = 9;
            this.g.TabStop = false;
            this.g.Text = "Thông tin";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(17, 23);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTin.Size = new System.Drawing.Size(596, 243);
            this.dgvThongTin.TabIndex = 0;
            this.dgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellClick);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(692, 131);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(125, 57);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lbPhanQuyen
            // 
            this.lbPhanQuyen.AutoSize = true;
            this.lbPhanQuyen.Location = new System.Drawing.Point(59, 494);
            this.lbPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhanQuyen.Name = "lbPhanQuyen";
            this.lbPhanQuyen.Size = new System.Drawing.Size(100, 20);
            this.lbPhanQuyen.TabIndex = 11;
            this.lbPhanQuyen.Text = "Phân Quyền";
            // 
            // txbPhanQuyen
            // 
            this.txbPhanQuyen.Location = new System.Drawing.Point(209, 494);
            this.txbPhanQuyen.Multiline = true;
            this.txbPhanQuyen.Name = "txbPhanQuyen";
            this.txbPhanQuyen.Size = new System.Drawing.Size(105, 33);
            this.txbPhanQuyen.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(692, 398);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 63);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.Location = new System.Drawing.Point(209, 548);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(171, 40);
            this.btnXoaHet.TabIndex = 14;
            this.btnXoaHet.Text = "Xóa dữ liệu trên ô";
            this.btnXoaHet.UseVisualStyleBackColor = true;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // frmAdmmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 620);
            this.Controls.Add(this.btnXoaHet);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbPhanQuyen);
            this.Controls.Add(this.lbPhanQuyen);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.g);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbDanhSachTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmmin_Load);
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDanhSachTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lbPhanQuyen;
        private System.Windows.Forms.TextBox txbPhanQuyen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaHet;
    }
}