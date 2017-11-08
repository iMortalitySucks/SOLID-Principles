using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class BillCustomerTasking : VersatileTasking, ITasking
    {
        public BillCustomerTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            : base("bill customer", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            _customer.Pay();
            _customer.Leave(Mood.Happy);
        }
    }
}