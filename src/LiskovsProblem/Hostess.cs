using ResturantBasics;

namespace LiskovsProblem
{
    internal class Hostess : Worker, ISuperWorker
    {
        public Hostess()
        {
            
        }

        public void BillCustomer(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public void BusTable(int tableNumber)
        {
            throw new System.NotImplementedException();
        }

        public void CookOrder(string order)
        {
            throw new System.NotImplementedException();
        }

        public void DeliverOrder(Food food, Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public int FindEmptyTable()
        {
            CheckTask("find a table");
            return 10;
        }

        public Food PlateFood(string order)
        {
            throw new System.NotImplementedException();
        }

        public void PrepareFood(string order)
        {
            throw new System.NotImplementedException();
        }

        public void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            CheckTask("seat the customer");
        }

        public string TakeCustomerOrder(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }
    }
}