using System;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// Example of a class adapter
    /// </summary>
    class Square : Rectangle, IRegularPolygon
    {
        private static Point CalculateP1(Point center, float sideLength) => (new Point(center.x - sideLength / 2, center.y - sideLength / 2));

        private static Point CalculateP2(Point center, float sideLength) => new Point(center.x + sideLength / 2, center.y + sideLength / 2);

        public Square(Point center, float sideLength)
            : base(CalculateP1(center, sideLength), CalculateP2(center, sideLength))
        {

        }

        public Point Center { get => new Point((P1.x + P2.x) / 2, (P1.y + P2.y) / 2); }
        public int NumberOfSides { get => 4; }
        public float SidesLength { get => Height(); }

        public float CalculateTheCircuit() => NumberOfSides * SidesLength;

        public new void DisplayParameters()
        {
            Console.WriteLine($"Środek: ({Center.x}, {Center.y}), liczba boków: {NumberOfSides}, długość boków: {SidesLength}");
        }

        public new void DisplayShapeName()
        {
            base.DisplayShapeName();
            Console.Write(" foremny (kwadrat)");
        }

    }
}
