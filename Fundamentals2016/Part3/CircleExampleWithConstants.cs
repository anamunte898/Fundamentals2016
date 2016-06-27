namespace Fundamentals2016.Part3
{
    using System;

    public class CircleExampleWithConstants
    {
        // constant declaration 
        const double _pi = 3.14159;
        readonly double _pi2;
        double _r;

        public CircleExampleWithConstants()
        {
            //_pi = 3.14159;
            _pi2 = 3.14159;
        }

        public CircleExampleWithConstants(double r)
        {
            _r = r;
            //_pi = 3.14159;
            _pi2 = 3.14159;
        }

        public CircleExampleWithConstants(double r, double pi)
        {
            _r = r;
            //_pi = pi;
            _pi2 = pi;
        }

        public void DisplayArea()
        {
            Console.WriteLine();
            var areaCircle = _pi * Math.Pow(_r, 2);
            var areaCircle2 = _pi2 * Math.Pow(_r, 2);
            Console.WriteLine("Radius: {0}, Area: {1}, Area: {2}", _r, areaCircle, areaCircle2);
            Console.ReadLine();
        }
    }
}
