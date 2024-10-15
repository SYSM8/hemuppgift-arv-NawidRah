using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{ 
    public class HumanPlayer : Player
    {
        public HumanPlayer(string id) : base(id) 
        {
        
        }

        public override int takePins(Board board)
        {
            int PinChoice;
            do
            {
                Console.WriteLine($"{userId}, hur många pinnar vill du ta? (1 eller 2)");
                PinChoice = Convert.ToInt32(Console.ReadLine());

                if (PinChoice == 0  || PinChoice > 2)
                {
                    Console.WriteLine("Ogiltigt val, välj mellan 1 och 2");
                }
                

            }
            while (PinChoice < 1 || PinChoice > 2);



            return PinChoice;
        }
    }


}




