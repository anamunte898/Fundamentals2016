// A namespace is a collection of classes.The Fundamentals2016 namespace contains the class Program.
// Full name of class Program is in fact: Fundamentals2016.Program

namespace Fundamentals2016
{
    // the using keyword is used to include namespace in the program. A program generally has multiple using statements.
    // See the test: TestNamespaceInsideUsingUsing
    
    using Part3;
    using Part4;
    using Part5;
    using System;
    
    // class declaration
    // The class keyword is used for declaring a class.
    public class Program
    {
        // the entry point for all C# programs. The Main method states what the class does when executed.
        static void Main(string[] args)
        {
            
            #region part1 - Very short presentation, Hello World, class structure, using position in file

            Console.WriteLine("Part 1: \n");

            // my first program in C# 

            // WriteLine is a method of the Console class defined in the System namespace. This statement causes the message "Hello, World!" to be displayed on the screen.
            Console.WriteLine("Hello World");

            // This makes the program wait for a key press and it prevents the screen from running and closing quickly when the program is launched from Visual Studio.
            Console.ReadKey();

            #endregion


            #region part2 - Class, members, methodes, constructors, override ToString()

            Console.WriteLine("\n\n\nPart 2: \n");

            // initialization methods:
            // 1:
            var rectangle1 = new Fundamentals2016.Part2.Rectangle();
            rectangle1.Length = 10;
            rectangle1.Width = 6;

            // 2:
            var rectangle2 = new Fundamentals2016.Part2.Rectangle(12, 8);

            // 3:
            var rectangle3 = new Fundamentals2016.Part2.Rectangle();
            rectangle3.InitializeWithCustomValues();

            // 4:
            var rectangle4 = new Fundamentals2016.Part2.Rectangle();
            rectangle4.InitializeWithSpecificValues(20, 15);

            // call methods:
            Console.WriteLine(rectangle1.GetArea());
            rectangle1.Display();
            Console.WriteLine(rectangle1.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle2.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle3.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle4.ToString());
            Console.ReadKey();

            #endregion


            #region part3 - Value type, Referance type, boxing, unboxing, Dynamic type, static methodes, convertions, constant variables, readonly variables

            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadKey();

            // boxing & unboxing
            object obj;
            obj = 100; // this is boxing
            int unboxObj = (int)obj; // this is unboxing

            // cast double to int.
            double nr1 = 5673.74;
            int nr2;
            nr2 = (int)nr1;
            Console.WriteLine(nr2);
            Console.ReadKey();

            // dinamyc type: (with static methode)
            Console.WriteLine();
            DynamicTypes.DynamicTypesExample();

            // string conversion: (with static methode)
            Console.WriteLine();
            StringConversion.ConvertValues();

            // working with constants:
            Console.WriteLine("\n");
            Console.WriteLine("Enter Radius: ");
            var radius = Convert.ToDouble(Console.ReadLine());
            var circle = new CircleExampleWithConstants(radius);
            circle.DisplayArea();

            #endregion


            #region part4 - enums, if (?), ??, switch, inheritance, interface, IComparable, generic methods, overloading, polymorphism

            var triangle = new Triangle(3, 4, 5);
            var rectangle = new Fundamentals2016.Part4.Rectangle(2, 6);
            var regularPentagon = new RegularPentagon(4);

            Console.WriteLine("\n\n " + triangle.ToString() + ": Perimetru: " + PoligonHelper.GetPerimeter(triangle) + "  Arie: " + PoligonHelper.GetAria(triangle));
            Console.WriteLine("\n\n " + rectangle.ToString() + ": Perimetru: " + PoligonHelper.GetPerimeter(rectangle) + "  Arie: " + PoligonHelper.GetAria(rectangle));
            Console.WriteLine("\n\n " + regularPentagon.ToString() + ": Perimetru: " + PoligonHelper.GetPerimeter(regularPentagon) + "  Arie: " + PoligonHelper.GetAria(regularPentagon));
            Console.ReadKey();

            // polimophism:
            Poligon p = new Fundamentals2016.Part4.Rectangle(2, 6);
            Console.WriteLine("\n\n " + p.GetType() + ": Perimetru: " + p.CalculatePerimeter());
            Console.ReadKey();

            #endregion
            
            
            #region part5 - using, read from file, write in file, exceptions, custom exception, threads, async await

            var file = new WorkWithFileExample("E:\\ZTH\\TextFile.txt");
            file.ReadContent();
            file.WriteContent();

            // custom exception:
            Console.WriteLine("\n");
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                //throw new NegativeNumberException();
                throw new NegativeNumberException("Negative number is not allowed!");
            }
            Console.ReadKey();

            // events:

            // threads, async, await:

            #endregion
        }
    }
}
