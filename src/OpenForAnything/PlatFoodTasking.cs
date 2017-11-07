using ResturantBasics;

namespace OpenForAnything
{
    internal class PlatFoodTasking : Tasking
    {
        public PlatFoodTasking() : base("plate food")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}