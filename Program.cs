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
            Console.WriteLine("Bai tap 4: Dem so chan");
            List<int> numbers = new List<int> { 1, 2, 34, 5, 67, 8, 9, 22, 33, 44, 56 };
            Console.WriteLine("Danh sach : " + string.Join(", ", numbers));
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("So luong so chan la: " + count);
        }
    }
}