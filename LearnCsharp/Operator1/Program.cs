using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(4,5);
            PhanSo b = new PhanSo(2,3);
            PhanSo x = new PhanSo();
            x = a + b;
            Console.WriteLine(x.ToString());

        }
    }
}
