using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Spock : Pick
    {
        public Spock()
        {
            value = 3;
            name = "Spock";
        }
        public new void win()
        {
            Console.WriteLine("Spock wins!");
        }
        public new void loss()
        {

        }
    }
}
