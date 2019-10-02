using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Cat : Mammal
    {

        public override void Talk()
        {
            Console.WriteLine("meow");
        }

        //public override int LegN { get { return 4; } }


    }
}
