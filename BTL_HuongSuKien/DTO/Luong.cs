namespace BTL_HuongSuKien.DTO
{
    internal class Luong
    {
        private int soNgayCong;

        public Luong(int soNgayCong)
        {
            this.soNgayCong = soNgayCong;
        }

        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
    }
}
