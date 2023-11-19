using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
using TeacherLibrary;

namespace StudentLibrary
{
    public class Student : Person
    {
        public int Course { get; set; }

        public Student(string name, int age, int course): base(name, age)
        {
            Name = name;
            Age = age;
            Course = course;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Курс: {0}", Course);
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Курс: {Course}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                return Name == ((Student)obj).Name && Age == ((Student)obj).Age && Course == ((Student)obj).Course;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Course.GetHashCode();
        }
    }
}
