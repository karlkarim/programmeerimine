using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Dog : Mammal
    {
        public override void Talk()
        {
            Console.WriteLine("auh");
        }

        public override int LegN { get { return 4; } }


    }
}
