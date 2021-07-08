namespace PhanMemQLTV
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenCD = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radMaSach = new System.Windows.Forms.RadioButton();
            this.dataGridViewDSSach0 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach0)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grpTimKiem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(33, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 96);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm Sách";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.txtNDTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(435, 19);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(243, 60);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(218, 23);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenCD);
            this.groupBox4.Controls.Add(this.radTenTG);
            this.groupBox4.Controls.Add(this.radTenSach);
            this.groupBox4.Controls.Add(this.radMaSach);
            this.groupBox4.Location = new System.Drawing.Point(31, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 60);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // radTenCD
            // 
            this.radTenCD.AutoSize = true;
            this.radTenCD.Location = new System.Drawing.Point(296, 24);
            this.radTenCD.Name = "radTenCD";
            this.radTenCD.Size = new System.Drawing.Size(71, 20);
            this.radTenCD.TabIndex = 3;
            this.radTenCD.TabStop = true;
            this.radTenCD.Text = "Tên CD";
            this.radTenCD.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            this.radTenTG.AutoSize = true;
            this.radTenTG.Location = new System.Drawing.Point(208, 24);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(71, 20);
            this.radTenTG.TabIndex = 2;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tên TG";
            this.radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenSach
            // 
            this.radTenSach.AutoSize = true;
            this.radTenSach.Location = new System.Drawing.Point(111, 24);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(80, 20);
            this.radTenSach.TabIndex = 1;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tên Sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            // 
            // radMaSach
            // 
            this.radMaSach.AutoSize = true;
            this.radMaSach.Location = new System.Drawing.Point(18, 24);
            this.radMaSach.Name = "radMaSach";
            this.radMaSach.Size = new System.Drawing.Size(76, 20);
            this.radMaSach.TabIndex = 0;
            this.radMaSach.TabStop = true;
            this.radMaSach.Text = "Mã Sách";
            this.radMaSach.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDSSach0
            // 
            this.dataGridViewDSSach0.AllowUserToAddRows = false;
            this.dataGridViewDSSach0.AllowUserToDeleteRows = false;
            this.dataGridViewDSSach0.AllowUserToResizeRows = false;
            this.dataGridViewDSSach0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenSach,
            this.colTenLoai,
            this.colTenTG,
            this.colMaNXB,
            this.colNamXB,
            this.colSoLuong,
            this.colTriGia,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewDSSach0.Location = new System.Drawing.Point(16, 27);
            this.dataGridViewDSSach0.Name = "dataGridViewDSSach0";
            this.dataGridViewDSSach0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSSach0.Size = new System.Drawing.Size(707, 176);
            this.dataGridViewDSSach0.TabIndex = 6;
            this.dataGridViewDSSach0.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSach0_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            this.colTenSach.Width = 140;
            // 
            // colTenLoai
            // 
            this.colTenLoai.DataPropertyName = "TheLoai";
            this.colTenLoai.HeaderText = "Chủ Đề";
            this.colTenLoai.Name = "colTenLoai";
            this.colTenLoai.ReadOnly = true;
            this.colTenLoai.Width = 80;
            // 
            // colTenTG
            // 
            this.colTenTG.DataPropertyName = "TacGia";
            this.colTenTG.HeaderText = "Tác Giả";
            this.colTenTG.Name = "colTenTG";
            this.colTenTG.ReadOnly = true;
            // 
            // colMaNXB
            // 
            this.colMaNXB.DataPropertyName = "NXB";
            this.colMaNXB.HeaderText = "NXB";
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.ReadOnly = true;
            // 
            // colNamXB
            // 
            this.colNamXB.DataPropertyName = "NamXB";
            this.colNamXB.HeaderText = "Năm XB";
            this.colNamXB.Name = "colNamXB";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SLNhap";
            this.colSoLuong.HeaderText = "SL Nhập";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 50;
            // 
            // colTriGia
            // 
            this.colTriGia.DataPropertyName = "TriGia";
            this.colTriGia.HeaderText = "Đơn Giá";
            this.colTriGia.Name = "colTriGia";
            this.colTriGia.ReadOnly = true;
            this.colTriGia.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TinhTrang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tình Trạng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDSSach0);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sách";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDocGia";
            this.Text = "frmDocGia";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.groupBox3.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach0)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenCD;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private System.Windows.Forms.DataGridView dataGridViewDSSach0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}