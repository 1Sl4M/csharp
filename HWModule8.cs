using System;
using System.Collections.Generic;
using System.Globalization;
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
            SquaredArray squaredArray = new SquaredArray();

            squaredArray[0] = 3;
            squaredArray[1] = 4;
            squaredArray[2] = 5;
            squaredArray[3] = 6;
            squaredArray[4] = 7;

            Console.WriteLine(squaredArray[4]);

            // 2.
            CultureInfo cultureInfo = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

            double heatingRate = 5.0;
            double waterRate = 2.0;
            double gasRate = 3.0;
            double repairRate = 4.0;
            bool isWinterSeason = true;

            PaymentCalculator calculator = new PaymentCalculator(heatingRate, waterRate, gasRate, repairRate, isWinterSeason);

            double squareMeters = 100.0;
            int numResidents = 3;

            Console.WriteLine("Таблица коммунальных платежей:");
            Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10}", "Вид платежа", "Начислено", "Льгота", "Итого");
            Console.WriteLine(new string('-', 50));

            string[] paymentTypes = { "heating", "water", "gas", "repair" };
            foreach (string paymentType in paymentTypes)
            {
                double rate = calculator[paymentType];
                double totalPayment = rate * (paymentType == "water" ? numResidents : squareMeters);
                double discount = 0.0;

                Console.WriteLine("{0,-15} {1,-10:C} {2,-15:C} {3,-10:C}",
                    paymentType, totalPayment, discount, totalPayment - discount);
            }

            double totalAmount = 0.0;
            foreach (string paymentType in paymentTypes)
            {
                double rate = calculator[paymentType];
                double totalPayment = rate * (paymentType == "water" ? numResidents : squareMeters);
                double discount = 0.0;
                totalAmount += (totalPayment - discount);
            }

            Console.WriteLine("\nИтоговая сумма: {0:C}", totalAmount);


            Console.ReadLine();
        }
    }
}
class SquaredArray
{
    public int[] array;

    public SquaredArray()
    {
        array = new int[5];
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }

        set
        {
            array[index] = (int)Math.Pow(value, 2);
        }
    }
}
class PaymentCalculator
{
    private double heatingRatePerSquareMeter;
    private double waterRatePerPerson;
    private double gasRatePerPerson;
    private double repairRatePerSquareMeter;
    private bool isWinterSeason;

    public PaymentCalculator(double heatingRate, double waterRate, double gasRate, double repairRate, bool winterSeason)
    {
        heatingRatePerSquareMeter = heatingRate;
        waterRatePerPerson = waterRate;
        gasRatePerPerson = gasRate;
        repairRatePerSquareMeter = repairRate;
        isWinterSeason = winterSeason;
    }

    public double this[string paymentType]
    {
        get
        {
            switch (paymentType.ToLower())
            {
                case "heating":
                    double heatingRate = isWinterSeason ? heatingRatePerSquareMeter * 1.5 : heatingRatePerSquareMeter;
                    return heatingRate;
                case "water":
                    return waterRatePerPerson;
                case "gas":
                    return gasRatePerPerson;
                case "repair":
                    return repairRatePerSquareMeter;
                default:
                    throw new ArgumentException("Недопустимый вид платежа");
            }
        }
    }
}



