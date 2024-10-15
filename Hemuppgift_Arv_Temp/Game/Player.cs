using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        protected string userId;

        public Player(string id) //Detta är basen för användarnamnet (UserID)
        {
            userId = id;
        }

        public string getUserId()
        {
            return userId;
        }

        // Detta är en abstrakt metod som används för att implementeras i andra klasser. På så sätt har vi en bas som kan användas i blandannat HumanPlayer och ComputerPlayer.
        public abstract int takePins(Board board);
    }

}
