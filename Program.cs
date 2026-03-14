using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoten: Nguyen Trong Nhan");
            Console.WriteLine("MSV: 23115053122125");
            Console.WriteLine("Bai tap 2: Tinh tong cac phan tu");
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap 5 so nguyen : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap so nguyen thu {0}: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so nguyen hop le.");
                    i--;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine("Tong cac phan tu trong danh sach la: " + sum);
        }
    }
}