using ResturantBasics;

namespace OpenForAnything
{
    internal class PrepareFoodTasking : Tasking
    {
        public PrepareFoodTasking() : base("prepare food")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}