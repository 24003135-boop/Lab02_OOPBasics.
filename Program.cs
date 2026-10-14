
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab02_OOPBasics
{
    internal class Program
    {
        static List<SinhVien> ds = new List<SinhVien>
        {
            new SinhVien("SV01", "Nguyen An",
                new DateTime(2005, 5, 12), 8.2),
            new SinhVien("SV02", "Tran Binh",
                new DateTime(2005, 9, 3), 6.8),
            new SinhVien("SV03", "Le Cuong",
                new DateTime(2004, 3, 20), 9.1)
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== LAB 2 C# - 10 BAI =====");
                Console.WriteLine("1. Khai bao lop SinhVien");
                Console.WriteLine("2. Constructor");
                Console.WriteLine("3. Dong goi va kiem tra du lieu");
                Console.WriteLine("4. Tinh tuoi va xep loai");
                Console.WriteLine("5. Quan ly danh sach SinhVien");
                Console.WriteLine("6. Lop SanPham");
                Console.WriteLine("7. TaiKhoanNganHang");
                Console.WriteLine("8. Lop NhanVien");
                Console.WriteLine("9. Lop HinhChuNhat");
                Console.WriteLine("10. Ung dung quan ly sinh vien");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon bai: ");

                string chon = Console.ReadLine();

                try
                {
                    switch (chon)
                    {
                        case "1": Bai1(); break;
                        case "2": Bai2(); break;
                        case "3": Bai3(); break;
                        case "4": Bai4(); break;
                        case "5": Bai5(); break;
                        case "6": Bai6(); break;
                        case "7": Bai7(); break;
                        case "8": Bai8(); break;
                        case "9": Bai9(); break;
                        case "10": Bai10(); break;
                        case "0": return;
                        default:
                            Console.WriteLine("Lua chon khong hop le!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi: " + ex.Message);
                }

                Console.WriteLine("\nNhan Enter de tiep tuc...");
                Console.ReadLine();
            }
        }

        // Bai 1: Khai bao lop va hien thi doi tuong
        static void Bai1()
        {
            SinhVien sv = new SinhVien(
                "SV04", "Pham Minh",
                new DateTime(2005, 1, 15), 7.5);

            sv.HienThi();
        }

        // Bai 2: Hai constructor
        static void Bai2()
        {
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien(
                "SV05", "Hoang Nam",
                new DateTime(2005, 6, 10), 8.5);

            Console.WriteLine("Constructor mac dinh:");
            sv1.HienThi();

            Console.WriteLine("Constructor co tham so:");
            sv2.HienThi();
        }

        // Bai 3: Dong goi va kiem tra du lieu
        static void Bai3()
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = "SV06";
            sv.HoTen = "Nguyen Van A";
            sv.DiemTB = 8;

            Console.WriteLine("Du lieu hop le:");
            sv.HienThi();

            Console.WriteLine("Thu nhap diem 12:");
            sv.DiemTB = 12; // Phat sinh loi de minh hoa
        }

        // Bai 4: Tinh tuoi va xep loai
        static void Bai4()
        {
            SinhVien sv = ds[0];

            Console.WriteLine("Sinh vien: " + sv.HoTen);
            Console.WriteLine("Tuoi: " + sv.TinhTuoi());
            Console.WriteLine("Xep loai: " + sv.XepLoai());
        }

        // Bai 5: Them, in va tim sinh vien
        static void Bai5()
        {
            ds.Add(new SinhVien(
                "SV07", "Do Hoa",
                new DateTime(2005, 8, 12), 7.8));

            Console.WriteLine("Danh sach sinh vien:");
            foreach (SinhVien sv in ds)
                sv.HienThi();

            Console.Write("Nhap ma sinh vien can tim: ");
            string ma = Console.ReadLine() ?? "";

            SinhVien kq = ds.Find(
                x => x.MaSV.Equals(
                    ma, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(kq == null
                ? "Khong tim thay sinh vien."
                : "Tim thay: " + kq.HoTen);
        }

        // Bai 6: San pham
        static void Bai6()
        {
            SanPham sp = new SanPham(
                "SP01", "Ban phim", 250000, 3);

            sp.HienThi();
        }

        // Bai 7: Nap, rut va chuyen tien
        static void Bai7()
        {
            TaiKhoanNganHang tk1 =
                new TaiKhoanNganHang("123", "Nguyen An", 1000000);

            TaiKhoanNganHang tk2 =
                new TaiKhoanNganHang("456", "Tran Binh", 500000);

            tk1.NapTien(200000);
            tk1.RutTien(100000);
            tk1.ChuyenTien(tk2, 300000);

            Console.WriteLine("Tai khoan 1:");
            tk1.HienThi();

            Console.WriteLine("Tai khoan 2:");
            tk2.HienThi();
        }

        // Bai 8: Nhan vien
        static void Bai8()
        {
            List<NhanVien> dsNV = new List<NhanVien>
            {
                new NhanVien("NV01", "Nguyen An",
                    5000000, 2.0, 500000),
                new NhanVien("NV02", "Tran Binh",
                    6000000, 1.5, 300000)
            };

            Console.WriteLine("BANG LUONG NHAN VIEN");
            foreach (NhanVien nv in dsNV)
                nv.HienThi();
        }

        // Bai 9: Hinh chu nhat
        static void Bai9()
        {
            HinhChuNhat hcn = new HinhChuNhat(5, 3);

            Console.WriteLine("Chieu dai: " + hcn.Dai);
            Console.WriteLine("Chieu rong: " + hcn.Rong);
            Console.WriteLine("Chu vi: " + hcn.ChuVi());
            Console.WriteLine("Dien tich: " + hcn.DienTich());
        }

        // Bai 10: Ung dung quan ly sinh vien
        static void Bai10()
        {
            while (true)
            {
                Console.WriteLine("\n--- QUAN LY SINH VIEN ---");
                Console.WriteLine("1. Them");
                Console.WriteLine("2. Sua");
                Console.WriteLine("3. Xoa");
                Console.WriteLine("4. Tim kiem");
                Console.WriteLine("5. Sap xep diem giam dan");
                Console.WriteLine("6. Thong ke");
                Console.WriteLine("7. Hien thi danh sach");
                Console.WriteLine("0. Quay lai menu chinh");
                Console.Write("Chon: ");

                string chon = Console.ReadLine();

                if (chon == "0") break;

                switch (chon)
                {
                    case "1":
                        ThemSV();
                        break;
                    case "2":
                        SuaSV();
                        break;
                    case "3":
                        XoaSV();
                        break;
                    case "4":
                        TimSV();
                        break;
                    case "5":
                        ds = ds.OrderByDescending(
                            x => x.DiemTB).ToList();
                        Console.WriteLine("Da sap xep!");
                        HienThiDS();
                        break;
                    case "6":
                        Console.WriteLine("So sinh vien: " + ds.Count);
                        Console.WriteLine("Diem trung binh: " +
                            (ds.Count > 0
                            ? ds.Average(x => x.DiemTB).ToString("N2")
                            : "Chua co du lieu"));
                        Console.WriteLine("So sinh vien dat tu 5 diem: " +
                            ds.Count(x => x.DiemTB >= 5));
                        break;
                    case "7":
                        HienThiDS();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }

        static void ThemSV()
        {
            Console.Write("Ma SV: ");
            string ma = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(ma) ||
                ds.Any(x => x.MaSV.Equals(
                    ma, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Ma rong hoac da ton tai!");
                return;
            }

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine() ?? "";

            Console.Write("Ngay sinh (dd/MM/yyyy): ");
            DateTime ngay = DateTime.ParseExact(
                Console.ReadLine() ?? "",
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Diem TB: ");
            double diem = double.Parse(Console.ReadLine() ?? "");

            ds.Add(new SinhVien(ma, ten, ngay, diem));
            Console.WriteLine("Them thanh cong!");
        }

        static void SuaSV()
        {
            SinhVien sv = NhapSVTheoMa();
            if (sv == null) return;

            Console.Write("Ho ten moi: ");
            sv.HoTen = Console.ReadLine() ?? "";

            Console.Write("Diem moi: ");
            sv.DiemTB = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Sua thanh cong!");
        }

        static void XoaSV()
        {
            SinhVien sv = NhapSVTheoMa();
            if (sv == null) return;

            ds.Remove(sv);
            Console.WriteLine("Xoa thanh cong!");
        }

        static void TimSV()
        {
            SinhVien sv = NhapSVTheoMa();

            if (sv != null)
            {
                sv.HienThi();
                Console.WriteLine("Tuoi: " + sv.TinhTuoi());
                Console.WriteLine("Xep loai: " + sv.XepLoai());
            }
        }

        static SinhVien NhapSVTheoMa()
        {
            Console.Write("Nhap ma SV: ");
            string ma = Console.ReadLine() ?? "";

            SinhVien sv = ds.Find(x => x.MaSV.Equals(
                ma, StringComparison.OrdinalIgnoreCase));

            if (sv == null)
                Console.WriteLine("Khong tim thay!");

            return sv;
        }

        static void HienThiDS()
        {
            Console.WriteLine("MA SV      HO TEN                 NGAY SINH    DIEM");
            foreach (SinhVien sv in ds)
                sv.HienThi();
        }
    }
}
