using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
using StudentLibrary;
using StudentWithAdviserLibrary;
using TeacherLibrary;

namespace HWModule10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[]
        {
            new Person("Olzhas", 21),
            new Student("Alihan", 20, 1),
            new Student("Elkhan", 21, 3),
            new Student("Iliyas", 20, 2),
            new StudentWithAdviser("Dimash", 21, 2, new Teacher("Evgenii", 45)),
        };

            
            var students = new List<Student>
            {
                new Student("Madina", 20, 1),
                new Student("Dias", 21, 3),
                new Student("Iliyas Ashim", 20, 2),
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Evgenii", 45),
                new Teacher("Arai", 50),
                new Teacher("Bimbam", 48),
            };

            var advisor = new Teacher("Evgenii", 45);

            var student = new Student("Islam", 20, 1);

            advisor.AddStudent(student);

            foreach (var newperson in persons)
            {
                newperson.Print();
            }

            var personsCount = persons.Where(p => p is Person).Count();
            var studentsCount = persons.Where(p => p is Student).Count();
            var teachersCount = persons.Where(p => p is Teacher).Count();

            foreach (var newstudent in persons.Where(p => p is Student).Cast<Student>())
            {
                student.Course++;
            }

            Console.Write(advisor + " = ");

            advisor.ShowStudents();

            foreach (var person in persons)
            {
                if (person is Person)
                {
                    personsCount++;
                }
                else if (person is Student)
                {
                    studentsCount++;
                }
                else if (person is Teacher)
                {
                    teachersCount++;
                }
                else if (person is StudentWithAdviser)
                {
                    studentsCount++;
                }
            }

            Person a = new Person("Olzhas", 21);
            Person b = new Person("Olzhas", 21);
            Student c = new Student("Alihan", 20, 1);
            Student d = new Student("Alihan", 20, 1);
            Teacher e = new Teacher("Arai", 45);
            Teacher f = new Teacher("Evgenii", 45);

            Console.WriteLine("a == b: {0}", a == b);
            Console.WriteLine("c == d: {0}", c == d);
            Console.WriteLine("e == f: {0}", e == f);

            Console.WriteLine("a != b: {0}", a != b);
            Console.WriteLine("c != d: {0}", c != d);
            Console.WriteLine("e != f: {0}", e != f);

            Type studentType = student.GetType();
            Console.WriteLine(studentType.Name);

            Console.ReadLine();
        }
    }
}

