﻿
namespace PhanMemQLTV
{
    partial class frmPhieuthutienphat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuthutienphat));
            this.lblNhapCD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtHotenDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotienthu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConlai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblNhapCD
            // 
            this.lblNhapCD.AutoSize = true;
            this.lblNhapCD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNhapCD.Location = new System.Drawing.Point(668, 58);
            this.lblNhapCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapCD.Name = "lblNhapCD";
            this.lblNhapCD.Size = new System.Drawing.Size(0, 22);
            this.lblNhapCD.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(132, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Độc giả:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaDG.Location = new System.Drawing.Point(299, 63);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(295, 30);
            this.txtMaDG.TabIndex = 14;
            this.txtMaDG.TextChanged += new System.EventHandler(this.txtMaDG_TextChanged);
            // 
            // txtHotenDG
            // 
            this.txtHotenDG.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtHotenDG.Location = new System.Drawing.Point(302, 178);
            this.txtHotenDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHotenDG.Name = "txtHotenDG";
            this.txtHotenDG.Size = new System.Drawing.Size(292, 30);
            this.txtHotenDG.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label5.Location = new System.Drawing.Point(132, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Họ tên Độc Giả :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTongno
            // 
            this.txtTongno.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTongno.Location = new System.Drawing.Point(302, 266);
            this.txtTongno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongno.Name = "txtTongno";
            this.txtTongno.Size = new System.Drawing.Size(292, 30);
            this.txtTongno.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(132, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng nợ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSotienthu
            // 
            this.txtSotienthu.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSotienthu.Location = new System.Drawing.Point(302, 369);
            this.txtSotienthu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSotienthu.MaxLength = 9;
            this.txtSotienthu.Name = "txtSotienthu";
            this.txtSotienthu.Size = new System.Drawing.Size(292, 30);
            this.txtSotienthu.TabIndex = 20;
            this.txtSotienthu.TextChanged += new System.EventHandler(this.txtSotienthu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(132, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số tiền thu :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConlai
            // 
            this.txtConlai.Enabled = false;
            this.txtConlai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtConlai.Location = new System.Drawing.Point(302, 457);
            this.txtConlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConlai.Name = "txtConlai";
            this.txtConlai.Size = new System.Drawing.Size(292, 30);
            this.txtConlai.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label6.Location = new System.Drawing.Point(132, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Còn lại :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(795, 405);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 77);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPhieuthutienphat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 540);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtConlai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSotienthu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotenDG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNhapCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDG);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhieuthutienphat";
            this.Text = "Phiếu thu tiền phạt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtHotenDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSotienthu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConlai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}