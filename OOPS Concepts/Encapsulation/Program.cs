using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Rectangle
    {
        public double length;
        public double breadth;

        public double GetArea()
        {
            return length * breadth;
        }

        public void Display()
        {
            Console.WriteLine("Length : {0}",length);
            Console.WriteLine("Width : {0}", breadth);
            Console.WriteLine("Area : {0}",GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleObj = new Rectangle();
            rectangleObj.length = 4.5;
            rectangleObj.breadth = 5.5;
            rectangleObj.Display();
            Console.ReadKey();
        }
    }
}
