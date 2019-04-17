using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.Decorations
{
    public class TimesPlayed : FlexDecorator
    {
        public int PlayedNumber { get; set; }
        public TimesPlayed(IShoutFlex shoutFlex, int playedNumber) : base(shoutFlex)
        {
            PlayedNumber = playedNumber;
        }

        public override string ShoutFlex()
        {
            if (PlayedNumber > 2)
            {
                return "You play too much";
            }

            return base.ShoutFlex();
        }
    }
}
