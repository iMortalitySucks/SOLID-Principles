using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public interface IOrderInfo
    {
        ICustomer Customer { get; }

        int TableNumber { get; set; }

        IFood Food { get; set; }
    }
}
