using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class PrepareFoodTasking : VersatileTasking, ITasking
    {
        public PrepareFoodTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            :base("prepare food", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            var order = _orderInfoProvider.GetOrderInfo(_customer);
            order.Food = new Food();
            order.Food.FoodState = FoodState.Raw;
        }
    }
}