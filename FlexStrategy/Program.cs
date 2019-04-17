using FlexStrategy.Code.strats;
using System;
using FlexStrategy.Code.Decorations;

namespace FlexStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;
            var wannaPlayCheck = "Wanna play again, Y or N?";
            var playTimeCount = 0;
            while (run)
            {
                Console.WriteLine("Choose a type: Bro, Nerd, Other, Next Level, or manbun");
                var response = Console.ReadLine();
                TimesPlayed play;

                switch (response.ToLower())
                {
                    case "bro":
                        play = new TimesPlayed(new BroFlex(), playTimeCount);
                        break;
                    case "nerd":
                        play = new TimesPlayed(new NerdFlex(), playTimeCount);
                        break;
                    case "other":
                        play = new TimesPlayed(new SomeOtherFlex(), playTimeCount);
                        break;
                    case "next level":
                        play = new TimesPlayed(new NextLevelFlex(), playTimeCount);
                        break;
                    case "manbun":
                        play = new TimesPlayed(new manbun(), playTimeCount);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(response);
                }
                
                var shout = play.ShoutFlex();
                
                Console.WriteLine(shout);

                Console.WriteLine(wannaPlayCheck);

                var playResponse = Console.ReadLine();

                if(playResponse.ToLower().Equals("y"))
                {
                    playTimeCount++;
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
