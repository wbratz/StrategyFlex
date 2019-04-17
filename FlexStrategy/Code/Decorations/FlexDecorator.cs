using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexStrategy.Code.Decorations
{
    public abstract class FlexDecorator : IShoutFlex
    {
        protected IShoutFlex _shoutFlex;

        public FlexDecorator(IShoutFlex shoutFlex)
        {
            _shoutFlex = shoutFlex;
        }

        public override string ShoutFlex()
        {
            var flex = _shoutFlex.ShoutFlex();
            return flex;
        }
    }
}
