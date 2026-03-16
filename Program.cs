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
            Console.WriteLine("Bai tap 9:Loai bo cac phan tu trung");
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 9, 9, 15, 40 };
            Console.WriteLine("Danh sach ban dau:");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nDanh sach sau khi loai bo cac phan tu trung:");
            List<int> uniqueList = list.Distinct().ToList();
            foreach (int item in uniqueList)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
        }
}