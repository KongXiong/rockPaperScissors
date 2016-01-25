using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Rock : Pick
    {
        public Rock()
        {
            value = 0;
            name = "Rock";
        }
        public new void win()
        {
            Console.WriteLine("Rock wins!");
        }
        public new void loss()
        {

        }
    }
}
