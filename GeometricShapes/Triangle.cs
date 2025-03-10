namespace GeometricShapes
{
    class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;
        private double SemiPerimeter;
        private double Area;

        public override string ToString()
        {
            return $"\nTriangle with sides {SideA:F2}, {SideB:F2} and {SideC:F2} has an area of {Area:F2}";

        }
        public Triangle()
        {
            Console.Write("\nType the size of side A: ");
            SideA = double.Parse(Console.ReadLine());

            Console.Write("\nType the size of side B: ");
            SideB = double.Parse(Console.ReadLine());

            Console.Write("\nType the size of side C: ");
            SideC = double.Parse(Console.ReadLine());

            SetTriangleSemiPerimeter();
            SetTriangleArea();
        }

        private void SetTriangleSemiPerimeter()
        {
            SemiPerimeter = (SideA + SideB + SideC) / 2;
        }

        private void SetTriangleArea()
        {
            Area = Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA) * (SemiPerimeter - SideB) * (SemiPerimeter - SideC));
        }
    }
}
