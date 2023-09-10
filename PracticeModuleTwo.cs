using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeModuleTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            //int number1 = 10;
            //int number2 = 20;
            //int number3 = 30;

            //Console.WriteLine($"{number1}  {number2}  {number3}");

            // 2.

            //int n1 = 5;
            //int n2 = 10;
            //int n3 = 21;

            //Console.WriteLine("5\n10\n21");

            // 3.

            //Console.Write("Input cm: ");
            //int cm = int.Parse(Console.ReadLine());

            //int m = cm / 100;

            //Console.WriteLine("Full metres: " + m);

            // 4.

            //Console.WriteLine("Input days");
            //int days = int.Parse(Console.ReadLine());
            //int weeks = days / 7;

            //Console.WriteLine("За " + days + " дней прошло " + weeks + " полных недель.");

            // 5.

            // Console.Write("Введите двузначное число: ");
            //int numberdvux = int.Parse(Console.ReadLine());

            //dvuxznach(numberdvux);

            // 6.

            //Console.WriteLine("Даны радиус круга и сторона квадрата.У какой фигуры площадь больше");

            //Console.Write("Введите радиус круга: ");
            //double radius = double.Parse(Console.ReadLine());

            //Console.Write("Введите длину стороны квадрата: ");
            //double sideLength = double.Parse(Console.ReadLine());

            //double circle = Math.PI * Math.Pow(radius, 2);
            //double qadrat = Math.Pow(sideLength, 2);

            //if (circle > qadrat)
            //{
            //    Console.WriteLine("Площадь круга больше.");
            //}
            //else if (qadrat > circle)
            //{
            //    Console.WriteLine("Площадь квадрата больше.");
            //}
            //else
            //{
            //    Console.WriteLine("Площади равны.");
            //}

            // 7.

            //plotnost();

            // 8.

            //stolbA(20, 35);

            //Console.WriteLine("Введите размер b");
            //int b = Int32.Parse(Console.ReadLine());

            //stolbB(10, b);

            //Console.WriteLine("Введите размер a (a < 50)");
            //int a = Int32.Parse(Console.ReadLine());

            //if(a<50)
            //{
            //    stolbC(a, 50);
            //}
            //else
            //{
            //    throw new Exception("500 Server Error a must be less than 50");
            //}

            //Console.WriteLine("Введите размер x x<y");
            //int x = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Введите размер y y>x");
            //int y = Int32.Parse(Console.ReadLine());

            //if (x < y && x % 1 == 0 && y % 1 == 0)
            //{
            //    stolbD(x, y);
            //}
            //else
            //{
            //    throw new Exception("500 Server Error x must be less than y");
            //}

            // 9.

            //Console.Write("Введите радиус окружности: ");
            //double radius = double.Parse(Console.ReadLine());

            //double circle = calculateCircle(radius);
            //double area = calculateArea(radius);

            //Console.WriteLine($"Длина окружности: {circle:F2}");
            //Console.WriteLine($"Площадь круга: {area:F2}");

            // 10.

            //Console.Write("Введите расстояние в сантиметрах: ");
            //double cm = double.Parse(Console.ReadLine());

            //double m = cm / 100;

            //Console.WriteLine($"Число полных метров: {m:F2} метров");

            // 11.

            //Console.WriteLine("Input days");
            //int days = int.Parse(Console.ReadLine());
            //int weeks = days / 7;

            //Console.WriteLine("За " + days + " дней прошло " + weeks + " полных недель.");

            // 12.

            //Console.Write("Введите двузначное число: ");
            //int numberdvux = int.Parse(Console.ReadLine());

            //dvuxznach(numberdvux);

            // 13.

            //Console.Write("Введите четырехзначное число: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n >= 1000 && n <= 9999)
            //{
            //    chetyrexnumber(n);
            //}
            //else
            //{
            //    throw new Exception("500 Server Error");
            //}

            // 14.

            //int a = 5;
            //int b = 10;

            //Console.WriteLine($"До обмена: a = {a}, b = {b}");

            //swap(ref a, ref b);

            //Console.WriteLine($"После обмена: a = {a}, b = {b}");

            // 15.

            //Console.Write("Введите значение x: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.Write("Введите значение y: ");
            //int y = int.Parse(Console.ReadLine());

            //int result = f(x, y);

            //Console.WriteLine($"Результат: {result}");

            // 16.

            //Console.Write("Введите часы: ");
            //int hours = Int32.Parse(Console.ReadLine());

            //Console.Write("Введите минуты: ");
            //int minutes = Int32.Parse(Console.ReadLine());

            //Console.Write("Введите секунды: ");
            //int seconds = Int32.Parse(Console.ReadLine());

            //int totalSeconds = fff(hours, minutes, seconds);

            //Console.WriteLine($"Прошло секунд с начала дня: {totalSeconds}");

            // 17.

            //Console.Write("Введите месяц (1-12): ");
            //int month = Int32.Parse(Console.ReadLine());

            //Console.Write("Введите день (1-30): ");
            //int day = Int32.Parse(Console.ReadLine());

            //int totalDays = d(month, day);

            //Console.WriteLine($"Прошло дней с начала года: {totalDays}");

            // 18.

            //Console.Write("Введите M (M < N): ");
            //int M = Int32.Parse(Console.ReadLine());

            //Console.Write("Введите N (M < N): ");
            //int N = Int32.Parse(Console.ReadLine());

            //int sumNechetnyx = c(M, N);

            //Console.WriteLine($"Сумма нечетных чисел от M дo N: {sumNechetnyx}");

            // 19.

            //Console.Write("Введите N: ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Введите n: ");
            //int n = int.Parse(Console.ReadLine());

            //int result = e(N, n);

            //Console.WriteLine($"Наименьшее число, большее или равное {N}, которое делится нацело на {n}: {result}");

            // 20.

            //Random random = new Random();
            //using (StreamWriter protocolFile = new StreamWriter("protocol.txt"))
            //{
            //    const int numGrades = 10;

            //    for (int i = 0; i < numGrades; i++)
            //    {
            //        int grade = random.Next(2, 6);

            //        writeToFile(grade, protocolFile);
            //    }
            //}

            //Console.WriteLine("Программа завершила работу. Результаты записаны в файл 'protocol.txt'.");

            Console.ReadLine();
        }

        static void dvuxznach(int number)
        {
            if (number >= 10 && number <= 99)
            {
                // Находим число десятков
                int tens = number / 10;

                // Находим число единиц
                int ones = number % 10;

                // Сумма цифр
                int sum = tens + ones;

                // Произведение цифр
                int product = tens * ones;

                Console.WriteLine("Число десятков: " + tens);
                Console.WriteLine("Число единиц: " + ones);
                Console.WriteLine("Сумма цифр: " + sum);
                Console.WriteLine("Произведение цифр: " + product);
            }
            else
            {
                Console.WriteLine("Введите корректное двузначное число.");
            }
        }

        static void plotnost()
        {
            Console.Write("Введите массу первого тела: ");
            double m1 = double.Parse(Console.ReadLine());

            Console.Write("Введите объем первого тела: ");
            double V1 = double.Parse(Console.ReadLine());

            Console.Write("Введите массу второго тела: ");
            double m2 = double.Parse(Console.ReadLine());

            Console.Write("Введите объем второго тела: ");
            double V2 = double.Parse(Console.ReadLine());

            double p1 = m1 / V1;
            double p2 = m2 / V2;

            if (p1 > p2)
            {
                Console.WriteLine("Материал первого тела имеет большую плотность.");
            }
            else if (p1 > p2)
            {
                Console.WriteLine("Материал второго тела имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }

        static void stolbA(int a, int b)
        {
            if (a < b)
            {
                for (int i = a; a <= b; a++)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("A must be less than B");
            }
        }

        static void stolbB(int a, int b)
        {
            if (b > 10)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("B must be more than 10");
            }
        }

        static void stolbC(int a, int b)
        {

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }

        static void stolbD(int x, int y)
        {
            for (int i = x; x <= y; x++)
            {
                Console.WriteLine(x);
            }
        }

        static double calculateCircle(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        static double calculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static void chetyrexnumber(int n)
        {
            int thousands = n / 1000;
            int hundreds = (n / 100) % 10;
            int tens = (n / 10) % 10;
            int ones = n % 10;

            int sum = thousands + hundreds + tens + ones;
            int product = thousands * hundreds * tens * ones;

            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);
        }

        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int f(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                return 12 / x;
            }
            else if (x == 0)
            {
                return 12 / y;
            }
            else
            {
                return 144 / (x * y);
            }
        }

        static int fff(int h, int m, int s)
        {
            int totalSeconds = h * 3600 + m * 60 + s;
            return totalSeconds;
        }

        static int d(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 30)
            {
                Console.WriteLine("Недопустимые значения месяца или дня.");
                return -1;
            }

            int totalDays = (m - 1) * 30 + d;
            return totalDays;
        }

        static int c(int M, int N)
        {
            int temp = 0;

            if(M<N)
            {
                for(int i = M; i <= N; i++)
                {
                    if(i % 2 != 0)
                    {
                        temp += i;
                    }
                }
            }
            else
            {
                Console.Write("M должен быть < N");
            }

            return temp;
        }

        static int e(int N, int n)
        {
            int x = N;

            while (x % n != 0)
            {
                x++;
            }

            return x;
        }

        static void writeToFile(int grade, StreamWriter protocolFile)
        {
            switch (grade)
            {
                case 2:
                    protocolFile.WriteLine("Неуд");
                    break;
                case 3:
                    protocolFile.WriteLine("Удовл");
                    break;
                case 4:
                    protocolFile.WriteLine("Хор");
                    break;
                case 5:
                    protocolFile.WriteLine("Отл");
                    break;
                default:
                    protocolFile.WriteLine("Недопустимая оценка");
                    break;
            }
        }

    }
}
