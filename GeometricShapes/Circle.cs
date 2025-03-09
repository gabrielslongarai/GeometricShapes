

namespace GeometricShapes
{
    class Circle
    {
        double Radius;
        double Circumference;
        double Volume;

        public override string ToString()
        {
            return $"\nRadius: {Radius:F2}\nCircumference: {Circumference:F2}\nVolume: {Volume:F2}";
        }
        public static void SetCircle(Circle a)
        {
            Console.Write("\nType the radius of the circle: ");
            a.Radius = double.Parse(Console.ReadLine());
            Circle.SetCircleCircumference(a);
            Circle.SetCircleVolume(a);
        }

        private static void SetCircleCircumference(Circle a)
        {
            double circumference = 2 * Math.PI * a.Radius;
            a.Circumference = circumference;
        }

        private static void SetCircleVolume(Circle a)
        {
            double volume = (4 / 3) * Math.PI * Math.Pow(a.Radius, 3);
            a.Volume = volume;
        }

        
    }
}
