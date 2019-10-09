using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturePattern.MVC.Model
{
    public class Adder
    {
        public delegate void SumChangedEventHandler(decimal sum, decimal limit);
        public event SumChangedEventHandler SumChanged;

        public decimal Sum { get; private set; }
        public decimal Limit { get; private set; }

        public Adder(decimal limit, decimal sum)
        {
            Sum = sum;
            Limit = limit;
            SumChanged?.Invoke(Sum, Limit);
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
            SumChanged?.Invoke(Sum, Limit);
        }

    }
}
