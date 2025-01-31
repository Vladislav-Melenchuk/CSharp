using System;
using System.Collections.Generic;
using System.Linq;

public enum Category
{
    Food,
    Electronics,
    Clothing,
    Household,
    Misc
}

public struct Item
{
    public string Title { get; }
    public int Count { get; }
    public decimal UnitCost { get; }
    public decimal Discount { get; }
    public Category Type { get; }

    public Item(string title, int count, decimal unitCost, decimal discount, Category type)
    {
        Title = title;
        Count = count;
        UnitCost = unitCost;
        Discount = discount;
        Type = type;
    }

    public decimal CalculateTotal() => Count * UnitCost * (1 - Discount / 100);
}

public class Receipt
{
    private List<Item> items = new List<Item>();
    private DateTime timestamp = DateTime.Now;

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void Display()
    {
        Console.WriteLine("====================");
        Console.WriteLine($"Чек - {timestamp}");
        Console.WriteLine("====================");
        decimal totalSum = 0;

        foreach (var item in items)
        {
            decimal itemTotal = item.CalculateTotal();
            totalSum += itemTotal;
            Console.WriteLine($"{item.Title} ({item.Type}) x{item.Count}");
            Console.WriteLine($"Цена: {item.UnitCost} | Скидка: {item.Discount}%");
            Console.WriteLine($"= {itemTotal}");
            Console.WriteLine("--------------------");
        }

        Console.WriteLine($"Общая сумма: {totalSum}");
        Console.WriteLine("====================");
    }
}

class Program
{
    static void Main()
    {
        Receipt receipt = new Receipt();

        receipt.AddItem(new Item("Молоко", 1, 80, 10, Category.Food));
        receipt.AddItem(new Item("Сыр", 1, 150, 15, Category.Food));
        receipt.AddItem(new Item("Носки", 1, 80, 15, Category.Clothing));
        receipt.AddItem(new Item("Хлеб", 1, 40, 5, Category.Food));

        receipt.Display();
    }
}
