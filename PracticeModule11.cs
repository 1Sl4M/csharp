using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule11
{
    public class Program
    {
        public struct Employee
        {
            public string Name { get; set; }
            public Vacancies Vacancy { get; set; }
            public int[] HireDate { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return $"{Name}, {Vacancy}, Hired on: {HireDate[0]}.{HireDate[1]}.{HireDate[2]}, Salary: {Salary}";
            }
        }
        public enum Vacancies
        {
            Manager,
            Clerk,
            Engineer
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Islam",
                Vacancy = Vacancies.Manager,
                HireDate = new int[] { 2023, 08, 24 },
                Salary = 250000
            };

            Console.WriteLine(employee1);

            Console.ReadLine();
        }
    }
}
