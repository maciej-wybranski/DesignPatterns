using System;

namespace DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            Console.WriteLine($"{coffee}: {coffee.Price()} zł");
            Console.WriteLine($"Pojemność: {coffee.Size()} ml.");

            Beverage coffeWithMilk = new BeverageWithMilk(coffee);
            Console.WriteLine($"{coffeWithMilk}: {coffeWithMilk.Price()} zł");
            Console.WriteLine($"Pojemność: {coffeWithMilk.Size()} ml.");

            Beverage coffeWithMilkAndSuggar = new BeverageWithSuggar(coffeWithMilk);
            Console.WriteLine($"{coffeWithMilkAndSuggar}: {coffeWithMilkAndSuggar.Price()} zł");
            Console.WriteLine($"Pojemność: {coffeWithMilkAndSuggar.Size()} ml.");

            Beverage teaWithSuggar = new BeverageWithSuggar(new Tea(), true);
            Console.WriteLine($"{teaWithSuggar}: {teaWithSuggar.Price()} zł");
            Console.WriteLine($"Pojemność: {teaWithSuggar.Size()} ml.");
        }
    }
}
