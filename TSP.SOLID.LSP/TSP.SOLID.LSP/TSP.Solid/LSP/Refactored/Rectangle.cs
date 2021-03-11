namespace TSP.Solid.LSP.Refactored
{
    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int AreaCalculator()
        {
            return Height * Width;

        }
    }
}
