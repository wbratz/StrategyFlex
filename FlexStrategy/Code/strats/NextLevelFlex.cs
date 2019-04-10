using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.strats
{
    internal class NextLevelFlex : IShoutFlex
    {
        public string ShoutFlex()
        {
            var flex = "Sorry this flexer has flexed so hard that the world has exploded, you lose";
            return flex;
        }
    }
}
