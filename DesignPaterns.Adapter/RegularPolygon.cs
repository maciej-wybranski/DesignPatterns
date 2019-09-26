using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Adapter
{
    abstract class RegularPolygon : IRegularPolygon
    {
        public Point Center { get; private set; }
        public int NumberOfSides { get; private set; }
        public float SidesLength { get; private set; }

        public RegularPolygon(Point center, int numberOfSides, float sidesLength)
        {
            Center = center;
            NumberOfSides = numberOfSides;
            SidesLength = sidesLength;
        }

        public virtual void DisplayParameters()
        {
            Console.WriteLine($"Środek: ({Center.x}, {Center.y}), liczba boków: {NumberOfSides}, długość boków: {SidesLength}");
        }

        public abstract void DisplayShapeName();

        public float CalculateTheCircuit() => NumberOfSides * SidesLength;

        public abstract float CalculateTheField();

    }
}
