using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using TeacherLibrary;

namespace PersonLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() {}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        Random random = new Random();

        public Person RandomPerson(List<Person> persons)
        {
            int randomIndex = random.Next(0, persons.Count);
            return persons[randomIndex];
        }

        public Student RandomStudent(List<Student> students)
        {
            var randomIndex = random.Next(0, students.Count);
            return students[randomIndex];
        }


        public Teacher RandomTeacher(List<Teacher> teachers)
        {
            var randomIndex = random.Next();
            return teachers[randomIndex];
        }


        public virtual void Print()
        {
            Console.WriteLine("Имя: {0}, Возраст: {1}", Name, Age);
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}
