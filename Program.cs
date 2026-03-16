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
            Console.WriteLine("Bai tap 14: Xoa sinh vien theo ID");
            List<student> students = new List<student>();
            students.Add(new student() { id = 17, name = "Nguyen Trong Nhan" });
            students.Add(new student() { id = 21, name = "Do Ngoc Hoang Anh" });
            students.Add(new student() { id = 30, name = "Nguyen Long Nhat" });
            students.Add(new student() { id = 07, name = "Nguyen Long Nha" });
            students.Add(new student() { id = 01, name = "Nguyen Thanh Cong" });
            students.Add(new student() { id = 50, name = "Pham Van Vu" });
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (student s in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}", s.id, s.name);

            }
            Console.WriteLine("Nhap ID sinh vien can xoa: ");
            int id = int.Parse(Console.ReadLine());
            student studentToRemove = students.FirstOrDefault(s => s.id == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Da xoa sinh vien co ID: {0}", id);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ID: {0}", id);
            }
            Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
            foreach (student s in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}", s.id, s.name);
            }
        }
    }
}
