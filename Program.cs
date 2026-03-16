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
            Console.WriteLine("Bai tap 5: Xoa phan tu khoi List");
            List<string> list = new List<string> { string.Empty, "Nhan", "Van", "Ly", "Tinh", "Nhat" };
            Console.WriteLine("Danh sach truoc khi xoa:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(string.Empty);
            Console.WriteLine("Nhap vao ten can xoa:");
            string nameToRemove = Console.ReadLine();
            if (list.Remove(nameToRemove))
            {
                Console.WriteLine($"Da xoa {nameToRemove} khoi danh sach.");
            }
            else
            {
                Console.WriteLine($"{nameToRemove} khong co trong danh sach.");
            }
            Console.WriteLine("Danh sach sau khi xoa:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}