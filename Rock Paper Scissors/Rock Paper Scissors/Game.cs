using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace Rock_Paper_Scissors
{
    class Game
    {
        string playersAmt;
        Player player1;
        Player player2;

 

        public void playGame()
        {
            string play;
            Pick player1Pick;
            Pick player2Pick;
            int checker;

            //if (playersAmt == "1")
            //{
            //    this.player1 = new User(Console.ReadLine());
            //    //player1.Name = ;
            //    this.player2 = new ComputerPlayer();
            //}
            //else if (playersAmt == "2")
            //{
            //    this.player1 = new User(Console.ReadLine());
            //    this.player2 = new User(Console.ReadLine());
            //}
            //player1 = new User();
            //Console.WriteLine("What is Player's Name?");
            //player1.Name = Console.ReadLine();
            //player2 = new ComputerPlayer();
            play = "y";
            while (play == "y")
            {
                Console.WriteLine("{0} turn", player1.Name);
                player1Pick = player1.userPick();
                Console.WriteLine("{0} turn", player2.Name);
                player2Pick = player2.userPick();
                checker = (5 + player1Pick.value - player2Pick.value) % 5;
                Console.WriteLine("{0} chose {1}." , player1.Name, player1Pick.name);
                Console.WriteLine("{0} chose {1}." , player2.Name, player2Pick.name);
                if (checker == 1 || checker == 3)
                {
                    Console.WriteLine("{0} Wins", player1.Name);
                    player1Pick.win(player1.Name, player1.score++);
                    
                }
                else if (checker == 2 || checker == 4)
                {
                    Console.WriteLine("{0} Wins", player2.Name);
                    player2Pick.win(player2.Name, player2.score++);
                }
                else if (checker == 0)
                {
                    Console.WriteLine("It's a Tie!!");
                }
                Console.WriteLine("play again? y or n");
                play = Console.ReadLine();
            }
        }

        public void makePlayers()
        {
            Console.WriteLine("How many Player's?  1 or 2?");
            string playersAmt = Console.ReadLine();
            if (playersAmt == "1")
            {
                player1 = new User();
                Console.WriteLine("What is Player's Name?");
                player1.Name = Console.ReadLine();
                player2 = new ComputerPlayer();
            }
            else if (playersAmt == "2")
            {
                player1 = new User();
                Console.WriteLine("What is first Player's Name?");
                player1.Name = Console.ReadLine();
                Console.WriteLine("What is second Player's Name?");
                player2 = new User();
                player2.Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nope");
            }

            //Console.ReadKey();

        }
    }
}
