using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Bird : Animal
    {

        public override void Talk()
        {
            Console.WriteLine("Birds sing");
        }

        public override int LegN { get { return 2; } }





    }
}
