using ResturantBasics;

namespace OpenForAnything
{
    internal class TakeOrderTasking : Tasking
    {
        public TakeOrderTasking() : base("take customer's order")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}