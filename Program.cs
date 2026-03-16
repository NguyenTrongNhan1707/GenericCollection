using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class student
    {
        public int id;
        public string name;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hoten: Nguyen Trong Nhan");
            Console.WriteLine("MSV: 23115053122125");
            Console.WriteLine("Bai tap 17: Tim phan tu xuat hien nhieu nhat");
            List<int> ints = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                int x = int.Parse(Console.ReadLine());
                ints.Add(x);
            }
            var mostFrequent = ints.GroupBy(x => x)
                                   .OrderByDescending(g => g.Count())
                                   .First()
                                   .Key;
            Console.WriteLine("Phan tu xuat hien nhieu nhat: " + mostFrequent + " So lan xuat hien: " + ints.Count(x => x == mostFrequent));
            Console.ReadLine();
        }
    }
}
