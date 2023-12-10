using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HWModule15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("Задание 1");
            Type consoleType = typeof(Console);
            MethodInfo[] consoleMethods = consoleType.GetMethods();
            foreach (MethodInfo method in consoleMethods)
            {
                Console.WriteLine(method.Name);
            }

            // 2.
            Console.WriteLine("Задание 2");
            Example ex = new Example();
            PropertyInfo[] properties = ex.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(ex)}");
            }

            // 3.
            Console.WriteLine("Задание 3");
            string originalString = "Hello, World!";
            MethodInfo substringMethod = typeof(string).GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            object[] parameters = { 0, 5 };
            string result = (string)substringMethod.Invoke(originalString, parameters);
            Console.WriteLine($"Original String: {originalString}");
            Console.WriteLine($"Substring: {result}\n");

            // 4.
            Console.WriteLine("Задание 4");
            Type listType = typeof(List<>);
            ConstructorInfo[] listConstructors = listType.GetConstructors();
            foreach (ConstructorInfo constructor in listConstructors)
            {
                Console.WriteLine(constructor);
            }


            Console.ReadLine();
        }
        class Example
        {
            public int MyProperty1 { get; set; } = 42;
            public string MyProperty2 { get; set; } = "Hello, Reflection!";
        }
    }
}
