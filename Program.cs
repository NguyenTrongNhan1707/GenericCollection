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
            Console.WriteLine("Bai tap 6: Kiem tra phan tu yeu cau");
            List<String> list = new List<string> { "Nhan", "Anh yeu em", "Ly", "Vip", "Hello" };
            Console.WriteLine("Danh sach phan tu trong list: ");
            foreach (String elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Nhap phan tu can kiem tra: ");
            String element = Console.ReadLine();
            if (list.Contains(element))
            {
                Console.WriteLine("Phan tu {0} co trong list", element);
            }
            else
            {
                Console.WriteLine("Phan tu {0} khong co trong list", element);

            }
        }
    }
}