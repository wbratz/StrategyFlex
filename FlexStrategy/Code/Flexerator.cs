using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code
{
    public class Flexerator
    {
        public string flexer;
        private IShoutFlex _shoutFlex;

        public void MakeAFlex(IShoutFlex flex)
        {
            _shoutFlex = flex;
        }

        public string FlexOnEm()
        {
            return _shoutFlex.ShoutFlex();
        }
        

    }
}
