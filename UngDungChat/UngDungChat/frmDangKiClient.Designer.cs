
namespace UngDungChat
{
    partial class frmDangKiClient
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(324, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(190, 185);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(235, 43);
            this.txbMatKhau.TabIndex = 6;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(190, 125);
            this.txbTaiKhoan.Multiline = true;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(239, 40);
            this.txbTaiKhoan.TabIndex = 4;
            this.txbTaiKhoan.UseSystemPasswordChar = true;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(51, 188);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lbMatKhau.TabIndex = 7;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(190, 261);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(107, 38);
            this.btnDangKi.TabIndex = 8;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(51, 128);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(95, 17);
            this.lbTaiKhoan.TabIndex = 5;
            this.lbTaiKhoan.Text = "Tên tài khoản";
            // 
            // frmDangKiClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.lbTaiKhoan);
            this.Name = "frmDangKiClient";
            this.Text = "DangKiClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangKiClient_FormClosed);
            this.Load += new System.EventHandler(this.frmDangKiClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label lbTaiKhoan;
    }
}