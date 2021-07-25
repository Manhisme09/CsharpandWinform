using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class oto : Vehicle
    {
        int soChoNgoi;
        int dungTich;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap so cho ngoi:");
            soChoNgoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap dung tich:");
            dungTich = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}".PadRight(15)+"{1}",soChoNgoi,dungTich);
            Console.WriteLine();
        }
    }
}
