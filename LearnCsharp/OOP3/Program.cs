using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGK m = new SachGK();
            m.nhap();
            Console.WriteLine("Tac Gia".PadRight(15)+"Dia chi tg".PadRight(15)+"Ma sach".PadRight(15)+"Ten Sach".PadRight(15));
            m.xuat();

        }
    }
}
