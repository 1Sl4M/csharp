using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule4Fourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoBase autoBase = new AutoBase();
            Dispetcher dispetcher = new Dispetcher(autoBase);

            Driver driver1 = new Driver("Олжас", "Адылханов");
            Driver driver2 = new Driver("Аймурат", "Идриссов");

            autoBase.AddDriver(driver1);
            autoBase.AddDriver(driver2);

            Console.WriteLine("Рейсы распределяются...");
            dispetcher.AssignTrip(driver1, "Поездка в Шымкент");
            dispetcher.AssignTrip(driver2, "Поездка в Алматы");

            Console.WriteLine("\nСтатус водилы 1:");
            driver1.DisplayStatus();

            Console.WriteLine("\nnСтатус водилы 2:");
            driver2.DisplayStatus();

            Console.WriteLine("\nВодила 1 запрашивает ремонт...");
            driver1.RequestRepair("Поломка двигателя");

            Console.WriteLine("\nДиспетчер останавливает поездку водилы 2...");
            dispetcher.SuspendDriver(driver2);

            Console.WriteLine("\nСтатус водилы 2 после остановки:");
            driver2.DisplayStatus();

            Console.ReadLine();
        }
    }
}
public class AutoBase
{
    private List<Driver> drivers = new List<Driver>();

    public void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

    public List<Driver> GetDrivers()
    {
        return drivers;
    }
}
public class Dispetcher
{
    private AutoBase autoBase;

    public Dispetcher(AutoBase autoBase)
    {
        this.autoBase = autoBase;
    }
    public void AssignTrip(Driver driver, string description)
    {
        if(driver != null)
        {
            Console.WriteLine($"Принял поездку в '{description}' водитель {driver.FirstName} {driver.LastName}");
            driver.AcceptTrip(description);
        }
    }
    public void SuspendDriver(Driver driver)
    {
        if (driver != null)
        {
            Console.WriteLine($"Приостановлен - {driver.FirstName} {driver.LastName}");
            driver.Suspend();
        }
    }
}
public class Driver
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Status { get; private set; }
    public string TripDescription { get; private set; }
    public string VehicleStatus { get; private set; }

    public Driver(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Status = "Свободен";
        VehicleStatus = "OK";
    }

    public void AcceptTrip(string tripDescription)
    {
        TripDescription = tripDescription;
        Status = "В поездке";
        Console.WriteLine($"{FirstName} {LastName} в поездке : {tripDescription}");
    }

    public void Suspend()
    {
        Status = "Остановлен";
        Console.WriteLine($"{FirstName} {LastName} остановлен от работы");
    }

    public void RequestRepair(string issue)
    {
        VehicleStatus = "В ремонте";
        Console.WriteLine($"{FirstName} {LastName} на ремонте : {issue}");
    }

    public void CompleteTrip()
    {
        TripDescription = "";
        Status = "Свободен";
        VehicleStatus = "OK";
        Console.WriteLine($"{FirstName} {LastName} выполнил поездку.");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Trip Description: {TripDescription}");
        Console.WriteLine($"Vehicle Status: {VehicleStatus}");
    }
}