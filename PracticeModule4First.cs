using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeModule4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            students[0] = new Student
            {
                name = "Ислам",
                surname = "Шопалов",
                otchestvo = "Аскарбекович",
                numberOfGroup = 1,
                Value = new int[] { 4, 5, 5, 5, 5 }
            };
            students[1] = new Student
            {
                name = "Аймурат",
                surname = "Идриссов",
                otchestvo = "Нурланович",
                numberOfGroup = 1,
                Value = new int[] { 4, 5, 4, 3, 5 }
            };
            students[2] = new Student
            {
                name = "Олжас",
                surname = "Адылханов",
                otchestvo = "Айдынулы",
                numberOfGroup = 1,
                Value = new int[] { 5, 5, 5, 4, 5 }
            };
            students[3] = new Student
            {
                name = "Эльхан",
                surname = "Исаев",
                otchestvo = "Фагратович",
                numberOfGroup = 2,
                Value = new int[] { 5, 5, 5, 5, 5 }
            };
            students[4] = new Student
            {
                name = "Димаш",
                surname = "Омирзак",
                numberOfGroup = 2,
                Value = new int[] { 4, 5, 5, 3, 5 }
            };
            students[5] = new Student
            {
                name = "Алихан",
                surname = "Сабитов",
                otchestvo = "Уральскович",
                numberOfGroup = 1,
                Value = new int[] { 5, 5, 4, 5, 5 }
            };
            students[6] = new Student
            {
                name = "Ильяс",
                surname = "Укенов",
                otchestvo = "Олжасович",
                numberOfGroup = 2,
                Value = new int[] { 4, 5, 4, 5, 5 }
            };
            students[7] = new Student
            {
                name = "Санжар",
                surname = "Калибеков",
                otchestvo = "Гитарович",
                numberOfGroup = 2,
                Value = new int[] { 5, 5, 5, 5, 5 }
            };
            students[8] = new Student
            {
                name = "Мадина",
                surname = "Жакупова",
                otchestvo = "Незнаювич",
                numberOfGroup = 1,
                Value = new int[] { 4, 5, 4, 3, 5 }
            };
            students[9] = new Student
            {
                name = "Евгений",
                surname = "Халык",
                otchestvo = "Банк",
                numberOfGroup = 100,
                Value = new int[] { 5, 5, 4, 4, 5 }
            };

            var sortedStudents = students.OrderByDescending(s => s.GetAvgValue(s.Value)).ToArray();

            for (int i = 0; i < students.Length; i++)
            {
                bool allGradesAre4Or5 = true;

                for (int j = 0; j < sortedStudents[i].Value.Length; j++)
                {
                    if (sortedStudents[i].Value[j] != 4 && sortedStudents[i].Value[j] != 5)
                    {
                        allGradesAre4Or5 = false;
                        break;
                    }
                }

                if (allGradesAre4Or5)
                {
                    Console.WriteLine($"ФИО: {sortedStudents[i].FullName}");
                    Console.WriteLine($"ФИО сокращенный: {sortedStudents[i].ShortFullName}");
                    Console.WriteLine($"Группа: {sortedStudents[i].numberOfGroup}");
                    Console.WriteLine($"Средний балл: {sortedStudents[i].GetAvgValue(sortedStudents[i].Value)}");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}

public class Student
{
    public string name { get; set; }
    public string surname { get; set; }
    public string otchestvo { get; set; }
    public string FullName
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(otchestvo))
            {
                return string.Format("{0} {1} {2}", surname, name, otchestvo);
            }
            else
            {
                return string.Format("{0} {1}", surname, name);
            }

        }
    }
    public string ShortFullName
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(otchestvo))
                return string.Format("{0} {1}.{2}.", surname, name[0], otchestvo[0]);
            else
                return string.Format(" {0} {1}.", name, surname[0]);
        }
    }
    public int numberOfGroup { get; set; }

    private int[] _value = new int[5];

    public int[] Value
    {
        get { return _value; }
        set { _value = value; }
    }
    public double GetAvgValue(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / 5;
    }
}
