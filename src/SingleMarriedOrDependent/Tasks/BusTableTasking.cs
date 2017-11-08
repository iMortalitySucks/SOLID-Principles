using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class BusTableTasking : VersatileTasking, ITasking
    {
        public BusTableTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            :base("bus table", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            // The bus boy is cleaning the table
        }
    }
}