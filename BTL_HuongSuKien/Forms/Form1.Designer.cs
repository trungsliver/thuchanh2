namespace BTL_HuongSuKien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.txtNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(735, 243);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(735, 281);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 26);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(735, 322);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 26);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(735, 364);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(78, 23);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phòng ban";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chức vụ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(131, 247);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(174, 20);
            this.txtHoten.TabIndex = 11;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            this.txtHoten.Validated += new System.EventHandler(this.txtHoten_Validated);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(476, 287);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(171, 20);
            this.txtDiachi.TabIndex = 15;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(476, 329);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(171, 20);
            this.txtSdt.TabIndex = 16;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(30, 32);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(850, 194);
            this.dgvNhanvien.TabIndex = 18;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(476, 247);
            this.txtNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgaysinh.Mask = "00/00/0000";
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(171, 20);
            this.txtNgaysinh.TabIndex = 19;
            this.txtNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanToolStripMenuItem,
            this.phongBànToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.phòngBanToolStripMenuItem.Text = "Nhân viên";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // phongBànToolStripMenuItem
            // 
            this.phongBànToolStripMenuItem.Name = "phongBànToolStripMenuItem";
            this.phongBànToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.phongBànToolStripMenuItem.Text = "Phòng ban";
            this.phongBànToolStripMenuItem.Click += new System.EventHandler(this.phongBànToolStripMenuItem_Click);
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Items.AddRange(new object[] {
            "Phòng kinh doanh",
            "Phòng nhân sự",
            "Phòng kế toán",
            "Phòng marketing",
            "Phòng kĩ thuật"});
            this.cbPhongBan.Location = new System.Drawing.Point(131, 287);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(174, 21);
            this.cbPhongBan.TabIndex = 21;
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Phó phòng",
            "Nhân viên"});
            this.cbChucVu.Location = new System.Drawing.Point(131, 327);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(174, 21);
            this.cbChucVu.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtNu);
            this.panel1.Controls.Add(this.rbtNam);
            this.panel1.Location = new System.Drawing.Point(476, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 63);
            this.panel1.TabIndex = 23;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNu.Location = new System.Drawing.Point(113, 6);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(47, 24);
            this.rbtNu.TabIndex = 25;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nu";
            this.rbtNu.UseVisualStyleBackColor = true;
            this.rbtNu.CheckedChanged += new System.EventHandler(this.rbtNu_CheckedChanged);
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNam.Location = new System.Drawing.Point(3, 6);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(60, 24);
            this.rbtNam.TabIndex = 24;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Danh sách nhân viên";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.MaskedTextBox txtNgaysinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongBànToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.RadioButton rbtNam;
    }
}

