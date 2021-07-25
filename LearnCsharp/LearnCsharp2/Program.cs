using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhan n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            while(n > 0)
            {
                n = n / 10;
                if (n > 0) 
                    dem++;
            }
            Console.WriteLine("{0}",dem+1);
                  
        }
    }
}
