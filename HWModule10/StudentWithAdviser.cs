using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using TeacherLibrary;

namespace StudentWithAdviserLibrary
{
    public class StudentWithAdviser : Student
    {
        public Teacher Advisor { get; set; }

        public StudentWithAdviser(string name, int age, int course, Teacher advisor)
            : base(name, age, course)
        {
            Advisor = advisor;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Курс: {0}, Руководитель: {1}", Course, Advisor);
        }

        public override string ToString()
        {
            if (Advisor == null)
            {
                return $"Имя: {Name}, Возраст: {Age}, Курс: {Course}";
            }
            else
            {
                return $"Имя: {Name}, Возраст: {Age}, Курс: {Course}, Руководитель: {Advisor.Name}";
            }
        }
    }
}
