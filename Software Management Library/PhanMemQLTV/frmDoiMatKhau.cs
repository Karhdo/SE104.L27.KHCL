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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text.Length==0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Tài Khoản.", "Thông Báo");
                txtTenTaiKhoan.Focus();
            }
            else if(txtMatKhau.Text.Length==0)
            {
                MessageBox.Show("Bạn chưa nhập Mật Khẩu.", "Thông Báo");
                txtMatKhau.Focus();
            }
            else if (txtMatKhauMoi.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mật Khẩu Mới.", "Thông Báo");
                txtMatKhauMoi.Focus();
            }
            else if (txtNhapLaiMKMoi.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa Nhập Lại Mật Khẩu Mới.", "Thông Báo");
                txtNhapLaiMKMoi.Focus();
            }
            string mk1, mk2;
            mk1 = txtMatKhauMoi.Text;
            mk2 = txtNhapLaiMKMoi.Text;
            int kq=mk1.CompareTo(mk2);
            if(txtTenTaiKhoan.Text.Length>0 && txtMatKhau.Text.Length>0 &&txtMatKhauMoi.Text.Length>0 &&txtNhapLaiMKMoi.Text.Length>0)
            {
                try
                {
                    myConnection = new SqlConnection(chuoiKetNoi);
                    myConnection.Open();
                    string strCauTruyVan = "select count(*) from tblThuThu where TaiKhoanTT=@acc and MatKhauTT =@pass";
                    myCommand = new SqlCommand(strCauTruyVan, myConnection);
                    myCommand.Parameters.Add(new SqlParameter("@acc", txtTenTaiKhoan.Text));
                    myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                    int x = (int)myCommand.ExecuteScalar();
                    myConnection.Close();
                    if (x == 1)
                    {
                        if (kq == 0)
                        {
                            string luumk = "update tblThuThu set MatKhauTT='" + txtMatKhauMoi.Text + "' where MaTT='" + txtTenTaiKhoan.Text + "'";
                            myConnection = new SqlConnection(chuoiKetNoi);
                            myConnection.Open();
                            myCommand = new SqlCommand(luumk, myConnection);
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();
                            MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo");
                            txtTenTaiKhoan.Clear();
                            txtMatKhau.Clear();
                            txtMatKhauMoi.Clear();
                            txtNhapLaiMKMoi.Clear();
                            txtTenTaiKhoan.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không khớp nhau.", "Thông Báo");
                            txtMatKhauMoi.Clear();
                            txtNhapLaiMKMoi.Clear();
                            txtMatKhauMoi.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu.\nVui lòng nhập lại.", "Thông Báo");
                        txtTenTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtMatKhauMoi.Clear();
                        txtNhapLaiMKMoi.Clear();
                        txtTenTaiKhoan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatKhauCu.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                
            }
                
        }

        private void chkMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatKhauMoi.Checked)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
                txtMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void chkNhapLaiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhapLaiMatKhau.Checked)
            {
                txtNhapLaiMKMoi.UseSystemPasswordChar = false;
            }
            else
                txtNhapLaiMKMoi.UseSystemPasswordChar = true;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        
        

    }
}
