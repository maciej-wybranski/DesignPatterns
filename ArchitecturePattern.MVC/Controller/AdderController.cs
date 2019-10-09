using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturePattern.MVC.Controller
{
    using Model;
    using View;

    public class AdderController
    {
        private Adder _adder;
        private Display _display;

        public AdderController(decimal limit)
        {
            _adder = new Adder(limit, 0);
            _display = new Display();
            _adder.SumChanged += _display.DisplaySum;
        }

        public void Run()
        {
            _display.DisplayHello();
            bool exit = false;
            do
            {
                _display.DisplayCommand();
                string priceString = Console.ReadLine();

                if (string.IsNullOrEmpty(priceString))
                {
                    exit = true;
                    continue;
                }

                if (!decimal.TryParse(priceString, out decimal price))
                {
                    _display.DisplayError("Podana wartość nie jest kwotą");
                    continue;
                }

                try
                {
                    _adder.Add(price);
                }
                catch(Exception e)
                {
                    _display.DisplayError(e.Message);
                    continue;
                }

            }
            while (!exit);

            _display.DisplayBye();
        }
    }
}
