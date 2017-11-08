using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class CookOrderTasking : VersatileTasking, ITasking
    {
        public CookOrderTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            :base("cook order", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            var order = _orderInfoProvider.GetOrderInfo(_customer);
            order.Food.FoodState = FoodState.Cooked;
        }
    }
}