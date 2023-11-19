using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule11
{
    public class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        public struct Employee : IEmployee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Gender Gender { get; set; }
            public string Position { get; set; }
            public int Salary { get; set; }
            public DateTime Hiredate { get; set; }

            public Employee(string name, int age, Gender gender, string position, int salary, DateTime hiredate)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
                this.Position = position;
                this.Salary = salary;
                this.Hiredate = hiredate;
            }
            public override string ToString()
            {
                return $"{this.Name} {this.Age} лет, пол: {this.Gender}, должность: {this.Position}, зп: {this.Salary}, был нанят на работу : {this.Hiredate}";
            }
        }

        static void Main(string[] args)
        {
            double avgSalary = 0;

            Console.WriteLine("Введите длину массива сотрудников: ");
            int arrayLength = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Введите имя сотрудника №{0}", i+1);
                string name = Console.ReadLine();

                Console.WriteLine("Введите возраст сотрудника №{0}", i + 1);
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введите пол сотрудника №{i + 1} (Male/Female):");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                Console.WriteLine("Введите должность сотрудника №{0}", i + 1);
                string position = Console.ReadLine();

                Console.WriteLine("Введите зп сотрудника №{0}", i + 1);
                int salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату приема на работу (формат: yyyy-MM-dd): ");
                DateTime hireDate = DateTime.Parse(Console.ReadLine());

                employees[i] = new Employee(name, age, gender, position, salary, hireDate);

                avgSalary += salary;
            }

            avgSalary /= arrayLength;

            Console.WriteLine("Введите должность сотрудников, информацию о которых хотите получить: ");
            string searchPosition = Console.ReadLine();

            Array.Sort(employees, new CompareEmployeesByLastName());

            Console.WriteLine("Введите дату для фильтрации сотрудников (формат: yyyy-MM-dd): ");
            DateTime filterDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите пол сотрудников, информацию о которых хотите получить (Male/Female). Чтобы вывести всех, просто нажмите Enter: ");
            string genderInput = Console.ReadLine();
            Gender? filterGender = string.IsNullOrWhiteSpace(genderInput) ? (Gender?)null : (Gender)Enum.Parse(typeof(Gender), genderInput, true);

            List<Employee> filteredEmployees = new List<Employee>();
            Console.WriteLine("Список мэнеджеров у кого зп больше средней");
            foreach (var employee in employees)
            {
                if(employee.Hiredate > filterDate && employee.Salary >= avgSalary && employee.Position == searchPosition && ((!filterGender.HasValue || employee.Gender == filterGender.Value)
                ))
                {
                    filteredEmployees.Add(employee);
                }
            }
            for(int i = 0; i < filteredEmployees.Count; i++)
            {
                Console.WriteLine(filteredEmployees[i]);
            }

            Console.ReadLine();
        }
        private class CompareEmployeesByLastName : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
