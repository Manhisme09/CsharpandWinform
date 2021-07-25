using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class SachGK : IDSach
    {
        TacGia x = new TacGia();
        public override void nhap()
        {
            Console.WriteLine("Nhap ten tac gia:");
            x.tentg = Console.ReadLine();
            Console.WriteLine("Nhap dia chi tac gia:");
            x.diachitg = Console.ReadLine();
            base.nhap();
        }
        public override void xuat()
        {
            Console.Write("{0}".PadRight(15)+"{1}".PadRight(15),x.tentg,x.diachitg);
            base.xuat();
        }
    }
}
