using System;

namespace Fundamentals2016.Part4
{
    public class Triangle : Poligon, IPoligon, IComparable<Triangle>
    {
        public double? L2 { get; set; }
        public double? L3 { get; set; }

        public Triangle(double l1, double l2, double l3)
            : base(l1)
        {
            L2 = l2;
            L3 = l3;
        }

        protected override PoligonEnum Type
        {
            get
            {
                return PoligonEnum.Triangle;
            }
        }

        public override double CalculatePerimeter()
        {
            return base.CalculatePerimeter() + this.L2 ?? 0 + this.L3 ?? 0;
        }

        public double CalculateArea()
        {
            var p = this.CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - L1 ?? 0) * (p - L2 ?? 0) * (p - L3 ?? 0));
        }

        public int CompareTo(Triangle obj)
        {
            return this.CalculateArea() == obj.CalculateArea() &&
                this.CalculatePerimeter() == obj.CalculatePerimeter() ? 1 : 0;
        }
    }
}
