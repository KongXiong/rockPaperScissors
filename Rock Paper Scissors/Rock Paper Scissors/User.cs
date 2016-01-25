using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class User : Player
    {
        //new string Name;
        //int Score;



        ////string input;        

        ////public void setScore(int Score)
        ////{
        ////    this.Score = Score;
        ////}
        ////public int getScore()
        ////{
        ////    return this.Score;
        ////}
        public override Pick userPick()
        {
            //Pick value;
            Console.WriteLine("Press  R-Rock, P-Paper, S-Scissors, Sp-Spock, L-Lizard");
            string input = Console.ReadLine();
            //Console.Clear();
            if (input == "r")
            {
                Rock rock = new Rock();
                return rock;
            }
            else if (input == "p")
            {
                Paper paper = new Paper();
                return paper;
            }
            else if (input == "s")
            {
                Scissors scissors = new Scissors();
                return scissors;
            }
            else if (input == "sp")
            {
                Spock spock = new Spock();
                return spock;
            }
            else if (input == "l")
            {
                Lizard lizard = new Lizard();
                return lizard;
            }
            else
            {
                userPick();
                return null;
            }
        }


    }
}
