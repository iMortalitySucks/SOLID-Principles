using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class TakeOrderTasking : VersatileTasking, ITasking
    {
        public TakeOrderTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            :base("take customer's order", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            // Customer order is being taken
        }
    }
}