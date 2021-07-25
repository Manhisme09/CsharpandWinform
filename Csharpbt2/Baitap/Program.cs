using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static private List<HangHoa> HH = new List<HangHoa>();
        static public void timKiem()
        {
            string mh;
            Console.WriteLine("Nhap ma hang can tim kiem:");
            mh = Console.ReadLine();
            foreach (HangHoa item in HH)
            {
                if (item.maHang == mh)
                {
                    item.xuat();
                }
            }
        }
        static public void xoaMH()
        {
            string mh;
            Console.WriteLine("Nhap ma hang can xoa:");
            mh = Console.ReadLine();
            for (int i = 0; i < HH.Count; i++)
            {
                if (HH[i].maHang == mh)
                {
                    HH.RemoveAt(i);
                }
            }
        }
        static void Main(string[] args)
        {

            int luaChon;
          
            do
            {
                Console.WriteLine("1.Nhap thong tin mat hang");
                Console.WriteLine("2.Hien thi danh sach hang");
                Console.WriteLine("3.Tim kiem thong tin mat hang");
                Console.WriteLine("4.Xoa mat hang");
                Console.WriteLine("0.Thoat");

                Console.WriteLine("Nhap lua chon cua ban");
                luaChon = Convert.ToInt32(Console.ReadLine());

                switch(luaChon)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin hang hoa can them:");
                        HangHoa h1 = new HangHoa();
                        h1.nhap();
                        HH.Add(h1);
                        break;
                    case 2:
                        Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {3,-25}", "Ma Hang", "Ten Hang", "So Luong", "Gia", "Tong tien");
                        foreach (HangHoa item in HH)
                        {
                            item.xuat();
                        }
                        break;
                    case 3:
                        timKiem();
                        break;
                    case 4:
                        xoaMH();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Moi ban nhap lai");
                        break;

                }



            } while (luaChon != 0);


             

        }
    }
}
