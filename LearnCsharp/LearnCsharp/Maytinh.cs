using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int a, b;
            Console.WriteLine("====== May Tinh Ca Nhan =====");
            Console.WriteLine("1.Cong");
            Console.WriteLine("2.Tru");
            Console.WriteLine("3.Nhan");
            Console.WriteLine("4.Chia");
            Console.WriteLine("5.Chia du");
            Console.WriteLine("6.a^b");
            Console.WriteLine("0.Thoat");
            Console.WriteLine("Ban chon phep tinh:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("============= HEN GAP LAI =============");
                    break;
                case 1:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}+{b}={a + b}");
                    break;
                case 2:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case 3:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case 4:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}/{b}={a / b}");
                    break;
                case 5:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}%{b}={a % b}");
                    break;
                case 6:
                    Console.WriteLine("Nhap so nguyen a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}^{b}={Math.Pow(a, b)}");
                    break;
            }
        }
    }
}
