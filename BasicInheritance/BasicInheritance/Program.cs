using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");

            MiniVav myVan = new MiniVav();
            myVan.Speed = 10;
            Console.WriteLine("My Car car is going { 0} MPH", myVan.Speed);
            myVan.currSpeed = 55;
            Console.ReadLine();
        }
    }
}
