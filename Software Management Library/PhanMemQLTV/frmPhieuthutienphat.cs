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
    public partial class frmPhieuthutienphat : Form
    {
        public frmPhieuthutienphat()
        {
            InitializeComponent();
        }
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
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
            return myTable;
        }


        Bitmap bitmap;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSotienthu.Text) < Convert.ToInt32(txtTongno.Text))
            {
                MessageBox.Show("Tiền thu nhỏ hơn tiền nợ!");
                return;
            }
            this.Print_PhieuThu();

            

            /*Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();*/
        }

        private void Print_PhieuThu()
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;
            this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 970, 234);
            this.printPreviewDialog1.Document = this.printDocument1;
            if (this.printPreviewDialog1.ShowDialog() == DialogResult.OK)
                this.printDocument1.Print();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 0, 0);
            e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(12, 9, 926, 50));
            e.Graphics.DrawString("PHIẾU THU TIỀN PHẠT", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(376, 26));
            e.Graphics.DrawString("Mã đọc giả: " + this.txtMaDG.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 86));
            e.Graphics.DrawString("Họ tên độc giả: " + this.txtHotenDG.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 86));
            e.Graphics.DrawString("Tổng nợ: " + this.txtTongno.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 124));
            e.Graphics.DrawString("Tiền thu: " + this.txtSotienthu.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 124));
            e.Graphics.DrawString("Còn lại: " + txtConlai.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 170));
        }


        private void txtMaDG_TextChanged(object sender, EventArgs e)
       {
            if(txtMaDG.Text == "")
            {
                txtHotenDG.Text = "";
                txtTongno.Text = "";
                return;
            }
            string query = "set dateformat dmy; select * from tblHSPhieuMuon where MaDG = '" + txtMaDG.Text + "'";
            DataTable temp = ketnoi(query);
            if(temp.Rows.Count == 0)
            {
                txtHotenDG.Text = "";
                txtTongno.Text = "";
                return;
            }
            int cnt = 0;
            int tongngay = 0;
            foreach(DataRow row in temp.Rows)
            {
                TimeSpan dif = DateTime.Now - Convert.ToDateTime(row["NgayTra"].ToString());
                if (dif.Days > 0)
                {
                    tongngay += dif.Days;
                    cnt += (int)row[5];
                }
            }

            query = "select TenDG from tblDocGia where MaDG = '" + txtMaDG.Text + "'";
            ketnoi(query);
            txtHotenDG.Text =  myCommand.ExecuteScalar().ToString();
            query = "select GiaTri from thamso where TenTS = 'TienPhat'";
            ketnoi(query);
            int tp = (int)myCommand.ExecuteScalar();
            txtTongno.Text = (cnt * tongngay * tp).ToString();
        }

        private void txtSotienthu_TextChanged(object sender, EventArgs e)
        {
            if (txtSotienthu.Text == "")
                return;
            int tienthu = Convert.ToInt32(txtSotienthu.Text);
            txtConlai.Text = (tienthu - Convert.ToInt32(txtTongno.Text)).ToString();
        }

        private void frmPhieuthutienphat_Load(object sender, EventArgs e)
        {

        }
    }
}
