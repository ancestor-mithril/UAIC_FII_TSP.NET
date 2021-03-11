using System;

namespace TSP.Solid.LSP.Refactored
{
    public class EntryPoint
    {
        public EntryPoint(string[] args)
        {
            SuperMain(args);
        }

        static void SuperMain(string[] args)
        {
            IShape rect = new Rectangle() { Width = 2, Height = 5 };
            IShape square = new Square() { Width = 10 };
            int rectArea = rect.AreaCalculator();
            int squareArea = square.AreaCalculator();
            Console.WriteLine($"Rectangle Area = {rectArea}");
            Console.WriteLine($"Square Area = {squareArea}");

        }
        
    }
    
}
