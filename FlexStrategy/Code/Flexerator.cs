
namespace FlexStrategy.Code
{
    public class Flexerator
    {
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
