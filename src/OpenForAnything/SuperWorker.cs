using ResturantBasics;
using System;

namespace OpenForAnything
{
    public class SuperWorker : Worker
    {
        public object PerformTask(ITasking tasking)
        {
            switch (tasking.Name)
            {
                case "find a table":
                    return FindEmptyTable();
                case "seat the customer":
                    SeatCustomer(null, 1);
                    return null;
                case "take customer's order":
                    return TakeCustomerOrder(null);
                case "prepare food":
                    PrepareFood("food");
                    return null;
                case "cook order":
                    CookOrder("food");
                    return null;
                case "plate food":
                    return PlateFood("food");
                case "deliver order":
                    DeliverOrder(null, null);
                    return null;
                case "bill customer":
                    BillCustomer(null);
                    return null;
                case "bus table":
                    BusTable(1);
                    return null;
                default:
                    throw new NotImplementedException("worker doesn't know how to do that task!");
            }
           
        }

        private int FindEmptyTable()
        {
            CheckTask("find a table");
            return 10;
        }

        private void SeatCustomer(Customer newCustomer, int tableNumber)
        {
            CheckTask("seat the customer");
        }

        private string TakeCustomerOrder(Customer newCustomer)
        {
            CheckTask("take customer's order");
            return "Some food and a drink";
        }

        private void PrepareFood(string order)
        {
            CheckTask("prepare food");
        }

        private void CookOrder(string order)
        {
            CheckTask("cook order");
        }

        private Food PlateFood(string order)
        {
            CheckTask("plate food");

            return new Food();
        }

        private void DeliverOrder(Food food, Customer newCustomer)
        {
            CheckTask("deliver order");
        }

        private void BillCustomer(Customer newCustomer)
        {
            CheckTask("bill customer");
        }

        private void BusTable(int tableNumber)
        {
            CheckTask("bus table");
        }
    }
}
