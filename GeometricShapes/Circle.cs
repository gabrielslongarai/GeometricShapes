

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
        public Circle()
        {
            Console.Write("\nType the radius of the circle: ");
            Radius = double.Parse(Console.ReadLine());
            SetCircleCircumference();
            SetCircleVolume();
        }

        private void SetCircleCircumference()
        {
            Circumference = 2 * Math.PI * Radius;
        }

        private void SetCircleVolume()
        {
            Volume = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }

        
    }
}
