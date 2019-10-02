using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }


        public override void Area()
        {
            Console.WriteLine(sideA*sideB);
        }

        public Rectangle(int sideA,int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;

        }

        public override void Perimeter()
        {
           

            Console.WriteLine(2*(sideA+sideB));
            
        }


    }
}
