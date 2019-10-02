using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Mammal : Animal
    {
        public override void Talk()
        {
            
        }

        public override int LegN { get { return 4; } }

    }
}
