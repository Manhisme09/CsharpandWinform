using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator1
{
    class PhanSo
    {
        int tuso;
        int mauso;
        public PhanSo()
        {
            tuso = 1;
            mauso = 1;
        }
        public PhanSo(int tuso,int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public static PhanSo operator +(PhanSo a,PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tuso = a.tuso*b.mauso + b.tuso*a.mauso;
            c.mauso = a.mauso * b.mauso;
            return c;
        }
        public override string ToString()
        {
            return Convert.ToString(this.tuso) + "/" + Convert.ToString(this.mauso);
        }
    }
}
