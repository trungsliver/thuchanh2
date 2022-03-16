
namespace BTL_HuongSuKien.Forms
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxPhongban = new System.Windows.Forms.ComboBox();
            this.btnHiendsNVPB = new System.Windows.Forms.Button();
            this.dgvNhanvienPB = new System.Windows.Forms.DataGridView();
            this.btnTongNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvienPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban:";
            // 
            // cboxPhongban
            // 
            this.cboxPhongban.FormattingEnabled = true;
            this.cboxPhongban.Location = new System.Drawing.Point(95, 16);
            this.cboxPhongban.Margin = new System.Windows.Forms.Padding(2);
            this.cboxPhongban.Name = "cboxPhongban";
            this.cboxPhongban.Size = new System.Drawing.Size(124, 21);
            this.cboxPhongban.TabIndex = 1;
            // 
            // btnHiendsNVPB
            // 
            this.btnHiendsNVPB.Location = new System.Drawing.Point(248, 17);
            this.btnHiendsNVPB.Margin = new System.Windows.Forms.Padding(2);
            this.btnHiendsNVPB.Name = "btnHiendsNVPB";
            this.btnHiendsNVPB.Size = new System.Drawing.Size(56, 19);
            this.btnHiendsNVPB.TabIndex = 2;
            this.btnHiendsNVPB.Text = "Hiện";
            this.btnHiendsNVPB.UseVisualStyleBackColor = true;
            this.btnHiendsNVPB.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNhanvienPB
            // 
            this.dgvNhanvienPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvienPB.Location = new System.Drawing.Point(32, 58);
            this.dgvNhanvienPB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanvienPB.Name = "dgvNhanvienPB";
            this.dgvNhanvienPB.RowHeadersWidth = 51;
            this.dgvNhanvienPB.RowTemplate.Height = 24;
            this.dgvNhanvienPB.Size = new System.Drawing.Size(654, 163);
            this.dgvNhanvienPB.TabIndex = 3;
            // 
            // btnTongNV
            // 
            this.btnTongNV.Location = new System.Drawing.Point(213, 240);
            this.btnTongNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongNV.Name = "btnTongNV";
            this.btnTongNV.Size = new System.Drawing.Size(67, 19);
            this.btnTongNV.TabIndex = 4;
            this.btnTongNV.Text = "Hiện";
            this.btnTongNV.UseVisualStyleBackColor = true;
            this.btnTongNV.Click += new System.EventHandler(this.btnTongNV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng nhân viên theo phòng ban:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTongNV);
            this.Controls.Add(this.dgvNhanvienPB);
            this.Controls.Add(this.btnHiendsNVPB);
            this.Controls.Add(this.cboxPhongban);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvienPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPhongban;
        private System.Windows.Forms.Button btnHiendsNVPB;
        private System.Windows.Forms.DataGridView dgvNhanvienPB;
        private System.Windows.Forms.Button btnTongNV;
        private System.Windows.Forms.Label label2;
    }
}