using System;

namespace DesignPattern.Singleton
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
