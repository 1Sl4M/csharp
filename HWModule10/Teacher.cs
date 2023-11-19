using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
using StudentLibrary;

namespace TeacherLibrary
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }

        public Teacher(string name, int age): base(name, age)
        {
            Name = name;
            Age = age;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            for(int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i].Name);
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Студенты: {0}", Students);
        }

        public override string ToString()
        {
            if (Students == null)
            {
                return $"Имя: {Name}, Возраст: {Age}";
            }
            else
            {
                return $"Имя: {Name}, Возраст: {Age}, Студенты: {Students.Count}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Teacher)
            {
                return Name == ((Teacher)obj).Name && Age == ((Teacher)obj).Age && Students == ((Teacher)obj).Students;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Students.GetHashCode();
        }
    }
}
