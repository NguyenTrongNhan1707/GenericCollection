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
            Console.WriteLine("Bai tap 10: Tim phan tu nho nhat");
            List<int> ints = new List<int>() { 20, 11, 7, 67, 59 };
            Console.WriteLine("Danh sach cac phan tu: ");
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            int min = ints[0];
            for (int i = 1; i < ints.Count; i++)
            {
                if (ints[i] < min)
                {
                    min = ints[i];
                }
            }
            Console.WriteLine("\nPhan tu nho nhat la: " + min);

        }
        }
}