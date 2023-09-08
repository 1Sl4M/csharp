using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Create simple console app
            consoleApp();

            // 5. Output FIO
            Console.WriteLine("Input your name!");
            string name = Console.ReadLine();

            Console.WriteLine("Input your second name!");
            string sname = Console.ReadLine();

            Console.WriteLine("Input your otchestvo!");
            string otchestvo = Console.ReadLine();

            if (IsNumeric(name) || IsNumeric(sname) || IsNumeric(otchestvo))
            {
                Console.WriteLine("Invalid input for name, last name, or middle name. Please enter valid strings.");
                Console.ReadLine();
            }
            else
            {
                FIO(name, sname, otchestvo);
            }

            //6.Output sum of numbers
            Console.WriteLine("Input first number!");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input second number!");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input third number!");
            int c = Int32.Parse(Console.ReadLine());

            sumOfNumbers(a, b, c);
        }

        static void FIO(string name, string sname, string otchestvo)
        {
            Console.Write("Privetstvuu vas " + sname + " " + name + " " + otchestvo);

            Console.ReadLine();
        }

        static void sumOfNumbers(int a, int b, int c)
        {
            int plus = a + b + c;

            Console.WriteLine("Sum of numbers: " + plus);
            Console.ReadLine();
        }

        static void consoleApp()
        {
            Console.WriteLine("Hello World!");
        }

        static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
