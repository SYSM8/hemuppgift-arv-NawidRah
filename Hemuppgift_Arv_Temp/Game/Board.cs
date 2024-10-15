using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {


        public int pinCount;

        public int setUpNo;

        public int takePinsNo;
        private void noPins(int PinCount)
        {

            PinCount = pinCount;

        }
        

        public void setUp(int SetUpNo)
        {
           

            SetUpNo += pinCount;

        }

        public void takePins(int TakePinsNo)
        {
           

           TakePinsNo -= pinCount;
        }

        public void getNoPins()
        {
            Console.WriteLine($"Number of pins are: {pinCount}");
        }


        

        
    }
}
