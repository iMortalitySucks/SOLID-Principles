using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class SeatCustomerTasking : VersatileTasking, ITasking
    {
        public SeatCustomerTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider):
            base("seat the customer", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            // Customer is being seated
        }
    }
}