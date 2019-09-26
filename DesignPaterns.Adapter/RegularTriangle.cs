using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaterns.Adapter
{
    /// <summary>
    /// Example of a class compatible with the target
    /// </summary>
    class RegularTriangle : RegularPolygon
    {
        public RegularTriangle(Point center, float sidesLength) 
            : base(center, 3, sidesLength)
        {
        }

        public override void DisplayShapeName()
        {
            Console.Write("Trójkąt foremny");
        }

        public override float CalculateTheField() => SidesLength * SidesLength * (float)(Math.Sqrt(3.0) / 4.0);
    }
}
