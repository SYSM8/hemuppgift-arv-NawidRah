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

       
        public void setUp(int pins) //Denna visar hur många pinnar programmet ska ha, brukar vara 10!
        {
            noPins = pins;
        }
        public void takePins(int pins) //Detta är koden som tar bort respektive pinnar
        {
            noPins -= pins;
        }
        public int getNoPins() //Få antalet pinnar.
        {
            return noPins;
        }
    }
}
