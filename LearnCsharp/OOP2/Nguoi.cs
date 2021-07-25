using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Nguoi
    {
        protected string hoten;
        protected int tuoi;
        protected string gioitinh;
       
        public virtual void nhap()
        {
            Console.WriteLine("Nhap ho ten:");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh:");
            gioitinh = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.Write("{0}".PadRight(15)+ "{1}".PadRight(15)+ "{2}".PadRight(15), hoten,tuoi,gioitinh);
        }
    }
}
