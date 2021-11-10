
namespace UngDungChat
{
    partial class frmDangKi
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
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(89, 88);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(131, 25);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tên tài khoản";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(228, 221);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(107, 38);
            this.btnDangKi.TabIndex = 2;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(89, 148);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(228, 85);
            this.txbTaiKhoan.Multiline = true;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(239, 40);
            this.txbTaiKhoan.TabIndex = 0;
            this.txbTaiKhoan.UseSystemPasswordChar = true;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(228, 145);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(235, 43);
            this.txbMatKhau.TabIndex = 1;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(362, 223);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(565, 406);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.lbTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangKi";
            this.Text = "Đăng kí thông tin người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangKi_FormClosed);
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnThoat;
    }
}