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

namespace PhanMemQLTV
{
    public partial class frmQLMuonTra : Form
    {
        public frmQLMuonTra()
        {
            InitializeComponent();
        }

        // Khai báo
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private DataTable myTable;
    




        /// <summary>
        /// /////////////////////////////////////////////////
        /// </summary>
        private DataTable myTableSach;
        private DataTable myTableDG;
        private SqlDataReader myDataReaderSach;
        private SqlDataReader myDataReaderSLSachDaMuon;
        //private SqlDataReader myDataReaderMuonTra;
        //////////////////////////////////////////////////////////////////////////////////


        // Kết nối tới sql
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh,myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable=new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSMuon0.DataSource=myTable;
            return myTable;
        }

        // Kết nối tới tblSach
        private DataTable ketnoitblSach(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTableSach = new DataTable();
            myDataAdapter.Fill(myTableSach);
            return myTableSach;
        }
        //cboMaSach0.SelectedIndex=dongcuoi;
        //int dongcuoi = myTableSach.Rows.Count+1;

        // Lấy mã sách lên cboMasach0
        public void layMaSachMuon()
        { 
            string strLayMaSach = "select MaSach from tblSach";
            cboMaSach0.DataSource = ketnoitblSach(strLayMaSach);
            cboMaSach0.DisplayMember = "MaSach";
            cboMaSach0.ValueMember = "MaSach";
            myConnection.Close();
        }

        // Kết nối tới tblDocGia
        private DataTable ketnoitblDocGia(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTableDG = new DataTable();
            myDataAdapter.Fill(myTableDG);
            return myTableDG;
        }

        // lấy Mã DG lên cboMaDG
        public void layMaDGMuon()
        {
            string strLayMaDG = "select * from tblDocGia";
            cboMaDG0.DataSource = ketnoitblSach(strLayMaDG);
            cboMaDG0.DisplayMember = "MaDG";
            cboMaDG0.ValueMember = "MaDG";
            myConnection.Close();
        }

        private void setControlsMuon(bool edit)
        {
            cboMaDG0.Enabled = edit;
            cboMaSach0.Enabled = edit;
            txtSLMuon0.Enabled = edit;
            //dtmNgayMuon0.Enabled = edit;
            //dtmNgayTra0.Enabled = edit;
            txtGhiChu0.Enabled = edit;
            dtmNgayTra0.Enabled = edit;
            dtmNgayMuon0.Enabled = edit;
            cboTinhTrang0.Enabled = edit;
        }

        private void frmQLMuonTra_Load(object sender, EventArgs e)
        {
            //soSanhNgay();
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon0.AutoGenerateColumns = false;

            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();

            radMaDG.Checked = true;
            radMaDG1.Checked = true;
            
            btnChoMuon0.Text = "Cho Mượn";
            btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnChoMuon0.Enabled = false;
            btnHuy0.Enabled = false;
            txtMaPhieu0.Enabled = false;

            //txtMaPhieu0.Enabled = false;
            txtTTMaSach.Enabled = false;
            txtTTTenSach.Enabled = false;
            txtTTSLCon.Enabled = false;
            txtTTTenTG.Enabled = false;
            //dtmNgayTra0.Enabled = false;
            //dtmNgayMuon0.Enabled = false;
            //txtTinhTrang0.Enabled = false;

            setControlsMuon(false);
            setControlsTra(false);
        }

