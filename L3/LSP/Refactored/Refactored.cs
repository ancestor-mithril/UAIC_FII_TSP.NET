using System;

namespace SOLID.LSP.Refactored
{
    public abstract class Patrulater
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Rectangle : Patrulater
    {
        public override int Width { get; set; }
        public override int Height { get; set; }
        public int Area
        {
            get
            {
                return Height * Width;
            }
        }
    }

    public class Square : Patrulater
    {
        private int _size;
        public override int Height
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public override int Width
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public int Area
        {
            get
            {
                return _size * _size;
            }
        }
    }

    public class AreaCalculator
    {
        public static int CalcPatrulater(Patrulater pat) => pat.Height * pat.Width;
    }

    class EntryPoint
    {
        static void SuperMain(string[] args)
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
