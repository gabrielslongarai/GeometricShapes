

namespace GeometricShapes
{
    class Rectangle
    {
        double Width;
        double Height;
        double Area;
        double Perimeter;
        double Diagonal;

        public static void SetRectangle(Rectangle a)
        {
            Console.WriteLine("\nType the width of the rectangle: ");
            a.Width = double.Parse(Console.ReadLine());

            Console.WriteLine("\nType the height of the rectangle: ");
            a.Height = double.Parse(Console.ReadLine());

            Rectangle.SetRectangleArea(a);
            Rectangle.SetRectanglePerimeter(a);
            Rectangle.SetRectangleDiagonal(a);
        }

        private static void SetRectangleArea(Rectangle a)
        {
            double area = a.Width * a.Height;
            a.Area = area;
        }

        private static void SetRectanglePerimeter(Rectangle a)
        {
            double perimeter = 2 * (a.Width + a.Height);
            a.Perimeter = perimeter;
        }

        private static void SetRectangleDiagonal(Rectangle a)
        {
            double diagonal = Math.Sqrt(Math.Pow(a.Width, 2) + Math.Pow(a.Height, 2));
            a.Diagonal = diagonal;
        }

        public override string ToString()
        {
            return $"Width: {Width}\nHeight: {Height}\nArea: {Area}\nPerimeter: {Perimeter}\nDiagonal: {Diagonal}";
        }
    }



}
