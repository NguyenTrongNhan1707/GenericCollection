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
            Console.WriteLine("Bai tap 13: De  tong so sinh vien");
            List<student> students = new List<student>();
            students.Add(new student() { id = 1, name = "Nguyen Trong Nhan" });
            students.Add(new student() { id = 2, name = "Do Ngoc Hoang Anh" });
            students.Add(new student() { id = 3, name = "Nguyen Long Nhat" });
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (student s in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}", s.id, s.name);

            }
            Console.WriteLine("Tong so sinh vien: {0}", students.Count);
            Console.ReadLine();
        }
    }
}
