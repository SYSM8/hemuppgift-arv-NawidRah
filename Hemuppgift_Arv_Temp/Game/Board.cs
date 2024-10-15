using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        private int noPins;

       
        public void setUp(int pins)
        {
            noPins = pins;
        }
        public void takePins(int pins)
        {
            noPins -= pins;
        }
        public int getNoPins()
        {
            return noPins;
        }
    }
}
