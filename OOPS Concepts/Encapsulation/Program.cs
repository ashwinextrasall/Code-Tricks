using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Rectangle
    {
        //Public Access Specifiers
        //public double length;
        //public double breadth;

        //Private Access Specifiers
        private double length;
        private double breadth;

        public double Getlength()
        {
            length = 4.5;
            return length;
        }

        public double Getbreadth()
        {
            breadth= 5.5;
            return breadth;
        }

        public double GetArea()
        { 
            return Getlength() * Getbreadth();
        }

        public void Display()
        {
            Console.WriteLine("Length : {0}", Getlength());
            Console.WriteLine("Width : {0}", Getbreadth());
            Console.WriteLine("Area : {0}",GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleObj = new Rectangle();
            //Commented to change from public to private access modifiers.
            //rectangleObj.length = 4.5;
            //rectangleObj.breadth = 5.5;
            rectangleObj.Display();
            Console.ReadKey();
        }
    }
}
