using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    public string Name { get; }
    public string BankCard { get; }
    public decimal AccountBalance { get; private set; }
    public bool IsCardBlocked { get; private set; }

    public Client(string name, string bankCard, decimal initialBalance)
    {
        Name = name;
        BankCard = bankCard;
        AccountBalance = initialBalance;
        IsCardBlocked = false;
    }

    public void MakePayment(decimal amount)
    {
        if (IsCardBlocked)
        {
            Console.WriteLine("Карта заблокирована. Платеж невозможен.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Сумма платежа должна быть положительной.");
            return;
        }

        if (AccountBalance >= amount)
        {
            AccountBalance -= amount;
            Console.WriteLine($"Платеж в размере {amount} успешно совершен.");
            Console.WriteLine($"Ваш счет {AccountBalance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете для совершения платежа.");
        }
    }

    public void TransferMoneyToAccount(Client client, decimal amount)
    {
        if (IsCardBlocked)
        {
            Console.WriteLine("Карта заблокирована. Перевод невозможен.");
            return;
        }

        if (client == null)
        {
            Console.WriteLine("Получатель не найден.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Сумма перевода должна быть положительной.");
            return;
        }

        if (AccountBalance >= amount)
        {
            AccountBalance -= amount;
            client.AccountBalance += amount;
            Console.WriteLine($"Перевод в размере {amount} успешно совершен на счет {client.Name}.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете для совершения перевода.");
        }
    }

    public void BlockCard()
    {
        IsCardBlocked = true;
        Console.WriteLine("Карта успешно заблокирована.");
    }

    public void CancelAccount()
    {
        AccountBalance = 0;
        IsCardBlocked = true;
        Console.WriteLine("Счет успешно аннулирован, и карта заблокирована.");
    }
}
public class Bank
{
    public List<Client> Clients { get; } = new List<Client>();

    public void AddClient(Client client)
    {
        Clients.Add(client);
        Console.WriteLine($"Клиент {client.Name} успешно добавлен в банк.");
    }

    public void BlockCardForExcessivePayment(Client client, decimal maximumPaymentAmount)
    {
        if (client == null)
        {
            Console.WriteLine("Клиент не найден.");
            return;
        }

        if (client.AccountBalance < maximumPaymentAmount)
        {
            client.BlockCard();
            Console.WriteLine($"Карта клиента {client.Name} заблокирована за превышение платежа.");
        }
        else
        {
            Console.WriteLine($"Клиент {client.Name} не превысил лимит платежа.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Client client1 = new Client("Шопалов", "1234-5678-9012-3456", 1000.0m);
        Client client2 = new Client("Исаев", "5678-9012-3456-7890", 500.0m);

        bank.AddClient(client1);
        bank.AddClient(client2);

        client1.MakePayment(200.0m);
        client1.TransferMoneyToAccount(client2, 300.0m);

        bank.BlockCardForExcessivePayment(client1, 500.0m);

        Console.ReadLine();
    }
}
