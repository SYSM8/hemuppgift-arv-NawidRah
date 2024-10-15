using Hemuppgift_Arv_Temp.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    class TakePinsGame
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.setUp(10); //Här bestämmer jag att den ska börja med 10 pinnar.

            Player player1 = new HumanPlayer("Spelare 1");
            Player player2 = new ComputerPlayer("Dator");

            Player currentPlayer = player1;
            while (board.getNoPins() > 0)
            {
                Console.WriteLine($"Antal pinnar kvar: {board.getNoPins()}");
                int pinsTaken = currentPlayer.takePins(board);
                board.takePins(pinsTaken);

                if (board.getNoPins() <= 0)
                {
                    Console.WriteLine($"{currentPlayer.getUserId()} har förlorat!"); //När antalet pinnar når siffran 0 så kommer detta meddelande spelas, och den spelaren som förlorar kommer att skrivas.
                    break;
                }

                
                currentPlayer = (currentPlayer == player1) ? player2 : player1; //Denna kod används för att växla användare i spelet för att ha ett pågående spel.
            }

            Console.WriteLine("Spelet är slut! :D");
        }
    }

}
