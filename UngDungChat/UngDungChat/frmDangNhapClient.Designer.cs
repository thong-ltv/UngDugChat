
namespace UngDungChat
{
    partial class frmDangNhapClient
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
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(305, 217);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(95, 47);
            this.btnDangKi.TabIndex = 17;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(180, 217);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(92, 47);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 140);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(220, 35);
            this.txtMatKhau.TabIndex = 15;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(180, 69);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(220, 34);
            this.txtTaiKhoan.TabIndex = 14;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(60, 140);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lbMatKhau.TabIndex = 13;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(55, 69);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(71, 17);
            this.lbTaiKhoan.TabIndex = 12;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // frmDangNhapClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 346);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Name = "frmDangNhapClient";
            this.Text = "DangNhapClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhapClient_FormClosed);
            this.Load += new System.EventHandler(this.frmDangNhapClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
    }
}