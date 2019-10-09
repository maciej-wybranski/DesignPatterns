using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturePattern.MVC.View
{
    public class Display
    {
        private static void DisplayString(string content, bool endOfLine = true)
        {
            if(endOfLine)
                Console.WriteLine(content);
            else
                Console.Write(content);
        }

        public void DisplayHello()
        {
            DisplayString("Hello :)");
        }

        public void DisplayCommand()
        {
            DisplayString("Set price: ", false);
        }

        public void DisplaySum(decimal sum, decimal limit)
        {
            DisplayString($"Sum: {sum}/{limit}");
        }

        public void DisplayBye()
        {
            DisplayString("Bye bye");
        }

        public void DisplayError(string error, bool endOfLine = true)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            DisplayString(error, endOfLine);
            Console.ForegroundColor = color;
        }
    }
}
