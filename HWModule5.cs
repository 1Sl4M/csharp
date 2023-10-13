using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HWModule5
{
    internal class HWModule5
    {
        static void Main(string[] args)
        {
            // 1.

            //try
            //{
            //    string url = "https://example.com/nonexistent_resource";

            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadString(url);
            //    }
            //}
            //catch (WebException ex)
            //{
            //    Console.WriteLine("Произошла ошибка при запросе веб-ресурса: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Завершение работы программы (пример 1).");
            //}

            // 2.

            int[] numbers = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Произошло исключение: выход за пределы массива.");
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива (пример 2).");
            }

            // 3.

            //try
            //{
            //    CallingMethod();
            //}
            //catch (CustomException ex)
            //{
            //    Console.WriteLine($"Произошло исключение: {ex.Message}");
            //}


            // 4.

            try
            {
                CallingMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Произошло исключение: {ex.Message}");
            }

            Console.ReadLine();
        }
        static void CallingMethod()
        {
            try
            {
                SecondMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение обработано в вызывающем методе.");
                throw;
            }
        }
        static void SecondMethod()
        {
            throw new CustomException("Это собственное исключение из второго метода.");
        }
    }
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
