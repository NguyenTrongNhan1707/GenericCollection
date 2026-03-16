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
            Console.WriteLine("Bai tap 7: Sap xep danh sach");
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("\nDanh sach truoc khi sap xep: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nDanh sach sau khi sap xep: ");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
        }
}