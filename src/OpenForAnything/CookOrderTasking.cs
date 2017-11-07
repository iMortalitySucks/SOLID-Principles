using ResturantBasics;

namespace OpenForAnything
{
    internal class CookOrderTasking : Tasking
    {
        public CookOrderTasking() : base("cook order")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}