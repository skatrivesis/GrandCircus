namespace Exercise45
{
    class Square
    {
        #region fields
        private double sideLength;
        #endregion

        #region properties
        public double SideLength { get => sideLength; set => sideLength = value; }
        #endregion

        #region constructors
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        #endregion

        #region methods
        public double CalculatePerimeter()
        {
            return sideLength * 4;
        }

        public double CalculateArea()
        {
            return sideLength * sideLength;
        }

        public override string ToString()
        {
            return $"\nSide Length: {sideLength}\n Area is: {CalculateArea()}\nPerimiter is: {CalculatePerimeter()}\n";
        }
        #endregion
    }
}
