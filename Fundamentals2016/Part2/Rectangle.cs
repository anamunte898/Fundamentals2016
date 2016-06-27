namespace Fundamentals2016.Part2
{
    using System;
    using System.Text;

    public class Rectangle
    {

        // member variables
        private double _length;
        private double _width;

        // properties
        public double Length {
            get {
                return _length;
            }
            set {
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        // parameterless constructor (implicit)
        public Rectangle() { }

        // constructor with parameter
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }


        // Methods:
        public void InitializeWithCustomValues()
        {
            _length = 8;
            _width = 4;
        }

        public void InitializeWithSpecificValues(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double GetArea()
        {
            return _length * _width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", _length);
            Console.WriteLine("Width: {0}", _width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        // ToString - a based methode from based class Object
        public override string ToString()
        {
            #region withStringConcat

            //string result = "Rectangle details: ";
            //var result = "Rectangle details: ";

            //result = result + "\n\t Length: " + this._length + "\n\t Width: " + this._width + "\n\t Area:" + this.GetArea();

            #endregion


            #region withStringBuilder

            StringBuilder result = new StringBuilder();
            result.AppendLine("Rectangle details: ");
            result.AppendLine("\tLength: " + this.Length)
                .AppendLine("\tWidth: " + this.Width)
                .AppendLine("\tArea: " + this.GetArea());

            #endregion

            return result.ToString();

        }
        
    }
}
