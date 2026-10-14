
using System;

namespace Lab02_OOPBasics
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }

        private double _donGia;
        public double DonGia
        {
            get { return _donGia; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Đơn giá không hợp lệ!");
                _donGia = value;
            }
        }

        private int _soLuong;
        public int SoLuong
        {
            get { return _soLuong; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Số lượng không hợp lệ!");
                _soLuong = value;
            }
        }

        public SanPham(string ma, string ten, double gia, int sl)
        {
            MaSP = ma;
            TenSP = ten;
            DonGia = gia;
            SoLuong = sl;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public void HienThi()
        {
            Console.WriteLine(
                $"{MaSP} - {TenSP} - {DonGia:N0} x " +
                $"{SoLuong} = {ThanhTien():N0} đồng");
        }
    }
}
