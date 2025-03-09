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

            Triangle a;
            a = new Triangle();
            Triangle.SetTriangle(a);
            Console.WriteLine(a);

            Rectangle b;
            b = new Rectangle();
            Rectangle.SetRectangle(b);
            Console.WriteLine(b);

            Circle c;
            c = new Circle();
            Circle.SetCircle(c);
            Console.WriteLine(c);
        }
    }

}
