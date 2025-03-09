using System;
using System.Drawing;
using System.Globalization;


namespace GeometricShapes
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Triangle.SetTriangle(x);
            Triangle.SetTriangle(y);

            Triangle.PrintTriangleArea(x);
            Triangle.PrintTriangleArea(y);

            Rectangle t;
            t = new Rectangle();

            Rectangle.SetRectangle(t);

            Console.WriteLine(t);
        }
    }

}
