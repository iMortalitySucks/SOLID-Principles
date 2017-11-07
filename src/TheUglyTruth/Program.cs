using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUglyTruth
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SuperWorker> workers = new List<SuperWorker>();
            workers.Add(new SuperWorker());

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                Console.WriteLine("New customer arrived, starting loop...");
                var worker = workers.First();

                // A customer walks in every 5 minutes
                var newCustomer = new Customer();
                customers.Add(newCustomer);

                try
                {
                    // When the customer comes in a worker has to find a table for them to sit at
                    int tableNumber = worker.FindEmptyTable();

                    // Then the worker has to seat the customer
                    worker.SeatCustomer(newCustomer, tableNumber);

                    // Then the worker has to take their order
                    string order = worker.TakeCustomerOrder(newCustomer);

                    // Then the worker has to prepare the order
                    worker.PrepareFood(order);

                    // Then the worker has to cook the food
                    worker.CookOrder(order);

                    // The worker then plates the food
                    Food food = worker.PlateFood(order);

                    // The worker has to deliver the food
                    worker.DeliverOrder(food, newCustomer);

                    // The customer eats the food
                    newCustomer.Eat();

                    // The worker has to bring the bill
                    worker.BillCustomer(newCustomer);

                    // The customer pays the bill
                    newCustomer.Pay();

                    // The customer leave
                    newCustomer.Leave(Mood.Happy);

                    // finally the worker has to clean the table
                    worker.BusTable(tableNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                List<Customer> unhappyCustomers = new List<Customer>();

                foreach(Customer cust in customers)
                {
                    // Loop is done, now each customer has to wait another loop
                    bool stillHappy = cust.Wait();

                    if (!stillHappy)
                        unhappyCustomers.Add(cust);
                }

                foreach(var unhappyCustomer in unhappyCustomers)
                {
                    customers.Remove(unhappyCustomer);
                }

                Console.WriteLine();
                Console.WriteLine();

                foreach(var w in workers)
                {
                    w.Reset();
                }
            }
        }
    }
}
