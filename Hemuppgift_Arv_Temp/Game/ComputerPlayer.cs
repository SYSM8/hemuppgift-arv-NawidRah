using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        private Random random;

        public ComputerPlayer(string id) : base(id)
        {
            random = new Random();
        }

        public override int takePins(Board board)
        {
            int pins = random.Next(1, 3); // Väljer slumpmässigt mellan 1 och 2
            Console.WriteLine($"{userId} (datorn) tog {pins} pinnar.");
            return pins;
        }
    }

}
