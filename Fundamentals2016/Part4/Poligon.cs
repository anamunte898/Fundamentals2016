namespace Fundamentals2016.Part4
{
    public abstract class Poligon 
    {
        public Poligon() { }

        public Poligon(double l1) 
        {
            L1 = l1;
        }

        protected abstract PoligonEnum Type { get; }
        public double? L1 { get; set; }

        public virtual double CalculatePerimeter() {
            return L1 ?? 0;
        }

        public override string ToString()
        {
            switch (Type)
            {
                case PoligonEnum.Triangle:
                    return string.Format("Triangle");
                case PoligonEnum.Rectangle:
                    return string.Format("Rectangle");
                case PoligonEnum.RegularPentagon:
                    return string.Format("RegularPentagon");
                default:
                    return string.Format("Unknown");
            }
        }
    }
}
