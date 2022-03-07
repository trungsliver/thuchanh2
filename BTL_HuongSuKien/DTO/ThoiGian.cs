namespace BTL_HuongSuKien.DTO
{
    internal class ThoiGian
    {
        private int thang;
        private int nam;

        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }

        public ThoiGian(int thang, int nam)
        {
            this.Thang = thang;
            this.Nam = nam;
        }
    }
}
