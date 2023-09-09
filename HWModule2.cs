using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Console.WriteLine("Input text (if you wanna stop, press .)");

            //string input = readText();
            //int spaceCount = countSpace(input);

            //Console.WriteLine("\nYour text:");
            //Console.WriteLine(input);
            //Console.WriteLine($"Spaces: {spaceCount}");
            //Console.ReadLine();

            // 2.
            //Console.WriteLine("Input your ticket's number");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int ticket))
            //{
            //    luckyTicket(ticket);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            //Console.ReadLine();

            // 4.
            //int a, b;

            //Console.Write("Введите значение A: ");
            //if (int.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.Write("Введите значение B (B > A): ");
            //    if (int.TryParse(Console.ReadLine(), out b))
            //    {
            //        if (b > a)
            //        {
            //            twoArray(a, b);
            //        }
            //        else
            //        {
            //            Console.WriteLine("B должно быть больше A.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введите корректное значение B.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Введите корректное значение A.");
            //}
            //Console.ReadLine();

            // 5.
            //Console.Write("Input number n: ");
            //int n = Int32.Parse(Console.ReadLine());

            //int reversedN = reverseNumber(n);

            //Console.WriteLine("Reversed: " + reversedN);
            //Console.ReadLine();

            // 6.
            //int n1 = 1;
            //int n2 = 2;
            //int n3 = 3;

            //printNumber(n1, n2, n3);
            //Console.ReadLine();

            // 7.
            //int nnn1 = 5;
            //int nnn2 = 10;
            //int nnn3 = 21;

            //Console.WriteLine("5\n10\n21");

            // 8.
            //Console.Write("Input cm: ");
            //int cm = int.Parse(Console.ReadLine());

            //int m = cm / 100;

            //Console.WriteLine("Full metres: " + m);

            // 9.
            //Console.WriteLine("Input days");
            //int days = int.Parse(Console.ReadLine());
            //int weeks = days / 7;

            //Console.WriteLine("За " + days + " дней прошло " + weeks + " полных недель.");

            // 10.
            //Console.Write("Введите двузначное число: ");
            //int numberdvux = int.Parse(Console.ReadLine());

            //dvuxznach(numberdvux);

            // 11.
            //bool A = true;
            //bool B = false;
            //bool C = false;

            //bool resultA = A || B;
            //Console.WriteLine("A или B: " + resultA);

            //bool resultB = A && B;
            //Console.WriteLine("A и B: " + resultB);

            //bool resultC = B || C;
            //Console.WriteLine("B или C: " + resultC);

            // 12.

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

            // 13.

            //plotnost();

            // 15.

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

            // 16.

            //Console.Write("Введите значение x: ");
            //double x = double.Parse(Console.ReadLine());

            //double result = uravnenie(x);

            //Console.WriteLine($"Значение функции при x = {x} равно {result}");

            // 25.

            //Console.Write("Введите двузначное число: ");
            //int n = int.Parse(Console.ReadLine());

            //if(n >= 10 && n <= 99)
            //{
            //    twentyfive(n);
            //}
            //else
            //{
            //    throw new Exception("500 Server Error");
            //}

            // 26.

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

            // 34.

            //Console.Write("Введите порядковый номер дня недели (1-7): ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //string dayName = getDayName(dayNumber);

            //Console.WriteLine("Название дня недели: " + dayName);

            // 35.

            //Console.Write("Введите порядковый номер месяца (1-12): ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //string monthName = getMonthName(monthNumber);

            //Console.WriteLine("Название месяца: " + monthName);

            // 36.

            //Console.Write("Введите порядковый номер месяца (1-12): ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //string season = getSeason(monthNumber);

            //Console.WriteLine($"Месяц {monthNumber} относится к времени года: {season}");

            // 41.

            //Console.WriteLine("Фунты    Килограммы");
            //Console.WriteLine("--------------------");

            //for (int pounds = 1; pounds <= 10; pounds++)
            //{
            //    double kilograms = pounds * 0.453;
            //    Console.WriteLine($"{pounds,-9} {kilograms,-12:F3}");
            //}


            Console.ReadLine();
        }

        static string readText()
        {
            string input = "";

            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                if (c == '.')
                {
                    break;
                }
                input += c;
            }

            return input;
        }
        
        static int countSpace(string input)
        {
            int spaces = 0;
            foreach(char c in input)
            {
                if (c == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }

        static void luckyTicket(int ticket)
        {
            if (ticket > 100000 && ticket < 999999)
            {
                int digit1 = ticket / 100000 % 10; // Первая цифра
                int digit2 = ticket / 10000 % 10;  // Вторая цифра
                int digit3 = ticket / 1000 % 10;   // Третья цифра
                int digit4 = ticket / 100 % 10;    // Четвертая цифра
                int digit5 = ticket / 10 % 10;     // Пятая цифра
                int digit6 = ticket % 10;          // Шестая цифра

                int sumFirstHalf = digit1 + digit2 + digit3;
                int sumSecondHalf = digit4 + digit5 + digit6;

                if(sumFirstHalf == sumSecondHalf)
                {
                    Console.WriteLine("Congratulations! You have lucky ticket");
                }
                else
                {
                    Console.WriteLine("Unfortunatelly you're loser");
                }
            }
            else
            {
                Console.WriteLine("ticket must be 6 znachnyi");
            }
        }

        static void twoArray(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static int reverseNumber(int number)
        {
            string numberStr = number.ToString();
            char[] charArray = numberStr.ToCharArray(); // массив символов
            Array.Reverse(charArray); // переворачиваю
            string reversedStr = new string(charArray); // делаю стринг
            return int.Parse(reversedStr); // возвращаю результат
        }

        static void printNumber(int n1, int n2, int n3)
        {
            Console.WriteLine($"{n1}  {n2}  {n3}");
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
                for(int i = a; a <= b; a++)
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
            if(b > 10)
            {
                for( int i = a; i <= b; i++)
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
            for(int i = x; x <= y; x++)
            {
                Console.WriteLine(x);
            }
        }

        static double uravnenie(double x)
        {
            double y = 7 * Math.Pow(x, 2) - 3 * x + 6;
            return y;
        }

        static void twentyfive(int n)
        {
            int tens = n / 10;
            int ones = n % 10;

            int sum = tens + ones;
            int product = tens * ones;

            Console.WriteLine("Число десятков: " + tens);
            Console.WriteLine("Число единиц: " + ones);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);
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

        static string getDayName(int dayNumber)
        {
            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 7:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Недопустимый номер дня";
                    break;
            }

            return dayName;
        }

        static string getMonthName(int monthNumber)
        {
            string monthName;

            switch (monthNumber)
            {
                case 1:
                    monthName = "Январь";
                    break;
                case 2:
                    monthName = "Февраль";
                    break;
                case 3:
                    monthName = "Март";
                    break;
                case 4:
                    monthName = "Апрель";
                    break;
                case 5:
                    monthName = "Май";
                    break;
                case 6:
                    monthName = "Июнь";
                    break;
                case 7:
                    monthName = "Июль";
                    break;
                case 8:
                    monthName = "Август";
                    break;
                case 9:
                    monthName = "Сентябрь";
                    break;
                case 10:
                    monthName = "Октябрь";
                    break;
                case 11:
                    monthName = "Ноябрь";
                    break;
                case 12:
                    monthName = "Декабрь";
                    break;
                default:
                    monthName = "Недопустимый номер месяца";
                    break;
            }

            return monthName;
        }

        static string getSeason(int monthNumber)
        {
            string season;

            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    season = "Капец холодно это же зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Все цветет у всех аллергия, медведь с спячки просыпается это же весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Шымкент +50 это Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Опять.... Универ.... Осень....";
                    break;
                default:
                    season = "Недопустимый номер месяца";
                    break;
            }

            return season;
        }
    }
}
