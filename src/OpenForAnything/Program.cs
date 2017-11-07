using ResturantBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenForAnything
{
    class Program
    {
        static ITasking[] NewCustomerTaskings()
        {
            return new ITasking[]
            {
                new FindTableTasking(),
                new SeatCustomerTasking(),
                new TakeOrderTasking(),
                new PrepareFoodTasking(),
                new CookOrderTasking(),
                new PlatFoodTasking(),
                new DeliverOrderTasking(),
                new BillCustomerTasking(),
                new BusTableTasking()
            };
        }

        static void Main(string[] args)
        {
            Queue<ITasking> tasksToDo = new Queue<ITasking>();

            List<SuperWorker> workers = new List<SuperWorker>();
            workers.Add(new SuperWorker());

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                List<Customer> removeCustomers = new List<Customer>();

                Console.WriteLine("New customer arrived, starting loop...");
                var worker = workers.First();

                // A customer walks in every 5 minutes
                var newCustomer = new Customer();
                customers.Add(newCustomer);

                var newTasks = NewCustomerTaskings();

                foreach (var tasking in newTasks)
                    tasksToDo.Enqueue(tasking);

                try
                {
                    ITasking tasking;

                    while((tasking = tasksToDo.Dequeue()) != null)
                    {
                        worker.PerformTask(tasking);

                        if(tasking is DeliverOrderTasking)
                        {
                            // The customer eats the food
                            newCustomer.Eat();
                        }

                        if(tasking is BillCustomerTasking)
                        {
                            newCustomer.Pay();
                            newCustomer.Leave(Mood.Happy);
                            removeCustomers.Add(newCustomer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                foreach (Customer cust in customers)
                {
                    // Loop is done, now each customer has to wait another loop
                    bool stillHappy = cust.Wait();

                    if (!stillHappy)
                        removeCustomers.Add(cust);
                }

                foreach (var unhappyCustomer in removeCustomers)
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
