using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_HuongSuKien.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string getdt = "select ten_phong_ban as[Tên phòng ban] from phong_ban";
            connectDB db = new connectDB();
            DataTable table = db.getTable(getdt);
            foreach (DataRow i in table.Rows)
            {
                cboxPhongban.Items.Add(i["Tên phòng ban"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenpb = cboxPhongban.SelectedItem.ToString();
            /*            MessageBox.Show(tenpb);*/
            string getdt = "exec NV_PhongBan @phongban=N'" + tenpb + "'";
            connectDB db = new connectDB();
            load_dgvNhanvienPB(db.getTable(getdt));
        }
        public void load_dgvNhanvienPB(DataTable table)
        {
            dgvNhanvienPB.DataSource = table;
        }

        private void btnTongNV_Click(object sender, EventArgs e)
        {
            string getdt = "select*from tongNV_PhongBan";
            connectDB db = new connectDB();
            load_dgvNhanvienPB(db.getTable(getdt));
        }
    }
}
