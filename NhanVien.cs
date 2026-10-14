
namespace Lab02_OOPBasics
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public decimal LuongCoBan { get; set; }
        public double HeSo { get; set; }
        public decimal PhuCap { get; set; }

        public NhanVien(string ma, string ten, decimal luong,
                        double heSo, decimal phuCap)
        {
            MaNV = ma;
            HoTen = ten;
            LuongCoBan = luong;
            HeSo = heSo;
            PhuCap = phuCap;
        }

        public decimal TinhLuong()
        {
            return LuongCoBan * (decimal)HeSo + PhuCap;
        }

        public void HienThi()
        {
            System.Console.WriteLine(
                $"{MaNV} - {HoTen} - Lương: {TinhLuong():N0} đồng");
        }
    }
}
