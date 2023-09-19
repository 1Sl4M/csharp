using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

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

            // 2.

            //Console.WriteLine("Введите размер массива М:");
            //int m = int.Parse(Console.ReadLine());
            //int[] M = new int[m];
            //Console.WriteLine("Введите размер массива N:");
            //int n = int.Parse(Console.ReadLine());
            //int[] N = new int[n];

            //Random rand = new Random();

            //for(int i = 0; i < m; i++)
            //{
            //    M[i] = rand.Next(1, 10);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    N[i] = rand.Next(1, 10);
            //}
            //for (int i = 0; i < m; i++)
            //{
            //    Console.Write(M[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(N[i] + " ");
            //}

            //HashSet<int> uniqueCommonElements = new HashSet<int>(M.Intersect(N));

            //Console.WriteLine("Уникальные общие элементы:");
            //Console.WriteLine(string.Join(" ", uniqueCommonElements));

            // 3.

            //Console.WriteLine("Введите строку: ");
            //string input = Console.ReadLine();

            //string cleanInput = input.Replace(" ", "").ToLower();

            //char[] inputChars = cleanInput.ToCharArray();

            //Array.Reverse(inputChars);

            //string reverseInput = new string(inputChars);

            //Console.WriteLine(reverseInput);
            //Console.WriteLine(cleanInput);

            //if(cleanInput == reverseInput)
            //{
            //    Console.WriteLine("Палиндром");
            //}
            //else
            //{
            //    Console.WriteLine("Не палиндром");
            //}

            // 4.

            //Console.WriteLine("Введите строку: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');

            //Console.WriteLine(words.Count());

            // 5.

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

            // 6.

            //Console.WriteLine("Введите строку: ");
            //string input = Console.ReadLine();

            //int maxCount = 0;
            //char maxChar = '\0';

            //int currentCount = 1;

            //for (int i = 1; i < input.Length; i++)
            //{
            //    if (input[i] == input[i - 1])
            //    {
            //        currentCount++;

            //        if (currentCount > maxCount)
            //        {
            //            maxCount = currentCount;
            //            maxChar = input[i];
            //        }
            //    }
            //    else
            //    {
            //        currentCount = 1;
            //    }
            //}

            //if (maxCount > 1)
            //{
            //    Console.WriteLine($"Наибольшее количество идущих подряд символов '{maxChar}' равно {maxCount}.");
            //}
            //else
            //{
            //    Console.WriteLine("В строке нет идущих подряд одинаковых символов.");
            //}

            // 7.

            //Console.WriteLine("Введите строку длиной 20 символов: ");
            //string input = Console.ReadLine();

            //if (input.Length != 20)
            //{
            //    Console.WriteLine("Строка должна содержать ровно 20 символов.");
            //    return;
            //}

            //int digitCount = 0;

            //foreach (char c in input)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        digitCount++;
            //    }
            //}

            //Console.WriteLine($"Количество цифр в строке: {digitCount}");

            // 8.

            //Console.WriteLine("Введите текст из 20 букв: ");
            //string input = Console.ReadLine();

            //if (input.Length != 20)
            //{
            //    Console.WriteLine("Текст должен содержать ровно 20 символов.");
            //}
            //else
            //{
            //    string yourName = "Ислам";

            //    if (CanCreateName(input, yourName))
            //    {
            //        Console.WriteLine($"Можно составить имя: {yourName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Нет имени.");
            //    }
            //}

            // 9.

            //Console.WriteLine("Введите строку:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //int count = 0;

            //foreach (string word in words)
            //{
            //    if (word.Length >= 2 && word[0] == word[word.Length - 1])
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Количество слов с совпадающими первым и последним символами: {count}");

            // 10.

            //string[] alphabet = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            //string[] uppercaseAlphabet = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };

            //Console.WriteLine("Введите маленькую букву:");
            //string lowercaseLetter = Console.ReadLine();
            //lowercaseLetter = lowercaseLetter.ToLower();

            //int index = 0;
            //while (index < alphabet.Length)
            //{
            //    if (alphabet[index] == lowercaseLetter)
            //    {
            //        break;
            //    }
            //    index++;
            //}

            //if (index < alphabet.Length)
            //{
            //    Console.WriteLine("Соответствующая большая буква: {0}", uppercaseAlphabet[index]);
            //}
            //else
            //{
            //    Console.WriteLine("Введенная буква не является маленькой русской буквой.");
            //}

            Console.ReadLine();
        }
        static bool CanCreateName(string input, string name)
        {
            input = input.ToUpper();
            name = name.ToUpper();

            foreach (char c in name)
            {
                if (input.Contains(c) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
