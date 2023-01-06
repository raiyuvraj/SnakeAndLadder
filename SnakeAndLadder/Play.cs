using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Play
    {
        int Player1 ;
        int Position = 0;

        public void RollDice()
        {
            Random random= new Random();
            Player1 = random.Next(0, 7);

            Console.WriteLine(Player1);
        }
    }
}
