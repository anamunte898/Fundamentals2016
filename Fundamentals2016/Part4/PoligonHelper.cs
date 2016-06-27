namespace Fundamentals2016.Part4
{
    // sealed: don't allow inheritance
    public sealed class PoligonHelper
    {
        // generic methods:
        public static double GetPerimeter<T>(T poligon)
            where T: Poligon
        {
            return poligon.CalculatePerimeter();
        }


        // polimorphism with overloading:
        public static double GetAria (Triangle t)
        {
            return t.CalculateArea();
        }

        public static double GetAria(Rectangle t)
        {
            return t.CalculateArea();
        }

        public static double GetAria(RegularPentagon t)
        {
            return t.CalculateArea();
        }
    }
}
