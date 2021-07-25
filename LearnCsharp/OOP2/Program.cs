using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.Write("Nhap so nhan vien:");
            //n = int.Parse(Console.ReadLine());
            //NhanVien []a = new NhanVien[n];
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = new NhanVien();
            //    a[i].nhap();
            //}

            //Console.WriteLine("Xuat tt:");
            //for (int i = 0; i < n; i++)
            //{

            //    a[i].xuat();
            //}


            NhanVien a = new NhanVien();
            a.nhap();
            Console.WriteLine("Ho ten".PadRight(15)+"Tuoi".PadRight(15)+"Gioi Tinh".PadRight(15)+"Ma NV".PadRight(15)+"Chuc vu".PadRight(15)+"Luong");
            a.xuat();



            //string str = "forty-two";        
            //Console.Write(str.PadRight(15));    
            //Console.WriteLine(str.PadRight(20));    


        }
    }
}
