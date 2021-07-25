using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class HangHoa
    {
        private string _maHang;
        private string _tenHang;
        private int _soLuong;
        private int _gia;

        public string maHang
        {
            get { return _maHang; }
            set { _maHang = value; }
        }

        public string tenHang
        {
            get { return _tenHang; }
            set { _tenHang = value; }
        }
        public int soLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public int gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public HangHoa()
        {

        }

        public HangHoa(string maHang,string tenHang,int soLuong,int gia)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.gia = gia;
        }
        
        public int tongTien()
        {
           return soLuong*gia;
        }

        public virtual void nhap()
        {
            Console.Write("Nhap ma hang:");
            maHang = Console.ReadLine();
            Console.Write("Nhap ten hang:");
            tenHang = Console.ReadLine();
            Console.Write("Nhap so luong:");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia:");
            gia = Convert.ToInt32(Console.ReadLine());

        }

        public virtual void xuat()
        {
            Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {3,-20}", maHang, tenHang, soLuong, gia, tongTien());
        }

    }    
}
