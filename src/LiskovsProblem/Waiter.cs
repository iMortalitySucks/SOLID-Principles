using ResturantBasics;

namespace LiskovsProblem
{
    internal class Waiter : Worker, ISuperWorker
    {
        public Waiter()
        {
        }

        public string TakeCustomerOrder(Customer newCustomer)
        {
            CheckTask("take customer's order");
            return "Some food and a drink";
        }

        public void DeliverOrder(Food food, Customer newCustomer)
        {
            CheckTask("deliver order");
        }

        public void BillCustomer(Customer newCustomer)
        {
            CheckTask("bill customer");
        }

        public void BusTable(int tableNumber)
        {
            throw new System.NotImplementedException();
        }

        public void CookOrder(string order)
        {
            throw new System.NotImplementedException();
        }

        public Food PlateFood(string order)
        {
            throw new System.NotImplementedException();
        }

        public void PrepareFood(string order)
        {
            throw new System.NotImplementedException();
        }

        public int FindEmptyTable()
        {
            throw new System.NotImplementedException();
        }

        public void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}