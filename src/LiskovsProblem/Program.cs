using ResturantBasics;
using System;
using System.Collections.Generic;

namespace LiskovsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // With a 'generic' interface, each individual class can be treated as a super worker
            //  however, in practice, each method would have to be tested at the interface level
            ISuperWorker hostess = new Hostess();
            ISuperWorker waiter = new Waiter();
            ISuperWorker cook = new Cook();
            ISuperWorker busser = new Busser();

            List<IWorker> workers = new List<IWorker>(new IWorker[] { hostess, waiter, cook, busser });

            List<ICustomer> customers = new List<ICustomer>();

            while (true)
            {
                Console.WriteLine("New customer arrived, starting loop...");

                // A customer walks in every 5 minutes
                var newCustomer = new Customer();
                customers.Add(newCustomer);

                try
                {
                    /* So Barabara Liskov pointed out that if you use interfaces, all classes that implement that interface
                     * should be able to pass the same tests.  The same program below has not changed, but lets say the waiter
                     * falls behind on his work the the hostess needs to step in and help.  The interface indicates that the host
                     * can also deliver orders and bill the customer, but in reality they cannot
                     */

                    // When the customer comes in a worker has to find a table for them to sit at
                    int tableNumber = hostess.FindEmptyTable();

                    // Then the worker has to seat the customer
                    hostess.SeatCustomer(newCustomer, tableNumber);

                    // Then the worker has to take their order
                    string order = waiter.TakeCustomerOrder(newCustomer);

                    // Then the worker has to prepare the order
                    cook.PrepareFood(order);

                    // Then the worker has to cook the food
                    cook.CookOrder(order);

                    // The worker then plates the food
                    Food food = cook.PlateFood(order);

                    // The worker has to deliver the food
                    waiter.DeliverOrder(food, newCustomer);

                    // The customer eats the food
                    newCustomer.Eat();

                    // The hostest has to bring the bill because the waiter is busy
                    //  Testing to interfaces is an important part of unit/integration testing
                    //  Aditionally, a new developer coming in should be able to assume that a class that implements
                    //  an interface should work as described on that interface!!!
                    hostess.BillCustomer(newCustomer);

                    // The customer pays the bill
                    newCustomer.Pay();

                    // The customer leave
                    newCustomer.Leave(Mood.Happy);

                    // finally the worker has to clean the table
                    busser.BusTable(tableNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                List<Customer> unhappyCustomers = new List<Customer>();

                foreach (Customer cust in customers)
                {
                    // Loop is done, now each customer has to wait another loop
                    bool stillHappy = cust.Wait();

                    if (!stillHappy)
                        unhappyCustomers.Add(cust);
                }

                foreach (var unhappyCustomer in unhappyCustomers)
                {
                    customers.Remove(unhappyCustomer);
                }

                Console.WriteLine();
                Console.WriteLine();

                foreach (var w in workers)
                {
                    w.Reset();
                }
            }
        }
    }
}
