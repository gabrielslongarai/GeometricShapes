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

            Triangle a = new Triangle();
            a.SetTriangle();
            Console.WriteLine(a);

            Rectangle b = new Rectangle();
            b.SetRectangle();
            Console.WriteLine(b);

            Circle c = new Circle();
            c.SetCircle();
            Console.WriteLine(c);
        }
    }

}
