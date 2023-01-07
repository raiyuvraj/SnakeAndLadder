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
            while (Position < 101)
            {
            
            Random random = new Random();
            Player1 = random.Next(0, 6);
            Console.WriteLine(Player1);

            int check1 = random.Next(0, 3);
                Console.WriteLine("Player option" +check1);
            int Position1 = 0;
                switch (check1)
                {
                    case 0:
                        break;
                    case 1:
                        Position1 += Player1;
                        break;
                    case 2:
                        Position1 -= Player1;
                        break;
                }
            }
        }
    }
}
