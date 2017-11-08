using ResturantBasics;

namespace LiskovsProblem
{
    /// <summary>
    /// The super worker that can do anything... or can they?
    /// </summary>
    public interface ISuperWorker : IWorker
    {
        /*  This interface introduces the next principle / problem of interface segregation
         *   There is no reason to have all of these methods in one interface because when writing
         *   real integration tests, you will have to test the interaction between two classes based
         *   on their interfaces and that also requires that each method that the calling class cares
         *   about be tested.  Hope no state changes during that time...
         */

        void BusTable(int tableNumber);
        void CookOrder(string order);
        Food PlateFood(string order);
        void PrepareFood(string order);
        int FindEmptyTable();
        void SeatCustomer(Customer newCustomer, int tableNumber);
        void BillCustomer(Customer newCustomer);
        void DeliverOrder(Food food, Customer newCustomer);
        string TakeCustomerOrder(Customer newCustomer);
    }
}
