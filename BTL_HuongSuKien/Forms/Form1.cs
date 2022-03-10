using BTL_HuongSuKien.Forms;
using System.Configuration;
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

        //Sự kiện click nút Thêm
        private void button1_Click(object sender, System.EventArgs e)
        {
            bool check = false;
            check = check|checktxt(txtHoten);
            check = check | checktxt(txtPhongban);
            check = check | checktxt(txtChucvu);
            check = check | checktxt(txtDiachi);
            check = check | checktxt(txtGioitinh);
            check = check | checktxt2(txtNgaysinh);
            check = check | checktxt(txtSdt);
            if (check==false)
            {
                string cont = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
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
                    MessageBox.Show("Thêm nhân viên thành công");
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
                MessageBox.Show("Thêm không thành công, nhập thiếu nội dung!");
            }   
        }

        //check nôi dung textbox
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

        //check nội dung MaskedTextBox - dành cho textbox ngày sinh
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


        //Load form
        private void Form1_Load(object sender, System.EventArgs e)
        {
            connectDB dt = new connectDB();
            string strdata = "select * from dsNhanVien";
            load_dgvNhanvien(dt.getTable(strdata));
            
        }

        //Lấy data hiển thị lên datagridview
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

        //Sự kiện click vào mỗi cell của datagridview
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

        //Sự kiện click nút Sửa
        private void btnSua_Click(object sender, System.EventArgs e)
        {
            int ma= int.Parse(dgvNhanvien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            string cont = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
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

        //sự kiện click nút Xóa
        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            int ma = int.Parse(dgvNhanvien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
            string cont = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
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

        //sự kiện click nút tìm kiếm
        private void btnTimkiem_Click(object sender, System.EventArgs e)
        {
            if (checktxt(txtHoten) == false)
            {
                connectDB dt = new connectDB();
                string hoten = txtHoten.Text;
                string getdt = @"SELECT id as [Mã nhân viên], 
                                    id_phong_ban as [Mã phòng ban], 
                                    id_chuc_vu as [Mã chức vụ],
                                    ten_nhan_vien as [Họ tên],
                                    ngay_sinh as [Ngày sinh], 
                                    dia_chi as [Địa chỉ], 
                                    sdt as [Số điện thoại], 
                                    gioi_tinh as [Giới tính] 
                                 FROM nhan_vien 
                                 WHERE ten_nhan_vien LIKE '%" + hoten + "%'and trang_thai=1";
                load_dgvNhanvien(dt.getTable(getdt));
            }
            else
            {
                MessageBox.Show("Chưa nhập họ tên trong TextBox!");
            }
        }

        //Sự kiện khi nhấn vào nút Phòng Ban trên menu
        private void phongBànToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            /*
            Form2 mnitem2 = new Form2();
            mnitem2.MdiParent = this;
            mnitem2.Show();*/
            MessageBox.Show("Chưa chuyển sang form Phòng Ban được");
        }

        //Sự kiện khi nhấn vào nút Nhân viên trên menu: load lại datagridview
        private void phòngBanToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            connectDB dt = new connectDB();
            string getdata = "select * from dsNhanVien";
            load_dgvNhanvien(dt.getTable(getdata));
        }
    }
}
