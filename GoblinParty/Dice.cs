using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinParty
{
    class Dice
    {
        int[] fiveDice = new int[5];

        Random rnd = new Random();

        public void rollFiveDSix()
        {

            fiveDice[0] = rnd.Next(6) + 1;
            fiveDice[1] = rnd.Next(6) + 1;
            fiveDice[2] = rnd.Next(6) + 1;
            fiveDice[3] = rnd.Next(6) + 1;
            fiveDice[4] = rnd.Next(6) + 1;

            successCounter();
        }

        public void successCounter()
        {
            int count = 0;

            for (int i = 0; i < fiveDice.Length; i++)
            {
                if (fiveDice[i] >= 4)
                {
                    count++;
                }
                Console.Write(fiveDice[i] + " ");

            }
            Console.Write(" / " + count + " success(es)" + "\n");
        }

        public void autoRoller()
        {
            Console.WriteLine("How many times would you like to roll 5D6?");
            int numberOfAutoRolls = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfAutoRolls; i++)
            {
                rollFiveDSix();
            }

        }
    }
}
