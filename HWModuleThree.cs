using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModuleThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Console.WriteLine("Input size of array");
            //int n = Int32.Parse(Console.ReadLine());

            //int [] array = new int[n];

            //inputArray(array, n);

            //outputArray(array, n);

            // 2.
            //int[] array = { 1, 2, 3, 4, 5, 6, 50, 7, 8, 9, 10 };
            //int max = array.Max();
            //int maxIndex = Array.IndexOf(array, max);

            //outputArray(array, array.Length);

            //Console.WriteLine($"\nМаксимальное значение: {max}");
            //Console.WriteLine($"Индекс максимального значения: {maxIndex}");

            // 3.

            //int[] array = { 1, 2, 3, 4, 5, 6, 50, 51, 7, 8, 9, 10 };
            //int maxEvenIndex = -1;
            //int maxEvenValue = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0 && array[i] > maxEvenValue)
            //    {
            //        maxEvenValue = array[i];
            //        maxEvenIndex = i;
            //    }
            //}

            //if (maxEvenIndex != -1)
            //{
            //    Console.WriteLine($"Максимальное четное значение: {maxEvenValue}");
            //    Console.WriteLine($"Индекс максимального четного значения: {maxEvenIndex}");
            //}
            //else
            //{
            //    Console.WriteLine("В массиве нет четных значений.");
            //}

            // 4.

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine("Введите индекс элемента который хотите удалить");
            //int z = int.Parse(Console.ReadLine());

            //deleteElement(list, z);

            // 5.
            //Console.WriteLine("Введите текст: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{   
            //    if (words[i].Contains('а'))
            //    {
            //        words[i] = "";
            //    }
            //}
            //string output = string.Join(" ", words);

            //Console.WriteLine(output);

            // 6.

            //Console.WriteLine("Введите текст: ");
            //string text = Console.ReadLine();

            //squareScobki(text);

            // 7.

            //int spacesCount = 0;

            //while(true)
            //{
            //    char symbol = Console.ReadKey().KeyChar;

            //    if(symbol == '.')
            //    {
            //        break;
            //    }

            //    if(symbol == ' ')
            //    {
            //        spacesCount++;
            //    }
            //}

            //Console.WriteLine("\nКоличество пробелов: " + spacesCount);

            // 8.

            //string ticketNumber;

            //Console.WriteLine("Введите номер трамвайного билета:");
            //ticketNumber = Console.ReadLine();

            //if (ticketNumber.Length != 6)
            //{
            //    Console.WriteLine("Неверный формат номера билета.");
            //    return;
            //}
            //else
            //{
            //    happyTicket(ticketNumber);
            //}

            // 9.

            //int n;

            //Console.WriteLine("Введите целое число N (> 0):");
            //n = int.Parse(Console.ReadLine());

            //string numberStr = n.ToString();

            //string reversedStr = new string(numberStr.Reverse().ToArray());

            //int reversedNumber = int.Parse(reversedStr);

            //Console.WriteLine("Число, полученное при прочтении числа N справа налево: {0}", reversedNumber);

            // 10.

            //int[] A = new int[5];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"Введите значение для A[{i}]: ");
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //// Создаем и заполняем двумерный массив B случайными числами
            //int[,] B = new int[3, 4];
            //Random random = new Random();
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 4; col++)
            //    {
            //        B[row, col] = random.Next(11);
            //    }
            //}

            //Console.WriteLine("Массив A:");
            //foreach (int num in A)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Массив B:");
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 4; col++)
            //    {
            //        Console.Write(B[row, col] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int maxA = A[0];
            //int minA = A[0];
            //int maxB = B[0, 0];
            //int minB = B[0, 0];
            //int sumAll = 0;
            //int productAll = 1;
            //int sumEvenA = 0;
            //int sumOddColumnsB = 0;

            //foreach (int num in A)
            //{
            //    if (num > maxA)
            //        maxA = num;
            //    if (num < minA)
            //        minA = num;
            //    sumAll += num;
            //    productAll *= num;
            //    if (num % 2 == 0)
            //        sumEvenA += num;
            //}

            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 4; col++)
            //    {
            //        int num = B[row, col];
            //        if (num > maxB)
            //            maxB = num;
            //        if (num < minB)
            //            minB = num;
            //        sumAll += num;
            //        productAll *= num;
            //        if (col % 2 != 0)
            //            sumOddColumnsB += num;
            //    }
            //}

            //Console.WriteLine($"Максимальный элемент в A: {maxA}");
            //Console.WriteLine($"Минимальный элемент в A: {minA}");
            //Console.WriteLine($"Максимальный элемент в B: {maxB}");
            //Console.WriteLine($"Минимальный элемент в B: {minB}");
            //Console.WriteLine($"Общая сумма всех элементов: {sumAll}");
            //Console.WriteLine($"Общее произведение всех элементов: {productAll}");
            //Console.WriteLine($"Сумма четных элементов в A: {sumEvenA}");
            //Console.WriteLine($"Сумма нечетных столбцов в B: {sumOddColumnsB}");

            // 11.

            //int[,] array = new int[5, 5];

            //Random random = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        array[i, j] = random.Next(-100, 101);
            //    }
            //}

            //Console.WriteLine("Двумерный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int min = array[0, 0];
            //int max = array[0, 0];
            //int sum = 0;
            //bool foundMin = false;
            //bool foundMax = false;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        int current = array[i, j];

            //        if (current < min)
            //        {
            //            min = current;
            //            foundMin = true;
            //        }

            //        if (current > max)
            //        {
            //            max = current;
            //            foundMax = true;
            //        }

            //        if (foundMin && foundMax)
            //        {
            //            break;
            //        }
            //    }

            //    if (foundMin && foundMax)
            //    {
            //        break;
            //    }
            //}

            //bool betweenMinMax = false;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        int current = array[i, j];

            //        if (current == min)
            //        {
            //            betweenMinMax = !betweenMinMax;
            //        }
            //        else if (current == max)
            //        {
            //            betweenMinMax = !betweenMinMax;
            //        }
            //        else if (betweenMinMax)
            //        {
            //            sum += current;
            //        }
            //    }
            //}

            //Console.WriteLine("Минимальный элемент: " + min);
            //Console.WriteLine("Максимальный элемент: " + max);
            //Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);

            // 12.

            //string input = "Туда сюда бим бим бам бам / тутутутутуту \\";

            //string output = input.Replace("/", "Javascript is better").Replace("\\", "");

            //Console.WriteLine(output);

            // 13.

            //Console.WriteLine("Введите строку:");
            //string input = Console.ReadLine();

            //int digitCount = countDigits(input);

            //Console.WriteLine("Количество цифр в строке: " + digitCount);

            // 14.

            //Console.WriteLine("Введите строку:");
            //string input = Console.ReadLine();

            //int count = countCharacterOccurrences(input, 'p');

            //Console.WriteLine("Количество вхождений буквы 'p': " + count);

            // 15.

            //Console.WriteLine("Введите текст:");
            //string inputText = Console.ReadLine();

            //string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine($"Количество слов в тексте: {words.Length}");
            //Console.WriteLine("Слова в столбик:");

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            // 16. Задача на сникерс

            //string str = "123 456 784 321 453";
            //int sum = 0;

            //string[] words = str.Split(' ');

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //    if (word[word.Length - 1] == '3' || word[word.Length - 1] == '4')
            //    {
            //        sum += int.Parse(word);
            //    }
            //}

            //Console.WriteLine("Сумма чисел, оканчивающихся на цифры 3 или 4: {0}", sum);


            Console.ReadLine();
        }

        static void inputArray(int[] array, int n)
        {

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        } 

        static void outputArray(int []array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void deleteElement(List <int> list, int z)
        {
            if(z >= 0 && z < list.Count)
            {
                int deletedElement = list[z];

                list.RemoveAt(z);

                Console.WriteLine("Новый список:");
                foreach (int l in list)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine($"\nУдаленный элемент {deletedElement}");
            }
            else
            {
                Console.WriteLine("Неверный индекс элемента для удаления.");
            }
        }

        static void squareScobki(string text)
        {
            string[] words = text.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].First() == words[i].Last())
                {
                    words[i] = "[" + words[i] + "]";
                }
            }

            string output = string.Join(" ", words);

            Console.WriteLine(output);
        }

        static int calculateSumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    sum += int.Parse(digit.ToString());
                }
            }
            return sum;
        }

        static void happyTicket(string ticketNumber)
        {
            string firstDig, lastDig;

            firstDig = ticketNumber.Substring(0, 3);
            lastDig = ticketNumber.Substring(3, 3);

            int sumFirstHalf = calculateSumOfDigits(firstDig);
            int sumSecondHalf = calculateSumOfDigits(lastDig);

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Поздравляю у вас счастливый билет.");
            }
            else
            {
                Console.WriteLine("Извините но вы лузер.");
            }
        }

        static int countDigits(string input)
        {
            int digitCount = 0;

            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }

        static int countCharacterOccurrences(string str, char character)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (c == character)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
