using System;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// Adaptee, adapted class
    /// </summary>
    class Rectangle
    {
        public Point P1 { get; private set; } //left-top corner
        public Point P2 { get; private set; } //right-bottom corner

        protected float Width() => P2.x - P1.x;
        protected float Height() => P2.y - P1.y;

        public Rectangle(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public void DisplayShapeName()
        {
            Console.Write("Prostokąt");
        }

        public void DisplayParameters()
        {
            Console.WriteLine($"Lewa krawędź: { P1.x }, górna krawędź: { P1.y }, szerokość: { Width() }, wysokość: { Height() }.");
        }

        public float CalculateTheField() => Width() * Height();
    }
}
