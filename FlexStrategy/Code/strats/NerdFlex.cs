using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.strats
{
    class NerdFlex : IShoutFlex
    {
        public string ShoutFlex()
        {
            var flex = "Weird flex but ok!";
            return flex;
        }
    }
}
