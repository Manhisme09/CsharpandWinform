using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Mang_4
    {
        static void nhap(int[] number, int n)
        {
            for (int i = 0; i<n; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            nhap(number,n);
            int max = number[0];
            int min = number[0];
            int max2, min2;
            for (int i = 0; i < n; i++)
            {
                if (max < number[i])
                {
                    max = number[i];
                }
                if (min > number[i])
                {
                    min = number[i];
                }
            }
            max2 = min;
            min2 = max;
            for (int i = 0; i < n; i++)
            {
                if(max2 < number[i] && number[i] != max)
                {
                    max2 = number[i];
                }
                if (min2 > number[i] && number[i] != min)
                {
                    min2 = number[i];
                }
            }
            Console.WriteLine("Gia tri nho thu hai: " + min2);
            Console.WriteLine("Gia tri lon thu hai la: " + max2);
        }
    }
}
