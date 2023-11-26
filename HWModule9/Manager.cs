using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9
{
    public class Manager: Employee
    {
        private double bonus;

        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Bonus: {bonus}");
        }

        public override double CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + bonus;
        }
    }
}
