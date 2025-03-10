using System;
using System.Drawing;
using System.Globalization;


namespace GeometricShapes
{
    class Program
    {

        static void Menu()
        {
            int opcao;
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.WriteLine("4 - Exit");

            Console.Write("\nChoose an option: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Triangle a = new Triangle();
                    Console.WriteLine(a);
                    break;
                case 2:
                    Rectangle b = new Rectangle();
                    Console.WriteLine(b);
                    break;
                case 3:
                    Circle c = new Circle();
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Menu();
        }
    }

}
