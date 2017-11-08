using ResturantBasics;

namespace OpenForAnything
{
    internal class SeatCustomerTasking : Tasking
    {
        public SeatCustomerTasking() : base("seat the customer")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}