using ResturantBasics;

namespace OpenForAnything
{
    internal class BillCustomerTasking : Tasking
    {
        public BillCustomerTasking() : base("bill customer")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}