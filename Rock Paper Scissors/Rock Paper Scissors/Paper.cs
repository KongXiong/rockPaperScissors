using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Paper : Pick
    {
        public Paper()
        {
            value = 1;
            name = "Paper";
        }
        public new void win()
        {
            Console.WriteLine("Paper wins!");

        }
        public new void loss()
        {

        }
    }
}
