

namespace GeometricShapes
{
    class Rectangle
    {
        double Width;
        double Height;
        double Area;
        double Perimeter;
        double Diagonal;

        public void SetRectangle()
        {
            Console.Write("\nType the width of the rectangle: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("\nType the height of the rectangle: ");
            Height = double.Parse(Console.ReadLine());

            SetRectangleArea();
            SetRectanglePerimeter();
            SetRectangleDiagonal();
        }

        private void SetRectangleArea()
        { 
            Area = Width * Height;
        }

        private void SetRectanglePerimeter()
        {
            Perimeter = 2 * (Width + Height);
        }

        private void SetRectangleDiagonal()
        {
            Diagonal = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

        public override string ToString()
        {
            return $"\nWidth: {Width:F2}\nHeight: {Height:F2}\nArea: {Area:F2}\nPerimeter: {Perimeter:F2}\nDiagonal: {Diagonal:F2}";
        }
    }



}
