using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;


        private SqlDataReader myDataReaderSLDauSach;
        private SqlDataReader myDataReaderSLMuon;
        private SqlDataReader myDataReaderSLDG;
        private SqlDataReader myDataReaderSLDGMuon;
        private SqlDataReader myDataReaderSLSQuaHan;
        private SqlDataReader myDataReaderSLDGQuaHan;


        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSDGQuaHan.DataSource = myTable;
            return myTable;
        }



        public string luuSLDauSach, luuSLCuon, luuTongGiaTriSach;
        // Tính SL Đầu Sách, SL Cuốn, SL Còn, Tổng GT Sách
        private void slDauSach()
        {
            string strTinhSLDauSach = "select count(MaSach) as TongSLDauSach, sum(SLNhap) as TongSLSach, sum(TriGia) as TongGiaTriSach from tblSach";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLDauSach, myConnection);
            myDataReaderSLDauSach = myCommand.ExecuteReader();
            while (myDataReaderSLDauSach.Read())
            {
                luuSLDauSach = myDataReaderSLDauSach.GetInt32(0).ToString();
                luuSLCuon = myDataReaderSLDauSach.GetInt32(1).ToString();
                luuTongGiaTriSach = myDataReaderSLDauSach.GetInt32(2).ToString();
            }

        }

        // Tính SL Mượn
        public string luuSLMuon;
        private void slMuon()
        {
            string strTinhSLMuon = "select sum(SLMuon) as Tong from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLMuon = myCommand.ExecuteReader();
            while (myDataReaderSLMuon.Read())
            {
                luuSLMuon = myDataReaderSLMuon.GetInt32(0).ToString();
            }

        }

        // Tính SL Độc Giả
        public string luuSLDG;
        private void slDocGia()
        {
            string strTinhSLMuon = "select count(MaDG) as TongSLDG from tblDocGia";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDG = myCommand.ExecuteReader();
            while (myDataReaderSLDG.Read())
            {
                luuSLDG = myDataReaderSLDG.GetInt32(0).ToString();
            }
        }
        
        // Tính SLDG Đã Mượn sách
        public string luuSLDGMuon;
        private void slDocGiaMuon()
        {
            string strTinhSLMuon = "select (count(distinct(MaDG))) as TongSLDGMuon from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDGMuon = myCommand.ExecuteReader();
            while (myDataReaderSLDGMuon.Read())
            {
                luuSLDGMuon = myDataReaderSLDGMuon.GetInt32(0).ToString();
            }
        }

        //SL sách quá hạn
        public string luuSLSQuaHan;
        private void slSachQuaHan()
        {
            string strTinhSLSachQuaHan = "SELECT count(SLMuon) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLSachQuaHan, myConnection);
            myDataReaderSLSQuaHan = myCommand.ExecuteReader();
            while (myDataReaderSLSQuaHan.Read())
            {
                luuSLSQuaHan = myDataReaderSLSQuaHan.GetInt32(0).ToString();
            }

        }

        // SL Độc Giả quá hạn
        public string luuSLDGQuaHan;
        private void slDGQuaHan()
        {
            string strTinhSLDGQuaHan = "SELECT count(distinct(MaDG)) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLDGQuaHan, myConnection);
            myDataReaderSLDGQuaHan = myCommand.ExecuteReader();
            while (myDataReaderSLDGQuaHan.Read())
            {
                luuSLDGQuaHan = myDataReaderSLDGQuaHan.GetInt32(0).ToString();
            }

        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            txtSLDauSach.Enabled = false;
            txtSLCuon.Enabled = false;
            txtSLCon.Enabled = false;
            txtSLMuon.Enabled = false;
            txtTongGiaTriSach.Enabled = false;
            txtSLSachQuaHan.Enabled = false;

            txtSLDGQuaHan.Enabled = false;
            txtSLDocGia.Enabled = false;
            txtSLDGMuon.Enabled = false;

            dataGridViewDSDGQuaHan.Hide();

            // Tổng SL Đầu sách, sl nhập, sl còn , tổng giá trị
            slDauSach();
            txtSLDauSach.Text = luuSLDauSach;
            txtSLCuon.Text = luuSLCuon;
            txtTongGiaTriSach.Text = luuTongGiaTriSach;

            // tổng sl mượn
            slMuon();
            txtSLMuon.Text = luuSLMuon;
            int luuSLCon = Convert.ToInt32(luuSLCuon) - Convert.ToInt32(luuSLMuon);
            txtSLCon.Text = luuSLCon.ToString();

            // tổng sl độc giả
            slDocGia();
            txtSLDocGia.Text = luuSLDG;

            // SL  độc giả đã mượn sahcs
            slDocGiaMuon();
            txtSLDGMuon.Text = luuSLDGMuon;


            // SL Sách quá hạn
            slSachQuaHan();
            txtSLSachQuaHan.Text = luuSLSQuaHan;

            //SL DG quá hạn
            slDGQuaHan();
            txtSLDGQuaHan.Text = luuSLDGQuaHan;
        }

        private void frmBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            dataGridViewDSDGQuaHan.Hide();
        }

        private void btnXemSLSachQuaHan_Click(object sender, EventArgs e)
        {
            dtpBaocao.Enabled = false;
            string strTimSLSQuaHan = @"SELECT MaPhieu as 'Mã Phiếu', MaDG as 'Mã DG', MaSach as 'Mã Sách', NgayMuon as 'Ngày Mượn', NgayTra as 'Ngày Trả', GhiChu as 'Ghi Chú' from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()";
            dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLSQuaHan);
            dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            dtpBaocao.Enabled = true;
            string query = "select TheLoai as [Thể loại], sum(SoLanMuon) as [Số lần mượn] from tblSach S, ChiTietPM CT where S.MaSach = CT.MaSach and month(CT.NgayThang) = " + dtpBaocao.Value.Month + "and year(CT.NgayThang) = " + dtpBaocao.Value.Year + " group by S.TheLoai";
            dataGridViewDSDGQuaHan.DataSource = ketnoi(query);
            dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();

        }

        private void dtpBaocao_ValueChanged(object sender, EventArgs e)
        {
            this.btnBaocao_Click(this, new EventArgs());
        }

        private void btnSLDGQuaHan_Click(object sender, EventArgs e)
        {
            dtpBaocao.Enabled = false;
            string strTimSLDGQuaHan = @"SELECT MaDG as 'Mã DG', sum(SLMuon) as 'SL Sách Mượn' from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) <= getdate() group by MaDG";
            dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLDGQuaHan);
            dataGridViewDSDGQuaHan.Columns["SL Sách Mượn"].Width=440;
            dataGridViewDSDGQuaHan.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
