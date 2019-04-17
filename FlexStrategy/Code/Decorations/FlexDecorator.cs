
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
