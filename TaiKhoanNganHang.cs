
using System;

namespace Lab02_OOPBasics
{
    public class TaiKhoanNganHang
    {
        public string SoTaiKhoan { get; set; }
        public string ChuTaiKhoan { get; set; }
        public decimal SoDu { get; private set; }

        public TaiKhoanNganHang(string soTK, string chuTK,
                                decimal soDuBanDau = 0)
        {
            if (soDuBanDau < 0)
                throw new ArgumentException("Số dư không được âm!");

            SoTaiKhoan = soTK;
            ChuTaiKhoan = chuTK;
            SoDu = soDuBanDau;
        }

        public void NapTien(decimal tien)
        {
            if (tien <= 0)
                throw new ArgumentException("Tiền nạp phải lớn hơn 0!");
            SoDu += tien;
        }

        public bool RutTien(decimal tien)
        {
            if (tien <= 0 || tien > SoDu)
                return false;

            SoDu -= tien;
            return true;
        }

        public bool ChuyenTien(TaiKhoanNganHang dich, decimal tien)
        {
            if (dich == null || dich == this ||
                tien <= 0 || tien > SoDu)
                return false;

            RutTien(tien);
            dich.NapTien(tien);
            return true;
        }

        public void HienThi()
        {
            Console.WriteLine(
                $"{SoTaiKhoan} - {ChuTaiKhoan} - Số dư: {SoDu:N0} đồng");
        }
    }
}
