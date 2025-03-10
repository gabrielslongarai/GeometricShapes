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
            Console.WriteLine(a);

            Rectangle b = new Rectangle();
            Console.WriteLine(b);

            Circle c = new Circle();
            Console.WriteLine(c);
        }
    }

}
