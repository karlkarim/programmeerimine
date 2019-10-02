using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ruut = new Rectangle(2,3);

            ruut.Perimeter();
            ruut.Area();

            Console.ReadLine();

        }
    }
}
