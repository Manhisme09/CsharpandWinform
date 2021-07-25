using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class xemcung
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int dem = 0;
            while (true)
            {
                Console.WriteLine("Nhap ngay sinh:");
                day = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang sinh:");
                month = int.Parse(Console.ReadLine());
                if (month == 2 && day >= 1 && day <= 28)
                {
                    break;
                }
                if ((month == 4 || month == 6 || month == 9 || month == 11) && day >= 1 && day <= 30)
                {
                    break;

                }
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day >= 1 && day <= 31)
                {
                    break;
                }
                Console.WriteLine("Khong hop le");
                dem++;
                if (dem == 3)
                {
                    System.Environment.Exit(0);
                }
            }
            string result = "";
            switch (month)
            {
                case 1:
                    if (day >= 20)
                    {
                        result = "Bao Binh";
                    }
                    else
                    {
                        result = "Ma Ket";
                    }
                    break;

                case 2:
                    if (day >= 19)
                    {
                        result = "Song Ngu";
                    }
                    else
                    {
                        result = "Bao Binh";
                    }
                    break;

                case 3:
                    if (day >= 21)
                    {
                        result = "Bach Duong";
                    }
                    else
                    {
                        result = "Song Ngu";
                    }
                    break;

                case 4:
                    if (day < 20)
                    {
                        result = "Bach Duong";
                    }
                    else
                    {
                        result = "Kim Nguu";
                    }
                    break;

                case 5:
                    if (day >= 21)
                    {
                        result = "Song Tu";
                    }
                    else
                    {
                        result = "Kim Nguu";
                    }
                    break;

                case 6:
                    if (day < 21)
                    {
                        result = "Song Tu";
                    }
                    else
                    {
                        result = "Cu Giai";
                    }
                    break;

                case 7:
                    if (day >= 23)
                    {
                        result = "Su Tu";
                    }
                    else
                    {
                        result = "Cu Giai";
                    }
                    break;

                case 8:
                    if (day < 23)
                    {
                        result = "Su Tu";
                    }
                    else
                    {
                        result = "Xu Nu";
                    }
                    break;

                case 9:
                    if (day >= 23)
                    {
                        result = "Thien Binh";
                    }
                    else
                    {
                        result = "Xu Nu";
                    }
                    break;

                case 10:
                    if (day < 23)
                    {
                        result = "Thien Binh";
                    }
                    else
                    {
                        result = "Thien Yet";
                    }
                    break;

                case 11:
                    if (day >= 22)
                    {
                        result = "Nhan Ma";
                    }
                    else
                    {
                        result = "Thien Yet";
                    }
                    break;

                case 12:
                    if (day < 22)
                    {
                        result = "Nhan Ma";
                    }
                    else
                    {
                        result = "Ma Ket";
                    }
                    break;
            }
            Console.WriteLine($"Ban thuoc cung {result}");

        }
    }
}
