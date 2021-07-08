using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên người dùng.", "Thông Báo");
                txtTenNguoiDung.Focus();
            }
            else if (txtTenTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên tài khoản.", "Thông Báo");
                txtTenTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mật Khẩu.", "Thông Báo");
                txtMatKhau.Focus();
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Email.", "Thông Báo");
                txtEmail.Focus();
            }
            
            if (txtTenNguoiDung.Text.Length > 0 && txtTenTaiKhoan.Text.Length > 0 && txtMatKhau.Text.Length > 0 && txtEmail.Text.Length > 0)
            {
                try
                {
                    myConnection = new SqlConnection(chuoiKetNoi);
                    myConnection.Open();
                    string strCauTruyVan = "select count(*) from tblDangNhap where TenTaiKhoan=@acc";
                    myCommand = new SqlCommand(strCauTruyVan, myConnection);
                    myCommand.Parameters.Add(new SqlParameter("@acc", txtTenTaiKhoan.Text));
             
                    int x = (int)myCommand.ExecuteScalar();
                    myConnection.Close();
                    if (x == 0)
                    {
                        try
                        {

                            string themdongSql;
                            themdongSql = "insert into tblDangNhap values ('" + txtTenTaiKhoan.Text + "',N'" + txtMatKhau.Text + "',N'" + txtTenNguoiDung.Text + "','" + txtEmail.Text + "')";
                            myConnection = new SqlConnection(chuoiKetNoi);
                            myConnection.Open();
                            myCommand = new SqlCommand(themdongSql, myConnection);
                            MessageBox.Show("Đăng ký thành công.", "Thông Báo");
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();

                            txtTenNguoiDung.Clear();
                            txtTenTaiKhoan.Clear();
                            txtMatKhau.Clear();
                            txtEmail.Clear();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại.\nVui lòng nhập tên khác.", "Thông Báo");
                        txtTenTaiKhoan.Clear();
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
