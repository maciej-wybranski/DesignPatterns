using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Adapter
{
    /// <summary>
    /// Example of an object adapter
    /// </summary>
    class Square2 : RegularPolygon
    {
        private Rectangle rectangle;
        public Square2(Rectangle rectangle)
            : base(CalculateCenterPoint(rectangle.P1, rectangle.P2), 4, CalculateSideLength(rectangle.P1, rectangle.P2))
        {
            this.rectangle = rectangle;
        }

        private static Point CalculateCenterPoint(Point p1, Point p2) => new Point((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);

        private static float CalculateSideLength(Point p1, Point p2)
        {
            float sideLengthA = p2.x - p1.x;
            float sideLengthB = p2.y - p1.y;
            if (sideLengthA != sideLengthB)
                throw new ArgumentException("Podany prostokąt nie jest kwadratem");
            else
                return sideLengthA;
        }

        public override void DisplayShapeName()
        {
            Console.Write("Kwadrat");
        }

        public override float CalculateTheField() => rectangle.CalculateTheField();
    }
}
