namespace BTL_HuongSuKien.DTO
{
    internal class PhongBan
    {
        private string tenPhongBan;

        public PhongBan(string tenPhongBan)
        {
            this.TenPhongBan = tenPhongBan;
        }

        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
    }
}
