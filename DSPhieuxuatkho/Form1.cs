using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace DSPhieuxuatkho
{
    public partial class frmXuatKho : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmXuatKho()
        {
            InitializeComponent();
        }
        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [DSXuatKho]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void viewData1()
        {
            OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from [NhanVien]", conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }
        void ClearDate()
        {
            txtMaPhieu.Clear();
        }
        void selectNV()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select NVID,TenNV from [Nhanvien]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbNVLH.DataSource = ds.Tables[0];
            cbNVLH.DisplayMember = "TenNV";
            cbNVLH.ValueMember = "NVID";
        }
        private void GeneratePOId()
        {
            // Tạo chuỗi format để tạo ID
            string format = "XK";
            // Lấy ngày hiện tại dưới dạng chuỗi theo định dạng yyMMdd
            string currentDate = DateTime.Now.ToString("ddMMyyyy");
            // Lấy danh sách các PO Id đã tồn tại trong cơ sở dữ liệu
            List<string> existingIds = GetExistingPOIds();
            // Lấy số thứ tự tiếp theo cho PO Id
            int nextId = GetNextPOId(existingIds);
            // Tạo chuỗi số thứ tự tiếp theo dưới dạng 3 chữ số
            string nextIdString = nextId.ToString("D3");
            // Tạo PO Id từ các thành phần
            string poId = string.Format("{0}{1}{2}", format, currentDate, nextIdString);
            // Gán PO Id vào textbox
            txtIDXK.Text = poId;
        }
        private List<string> GetExistingPOIds()
        {
            List<string> existingIds = new List<string>();


            conn.Open();
            using (OleDbCommand cmd = new OleDbCommand("SELECT MaXuatKho FROM DSXuatKho", conn))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existingIds.Add(reader.GetValue(0).ToString());
                    }
                }
                conn.Close();
            }


            return existingIds;
        }

        private int GetNextPOId(List<string> existingIds)
        {
            // Nếu danh sách existingIds rỗng thì trả về số thứ tự đầu tiên là 1
            if (existingIds.Count == 0)
            {
                return 1;
            }
            else
            {
                // Nếu danh sách existingIds không rỗng thì lấy số thứ tự lớn nhất
                // trong danh sách, tăng lên 1 và trả về
                int maxId = existingIds.Select(id => int.Parse(id.Substring(10))).Max();
                return maxId + 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            GeneratePOId();
            GetExistingPOIds();
            viewData1();
            viewData();
            ClearDate();
            DateTime dt = DateTime.Now;
            txtTime.Text = dt.ToString();
            selectNV();

        }

        private void bntThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("DELETE FROM [DSXuatKho] WHERE MAPHIEU = '" + txtMaPhieu.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
            
        }

        private void tabPhieuXuat_Click(object sender, EventArgs e)
        {

        }

        private void bntThem_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [DSXuatKho] values ('" + txtIDXK.Text + "','" + txtMaPhieu.Text + "','" + cbNVLH.Text + "','" + txtTime.Text + "')  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
            MessageBox.Show("Nhập dữ liệu thành công");
           
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("update [DSXuatKho] set " + " NVXuatKho =" + "'" + cbNVLH.Text + "'" + " where MaPhieu ='" + txtMaPhieu.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("DELETE FROM [DSXuatKho] WHERE MAPHIEU = '" + txtMaPhieu.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [NhanVien] (TenNV) values ('" + txtNhanVien.Text + "')  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData1();
            txtNhanVien.Clear();
            selectNV();
            MessageBox.Show("Nhập dữ liệu thành công");
        }

    }
}
