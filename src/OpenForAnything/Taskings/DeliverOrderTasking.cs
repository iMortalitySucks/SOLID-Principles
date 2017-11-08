using ResturantBasics;

namespace OpenForAnything
{
    internal class DeliverOrderTasking : Tasking
    {
        public DeliverOrderTasking() : base("deliver order")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}