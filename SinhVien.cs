
using System;

namespace Lab02_OOPBasics
{
    public class SinhVien
    {
        public string MaSV { get; set; } = "Chưa có";

        private string _hoTen = "Chưa có";
        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được rỗng!");
                _hoTen = value.Trim();
            }
        }

        public DateTime NgaySinh { get; set; } = DateTime.Today;

        private double _diemTB;
        public double DiemTB
        {
            get { return _diemTB; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException(
                        nameof(value), "Điểm phải từ 0 đến 10!");
                _diemTB = value;
            }
        }

        // Bài 2: Constructor mặc định
        public SinhVien() { }

        // Bài 2: Constructor có tham số
        public SinhVien(string maSV, string hoTen,
                        DateTime ngaySinh, double diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiemTB = diemTB;
        }

        // Bài 1: Hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine(
                $"{MaSV,-10} {HoTen,-22} " +
                $"{NgaySinh:dd/MM/yyyy} {DiemTB,6:N2}");
        }

        // Bài 4: Tính tuổi
        public int TinhTuoi()
        {
            int tuoi = DateTime.Today.Year - NgaySinh.Year;
            if (NgaySinh.Date > DateTime.Today.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }

        // Bài 4: Xếp loại
        public string XepLoai()
        {
            if (DiemTB >= 9) return "Xuất sắc";
            if (DiemTB >= 8) return "Giỏi";
            if (DiemTB >= 6.5) return "Khá";
            if (DiemTB >= 5) return "Trung bình";
            return "Yếu";
        }
    }
}
