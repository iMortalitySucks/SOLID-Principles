using System.Collections.Generic;
using System.Linq;
using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public class OrderInfoProvider : IOrderInfoProvider
    {
        private readonly List<IOrderInfo> _orders = new List<IOrderInfo>();

        public IOrderInfo GetOrderInfo(ICustomer customer)
        {
            var orderInfo = _orders.FirstOrDefault(info => info.Customer == customer);

            if(orderInfo == null)
            {
                orderInfo = new OrderInfo(customer);
                _orders.Add(orderInfo);
            }

            return orderInfo;
        }
    }
}
