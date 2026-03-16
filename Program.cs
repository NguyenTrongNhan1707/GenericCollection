using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class student
    {
        public string name;
        public double score;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hoten: Nguyen Trong Nhan");
            Console.WriteLine("MSV: 23115053122125");
            Console.WriteLine("Bai tap 18: Quan ly diem sinh vien");
            List<student> students = new List<student>();
            students.Add(new student() { name = "Nguyen Van Luy", score = 8.5 });
            students.Add(new student() { name = "Nguyen Van Tam", score = 7.0 });
            students.Add(new student() { name = "Tran Cao Van", score = 9.0 });
            students.Add(new student() { name = "Tran Van Viet", score = 9.0 });
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ten: {student.name}, Diem: {student.score}");
            }
            Console.WriteLine("Sinh vien có diem cao nhat la");
            double maxScore = students.Max(s => s.score);
            var topStudents = students.Where(s => s.score == maxScore).ToList();

            Console.WriteLine("\nSinh vien co diem cao nhat la:");
            foreach (var s in topStudents)
            {
                Console.WriteLine($"Ten: {s.name}, Diem: {s.score}");
            }
            Console.ReadLine();
        }
    }
}
