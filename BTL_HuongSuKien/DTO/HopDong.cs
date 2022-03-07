using System;

namespace BTL_HuongSuKien.DTO
{
    internal class HopDong
    {
        private string loaiHopDong;
        private int idNhanVien;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int donGiaNgayCong;
        private int trangThai;

        public HopDong(string loaiHopDong, int idNhanVien, DateTime ngayBatDau, DateTime ngayKetThuc, int donGiaNgayCong, int trangThai)
        {
            this.loaiHopDong = loaiHopDong;
            this.idNhanVien = idNhanVien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.donGiaNgayCong = donGiaNgayCong;
            this.trangThai = trangThai;
        }

        public string LoaiHopDong { get => loaiHopDong; set => loaiHopDong = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int DonGiaNgayCong { get => donGiaNgayCong; set => donGiaNgayCong = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
