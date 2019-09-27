using System;

namespace DesignPattern.Singleton
{
    class SomeClass
    {
        public SomeClass()
        {
            EventLog.GetInstance().AddEvent($"[{DateTime.Now}] Utworzono instancję klasy");
        }
        
    }
}
