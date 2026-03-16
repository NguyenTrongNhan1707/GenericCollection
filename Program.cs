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
            Console.WriteLine("Bai tap 15: Su dung Dictionary");
            Dictionary<String, string> dict = new Dictionary<String, string>
            {
                {"hello", "xin chao"},
                {"goodbye", "tam biet"},
                {"thank you", "cam on"},
                {"sorry", "xin loi"}
            };
            Console.WriteLine("Tu dien hien tai co cac tu sau:");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }
                Console.WriteLine("Nhap tu can dich:");
                string input = Console.ReadLine();
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine("Nghia cua tu '{0}' la: {1}", input, dict[input]);
                }
                else
                {
                    Console.WriteLine("Tu '{0}' khong co trong tu dien.", input);
            }
                Console.ReadLine();
        }
    }
}
