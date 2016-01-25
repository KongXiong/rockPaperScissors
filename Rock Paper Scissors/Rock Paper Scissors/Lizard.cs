using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Lizard : Pick
    {
        public Lizard()
        {
            value = 4;
            name = "Lizard";
        }
        public new void win()
        {
            Console.WriteLine("Lizard wins!");
        }
        public new void loss()
        {

        }

    }
}
