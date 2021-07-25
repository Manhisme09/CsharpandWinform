using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra1
{
    class SinhVien
    {
        private string _masv;
        private string _tensv;
        private double _diemtoan;
        private double _diemvan;
        private double _diemanh;

        public string masv
        {
            get { return _masv; }
            set { _masv = value; }
        }

        public string tensv
        {
            get { return _tensv; }
            set { _tensv = value; }
        }

        public double diemtoan
        {
            get { return _diemtoan; }
            set { _diemtoan = value; }
        }
        public double diemvan
        {
            get { return _diemvan; }
            set { _diemvan = value; }
        }
        public double diemanh
        {
            get { return _diemanh; }
            set { _diemanh = value; }
        }

        public SinhVien() { }
        public SinhVien(string masv,string tensv,double diemtoan,double diemvan,double diemanh)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.diemvan = diemvan;
            this.diemtoan = diemtoan;
            this.diemanh = diemanh;
        }

        public double diemTB()
        {
            return ((diemtoan + diemvan + diemanh) / 3);
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ma sinh vien:");
            masv = Console.ReadLine();
            Console.Write("Nhap ten sinh vien:");
            tensv = Console.ReadLine();
            Console.Write("Nhap diem toan:");
            diemtoan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem van:");
            diemvan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem anh:");
            diemanh = Convert.ToInt32(Console.ReadLine());

        }

        public virtual void xuat()
        {
            Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {4,-25} {5,-25}", masv, tensv, diemtoan, diemvan, diemanh,diemTB());
        }
    }
}
