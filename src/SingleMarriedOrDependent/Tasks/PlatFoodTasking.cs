using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class PlatFoodTasking : VersatileTasking, ITasking
    {

        public PlatFoodTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            : base("plate food", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            var order = _orderInfoProvider.GetOrderInfo(_customer);

            if (order.Food.FoodState == FoodState.Cooked)
                order.Food.FoodState = FoodState.Plated;
        }
    }
}