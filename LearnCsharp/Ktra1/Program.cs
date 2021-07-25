using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra1
{
    class Program
    {
        static private List<SinhVien> sv = new List<SinhVien>();

        static public void timKiem()
        {
            string ma;
            Console.WriteLine("Nhap ma sinh vien can tim kiem:");
            ma = Console.ReadLine();
            foreach (SinhVien item in sv)
            {
                if (item.masv == ma)
                {
                    item.xuat();
                }
            }
        }

        static public void xoasv()
        {
            string ma;
            Console.WriteLine("Nhap ma sinh vien can xoa:");
            ma = Console.ReadLine();
            for (int i = 0; i < sv.Count; i++)
            {
                if (sv[i].masv == ma)
                {
                    sv.RemoveAt(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int luachon;
            var a = 1;
            do
            {
                Console.WriteLine("============Main Menu============");
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1.Nhap thong tin sinh vien");
                Console.WriteLine("2.Hien thi danh sach sinh vien");
                Console.WriteLine("3.Tim sinh vien");
                Console.WriteLine("4.Xoa sinh vien");
                Console.WriteLine("0.Thoat");

                Console.WriteLine("Nhap lua chon cua ban");
                luachon = Convert.ToInt32(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin sinh vien:");
                        SinhVien sv1 = new SinhVien();
                        sv1.nhap();
                        sv.Add(sv1);
                        break;
                    case 2:
                        Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {4,-25} {5,-25}", "Ma SV", "Ten SV", "Diem Toan", "Diem Van", "Diem Anh","Diem TB");
                        foreach (SinhVien item in sv)
                        {
                            item.xuat();
                        }
                        break;
                    case 3:
                        timKiem();
                        break;
                    case 4:
                        xoasv();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Moi ban nhap lai");
                        break;
                }
                

            } while (luachon != 0);
        }
    }
}
