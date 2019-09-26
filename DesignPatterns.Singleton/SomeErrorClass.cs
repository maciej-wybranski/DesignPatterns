using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    class SomeErrorClass
    {
        public SomeErrorClass()
        {
            try
            {
                EventLog.GetInstance().AddEvent($"[{ DateTime.Now}] Utworzono instancję SomeErrorClass");
                GenerateError();
            }
            catch(Exception ex)
            {
                ErrorLog.GetInstance().AddEvent(ex.Message);
            }
        }

        private void GenerateError()
        {
            throw new Exception($"[{DateTime.Now}] Wystąpił błąd w klasie SomeErrorClass");
        }
    }
}
