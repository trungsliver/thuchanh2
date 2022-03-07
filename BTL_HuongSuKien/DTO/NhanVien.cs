using System;

namespace BTL_HuongSuKien.DTO
{
    internal class NhanVien
    {
        private string tenNhanVien;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private string gioiTinh;
        private int trangThai;

        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }

        public NhanVien(string tenNhanVien, DateTime ngaySinh, string diaChi, string sdt, string gioiTinh, int trangThai)
        {
            this.TenNhanVien = tenNhanVien;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.GioiTinh = gioiTinh;
            this.TrangThai = trangThai;
        }
    }
}
