using System;
using System.Globalization;


namespace Program
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

            Triangle.ComparingTriangleArea(x, y);
            Triangle.PrintLargestArea(x, y);
        }
    }

}
