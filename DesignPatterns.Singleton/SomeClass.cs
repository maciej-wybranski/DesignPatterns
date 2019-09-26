using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    class SomeClass
    {
        public SomeClass()
        {
            EventLog.GetInstance().AddEvent($"[{DateTime.Now}] Utworzono instancję klasy");
        }
        
    }
}
