namespace GeometricShapes
{
    class Triangle
    {
        public string Name;
        public double SideA;
        public double SideB;
        public double SideC;
        private double SemiPerimeter;
        private double Area;

        public static void SetTriangle(Triangle a)
        {
            Console.Write("\nType the name of your triangle: ");
            a.Name = Console.ReadLine();

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

        public static string ComparingTriangleArea(Triangle a, Triangle b)
        {
            if (a.Area > b.Area)
            {
                return a.Name;
            }
            else
            {
                return b.Name;
            }
        }

        public static void PrintLargestArea(Triangle a, Triangle b)
        {
            Console.WriteLine($"Maior área: {ComparingTriangleArea(a, b)}");
        }

        public static void PrintTriangleArea(Triangle a)
        {
            Console.WriteLine($"The triangle \"{a.Name}\" area is: {a.Area:F4}");

        }
    }
}
