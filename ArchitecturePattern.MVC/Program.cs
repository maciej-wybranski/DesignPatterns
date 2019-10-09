using System;

namespace ArchitecturePattern.MVC
{
    using Controller;

    class Program
    {
        static void Main(string[] args)
        {
            AdderController adderController = new AdderController(1000);
            adderController.Run();
        }
    }
}
