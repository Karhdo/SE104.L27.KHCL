using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PhanMemQLTV
{
    public partial class frmDocGia : Form
    {
        public string tKDG;
        public frmDocGia(string tkDG)
        {
            InitializeComponent();
            tKDG = tkDG;
        }


        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private SqlDataAdapter myDataAdapter;
   
        private DataTable myTable;
    
 


        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSach0.DataSource = myTable;
            return myTable;
        }

       
        
        private void frmDocGia_Load(object sender, EventArgs e)
        {
        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMaSach.Checked)
            {
                string timkiemMS = "select MaSach, TenSach, TheLoai, TacGia, NXB, NamXB, SLNhap, TriGia, TinhTrang, GhiChu from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenSach.Checked)
            {
                string timkiemTS = "select MaSach, TenSach, TheLoai, TacGia, NXB, NamXB, SLNhap, TriGia, TinhTrang, GhiChu from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = ketnoi(timkiemTS);
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked)
            {
                string timkiemMS = "select MaSach, TenSach, TheLoai, TacGia, NXB, NamXB, SLNhap, TriGia, TinhTrang, GhiChu from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenCD.Checked)
            {
                string timkiemMS = "select MaSach, TenSach, TheLoai, TacGia, NXB, NamXB, SLNhap, TriGia, TinhTrang, GhiChu from tblSach where TheLoai like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMKDG MKDG = new frmDoiMKDG();
            MKDG.Show();
        }

        private void dataGridViewDSSach0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
