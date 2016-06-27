using System;

namespace Fundamentals2016.Part4
{
    public class Rectangle : Poligon, IPoligon, IComparable<Rectangle>
    {        
        public double? L2 { get; set; }

        protected override PoligonEnum Type
        {
            get
            {
                return PoligonEnum.Rectangle;
            }
        }

        public Rectangle(double l1, double l2) 
            : base(l1)
        {
            L2 = l2;
        }
        
        public override double CalculatePerimeter()
        {
            return (base.CalculatePerimeter() + this.L2 ?? 0) * 2;
        }

        public double CalculateArea()
        {
            return this.L1 ?? 0 * this.L2 ?? 0;
        }

        public int CompareTo(Rectangle obj)
        {
            return this.CalculateArea() == obj.CalculateArea() &&
                this.CalculatePerimeter() == obj.CalculatePerimeter() ? 1 : 0;
        }
    }
}
