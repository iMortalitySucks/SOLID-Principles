using ResturantBasics;
using SingleMarriedOrDependent.Tasks;
using System;

namespace SingleMarriedOrDependent
{
    internal class FindTableTasking : VersatileTasking, ITasking
    {

        public FindTableTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider) : base("find a table", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            var orderInfo = _orderInfoProvider.GetOrderInfo(_customer);

            // Get the table number and add it to the order info
            orderInfo.TableNumber = new Random(52).Next(1, 25);
        }

    }
}