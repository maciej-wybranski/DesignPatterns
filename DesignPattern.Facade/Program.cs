using DesignPattern.Decorator;
using System;

namespace DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            Console.WriteLine($"{coffee}: {coffee.Price()} zł");
            Console.WriteLine($"Pojemność: {coffee.Size()} ml.");

            Beverage coffeWithMilk = BeverageMenu.CoffeeWithMilk();
            Console.WriteLine($"{coffeWithMilk}: {coffeWithMilk.Price()} zł");
            Console.WriteLine($"Pojemność: {coffeWithMilk.Size()} ml.");

            Beverage coffeWithMilkAndSuggar = BeverageMenu.CoffeeWithMilkAndSuggar();
            Console.WriteLine($"{coffeWithMilkAndSuggar}: {coffeWithMilkAndSuggar.Price()} zł");
            Console.WriteLine($"Pojemność: {coffeWithMilkAndSuggar.Size()} ml.");

            Beverage teaWithSuggar = BeverageMenu.TeaWithSuggar(true);
            Console.WriteLine($"{teaWithSuggar}: {teaWithSuggar.Price()} zł");
            Console.WriteLine($"Pojemność: {teaWithSuggar.Size()} ml.");
        }
    }
}
