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

            Triangle x;
            x = new Triangle();
            Triangle.SetTriangle(x);
            Console.WriteLine(x);

            Rectangle t;
            t = new Rectangle();
            Rectangle.SetRectangle(t);
            Console.WriteLine(t);
        }
    }

}
