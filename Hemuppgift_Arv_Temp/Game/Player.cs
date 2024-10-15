using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {

        public string userID;

        public Player(string UserID)
        {
            userID = UserID;

        }


        public void getUserID()
        {
            Console.WriteLine($"UserID: {userID}");
        }

        public virtual void takePins(Board board)
        {
            Console.WriteLine($"Taking {board.takePinsNo} from the board");
        }



    }
}
