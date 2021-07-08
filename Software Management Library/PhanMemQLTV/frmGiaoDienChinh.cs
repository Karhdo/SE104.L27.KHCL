using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLSach QLSach = new frmQLSach();
            QLSach.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia = new frmQLDocGia();
            QLDocGia.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra QLMuonTra = new frmQLMuonTra();
            QLMuonTra.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BaoCaoThongKe = new frmBaoCaoThongKe();
            BaoCaoThongKe.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyTT DKTT = new frmDangKyTT();
            DKTT.Show();
        }

        private void đổiMậtKhậuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau DoiMKTT = new frmDoiMatKhau();
            DoiMKTT.Show();
        }

        private void phiếuThuTiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuthutienphat Thutienphat = new frmPhieuthutienphat();
            Thutienphat.Show();
        }
    }
}
