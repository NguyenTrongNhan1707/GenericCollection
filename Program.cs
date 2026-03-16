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
            Console.WriteLine("Bai tap 16: Dem so lan xuat hien");
            Console.WriteLine("Nhap chuoi: ");
            string str = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            Console.WriteLine("So lan xuat hien cua cac ky tu:");
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Ky tu '{kvp.Key}': {kvp.Value} lan");
            }
            Console.ReadLine();

        }
        }
}
