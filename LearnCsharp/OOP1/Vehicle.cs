using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Vehicle
    {
        string nhanHieu;
        int namsx;
        string hang;

        public virtual void nhap()
        {
            Console.WriteLine("Nhap nhan hieu:");
            nhanHieu = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat:");
            namsx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap hang :");
            hang = Console.ReadLine();
            

        }
        public virtual void xuat()
        {
            Console.Write("{0}".PadRight(15)+"{1}".PadRight(15)+"{2}".PadRight(15),nhanHieu,namsx,hang);
        }
    }
}
