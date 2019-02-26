using FlexStrategy.Code.strats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                IShoutFlex flex;
                Console.WriteLine("Choose a type: Bro, Nerd, or Other");
                var response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "bro":
                        flex = new BroFlex();
                        break;
                    case "nerd":
                        flex = new NerdFlex();
                        break;
                    case "other":
                        flex = new SomeOtherFlex();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(response);
                }

                var shout = flex.ShoutFlex();

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
