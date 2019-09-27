using System;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            SomeErrorClass errorClass = new SomeErrorClass();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next();

                EventLog.GetInstance().AddEvent($"[{DateTime.Now}] Wylosowana liczba: {randomNumber}");
            }
        }
    }
}
