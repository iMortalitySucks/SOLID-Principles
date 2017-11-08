using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public interface ICustomerManager
    {
        void CheckCustomers();

        void AddCustomer(ICustomer customer);
    }
}
