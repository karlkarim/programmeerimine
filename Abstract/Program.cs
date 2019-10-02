using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kass = new Cat();
            Dog koer = new Dog();
            Cat kass01 = new Cat();
            RobinRed lind = new RobinRed();

            kass.Talk();
            koer.Talk();
            kass01.Talk();
            koer.Talk();

            lind.Talk();




            Console.WriteLine(kass.LegN);
            Console.WriteLine(kass01.LegN);
            Console.WriteLine(koer.LegN);
            Console.WriteLine(lind.LegN);
            Console.ReadLine();




        }
    }
}