        public string maPhieu0, maDG0, maSach0, slMuon0, ngayMuon0, ngayTra0, ghiChu0, tinhTrang0;
        private void dataGridViewDSMuon0_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaPhieu0.Text = myTable.Rows[row]["MaPhieu"].ToString();
                maPhieu0 = txtMaPhieu0.Text;
                cboMaDG0.Text = myTable.Rows[row]["MaDG"].ToString();
                maDG0 = cboMaDG0.Text;
                cboMaSach0.Text = myTable.Rows[row]["MaSach"].ToString();
                maSach0 = cboMaSach0.Text;
                txtSLMuon0.Text = myTable.Rows[row]["SLMuon"].ToString();
                slMuon0 = txtSLMuon0.Text;
                dtmNgayMuon0.Text = myTable.Rows[row]["NgayMuon"].ToString();
                ngayMuon0 = dtmNgayMuon0.Text;
                dtmNgayTra0.Text = myTable.Rows[row]["NgayTra"].ToString();
                ngayTra0 = dtmNgayTra0.Text;
                cboTinhTrang0.Text = myTable.Rows[row]["TinhTrang"].ToString();
                tinhTrang0 = cboTinhTrang0.Text;
                txtGhiChu0.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu0 = txtGhiChu0.Text;
            }
            catch (Exception)
            {

            }

        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            setControlsMuon(false);
            btnNhap.Enabled = false;
            btnChoMuon0.Enabled = false;
            btnHuy0.Enabled = false;

            if (radMaDG.Checked)
            {
                string timkiemMaDG = "select * from tblHSPhieuMuon where MaDG like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMaDG);
                myCommand.ExecuteNonQuery();
                dataGridViewDSMuon0.DataSource = ketnoi(timkiemMaDG);
                dataGridViewDSMuon0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radMaSach.Checked)
            {
                string timkiemMS = "select * from tblHSPhieuMuon where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSMuon0.DataSource = ketnoi(timkiemMS);
                dataGridViewDSMuon0.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }


        private void btnLoadDanhSach0_Click(object sender, EventArgs e)
        {
            txtNDTimKiem.Text = "";
            btnNhap.Enabled = true;
            btnChoMuon0.Enabled = false;
            btnHuy0.Enabled = false;
            setControlsMuon(false);

            string cauTruyVanLoad = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVanLoad);
            dataGridViewDSMuon0.AutoGenerateColumns = false;
            myConnection.Close();
        }

        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon0.AutoGenerateColumns = false;
            myConnection.Close();

            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "MP001";
            }
            else
            {
                int k;
                maTuDong = "MP";
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

        public int xuly;
        public static DateTime today = DateTime.Now;  //Get Date time now on system
        public static DateTime newday = today.AddDays(5);
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
            layMaDGMuon();
            layMaSachMuon();

            btnChoMuon0.Text = "Cho Mượn";
            btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            setControlsMuon(true);
            btnNhap.Enabled = false;
            btnChoMuon0.Enabled = true;
            btnHuy0.Enabled = true;
            btnGiaHan.Enabled = false;
            dataGridViewDSMuon0.Enabled = false;

            txtMaPhieu0.Text = tangMaTuDong();
            cboMaDG0.Text = "";
            cboMaSach0.Text = "";
            txtSLMuon0.Text = "";
            dtmNgayMuon0.Text = Convert.ToString(today); ;
            dtmNgayTra0.Text = Convert.ToString(newday);
            //dtmNgayTra0.Text = "";
            txtGhiChu0.Text = "";

            lblNhapSLNhap.Text = "";
            xuly = 0;
        }

      
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 
        public string ngaymuon, thangmuon, nammuon, ngaytra, thangtra, namtra, ngaydgmuon, ngaydgtra;
        public int hieumuon,hieutra,catthangmuon,catngaymuon,catngaytra,catthangtra, songaymuon, sothangmuon, sonammuon, songaytra, sothangtra, sonamtra, kq = 1;

        private void dtmNgayMuon0_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayTra0.Value = dtmNgayMuon0.Value.AddDays(5);
        }

        public void soSanhNgay()
        {
            catngaymuon = dtmNgayMuon0.Text.IndexOf("/");
            ngaymuon = dtmNgayMuon0.Text.Substring(0, catngaymuon);
            catthangmuon = dtmNgayMuon0.Text.LastIndexOf("/");
            hieumuon = (catthangmuon - 1) - catngaymuon;
            thangmuon = dtmNgayMuon0.Text.Substring(catngaymuon + 1, hieumuon);
            nammuon = dtmNgayMuon0.Text.Substring(catthangmuon + 1, 4);

            songaymuon= Convert.ToInt32(ngaymuon);
            sothangmuon= Convert.ToInt32(thangmuon);
            sonammuon= Convert.ToInt32(nammuon);

            catngaytra = dtmNgayTra0.Text.IndexOf("/");
            ngaytra = dtmNgayTra0.Text.Substring(0, catngaytra);
            catthangtra = dtmNgayTra0.Text.LastIndexOf("/");
            hieutra = (catthangtra - 1) - catngaytra;
            thangtra = dtmNgayTra0.Text.Substring(catngaytra + 1, hieutra);
            namtra = dtmNgayTra0.Text.Substring(catthangtra + 1, 4);

            songaytra = Convert.ToInt32(ngaytra);
            sothangtra = Convert.ToInt32(thangtra);
            sonamtra = Convert.ToInt32(namtra);

            DateTime tgMuon = new DateTime(sonammuon, sothangmuon, songaymuon);
            DateTime tgTra = new DateTime(sonamtra, sothangtra, songaytra);


            //MessageBox.Show("Ngày mượn: " + ngaymuon + "Tháng mượn: " + thangmuon + "Năm mượn: " + nammuon);
            kq=tgTra.CompareTo(tgMuon);
            //MessageBox.Show("kq: " + kq, "Thông Báo");
            //DateTime ngaymuon= new DateTime()
        }

        public string strluuSLCon;
        private void cboMaSach0_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strlaydulieu = "select * from tblSach where MaSach='" + cboMaSach0.SelectedValue.ToString() + "'";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = strlaydulieu;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataReaderSach = myCommand.ExecuteReader();
            while (myDataReaderSach.Read())
            {
                //luuMaSach = cboMaSach0.Text;
                txtTTMaSach.Text = myDataReaderSach.GetString(0);
                txtTTTenSach.Text = myDataReaderSach.GetString(2);
                txtTTTenTG.Text = myDataReaderSach.GetString(4);
                txtTTSLCon.Text = myDataReaderSach.GetInt32(7).ToString();
                strluuSLCon = txtTTSLCon.Text;
            }
        }

        // Kiểm tra số lượng sách đg đã mượn
        public int luuSLSachDGDaMuon;
        private void slSachDaMuon()
        {
            string strTinhSLSachDaMuon = "select sum(SLMuon) as Tong from tblHSPhieuMuon where MaDG='" + cboMaDG0.Text + "' group by MaDG";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = strTinhSLSachDaMuon;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataReaderSLSachDaMuon = myCommand.ExecuteReader();
            while (myDataReaderSLSachDaMuon.Read())
            {
                luuSLSachDGDaMuon = Convert.ToInt32(myDataReaderSLSachDaMuon.GetInt32(0).ToString());
            }

        }

        public int luuSLCon, luuSLMuon;
        public int luuSLSauChoMuon;
        public int ktmuonchua;
        //public static DateTime today= DateTime.Now;
        //public static DateTime newday = today.AddDays(21);

        //DateTime today = DateTime.Now;  //Get Date time now on system
        //DateTime newday = today.AddDays(21);
        private void muonSach()
        {
            if (cboMaDG0.Text == "")
            {
                errMaDG0.SetError(cboMaDG0, "Vui lòng chọn Mã ĐG");
            }
            else
            {
                errMaDG0.Clear();
            }

            if (cboMaSach0.Text == "")
            {
                errMaSach0.SetError(cboMaSach0, "Vui lòng chọn Mã Sách");
            }
            else
            {
                errMaSach0.Clear();
            }

            if (txtSLMuon0.Text == "")
            {
                errSLMuon0.SetError(txtSLMuon0, "Vui lòng chọn SL Mượn");
            }
            else
            {
                errSLMuon0.Clear();
            }

            bool isNumberSLNhap = int.TryParse(txtSLMuon0.Text, out luuSLMuon);
            if (isNumberSLNhap == false)
            {
                MessageBox.Show("Vui lòng nhập số trong ô SL", "Thông Báo");
            }

            slSachDaMuon();
            luuSLCon = Convert.ToInt32(strluuSLCon);
            luuSLSauChoMuon = luuSLCon - luuSLMuon;
            //soSanhNgay();
            if (txtSLMuon0.Text.Length > 0 && cboMaDG0.Text.Length > 0 && cboMaSach0.Text.Length > 0)
            {
                if (luuSLMuon <= luuSLCon)
                {
                    //MessageBox.Show("SL đã mượn: " + luuSLSachDGDaMuon);
                    //MessageBox.Show("SL còn: " + luuSLCon);
                    //MessageBox.Show("Sl mượn: " + txtSLMuon0.Text);

                    if ((luuSLSachDGDaMuon + luuSLMuon) <= 5 && (luuSLSachDGDaMuon + luuSLMuon) > 0)
                    {
                        if (kq == 1)
                        {
                            try
                            {
                                ktmuonchua = 0;
                                string themdongsqlMuon;
                                themdongsqlMuon = "set dateformat dmy; insert into tblHSPhieuMuon values ('" + txtMaPhieu0.Text + "','" + cboMaDG0.Text + "','" + cboMaSach0.Text + "','" + dtmNgayMuon0.Text + "','" + dtmNgayTra0.Text + "','" + txtSLMuon0.Text + "',N'" + cboTinhTrang0.Text + "',N'" + txtGhiChu0.Text + "')";
                                ketnoi(themdongsqlMuon);
                                MessageBox.Show("Cho mượn thành công.", "Thông Báo");
                                //ktmuonchua = 0;
                                myCommand.ExecuteNonQuery();
                                myConnection.Close();
                                ktmuonchua = 0;
                            }
                            catch (Exception)
                            {
                                //ktmuonchua = 1;
                            }

                            if (ktmuonchua == 0)
                            {
                                try
                                {
                                    string strluuSLSauChoMuon = luuSLSauChoMuon.ToString();
                                    string strCapNhatSLCon = "update tblSach set SLNhap='" + strluuSLSauChoMuon + " ' where MaSach='" + cboMaSach0.Text + "'";
                                    ketnoi(strCapNhatSLCon);
                                    myCommand.ExecuteNonQuery();
                                    myConnection.Close();
                                    MessageBox.Show("Đã cập nhật SL Sách vào trong kho.", "Thông Báo");

                                    string query = "set dateformat dmy; select count(*) from chitietpm where month(NgayThang) = " + dtmNgayMuon0.Value.Month + " and year(NgayThang) = " + dtmNgayMuon0.Value.Year + " and MaSach = '" + cboMaSach0.Text + "'";
                                    ketnoi(query);
                                    int cnt = (int)myCommand.ExecuteScalar();
                                    if(cnt == 0)
                                    {
                                        query = "select * from ChiTietPM";
                                        dataGridViewDSMuon0.DataSource = ketnoi(query);
                                        dataGridViewDSMuon0.AutoGenerateColumns = false;
                                        myConnection.Close();

                                        string maTuDong = "";
                                        if (myTable.Rows.Count <= 0)
                                        {
                                            maTuDong = "PM001";
                                        }
                                        else
                                        {
                                            int k;
                                            maTuDong = "PM";
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

                                        query = "set dateformat dmy; insert into ChiTietPM values('" + maTuDong + "', '" + cboMaSach0.Text + "', '" + dtmNgayMuon0.Value.ToString("yyyy-MM-dd") +  "', " + txtSLMuon0.Text + " )";
                                        ketnoi(query);
                                        myCommand.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        query = "set dateformat dmy; update ChiTietPM set SoLanMuon += " + txtSLMuon0.Text + " where month(NgayThang) = " + dtmNgayMuon0.Value.Month + " and year(NgayThang) = " + dtmNgayMuon0.Value.Year + " and MaSach = '" + cboMaSach0.Text + "'";
                                        ketnoi(query);
                                        //myCommand.ExecuteNonQuery();
                                    }


                                    btnNhap.Enabled = true;
                                    btnChoMuon0.Enabled = false;
                                    btnHuy0.Enabled = false;
                                    btnGiaHan.Enabled = true;
                                    setControlsMuon(false);
                                    dataGridViewDSMuon0.Enabled = true;

                                }
                                catch (Exception)
                                {

                                }
                            }
                            else
                                MessageBox.Show("Mượn thất bại.", "Thông Báo");

                            string cauTruyVan = "select * from tblHSPhieuMuon";
                            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVan);
                            dataGridViewDSMuon0.AutoGenerateColumns = false;
                            myConnection.Close();
                        }
                        else
                            MessageBox.Show("Vui lòng chọn ngày trả lớn hơn ngày mươn.", "Thông Báo");



                    }
                    else
                    {
                        MessageBox.Show("Không thể mượn.\nSố sách bạn mượn quá 5 cuốn", "Thông Báo");
                        txtSLMuon0.Text = "";
                        txtSLMuon0.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Không thể mượn nhiều hơn số lượng còn.", "Thông Báo");

                    txtSLMuon0.Text = "";
                    txtSLMuon0.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo");
                txtSLMuon0.Text = "";
                txtSLMuon0.Focus();
            }
        }

        private void giaHanSach()
        {
            //soSanhNgay();
            if (kq == 1)
            {
                string strCapNhatSLCon = "set dateformat dmy; update tblHSPhieuMuon set NgayMuon='" + dtmNgayMuon0.Text + " ', NgayTra='" + dtmNgayTra0.Text + "' where MaPhieu='" + txtMaPhieu0.Text + "'";
                ketnoi(strCapNhatSLCon);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Gia hạn thành công.", "Thông Báo");

                string cauTruyVan = "select * from tblHSPhieuMuon";
                dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSMuon0.AutoGenerateColumns = false;
                myConnection.Close();

                setControlsMuon(false);
                btnNhap.Enabled = true;
                btnChoMuon0.Text = "Cho Mượn";
                btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                btnChoMuon0.Enabled = false;
                btnGiaHan.Enabled = true;
                btnHuy0.Enabled = false;

                dataGridViewDSMuon0.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày trả lớn hơn ngày mượn.", "Thông Báo");
            }
                
        }
        private void btnChoMuon0_Click(object sender, EventArgs e)
        {
            string query = "Select GiaTri from ThamSo Where TenTS='GiaTriThe'";
            ketnoi(query);
            int GiaTriThe = Convert.ToInt32(myCommand.ExecuteScalar());
            query = "set dateformat dmy; Select NgLapThe from tblDocGia Where MaDG='" + cboMaDG0.Text + "'";
            ketnoi(query);
            DateTime ngaylap = Convert.ToDateTime(myCommand.ExecuteScalar());

            

            TimeSpan han = DateTime.Now - ngaylap;
            if (han.Days > GiaTriThe*31)
            {
                MessageBox.Show("Thẻ đã hết hạn!");
                return;
            }

            if (xuly==0)
            {
                muonSach();
            }
            else if(xuly==1)
            {
                giaHanSach();

                
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            txtMaPhieu0.Text = maPhieu0;
            cboMaDG0.Text = maDG0;
            cboMaSach0.Text = maSach0;
            txtSLMuon0.Text = slMuon0;
            dtmNgayMuon0.Text = Convert.ToString(today);

            dtmNgayTra0.Text = Convert.ToString(newday);
            txtGhiChu0.Text = ghiChu0;

            setControlsMuon(true);
            cboMaDG0.Enabled = false;
            cboMaSach0.Enabled = false;
            txtSLMuon0.Enabled = false;

            btnNhap.Enabled = false;
            btnChoMuon0.Text = "Lưu";
            btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnChoMuon0.Enabled = true;
            btnGiaHan.Enabled = false;
            btnHuy0.Enabled = true;
            xuly = 1;
        }

        private void btnHuy0_Click(object sender, EventArgs e)
        {
            txtMaPhieu0.Text = tangMaTuDong();
            cboMaDG0.Text = "";
            cboMaSach0.Text = "";
            txtSLMuon0.Text = "";
            dtmNgayMuon0.Value = DateTime.Now;
            dtmNgayTra0.Value = DateTime.Now.AddDays(5);
            txtGhiChu0.Text = "";

            btnChoMuon0.Text = "Cho Mượn";
            btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            btnNhap.Enabled = true;
            btnChoMuon0.Enabled = false;
            btnGiaHan.Enabled = true;
            btnHuy0.Enabled = false;
            setControlsMuon(false);
            dataGridViewDSMuon0.Enabled = true;

            lblNhapSLNhap.Text = "";
        }

        private void btnThoat0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // tabTraSach
        //public void layMaPhieuTra()
        //{
        //    string strLayMaPhieu = "select * from tblHSPhieuMuon";
        //    cboMaPhieu1.DataSource = ketnoitblSach(strLayMaPhieu);
        //    cboMaPhieu1.DisplayMember = "MaPhieu";
        //    cboMaPhieu1.ValueMember = "MaPhieu";
        //    myConnection.Close();
        //}

        private void setControlsTra(bool edit)
        {
            txtMaPhieu1.Enabled = edit;
            txtMaDG1.Enabled = edit;
            txtMaSach1.Enabled = edit;
            txtSLMuon1.Enabled = edit;
            dtmNgayMuon1.Enabled = edit;
            dtmNgayTra1.Enabled = edit;
            txtGhiChu1.Enabled = edit;
            txtTinhTrang1.Enabled = edit;
        }

        public string maPhieu1, maDG1, maSach1, luuSLTra1, ngayMuon1, ngayTra1, ghiChu1, tinhTrang1;
        private void dataGridViewDSMuon1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaPhieu1.Text=myTable.Rows[row]["MaPhieu"].ToString();
                maPhieu1 = txtMaPhieu1.Text;
                txtMaDG1.Text = myTable.Rows[row]["MaDG"].ToString();
                maDG1 = txtMaDG1.Text;
                txtMaSach1.Text = myTable.Rows[row]["MaSach"].ToString();
                maSach1 = txtMaSach1.Text;
                txtSLMuon1.Text = myTable.Rows[row]["SLMuon"].ToString();
                luuSLTra1 = txtSLMuon1.Text;
                dtmNgayMuon1.Text = myTable.Rows[row]["NgayMuon"].ToString();
                ngayMuon1 = dtmNgayMuon1.Text;
                dtmNgayTra1.Text = myTable.Rows[row]["NgayTra"].ToString();
                ngayTra1 = dtmNgayTra1.Text;
                txtTinhTrang1.Text = myTable.Rows[row]["TinhTrang"].ToString();
                tinhTrang1 = txtTinhTrang1.Text;
                txtGhiChu1.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu1 = txtGhiChu1.Text;
            }
            catch(Exception)
            {

            }
        }

        public int luuSLSauTra;
        public string luuSLConTabMuon;

        private void traSach()
        {
            string strlaydulieu = "select * from tblSach where MaSach='" + txtMaSach1.Text + "'";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = strlaydulieu;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataReaderSach = myCommand.ExecuteReader();
            while (myDataReaderSach.Read())
            {
                luuSLConTabMuon = myDataReaderSach.GetInt32(6).ToString();
            }

            luuSLSauTra = Convert.ToInt32(luuSLTra1) + Convert.ToInt32(luuSLConTabMuon);
            //MessageBox.Show("SL Còn: " + luuSLConTabMuon);
            //MessageBox.Show("SL sau trả: " + luuSLSauTra);
            //MessageBox.Show("SL trả: " + luuSLTra1);
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn trả sách.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql;
                    xoadongsql = "delete from tblHSPhieuMuon where MaPhieu='" + txtMaPhieu1.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Trả sách thành công.", "Thông Báo");
                    myConnection.Close();
                    try
                    {
                        string strluuSLSauTra = luuSLSauTra.ToString();
                        string strCapNhatSLCon = "update tblSach set SLNhap='" + strluuSLSauTra + " ' where MaSach='" + txtMaSach1.Text + "'";
                        ketnoi(strCapNhatSLCon);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã cập nhật SL Sách vào kho.", "Thông Báo");
                        myConnection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật SL Sách thất bại.", "Thông Báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Trả sách thất bại.", "Thông Báo");
                }
            }

            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private void btnTraSach1_Click(object sender, EventArgs e)
        {
            traSach();
        }
 
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNDTimKiem1_TextChanged(object sender, EventArgs e)
        {
            if (radMaDG1.Checked)
            {
                string timkiemDG1 = "select * from tblHSPhieuMuon where MaDG like '%" + txtNDTimKiem1.Text + "%'";
                ketnoi(timkiemDG1);
                myCommand.ExecuteNonQuery();
                dataGridViewDSMuon1.DataSource = ketnoi(timkiemDG1);
                dataGridViewDSMuon1.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radMaSach1.Checked)
            {
                string timkiemMS2 = "select * from tblHSPhieuMuon where MaSach like '%" + txtNDTimKiem1.Text + "%'";
                ketnoi(timkiemMS2);
                myCommand.ExecuteNonQuery();
                dataGridViewDSMuon1.DataSource = ketnoi(timkiemMS2);
                dataGridViewDSMuon1.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        private void btnLoadDS1_Click(object sender, EventArgs e)
        {
            //layMaPhieuTra();
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void cboTinhTrang0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void cboMaPhieu1_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    setControlsTra(true);
            
        //    //dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
        //    //dataGridViewDSMuon1.AutoGenerateColumns = false;
        //    //myConnection.Close();
        //    //string cauTruyVan = "";
        //    string strlaydulieu = "select * from tblHSPhieuMuon where MaPhieu='" + cboMaPhieu1.SelectedValue.ToString() + "'";
        //    myConnection = new SqlConnection(strKetNoi);
        //    myConnection.Open();
        //    string thuchiencaulenh = strlaydulieu;
        //    myCommand = new SqlCommand(thuchiencaulenh, myConnection);
        //    myDataReaderMuonTra = myCommand.ExecuteReader();
        //    while (myDataReaderMuonTra.Read())
        //    {
        //        //luuMaSach = cboMaSach0.Text;
                
        //        txtMaDG1.Text = myDataReaderMuonTra.GetString(1);
        //        txtMaSach1.Text = myDataReaderMuonTra.GetString(2);
        //        txtSLMuon1.Text = myDataReaderMuonTra.GetInt32(5).ToString();
        //        dtmNgayMuon1.Text = myDataReaderMuonTra.GetString(3);
        //        dtmNgayTra1.Text = myDataReaderMuonTra.GetString(4);
        //        txtGhiChu1.Text = myDataReaderMuonTra.GetString(6);
        //    }






        //}   
    }
}
