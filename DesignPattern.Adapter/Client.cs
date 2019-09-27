using System;

namespace DesignPattern.Adapter
{
    class Client
    {
        public static void DisplayShapeInformation(IRegularPolygon regularPolygon)
        {
            regularPolygon.DisplayShapeName();
            Console.WriteLine(":");
            regularPolygon.DisplayParameters();
            Console.WriteLine($"Obwód: {regularPolygon.CalculateTheCircuit()}");
            Console.WriteLine($"Pole {regularPolygon.CalculateTheField()}");
        }
    }
}
