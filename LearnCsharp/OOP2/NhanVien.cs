using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class NhanVien : Nguoi
    {
         string manv;
         string chucvu;
         int luong;
       
        public override void nhap()
        {
           base.nhap();
            Console.WriteLine("Nhap ma nhan vien:");
            manv = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu:");
            chucvu = Console.ReadLine();
            Console.WriteLine("Nhap luong:");
            luong = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}".PadRight(15)+"{1}".PadRight(15)+"{2}", manv, chucvu, luong);
            Console.WriteLine();
        }

        
    }
}
