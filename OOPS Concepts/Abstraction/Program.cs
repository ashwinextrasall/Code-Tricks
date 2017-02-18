using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Animal
    {
        public abstract void Eat();
        public void Move()
        {
            Console.WriteLine("This is move method in abstract class");
        }
    }

    public class Monkey : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("This is eat method from monkey class");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is main");
            Console.ReadKey();
        }
    }
}
