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
            Console.WriteLine("Bai tap 1: tao danh sach so nguyen");
            List<int> listInt = new List<int>();
            listInt.Add(205);
            listInt.Add(206);
            listInt.Add(1707);
            listInt.Add(113);
            listInt.Add(3012);
            Console.WriteLine("Danh sach so nguyen: ");
            foreach (int i in listInt)
            {
                Console.WriteLine(i);
            }
        }
    }
}
