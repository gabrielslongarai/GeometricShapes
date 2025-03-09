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
        public static void SetTriangle(Triangle a)
        {
            Console.Write("\nType the size of side A: ");
            a.SideA = double.Parse(Console.ReadLine());

            Console.Write("\nType the size of side B: ");
            a.SideB = double.Parse(Console.ReadLine());

            Console.Write("\nType the size of side C: ");
            a.SideC = double.Parse(Console.ReadLine());

            Triangle.SetTriangleSemiPerimeter(a);
            Triangle.SetTriangleArea(a);
        }

        private static void SetTriangleSemiPerimeter(Triangle a)
        {
            double semiPerimeter = (a.SideA + a.SideB + a.SideC) / 2;

            a.SemiPerimeter = semiPerimeter;

        }

        private static void SetTriangleArea(Triangle a)
        {
            double p = a.SemiPerimeter;

            double area = Math.Sqrt(p * (p - a.SideA) * (p - a.SideB) * (p - a.SideC));

            a.Area = area;
        }
    }
}
