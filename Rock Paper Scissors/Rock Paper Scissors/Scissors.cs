using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Scissors : Pick
    {

        

        public Scissors()
        {
            value = 2;
            name = "Scissors";
        }
        public new void win()
        {
            Console.WriteLine("Scissors wins!");
        }
        public new void loss()
        {

        }
    }
}
