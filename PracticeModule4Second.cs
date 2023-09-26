using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

abstract class Animal : IComparable<Animal>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public abstract string Type { get; }
    public abstract double FoodConsumption();

    public int CompareTo(Animal other)
    {
        int result = other.FoodConsumption().CompareTo(this.FoodConsumption());
        if (result == 0)
            result = this.Name.CompareTo(other.Name);
        return result;
    }
}

class Carnivore : Animal
{
    public double DailyMeatConsumption { get; set; }

    public override string Type => "Хищник";

    public override double FoodConsumption()
    {
        return DailyMeatConsumption;
    }
}

class Omnivore : Animal
{
    public double DailyMeatConsumption { get; set; }
    public double DailyPlantConsumption { get; set; }

    public override string Type => "Всеядное";

    public override double FoodConsumption()
    {
        return DailyMeatConsumption + DailyPlantConsumption;
    }
}

class Herbivore : Animal
{
    public double DailyPlantConsumption { get; set; }

    public override string Type => "Травоядное";

    public override double FoodConsumption()
    {
        return DailyPlantConsumption;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Carnivore { Id = 1, Name = "Лев" },
            new Carnivore { Id = 2, Name = "Тигр" },
            new Omnivore { Id = 3, Name = "Медведь" },
            new Herbivore { Id = 4, Name = "Зебра" },
            new Herbivore { Id = 5, Name = "Слон" },
        };

        animals.Sort();

        foreach (var animal in animals)
        {
            Console.WriteLine($"ID: {animal.Id}, Имя: {animal.Name}, Тип: {animal.Type}, Потребление пищи: {animal.FoodConsumption()}");
        }

        var firstFiveNames = animals.Take(5).Select(a => a.Name);
        Console.WriteLine("\nПервые 5 имен:");
        foreach (var name in firstFiveNames)
        {
            Console.WriteLine(name);
        }

        var lastThreeIds = animals.Skip(Math.Max(0, animals.Count() - 3)).Select(a => a.Id);
        Console.WriteLine("\nПоследние 3 идентификатора:");
        foreach (var id in lastThreeIds)
        {
            Console.WriteLine(id);
        }

        string filePath = "animals.txt";
        SaveAnimalsToFile(filePath, animals);

        List<Animal> loadedAnimals = LoadAnimalsFromFile(filePath);

        if (loadedAnimals == null)
        {
            Console.WriteLine("Ошибка: некорректный формат файла.");
        }
        else
        {
            Console.WriteLine("\nЖивотные из файла:");
            foreach (var animal in loadedAnimals)
            {
                Console.WriteLine($"ID: {animal.Id}, Имя: {animal.Name}, Тип: {animal.Type}, Потребление пищи: {animal.FoodConsumption()}");
            }
        }
        Console.ReadLine();
    }

    static void SaveAnimalsToFile(string filePath, List<Animal> animals)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var animal in animals)
            {
                writer.WriteLine($"{animal.Id};{animal.Name};{animal.Type}");
            }
        }
    }

    static List<Animal> LoadAnimalsFromFile(string filePath)
    {
        List<Animal> animals = new List<Animal>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string type = parts[2];

                        Animal animal;

                        switch (type)
                        {
                            case "Хищник":
                                animal = new Carnivore { Id = id, Name = name };
                                break;
                            case "Всеядное":
                                animal = new Omnivore { Id = id, Name = name };
                                break;
                            case "Травоядное":
                                animal = new Herbivore { Id = id, Name = name };
                                break;
                            default:
                                return null;
                        }

                        animals.Add(animal);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        catch (IOException)
        {
            return null;
        }

        return animals;
    }
}
