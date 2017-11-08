using System.Collections.Generic;
using System.Linq;
using ResturantBasics;

namespace SingleMarriedOrDependent
{
    public class CustomerManager : ICustomerManager
    {
        private readonly List<ICustomer> _customers = new List<ICustomer>();

        public void AddCustomer(ICustomer customer)
        {
            _customers.Add(customer);
        }

        public void CheckCustomers()
        {
            var happyCustomers = _customers.Where(c => c.CurrentMood == Mood.Happy).ToArray();

            foreach(var happyCustomer in happyCustomers)
                _customers.Remove(happyCustomer);

            foreach(var customer in _customers)
            {
                customer.Wait();
            }

            var unhappycustomers = _customers.Where(c => c.CurrentMood == Mood.Unhappy).ToArray();

            foreach(var unhappyCustomer in unhappycustomers)
            {
                _customers.Remove(unhappyCustomer);
            }
        }
    }
}
