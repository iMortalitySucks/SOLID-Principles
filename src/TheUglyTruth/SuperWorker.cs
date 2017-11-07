using ResturantBasics;

namespace TheUglyTruth
{
    public class SuperWorker: Worker
    {
        internal int FindEmptyTable()
        {
            CheckTask("find a table");
            return 10;
        }

        internal void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            CheckTask("seat the customer");
        }

        internal string TakeCustomerOrder(Customer newCustomer)
        {
            CheckTask("take customer's order");
            return "Some food and a drink";
        }

        internal void PrepareFood(string order)
        {
            CheckTask("prepare food");
        }

        internal void CookOrder(string order)
        {
            CheckTask("cook order");
        }

        internal Food PlateFood(string order)
        {
            CheckTask("plate food");

            return new Food();
        }

        internal void DeliverOrder(Food food, Customer newCustomer)
        {
            CheckTask("deliver order");
        }

        internal void BillCustomer(Customer newCustomer)
        {
            CheckTask("bill customer");
        }

        internal void BusTable(int tableNumber)
        {
            CheckTask("bus table");
        }
    }
}
