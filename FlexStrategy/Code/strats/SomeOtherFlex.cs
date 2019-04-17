using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.strats
{
    class SomeOtherFlex : IShoutFlex
    {
        public override string ShoutFlex()
        {
            var flex = "I've really run out of things at this point and am just trying to take up space";
            return flex;
        }
    }
}
