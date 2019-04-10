using FlexStrategy.Code.strats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexStrategy.Code;

namespace FlexStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;
            var wannaPlayCheck = "Wanna play again, Y or N?";

            while (run)
            {
                Flexerator flexerator = new Flexerator();
                Console.WriteLine("Choose a type: Bro, Nerd, Other, or Next Level");
                var response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "bro":
                        flexerator.MakeAFlex(new BroFlex());
                        break;
                    case "nerd":
                        flexerator.MakeAFlex(new NerdFlex());
                        break;
                    case "other":
                        flexerator.MakeAFlex(new SomeOtherFlex());
                        break;
                    case "next level":
                        flexerator.MakeAFlex(new NextLevelFlex());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(response);
                }

                var shout = flexerator.FlexOnEm();

                Console.WriteLine(shout);

                Console.WriteLine(wannaPlayCheck);

                var playResponse = Console.ReadLine();

                if(playResponse.ToLower().Equals("y"))
                {
                    run = true;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
