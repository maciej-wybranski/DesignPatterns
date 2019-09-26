using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Adapter
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
