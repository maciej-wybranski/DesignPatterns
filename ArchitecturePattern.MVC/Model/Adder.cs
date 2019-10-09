using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturePattern.MVC.Model
{
    public class Adder
    {
        public decimal Sum { get; private set; }
        public decimal Limit { get; private set; }

        public Adder(decimal limit, decimal sum)
        {
            Sum = sum;
            Limit = limit;
        }

        private bool CheckIfThePriceIsCorrect(decimal price)
        {
            bool isPositive = price > 0;
            bool isExceedLimit = Sum + price > Limit;
            return isPositive && !isExceedLimit;
        }

        public void Add(decimal price)
        {
            if (!CheckIfThePriceIsCorrect(price))
                throw new ArgumentOutOfRangeException(nameof(price), "Value is too hight or negative");
            Sum += price;
        }
    }
}
