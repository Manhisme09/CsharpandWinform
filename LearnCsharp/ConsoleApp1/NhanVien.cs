using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NhanVien : Person
    {
        private string manv;
        private string chucvu;
        private int luongcb;

        public int Luongcb
        {
            get { return luongcb; }
            set { luongcb = value; }
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap ma nhan vien");
            manv = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu");
            chucvu = Console.ReadLine();
            Console.WriteLine("Nhap luong cb");
            luongcb = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}".PadRight(15) + "{1}".PadRight(15) + "{2}".PadRight(15),manv,chucvu,luongcb);
            if(chucvu=="Giam Doc")
            {
                Console.Write("{0}",luongcb*10);
            }else if(chucvu=="Truong Phong" || chucvu=="Pho Giam Doc")
            {
                Console.Write("{0}", luongcb * 6);
            }else if(chucvu=="Pho Phong")
            {
                Console.Write("{0}", luongcb * 4);
            }
            else
            {
                Console.Write("{0}", luongcb * 2);
            }
            Console.WriteLine();
        }
    }
}
