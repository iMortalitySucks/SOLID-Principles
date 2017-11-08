using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public class OrderInfo : IOrderInfo
    {
        public OrderInfo(ICustomer customer)
        {
            Customer = customer;
        }

        public ICustomer Customer { get; private set; }

        public int TableNumber { get; set; }

        public IFood Food { get; set; }
    }
}
