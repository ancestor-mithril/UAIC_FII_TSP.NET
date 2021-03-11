namespace TSP.Solid.LSP.Refactored
{
    class Square : IShape
    {
        public int Width { get; set; }

        public int AreaCalculator()
        {
            return Width * Width;
        }
    }
}
