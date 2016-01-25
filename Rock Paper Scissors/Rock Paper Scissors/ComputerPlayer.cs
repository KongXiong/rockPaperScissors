using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class ComputerPlayer : Player, Iplayer
    {
        public new string Name = "Computer";
        //int Score;
        public new Pick userPick()
        {
            Random random = new Random();
            int roll = random.Next(5);
            if (roll == 0)
            {
                Rock rock = new Rock();
                return rock;
            }
            else if (roll == 1)
            {
                Paper paper = new Paper();
                return paper;
            }
            else if (roll == 2)
            {
                Scissors scissors = new Scissors();
                return scissors;
            }
            else if (roll == 3)
            {
                Spock spock = new Spock();
                return spock;
            }
            else if (roll == 4)
            {
                Lizard lizard = new Lizard();
                return lizard;
            }
            else
            {
                userPick();
                return new Rock();
            }
        }
    }
}
