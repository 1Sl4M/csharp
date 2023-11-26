using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("John Manager", 35, 60000, 5000);
            Developer developer = new Developer("Alice Developer", 28, 70000, 1000);

            manager.GetInfo();
            Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary()}");

            Console.WriteLine();

            developer.GetInfo();
            Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary()}");

            Console.ReadLine();
        }
    }
}
