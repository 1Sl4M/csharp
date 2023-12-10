using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace PracticeModule15
{
    class Example
    {
        private string privateField = "Private Field";
        public int PublicProperty { get; set; }

        public Example()
        {
            // Конструктор без параметров
        }

        private Example(int value)
        {
            // Приватный конструктор
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }
    }

    class Program
    {
        static void Main()
        {
            // 1.
            ExploreType<Example>();

            // 2.
            CreateInstance<Example>();

            // 3.
            ManipulateObject();

            // 4.
            InvokePrivateMethod<Example>();

            Console.ReadLine();
        }

        static void ExploreType<T>()
        {
            Type type = typeof(T);

            Console.WriteLine($"Имя класса: {type.Name}");

            Console.WriteLine("\nКонструкторы:");
            foreach (var constructor in type.GetConstructors())
            {
                Console.WriteLine($"{constructor} - {constructor.IsPublic}");
            }

            Console.WriteLine("\nПоля и свойства:");
            foreach (var member in type.GetMembers())
            {
                Console.WriteLine($"{member} - {member.MemberType}");
            }

            Console.WriteLine("\nМетоды:");
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine($"{method} - {method.ReturnType}");
            }
        }

        static void CreateInstance<T>()
        {
            object instance = Activator.CreateInstance<T>();
            Console.WriteLine($"Создан экземпляр {instance.GetType().Name}");
        }

        static void ManipulateObject()
        {
            Example myObject = new Example();
            Type type = typeof(Example);

            PropertyInfo property = type.GetProperty("PublicProperty");
            property.SetValue(myObject, 42);

            MethodInfo method = type.GetMethod("PublicMethod");
            method.Invoke(myObject, null);

            Console.WriteLine($"Измененное значение свойства: {myObject.PublicProperty}");
        }

        static void InvokePrivateMethod<T>()
        {
            Example myObject = new Example();
            Type type = typeof(T);

            MethodInfo method = type.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(myObject, null);
        }
    }

}
