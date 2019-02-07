using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        public Student() {
            name = Console.ReadLine();
            id = Console.ReadLine();
            year = Convert.ToInt32(Console.ReadLine());
        }
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void info()
        {
            Console.WriteLine(name + " " + id  + " " + (year + 1));
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.info();
            Student b = new Student("Assan", "18bd", 2018);
            b.info();
        }
    }
}
