using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class moto : Vehicle
    {
        int phanKhoi;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap phan khooi:");
            phanKhoi = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}", phanKhoi);
            Console.WriteLine();
            
        }
    }   
}
