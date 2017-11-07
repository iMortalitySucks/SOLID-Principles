using ResturantBasics;

namespace SingleResponsibility
{
    internal class Waiter: Worker
    {
        public Waiter()
        {
        }

        internal string TakeCustomerOrder(Customer newCustomer)
        {
            CheckTask("take customer's order");
            return "Some food and a drink";
        }

        internal void DeliverOrder(Food food, Customer newCustomer)
        {
            CheckTask("deliver order");
        }

        internal void BillCustomer(Customer newCustomer)
        {
            CheckTask("bill customer");
        }
    }
}