using ResturantBasics;
using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Hostess hostess = new Hostess();
            Waiter waiter = new Waiter();
            Cook cook = new Cook();
            Busser busser = new Busser();

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

                    // The worker has to bring the bill
                    waiter.BillCustomer(newCustomer);

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
