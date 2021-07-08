using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace PhanMemQLTV
{
    public partial class frmQLDocGia : Form
    {
        public frmQLDocGia()
        {
            InitializeComponent();
        }

        // Khai báo 
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSDocGia.DataSource = myTable;
            return myTable;
        }

        // Phương thức thiết lập Controls
        private void setControls(bool edit)
        {
            txtTenDG.Enabled = edit;
            dtmNgaySinh.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtDiaChi.Enabled = edit;
            txtEmail.Enabled = edit;
            txtTenTK.Enabled = edit;
            txtMK.Enabled = edit;
            txtGhiChu.Enabled = edit;
            cboLoaiDG.Enabled = edit;
            dtmNgLapThe.Enabled = edit;
        }

        // Load
        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblDocGia";
            //dataGridViewDSDocGia.AutoGenerateColumns = false;
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);           
            myConnection.Close();
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaDG.Enabled = false;
        }

        // Phương thức hiển thị các thuộc tính bảng Độc Giả lên txt
        public string maDG, tenDG, gioiTinhDG, ngaySinhDG, diaChiDG, sdtDG, loaiDG, ghiChu, tenTK, mK, NgLapThe;
        private void dataGridViewDSDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaDG.Text = myTable.Rows[row]["MaDG"].ToString();
                maDG = txtMaDG.Text;
                txtTenDG.Text = myTable.Rows[row]["TenDG"].ToString();
                tenDG = txtTenDG.Text;
                cboGioiTinh.Text = myTable.Rows[row]["GioiTinhDG"].ToString();
                gioiTinhDG = cboGioiTinh.Text;
                dtmNgaySinh.Text = myTable.Rows[row]["NgaySinhDG"].ToString();
                ngaySinhDG = dtmNgaySinh.Text;
                txtEmail.Text = myTable.Rows[row]["SDTDG"].ToString();
                sdtDG = txtEmail.Text;
                txtDiaChi.Text = myTable.Rows[row]["DiaChiDG"].ToString();
                diaChiDG = txtDiaChi.Text;
                cboLoaiDG.Text = myTable.Rows[row]["LoaiDG"].ToString();
                loaiDG = cboLoaiDG.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
                txtTenTK.Text = myTable.Rows[row]["TenTaiKhoanDG"].ToString();
                tenTK = txtTenTK.Text;
                txtMK.Text = myTable.Rows[row]["MatKhauDG"].ToString();
                mK = txtMK.Text;
                dtmNgLapThe.Text = myTable.Rows[row]["NgLapThe"].ToString();
                NgLapThe = dtmNgLapThe.Text;
            }
            catch
            {

            }
        }

        // Phương thức tăng mã DG tự động
        public string setMaDG()
        {
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "DG001";
            }
            else
            {
                int k;
                maTuDong = "DG";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        // Phương thức thêm ĐG
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaDG.Text = setMaDG();
            txtTenDG.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cboGioiTinh.Text = "";
            dtmNgaySinh.Text = "";
            cboLoaiDG.Text = "";
            txtGhiChu.Text = "";
            txtTenTK.Text = txtMaDG.Text;
            txtTenTK.Enabled = false;
            txtMK.Text = "";
            dtmNgLapThe.Text = "";
            txtTenDG.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
            dataGridViewDSDocGia.Enabled = false;
        }

        // Phương thức sửa thông tin độc giả
        private void suaDG()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtTenDG.Focus();
            //dataGridViewDSDocGia.Enabled = false;
            //txtTenTK.Enabled = false;
            xuly = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            suaDG();
        }

   

        private void dataGridViewDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[0].Value.ToString();
            txtTenDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[2].Value.ToString();
            dtmNgaySinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridViewDSDocGia.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridViewDSDocGia.CurrentRow.Cells[5].Value.ToString();
            cboLoaiDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dataGridViewDSDocGia.CurrentRow.Cells[7].Value.ToString();
            txtTenTK.Text = dataGridViewDSDocGia.CurrentRow.Cells[8].Value.ToString();
            txtMK.Text = dataGridViewDSDocGia.CurrentRow.Cells[9].Value.ToString();
            dtmNgLapThe.Text = dataGridViewDSDocGia.CurrentRow.Cells[10].Value.ToString();


        }

        private void dataGridViewDSDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Phương thức xóa độc giả
        private void xoaDG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblDocGia where MaDG='" + txtMaDG.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    //btnXoa.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nĐộc Giả này đang mượn sách.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDG();
        }

        // Lưu
        private void themDG()
        {
            try
            {
                string themdongsql = "insert into tblDocGia values ('" + txtMaDG.Text + "',N'" + txtTenDG.Text + "',N'" + cboGioiTinh.Text + "','" + dtmNgaySinh.Text + "','" + txtEmail.Text + "',N'" + txtDiaChi.Text + "',N'" + cboLoaiDG.Text + "',N'" + txtGhiChu.Text + "','" + txtTenTK.Text + "','" + txtMK.Text + "','" + this.dtmNgLapThe.Text + "')";
                ketnoi(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            { 
            if (txtTenDG.Text == "")
            {
                errTenDG.SetError(txtTenDG, "Vui lòng nhập Tên DG");
            }
            else
            {
                errTenDG.Clear();
            }

            if (txtEmail.Text == "")
            {
                errEmail.SetError(txtEmail, "Vui lòng nhập Email");
            }
            else
            {
                errEmail.Clear();
            }

            if (txtDiaChi.Text == "")
            {
                errDC.SetError(txtDiaChi, "Vui lòng nhập Địa chỉ");
            }
            else
            {
                errDC.Clear();
            }

            if (txtTenTK.Text == "")
            {
                errTenTK.SetError(txtTenTK, "Vui lòng nhập Tên TK");
            }
            else
            {
                errTenTK.Clear();
            }

            if (txtMK.Text == "")
            {
                errMK.SetError(txtMK, "Vui lòng nhập MK");
            }
            else
            {
                errMK.Clear();
            }

            if (cboGioiTinh.Text == "")
            {
                errGT.SetError(cboGioiTinh, "Vui lòng chọn Giới Tính");
            }
            else
            {
                errGT.Clear();
            }

            if (cboLoaiDG.Text == "")
            {
                errLoaiDG.SetError(cboLoaiDG, "Vui lòng nhập Loại ĐG");
            }
            else
            {
                errLoaiDG.Clear();
            }
            }
            
            if(txtMaDG.Text.Length>0 && txtTenDG.Text.Length>0 && txtDiaChi.Text.Length>0  && dtmNgaySinh.Text.Length>0 && cboGioiTinh.Text.Length>0 && txtTenTK.Text.Length>0 && txtMK.Text.Length>0 && cboLoaiDG.Text.Length>0 && dtmNgLapThe.Text.Length>0)
            {
                string query = "Select giatri from ThamSo  where Tents = 'SoTuoiDGMin'";
                ketnoi(query);
                int tuoiMin = Convert.ToInt32(myCommand.ExecuteScalar());

                query = "Select giatri from ThamSo  where Tents = 'SoTuoiDGMax'";
                ketnoi(query);
                int tuoiMax = Convert.ToInt32(myCommand.ExecuteScalar());

                string[] nam = dtmNgaySinh.Text.Split('/');
                int NamSinh = Convert.ToInt32(nam[2]);
                int tuoi = DateTime.Now.Year - NamSinh;

                if (tuoi < tuoiMin || tuoi > tuoiMax)
                {
                    MessageBox.Show("Số tuổi không hợp lệ!");
                    return;
                }

                if (xuly==0)
                {
                    themDG();
                }
                else if(xuly==1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "update tblDocGia set NgLapThe = '" + dtmNgLapThe.Text + "' where MaDG = '" + txtMaDG.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
                    }
                }
                
                string cauTruyVan = "select * from tblDocGia";
                dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
                txtMaDG.Text = setMaDG();
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled=false;
                btnHuy.Enabled=false;
                btnThem.Enabled=true;
                btnSua.Enabled=true;
                btnXoa.Enabled=true;
                setControls(false);
                dataGridViewDSDocGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenDG.Text.Length == 0)
                    txtTenDG.Focus();
                else if (txtDiaChi.Text.Length == 0)
                    txtDiaChi.Focus();
                else if (txtEmail.Text.Length == 0)
                    txtEmail.Focus();
                else if (txtTenTK.Text.Length == 0)
                    txtTenTK.Focus();
                else if (txtMK.Text.Length == 0)
                    txtMK.Focus();
            }
        }

        // Phương thức nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = maDG;
            txtTenDG.Text = tenDG;
            txtEmail.Text = sdtDG;
            txtDiaChi.Text = diaChiDG;
            cboGioiTinh.Text = gioiTinhDG;
            dtmNgaySinh.Text = ngaySinhDG;
            cboLoaiDG.Text = loaiDG;
            txtGhiChu.Text = ghiChu;
            txtTenTK.Text = tenTK;
            txtMK.Text = mK;
            dtmNgLapThe.Text = NgLapThe;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
            errMK.Clear();
            errEmail.Clear();
            errTenTK.Clear();
            errTenDG.Clear();
            errDC.Clear();
            errLoaiDG.Clear();
            errGT.Clear();
        }

        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tìm kiếm 
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            //btnSua.Enabled = false;
            if (radMaDG.Checked)
            {
                string timkiem = "select * from tblDocGia where MaDG like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenDG.Checked)
            {
                string timkiem = "select * from tblDocGia where TenDG like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // Phương thức nút Load DS
        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapTenDG.Text = "";
            lblNhapNgaySinh.Text = "";
            lblNhapGioiTinh.Text = "";
            lblNhapSDT.Text = "";
            lblNhapDiaChi.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
