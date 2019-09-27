using DesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    static class BeverageMenu
    {
        public static Beverage CoffeeWithMilk()
        {
            Beverage beverage = new Coffee();
            beverage = new BeverageWithMilk(beverage);
            return beverage;
        }

        public static Beverage CoffeeWithMilkAndSuggar()
        {
            Beverage beverage = new Coffee();
            beverage = new BeverageWithSuggar(beverage);
            beverage = new BeverageWithMilk(beverage);
            return beverage;
        }

        public static Beverage TeaWithSuggar(bool brownSuggar = false)
        {
            Beverage beverage = new Tea();
            beverage = new BeverageWithSuggar(beverage, brownSuggar);
            return beverage;
        }
    }
}
