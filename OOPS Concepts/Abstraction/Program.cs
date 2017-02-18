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
        public virtual void Move()
        {
            Console.WriteLine("This is move method in abstract class");
        }
    }

    public class Tiger : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("This is eat method from Tiger class");
        }

        //public override void Move()
        //{
        //    Console.WriteLine("This is move method in Tiger class");
        //}
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is main");
            Tiger tigObj = new Tiger();
            tigObj.Eat();
            tigObj.Move();
            Animal aniVar = tigObj;
            aniVar.Eat();
            aniVar.Move();
            Console.ReadKey();
        }
    }
}
