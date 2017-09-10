using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{

    using System;
    /// <summary>
    /// A simple example of Blackjack card game
    /// </summary>
    class BlackJack
    {
        public static void PlayBlackJack()
        {
            int myNumber = 17;
            int theirNumber;
            System.Console.WriteLine("*** BlackJack! ***");
            do
            {
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given number is valid

                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win.");
                }
                if(theirNumber < myNumber && theirNumber > 1)
                {
                    System.Console.WriteLine("You lose.");
                }
                if (theirNumber < 1 || theirNumber > 21)
                {
                    break;
                } 

            } while (theirNumber != 0 || theirNumber < 21);

            System.Console.WriteLine("You lose. Invalid number.");


        }
    }
}