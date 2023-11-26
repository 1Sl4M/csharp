using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //List<int> numbers = new List<int> { 1, 5, 3, 7, 2, 8, 6, 4 };

            //int secondMaxValue = numbers.OrderByDescending(x => x).Skip(1).FirstOrDefault();
            //int secondMaxIndex = numbers.FindIndex(x => x == secondMaxValue);

            //Console.WriteLine($"Второе максимальное значение: {secondMaxValue}, Позиция: {secondMaxIndex}");

            //numbers.RemoveAll(x => x % 2 != 0);

            //Console.WriteLine("Список после удаления нечетных элементов:");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            // 2.
            //List<double> doubles = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };

            //double average = doubles.Average();

            //var result = doubles.Where(x => x > average);

            //Console.WriteLine("Элементы больше среднего арифметического:");
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            // 3.
            //List<string> lines = File.ReadAllLines("input.txt").ToList();
            //lines.Reverse();
            //File.WriteAllLines("output.txt", lines);

            // 4.
            //StreamReader reader = new StreamReader("employee.txt");
            //List<Employee> employees = new List<Employee>();

            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    string[] values = line.Split(';');

            //    Employee employee = new Employee(values[0], values[1], values[2], values[3], int.Parse(values[4]), int.Parse(values[5]));
            //    employees.Add(employee);
            //}

            //List<Employee> lowSalaryEmployees = new List<Employee>();
            //List<Employee> highSalaryEmployees = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.Salary < 10000)
            //    {
            //        lowSalaryEmployees.Add(employee);
            //    }
            //    else
            //    {
            //        highSalaryEmployees.Add(employee);
            //    }
            //}

            //Console.WriteLine("Сотрудники с зарплатой менее 10000:");
            //foreach (Employee employee in lowSalaryEmployees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("Сотрудники с зарплатой более 10000:");
            //foreach (Employee employee in highSalaryEmployees)
            //{
            //    Console.WriteLine(employee);
            //}

            //reader.Close();

            // 5.
            MusicCatalog catalog = new MusicCatalog();

            Disk disk1 = new Disk { Artist = "Artist1", Title = "Title1" };
            disk1.Songs.Add("Song1");
            disk1.Songs.Add("Song2");

            Disk disk2 = new Disk { Artist = "Artist2", Title = "Title2" };
            disk2.Songs.Add("Song3");
            disk2.Songs.Add("Song4");

            catalog.AddDisk("key1", disk1);
            catalog.AddDisk("key2", disk2);

            catalog.AddSong("key1", "Song5");

            catalog.DisplayCatalog();

            Console.ReadLine();
        }
    }
}
class Employee
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(string surname, string name, string patronymic, string gender, int age, int salary)
    {
        this.Surname = surname;
        this.Name = name;
        this.Patronymic = patronymic;
        this.Gender = gender;
        this.Age = age;
        this.Salary = salary;
    }
}
class Disk
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public List<string> Songs { get; set; } = new List<string>();
}
class MusicCatalog
{
    private Hashtable catalog = new Hashtable();

    public void AddDisk(string key, Disk disk)
    {
        catalog.Add(key, disk);
    }

    public void RemoveDisk(string key)
    {
        catalog.Remove(key);
    }

    public void AddSong(string diskKey, string song)
    {
        if (catalog.ContainsKey(diskKey) && catalog[diskKey] is Disk disk)
        {
            disk.Songs.Add(song);
        }
    }

    public void RemoveSong(string diskKey, string song)
    {
        if (catalog.ContainsKey(diskKey) && catalog[diskKey] is Disk disk)
        {
            disk.Songs.Remove(song);
        }
    }

    public void DisplayCatalog()
    {
        foreach (DictionaryEntry entry in catalog)
        {
            var disk = (Disk)entry.Value;
            Console.WriteLine($"Disk: {disk.Artist} - {disk.Title}");
            foreach (var song in disk.Songs)
            {
                Console.WriteLine($"  {song}");
            }
        }
    }
}
