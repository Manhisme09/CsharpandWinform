using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class ttMang
    {
        static void nhap(int []a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
                
            }
        }
        //static void sapXep(int[] a, int n)
        //{
        //    for (int i = 0; i < n-1; i++)
        //    {
        //        for (int j = i+1; j < n; j++)
        //        {
        //            if (a[i] < a[j])
        //            {
        //                int tam = a[i];
        //                a[i] = a[j];
        //                a[j] = tam;
        //            }
        //        }

        //    }
        //}
        static void chen(int[] a, ref int n,int k,int x)
        {
            for (int i = n; i > k; i--)
            {
                a[i] = a[i - 1];
            }
            a[k] = x;
            n++;
        }
        static void Main()
        {
            int n,k,x;
            Console.Write("Nhap so phan tu:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            nhap(a, n);
            xuat(a, n);
            Console.WriteLine();
            //sapXep(a, n);
            Console.Write("Nhap so phan tu can chen:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri chen:");
            k = Convert.ToInt32(Console.ReadLine());
            chen(a, ref n, k, x);
            xuat(a, n);


        }
    }
}
