using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IDSach
    {
        string tensach;
        string masach;
        public virtual void nhap()
        {
            Console.WriteLine("Nhap ma sach:");
            masach = Console.ReadLine();
            Console.WriteLine("Nhap ten sach:");
            tensach = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.Write("{0}".PadRight(15)+"{1}",masach,tensach);
            Console.WriteLine();
        }

    }
}
