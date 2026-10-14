
using System;

namespace Lab02_OOPBasics
{
    public class HinhChuNhat
    {
        private double _dai;
        private double _rong;

        public double Dai
        {
            get { return _dai; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Chiều dài phải dương!");
                _dai = value;
            }
        }

        public double Rong
        {
            get { return _rong; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Chiều rộng phải dương!");
                _rong = value;
            }
        }

        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public double ChuVi()
        {
            return (Dai + Rong) * 2;
        }

        public double DienTich()
        {
            return Dai * Rong;
        }
    }
}
