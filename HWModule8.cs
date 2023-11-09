using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            SquaredArray squared_arr = new SquaredArray(5);

            squared_arr[0] = 3;
            squared_arr[1] = 4;
            squared_arr[2] = 5;
            squared_arr[3] = 6;
            squared_arr[4] = 7;

            Console.WriteLine(squared_arr[4]);

            // 2.
            Console.Write("Введите площадь помещения (в м2): ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Введите количество проживающих: ");
            int residents = int.Parse(Console.ReadLine());

            Console.Write("Введите сезон (осень/зима): ");
            string season = Console.ReadLine().ToLower();

            Console.Write("Есть ли льготы (да/нет): ");
            string hasDiscount = Console.ReadLine().ToLower();

            double heatingRate = 5.0;
            double waterRate = 2.0;
            double gasRate = 3.0;
            double repairRate = 10.0;

            if (season == "осень" || season == "зима")
            {
                heatingRate *= 1.2;
            }

            double heatingPayment = area * heatingRate;
            double waterPayment = residents * waterRate;
            double gasPayment = residents * gasRate;
            double repairPayment = area * repairRate;

            double discount = 0.0;

            if (hasDiscount == "да")
            {
                discount = heatingPayment * 0.3;
            }

            double totalHeating = heatingPayment - discount;
            double totalWater = waterPayment;
            double totalGas = gasPayment;
            double totalRepair = repairPayment;
            double totalPayment = totalHeating + totalWater + totalGas + totalRepair;

            Console.WriteLine("Вид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t\t{heatingPayment:C}\t\t{discount:C}\t\t{totalHeating:C}");
            Console.WriteLine($"Вода\t\t\t{waterPayment:C}\t\t\t-\t\t{totalWater:C}");
            Console.WriteLine($"Газ\t\t\t{gasPayment:C}\t\t\t-\t\t{totalGas:C}");
            Console.WriteLine($"Ремонт\t\t\t{repairPayment:C}\t\t\t-\t\t{totalRepair:C}");
            Console.WriteLine($"Итого\t\t\t\t\t\t\t{totalPayment:C}");

            Console.ReadLine();
        }
    }
}
class SquaredArray
{
    private int[] arr;
    public SquaredArray(int size)
    {
        arr = new int[size];
    }
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне границ массива.");
            }
        }
        set
        {
            if (index >= 0 && index < arr.Length)
            {
                arr[index] = value * value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне границ массива.");
            }
        }
    }
}

