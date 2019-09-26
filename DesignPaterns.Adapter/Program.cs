using System;

namespace DesignPaterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Point triangleCenter = new Point(10.0f, 10.0f);
            IRegularPolygon regularTriangle = new RegularTriangle(triangleCenter, 5.0f);
            Client.DisplayShapeInformation(regularTriangle);

            Point squareCenter = new Point(10.0f, 20.0f);
            IRegularPolygon square = new Square(squareCenter, 5.0f);
            Client.DisplayShapeInformation(square);

            try
            {
                //Rectangle rectangle = new Rectangle(new Point(10.0f, 10.0f), new Point(20.0f, 30.0f)); //this is not regular rectangle, we get ArgumentException
                Rectangle rectangle = new Rectangle(new Point(10.0f, 10.0f), new Point(20.0f, 20.0f));
                IRegularPolygon square2 = new Square2(rectangle);
                Client.DisplayShapeInformation(square2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
