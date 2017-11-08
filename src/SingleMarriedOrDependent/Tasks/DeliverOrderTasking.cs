using ResturantBasics;
using SingleMarriedOrDependent.Tasks;

namespace SingleMarriedOrDependent
{
    internal class DeliverOrderTasking : VersatileTasking, ITasking
    {
        public DeliverOrderTasking(ICustomer customer, IOrderInfoProvider orderInfoProvider)
            :base("deliver order", customer, orderInfoProvider)
        {
        }

        protected override void DoTaskInternal()
        {
            // Waiter is delivering food
            var order = _orderInfoProvider.GetOrderInfo(_customer);

            if(order.Food.FoodState != FoodState.Plated)
            {
                _customer.Leave(Mood.Unhappy);
            }
            else
            {
                _customer.Eat();
            }
        }
    }
}