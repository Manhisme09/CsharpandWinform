using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cn;


            List<NhanVien> listnv = new List<NhanVien>();
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1.Them nhan vien");
                Console.WriteLine("2.Hien thi danh sach");
                Console.WriteLine("3.Sap xep danh sach");
                Console.WriteLine("0.Thoat");
                cn = Convert.ToInt32(Console.ReadLine());


                switch (cn)
                {
                    case 1:

                        Console.WriteLine("Nhap thong tin nhan vien can them:");

                        NhanVien nv = new NhanVien();
                        nv.nhap();
                        listnv.Add(nv);

                        break;
                    case 2:

                        Console.WriteLine("Danh sach nhan vien:");

                        foreach (NhanVien item in listnv)
                        {
                            item.xuat();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < listnv.Count-1; i++)
                        {
                            for(int j = i + 1; j < listnv.Count; j++)
                            {
                                if (listnv[i].Luongcb > listnv[j].Luongcb)
                                {
                                    NhanVien tg = listnv[j];
                                    listnv[j] = listnv[j - 1];
                                    listnv[j - 1] = tg;
                                }    
                            }
                        }

                        break;
                }
            } while (cn != 0);



            //int cn;

            //NhanVien[] a = new NhanVien[10];
            //int n = 0;
            //do
            //{
            //    Console.WriteLine("Chon chuc nang:");
            //    Console.WriteLine("1.Them nhan vien");
            //    Console.WriteLine("2.Hien thi danh sach");
            //    Console.WriteLine("3.Sap xep danh sach");
            //    Console.WriteLine("0.Thoat");
            //    cn = Convert.ToInt32(Console.ReadLine());


            //    switch (cn)
            //    {
            //        case 1:

            //            Console.WriteLine("Nhap thong tin nhan vien can them:");
            //            NhanVien nv = new NhanVien();
            //            nv.nhap();
            //            a[n] = nv;
            //            n++;
            //            break;
            //        case 2:

            //            Console.WriteLine("Danh sach nhan vien:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                a[i].xuat();
            //            }

            //            break;
            //        case 3:
            //            for (int i = 0; i < n-1; i++)
            //            {
            //                for (int j = i+1; j < n; j++)
            //                {
            //                    if(a[i].Luongcb>a[j].Luongcb)
            //                    {
            //                        NhanVien temp = a[i];
            //                        a[i] = a[j];
            //                        a[j] = temp;
            //                    }    
            //                }
            //            }
            //            break;
            //    }
            //} while (cn != 0);


            //int n;
            //Console.Write("Nhap so nhan vien:");
            //n = int.Parse(Console.ReadLine());
            //NhanVien[] a = new NhanVien[10];
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = new NhanVien();
            //    a[i].nhap();
            //}

            //do
            //{
            //    string ma;
            //    Console.WriteLine("Nhap chuc nang:");
            //    ma = Console.ReadLine();
            //    if (ma == "Hien thi danh sach")
            //    {


            //        Console.WriteLine("Danh sach nhan vien:");
            //        for (int i = 0; i < n; i++)
            //        {

            //            a[i].xuat();
            //        }
            //    }
            //    else if (ma == "Them")
            //    {
            //        NhanVien nv = new NhanVien();
            //        Console.WriteLine("Nhap thong tin nhan vien can them:");
            //        nv.nhap();
            //        List<NhanVien> listnv = new List<NhanVien>();
            //        listnv.Add(nv);
            //    }
            //}while(ma =="Thoat")



        }
    }
}
