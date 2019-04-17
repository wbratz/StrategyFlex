using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.strats
{
    internal class BroFlex : IShoutFlex
    {
        public override string ShoutFlex()
        {
            var flex = "COME AT ME BRO!";
            return flex;
        }
    }
}
