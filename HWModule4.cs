using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class FoodProduct
{
    private string name;
    private double weight;
    private DateTime productionDate;
    private DateTime expirationDate;
    private decimal price;

    private static int totalProducts = 0;
    private static decimal totalRevenue = 0;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public DateTime ProductionDate
    {
        get { return productionDate; }
        set { productionDate = value; }
    }

    public DateTime ExpirationDate
    {
        get { return expirationDate; }
        set { expirationDate = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public FoodProduct(string name, double weight, DateTime productionDate, DateTime expirationDate, decimal price)
    {
        this.name = name;
        this.weight = weight;
        this.productionDate = productionDate;
        this.expirationDate = expirationDate;
        this.price = price;

        totalProducts++;
        totalRevenue += price;
    }

    public FoodProduct()
    {
        totalProducts++;
    }

    static FoodProduct()
    {
        totalProducts = 0;
        totalRevenue = 0;
    }

    public void UpdateProduct(string name, double weight, DateTime productionDate, DateTime expirationDate, decimal price)
    {
        this.name = name;
        this.weight = weight;
        this.productionDate = productionDate;
        this.expirationDate = expirationDate;
        this.price = price;
    }

    public void SellProduct()
    {
        totalProducts--;
        totalRevenue += price;
    }

    public void IncreaseWeight(ref double additionalWeight)
    {
        weight += additionalWeight;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название продукта: {name}");
        Console.WriteLine($"Вес: {weight} грамм");
        Console.WriteLine($"Дата производства: {productionDate.ToShortDateString()}");
        Console.WriteLine($"Срок годности: {expirationDate.ToShortDateString()}");
        Console.WriteLine($"Цена: {price:C}");
    }
    public static int TotalProducts
    {
        get { return totalProducts; }
    }

    public static decimal TotalRevenue
    {
        get { return totalRevenue; }
    }
    public static void Main(string[] args)
    {
        FoodProduct product1 = new FoodProduct("Хлеб", 500, DateTime.Now, DateTime.Now.AddMonths(1), 2.5m);
        FoodProduct product2 = new FoodProduct("Молоко", 1000, DateTime.Now, DateTime.Now.AddMonths(2), 1.8m);

        product1.DisplayInfo();
        product2.DisplayInfo();

        Console.WriteLine($"Общее количество продуктов: {FoodProduct.TotalProducts}");
        Console.WriteLine($"Общий доход: {FoodProduct.TotalRevenue:C}");

        Console.ReadLine();
    }
}

