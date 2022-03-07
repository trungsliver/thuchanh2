using System;

namespace BTL_HuongSuKien.DTO
{
    public class ChucVu
    {
        private String tenChucVu;
        private int soTienPhuCap;

        public ChucVu(string tenChucVu, int soTienPhuCap)
        {
            this.tenChucVu = tenChucVu;
            this.soTienPhuCap = soTienPhuCap;
        }

        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public int SoTienPhuCap { get => soTienPhuCap; set => soTienPhuCap = value; }
    }
}
