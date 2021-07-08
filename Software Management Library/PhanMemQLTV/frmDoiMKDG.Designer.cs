namespace PhanMemQLTV
{
    partial class frmDoiMKDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMKDG));
            this.chkNhapLaiMatKhau = new System.Windows.Forms.CheckBox();
            this.chkMatKhauMoi = new System.Windows.Forms.CheckBox();
            this.chkMatKhauCu = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkNhapLaiMatKhau
            // 
            this.chkNhapLaiMatKhau.AutoSize = true;
            this.chkNhapLaiMatKhau.Location = new System.Drawing.Point(348, 129);
            this.chkNhapLaiMatKhau.Name = "chkNhapLaiMatKhau";
            this.chkNhapLaiMatKhau.Size = new System.Drawing.Size(54, 20);
            this.chkNhapLaiMatKhau.TabIndex = 21;
            this.chkNhapLaiMatKhau.Text = "Xem";
            this.chkNhapLaiMatKhau.UseVisualStyleBackColor = true;
            this.chkNhapLaiMatKhau.CheckedChanged += new System.EventHandler(this.chkNhapLaiMatKhau_CheckedChanged);
            // 
            // chkMatKhauMoi
            // 
            this.chkMatKhauMoi.AutoSize = true;
            this.chkMatKhauMoi.Location = new System.Drawing.Point(349, 93);
            this.chkMatKhauMoi.Name = "chkMatKhauMoi";
            this.chkMatKhauMoi.Size = new System.Drawing.Size(54, 20);
            this.chkMatKhauMoi.TabIndex = 20;
            this.chkMatKhauMoi.Text = "Xem";
            this.chkMatKhauMoi.UseVisualStyleBackColor = true;
            this.chkMatKhauMoi.CheckedChanged += new System.EventHandler(this.chkMatKhauMoi_CheckedChanged);
            // 
            // chkMatKhauCu
            // 
            this.chkMatKhauCu.AutoSize = true;
            this.chkMatKhauCu.Location = new System.Drawing.Point(349, 60);
            this.chkMatKhauCu.Name = "chkMatKhauCu";
            this.chkMatKhauCu.Size = new System.Drawing.Size(54, 20);
            this.chkMatKhauCu.TabIndex = 19;
            this.chkMatKhauCu.Text = "Xem";
            this.chkMatKhauCu.UseVisualStyleBackColor = true;
            this.chkMatKhauCu.CheckedChanged += new System.EventHandler(this.chkMatKhauCu_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên tài khoản: ";
            // 
            // txtNhapLaiMKMoi
            // 
            this.txtNhapLaiMKMoi.Location = new System.Drawing.Point(165, 127);
            this.txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            this.txtNhapLaiMKMoi.Size = new System.Drawing.Size(175, 23);
            this.txtNhapLaiMKMoi.TabIndex = 16;
            this.txtNhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(231, 177);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 39);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoSize = true;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(59, 177);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(111, 39);
            this.btnDoiMatKhau.TabIndex = 17;
            this.btnDoiMatKhau.Text = "Hoàn thành";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(165, 91);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(175, 23);
            this.txtMatKhauMoi.TabIndex = 15;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(165, 55);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(175, 23);
            this.txtMatKhau.TabIndex = 10;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(165, 21);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(175, 23);
            this.txtTenTaiKhoan.TabIndex = 9;
            // 
            // frmDoiMKDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 239);
            this.Controls.Add(this.chkNhapLaiMatKhau);
            this.Controls.Add(this.chkMatKhauMoi);
            this.Controls.Add(this.chkMatKhauCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapLaiMKMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmDoiMKDG";
            this.Text = "frmDoiMKDG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNhapLaiMatKhau;
        private System.Windows.Forms.CheckBox chkMatKhauMoi;
        private System.Windows.Forms.CheckBox chkMatKhauCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapLaiMKMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
    }
}