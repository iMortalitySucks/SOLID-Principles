using ResturantBasics;

namespace LiskovsProblem
{
    internal class Busser : Worker, ISuperWorker
    {
        public Busser()
        {
        }

        public void BillCustomer(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public void BusTable(int tableNumber)
        {
            CheckTask("bus table");
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

        public void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            throw new System.NotImplementedException();
        }

        public string TakeCustomerOrder(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }
    }
}