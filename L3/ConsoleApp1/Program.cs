using SOLID.LSP.Refactored;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrulater rect = new Rectangle() { Width = 2, Height = 5 };
            int rectArea = AreaCalculator.CalcPatrulater(rect);

            Console.WriteLine($"Rectangle Area = {rectArea}");

            //

            Patrulater square = new Square() { Height = 2, Width = 10 };
            int squareArea = AreaCalculator.CalcPatrulater(square);
            Console.WriteLine($"Square Area = {squareArea}");
        }
    }
}
