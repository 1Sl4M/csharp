using System;
using System.Collections.Generic;
using System.Linq;

public class Train
{
    public int TrainNumber { get; set; }
    public string DepartureStation { get; set; }
    public string DestinationStation { get; set; }
    public decimal Price { get; set; }

    public Train(int trainNumber, string departureStation, string destinationStation, decimal price)
    {
        TrainNumber = trainNumber;
        DepartureStation = departureStation;
        DestinationStation = destinationStation;
        Price = price;
    }
}

public class Ticket
{
    public int TicketNumber { get; set; }
    public Train SelectedTrain { get; set; }
    public string PassengerName { get; set; }
    public string Time { get; set; }
    public string Date { get; set; }

    public Ticket(int ticketNumber, Train selectedTrain, string passengerName, string time, string date)
    {
        TicketNumber = ticketNumber;
        SelectedTrain = selectedTrain;
        PassengerName = passengerName;
        Time = time;
        Date = date;
    }

    public decimal CalculateTotalPrice()
    {
        return SelectedTrain.Price;
    }
}

public class TicketingSystem
{
    private List<Train> availableTrains = new List<Train>();
    private List<Ticket> bookedTickets = new List<Ticket>();
    private int ticketCounter = 1;

    public void AddTrain(Train train)
    {
        availableTrains.Add(train);
    }

    public List<Train> SearchTrains(string departureStation, string destinationStation)
    {
        return availableTrains.FindAll(train =>
            train.DepartureStation.Equals(departureStation, StringComparison.OrdinalIgnoreCase) &&
            train.DestinationStation.Equals(destinationStation, StringComparison.OrdinalIgnoreCase));
    }

    public Ticket BookTicket(Train selectedTrain, string passengerName, string time, string date)
    {
        if (selectedTrain == null)
        {
            Console.WriteLine("Выбранный поезд не существует.");
            return null;
        }

        Ticket ticket = new Ticket(ticketCounter++, selectedTrain, passengerName, time, date);
        bookedTickets.Add(ticket);
        return ticket;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicketingSystem ticketingSystem = new TicketingSystem();

        ticketingSystem.AddTrain(new Train(1, "Алматы-2", "Шымкент", 7000.0m));
        ticketingSystem.AddTrain(new Train(2, "Тараз", "Шымкент", 8000.0m));
        ticketingSystem.AddTrain(new Train(3, "Астана", "Шымкент", 10000.0m));

        List<Train> availableTrains = ticketingSystem.SearchTrains("Алматы-2", "Шымкент");

        foreach (Train train in availableTrains)
        {
            Console.WriteLine($"Поезд {train.TrainNumber}: {train.DepartureStation} - {train.DestinationStation}, Цена: {train.Price}");
        }

        Train selectedTrain = availableTrains.FirstOrDefault();
        if (selectedTrain != null)
        {
            Ticket bookedTicket = ticketingSystem.BookTicket(selectedTrain, "Евгений Родной", "00:52", "2023-26-09");

            if (bookedTicket != null)
            {
                Console.WriteLine("Билет успешно забронирован.");
                Console.WriteLine($"Номер билета: {bookedTicket.TicketNumber}");
                Console.WriteLine($"Поезд: {bookedTicket.SelectedTrain.TrainNumber}");
                Console.WriteLine($"Пассажир: {bookedTicket.PassengerName}");
                Console.WriteLine($"Время отправления: {bookedTicket.Time}");
                Console.WriteLine($"Дата отправления: {bookedTicket.Date}");
                Console.WriteLine($"Сумма к оплате: {bookedTicket.CalculateTotalPrice()}");
            }
        }

        Console.ReadLine();
    }
}
