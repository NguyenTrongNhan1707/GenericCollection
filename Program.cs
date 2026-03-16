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
            Console.WriteLine("Bai tap 8: Dao nguoc danh sach");
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Danh sach ban dau:");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            list.Reverse();
            Console.WriteLine("Danh sach sau khi dao nguoc:");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        }
}