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
            Console.WriteLine("Bai tap 3: Tim so lon nhat");
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"So lon nhat trong danh sach la: {max}");

        }
    }
}