using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string hoten;
        private string diachi;

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap ho ten:");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            diachi = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.Write("{0}".PadRight(15) + "{1}".PadRight(15),hoten,diachi);
        }
    }
}
