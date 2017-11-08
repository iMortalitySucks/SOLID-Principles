using ResturantBasics;

namespace LiskovsProblem
{
    internal class Cook : Worker, ISuperWorker
    {
        public Cook()
        {
        }

        public void PrepareFood(string order)
        {
            CheckTask("prepare food");
        }

        public void CookOrder(string order)
        {
            CheckTask("cook order");
        }

        public Food PlateFood(string order)
        {
            CheckTask("plate food");

            return new Food();
        }

        public void BusTable(int tableNumber)
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

        public void BillCustomer(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public void DeliverOrder(Food food, Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public string TakeCustomerOrder(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }
    }
}