using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public interface IOrderInfoProvider
    {
        IOrderInfo GetOrderInfo(ICustomer customer);
    }
}
