using ResturantBasics;

namespace SingleResponsibility
{
    internal class Hostess : Worker
    {
        public Hostess()
        {
            
        }

        internal int FindEmptyTable()
        {
            CheckTask("find a table");
            return 10;
        }

        internal void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            CheckTask("seat the customer");
        }
    }
}