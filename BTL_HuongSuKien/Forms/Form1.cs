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

            check = check | checkTextBoxBlank(txtHoten);
            check = check | checkComboBoxBlank(cbPhongBan);
            check = check | checkComboBoxBlank(cbChucVu);
            check = check | checkTextBoxBlank(txtDiachi);
            check = check | checkTextBoxDate(txtNgaysinh);
            check = check | checkTextBoxBlank(txtSdt);

            var idPhongBan = cbPhongBan.SelectedIndex + 1;
            var idChucVu = cbPhongBan.SelectedIndex + 1;

            string gioiTinh = "";
            bool isChecked = rbtNam.Checked;
            if (isChecked)
                gioiTinh = rbtNam.Text;
            else
                gioiTinh = rbtNu.Text;

            if (check == false)
            {
                string cont = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"themNhanVien";

                cmd.Parameters.AddWithValue("@id_phong_ban", idPhongBan);
                cmd.Parameters.AddWithValue("@id_chuc_vu", idChucVu);
                cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
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
        //check comboxBox blank
        public bool checkComboBoxBlank(ComboBox cb)
        {
            if (cb.Text == "")
            {
                errorProvider1.SetError(cb, "Chưa nhập dữ liệu!");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
        }

        //check nôi dung textbox
        public bool checkTextBoxBlank(TextBox txtbox)
        {
            if (txtbox.Text == "")
            {
                errorProvider1.SetError(txtbox, "Chưa nhập dữ liệu!");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
        }

        //check nội dung MaskedTextBox - dành cho textbox ngày sinh
        public bool checkTextBoxDate(MaskedTextBox txtbox)
        {
            if (txtbox.Text == "")
            {
                errorProvider1.SetError(txtbox, "Chưa nhập dữ liệu!");
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

            setInitFormValue();
        }

        //sẽ thực hiện check trùng
        private static bool checkPrimaryKey(SqlConnection conn, int ma)
        {
            string sql = "SELECT * FROM sinh_vien WHERE MaSV=" + ma + "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                //check query da execute
                conn.Close();
                return false;
            }
        }

        private void setInitFormValue()
        {
            rbtNam.Checked = true;
            cbPhongBan.SelectedIndex = 0;
            cbChucVu.SelectedIndex = 0;
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
           // int idPhongBan = cbPhongBan.SelectedIndex + 1;
            cbPhongBan.SelectedIndex = int.Parse(dgvNhanvien.CurrentRow.Cells["Mã phòng ban"].Value.ToString()) - 1;
            cbChucVu.SelectedIndex = int.Parse(dgvNhanvien.CurrentRow.Cells["Mã chức vụ"].Value.ToString()) - 1;
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtNgaysinh.Text = dgvNhanvien.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtSdt.Text = dgvNhanvien.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            string gioiTinh = dgvNhanvien.CurrentRow.Cells["Giới tính"].Value.ToString();
            if(gioiTinh == rbtNam.Text)
            {
                rbtNam.Checked = true;
            } else
            {
                rbtNu.Checked = true;
            }

        }

        //Sự kiện click nút Sửa
        private void btnSua_Click(object sender, System.EventArgs e)
        {
            int ma = int.Parse(dgvNhanvien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
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
                    connectDB dt = new connectDB();
                    string getdata = "select * from dsNhanVien";
                    load_dgvNhanvien(dt.getTable(getdata));
                    MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Xóa không thành công");
        }

        //sự kiện click nút tìm kiếm
        private void btnTimkiem_Click(object sender, System.EventArgs e)
        {
            if (checkTextBoxBlank(txtHoten) == false)
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

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void rbtNu_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}
