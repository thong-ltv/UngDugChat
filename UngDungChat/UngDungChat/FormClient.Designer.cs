
namespace UngDungChat
{
    partial class FormClient
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
            this.lbHienThi = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDangXuat1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHienThi
            // 
            this.lbHienThi.FormattingEnabled = true;
            this.lbHienThi.ItemHeight = 16;
            this.lbHienThi.Location = new System.Drawing.Point(28, 116);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(665, 244);
            this.lbHienThi.TabIndex = 17;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(28, 378);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(530, 55);
            this.txtSend.TabIndex = 16;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(544, 81);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(149, 29);
            this.txtPort.TabIndex = 15;
            this.txtPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPort_KeyDown);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(122, 77);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(230, 29);
            this.txtIP.TabIndex = 14;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(491, 85);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(47, 25);
            this.lbPort.TabIndex = 13;
            this.lbPort.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Địa chỉ IP";
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(590, 378);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(103, 55);
            this.btnGui.TabIndex = 11;
            this.btnGui.Text = "Gui";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(423, 22);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(135, 51);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(27, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 51);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDangXuat1
            // 
            this.btnDangXuat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat1.Location = new System.Drawing.Point(584, 22);
            this.btnDangXuat1.Name = "btnDangXuat1";
            this.btnDangXuat1.Size = new System.Drawing.Size(109, 51);
            this.btnDangXuat1.TabIndex = 18;
            this.btnDangXuat1.Text = "Thoát";
            this.btnDangXuat1.UseVisualStyleBackColor = true;
            this.btnDangXuat1.Click += new System.EventHandler(this.btnDangXuat1_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnDangXuat1);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "FormClient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHienThi;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDangXuat1;
    }
}