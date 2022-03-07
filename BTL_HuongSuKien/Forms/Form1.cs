using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_HuongSuKien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            bool check = false;
            check=check|checktxt(txtHoten);
            check = check | checktxt(txtPhongban);
            check = check | checktxt(txtChucvu);
            check = check | checktxt(txtDiachi);
            check = check | checktxt(txtGioitinh);
            check = check | checktxt2(txtNgaysinh);
            check = check | checktxt(txtSdt);
            if (check==false)
            {
                string cont = @"Data Source=DESKTOP-Q609H2F;Initial Catalog=BTL_QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"themNhanVien";
                cmd.Parameters.AddWithValue("@id_phong_ban",int.Parse(txtPhongban.Text));
                cmd.Parameters.AddWithValue("@id_chuc_vu", int.Parse(txtChucvu.Text));
                cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                cmd.Parameters.AddWithValue("@gioitinh", txtGioitinh.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    connectDB dt = new connectDB();
                    string getdata = "select * from dsNhanVien";
                    load_dgvNhanvien(dt.getTable(getdata));
                }
                else 
                    MessageBox.Show("Thêm không thành công");
                cnt.Close();
            }
            else
            {
                MessageBox.Show("false");
            }
            
            
            
        }

        public bool checktxt(TextBox txtbox)
        {
            if (txtbox.Text=="")
            {
                errorProvider1.SetError(txtbox, "chưa nhập dữ liệu!");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
        }

        public bool checktxt2(MaskedTextBox txtbox)
        {
            if (txtbox.Text == "")
            {
                errorProvider1.SetError(txtbox, "chưa nhập dữ liệu!");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
        }



        private void Form1_Load(object sender, System.EventArgs e)
        {
            connectDB dt = new connectDB();
            string strdata = "select * from dsNhanVien";
            load_dgvNhanvien(dt.getTable(strdata));
            
        }
        public void load_dgvNhanvien(DataTable table)
        {
            dgvNhanvien.DataSource = table;
        }
        
        private void txtHoten_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void txtHoten_Validated(object sender, System.EventArgs e)
        {
            
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtHoten.Text = dgvNhanvien.CurrentRow.Cells["Họ tên"].Value.ToString();
            txtPhongban.Text = dgvNhanvien.CurrentRow.Cells["Mã phòng ban"].Value.ToString();
            txtChucvu.Text = dgvNhanvien.CurrentRow.Cells["Mã chức vụ"].Value.ToString();
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtNgaysinh.Text = dgvNhanvien.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtSdt.Text = dgvNhanvien.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            txtGioitinh.Text = dgvNhanvien.CurrentRow.Cells["Giới tính"].Value.ToString();

        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            int ma= int.Parse(dgvNhanvien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            string cont = @"Data Source=DESKTOP-Q609H2F;Initial Catalog=BTL_QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnt = new SqlConnection(cont);
            cnt.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnt;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"suaNhanVien_diachi";
            cmd.Parameters.AddWithValue("@id", ma);
            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công");
                connectDB dt = new connectDB();
                string getdata = "select * from dsNhanVien";
                load_dgvNhanvien(dt.getTable(getdata)); 
            }
            else MessageBox.Show("Sửa không thành công");

        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            int ma = int.Parse(dgvNhanvien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            string cont = @"Data Source=DESKTOP-Q609H2F;Initial Catalog=BTL_QLNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnt = new SqlConnection(cont);
            cnt.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnt;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"suaNhanVien_trangthai";
            cmd.Parameters.AddWithValue("@id", ma);
            cmd.Parameters.AddWithValue("@trangthai", 0);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công");
                connectDB dt = new connectDB();
                string getdata = "select * from dsNhanVien";
                load_dgvNhanvien(dt.getTable(getdata));
            }
            else MessageBox.Show("Xóa không thành công");
        }
    }
}
