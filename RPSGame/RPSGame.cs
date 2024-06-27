using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class RPSGame
    {
       public static string AIMove()
        {
            Random r = new Random();
            string[] moves = new string[3] {"rock","paper", "scissors" }; 

            int index=r.Next(moves.Length);
            return moves[index];
        }

        public static void Compare(string playerOneMove, string playerTwoMove, Player playerOne, Player AI)
        {
            if (playerOneMove == playerTwoMove)
            {
                Console.WriteLine("Tie , Choose Again.");
            }

            else if ((playerOneMove == "rock" && playerTwoMove == "scissors" )||
                (playerOneMove == "paper" && playerTwoMove == "rock")||
                (playerOneMove == "scissors" && playerTwoMove == "paper"))
            {
                playerOne.Score++;
                Console.WriteLine($"{playerOne.Name}  Score: {playerOne.Score} And Move {playerOneMove}");
                Console.WriteLine($"{AI.Name}  Score: {AI.Score} And Move: {playerTwoMove} ");
            }
            else
            {
                AI.Score++;
                Console.WriteLine($"{playerOne.Name}  Score: {playerOne.Score} And Move {playerOneMove}");
                Console.WriteLine($"{AI.Name}  Score: {AI.Score} And Move: {playerTwoMove} ");
            }
            if (playerOne.Score > AI.Score)
            {
                Console.WriteLine($"{playerOne.Name} is the  winner!");
            }
            else if (AI.Score > playerOne.Score)
            {
                Console.WriteLine($"{AI.Name} is the  winner!");
            }
            else
            {
                Console.WriteLine("the final result is Tie");
            }
        }
    }
}
