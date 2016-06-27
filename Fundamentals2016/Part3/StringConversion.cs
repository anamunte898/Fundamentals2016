using System;

namespace Fundamentals2016.Part3
{
    public class StringConversion
    {
        // Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object. 
        // The static modifier can be used with classes, fields, methods, properties, operators, events, and constructors, but it cannot be used with indexers, destructors, or types other than classes.
        public static void ConvertValues()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
