using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankQueue bankQueue = new BankQueue();

            while (true)
            {
                Console.WriteLine("1. Встать в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Выйти из программы");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите ИИН клиента:");
                        string iin = Console.ReadLine();
                        Console.WriteLine("Выберите услугу (1. Кредитование, 2. Открытие вклада, 3. Консультация):");
                        int serviceType = int.Parse(Console.ReadLine());

                        ServiceType selectedService = (ServiceType)serviceType;
                        Client newClient = new Client(iin, selectedService);

                        bankQueue.Enqueue(newClient);
                        Console.WriteLine($"Клиент {iin} добавлен в очередь для {selectedService}");
                        Console.WriteLine($"Текущая длина очереди: {bankQueue.Count}");
                        break;

                    case 2:
                        if (bankQueue.Count > 0)
                        {
                            Client servicedClient = bankQueue.Dequeue();
                            Console.WriteLine($"Обслужен клиент {servicedClient.IIN} для {servicedClient.Service}");
                            Console.WriteLine($"Текущая длина очереди: {bankQueue.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Очередь пуста.");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
