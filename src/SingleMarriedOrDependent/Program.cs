using ResturantBasics;
using SingleMarriedOrDependent.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleMarriedOrDependent
{
    class Program
    {
        static ITasking[] NewCustomerTaskings(ICustomer customer, IOrderInfoProvider orderInfoProvider) =>
            // There is something missing about these taskings...
            //  we will cover that in dependency inversion
            new ITasking[]
            {
                new FindTableTasking(customer,orderInfoProvider),
                new SeatCustomerTasking(customer,orderInfoProvider),
                new TakeOrderTasking(customer,orderInfoProvider),
                new PrepareFoodTasking(customer,orderInfoProvider),
                new CookOrderTasking(customer,orderInfoProvider),
                new PlatFoodTasking(customer,orderInfoProvider),
                new DeliverOrderTasking(customer,orderInfoProvider),
                new BillCustomerTasking(customer,orderInfoProvider),
                new BusTableTasking(customer,orderInfoProvider)
            };

        static void Main(string[] args)
        {
            IOrderInfoProvider orderInfoProvider = new OrderInfoProvider();
            Queue<ITasking> tasksToDo = new Queue<ITasking>();
            List<IWorker> workers = new List<IWorker>(new[] { new VersatileWorker { WorkerNumber = 1 }, new VersatileWorker { WorkerNumber = 2 } });
            IWorkerManager workerManager = new WorkerManager(workers);
            ICustomerManager customerManager = new CustomerManager();

            int counter = 1;
            

            while (true)
            {
                Console.WriteLine("New customer arrived, starting loop...");

                // A customer walks in every 5 minutes
                var newCustomer = new Customer() { CustomerName = "Customer " + counter++ };
                customerManager.AddCustomer(newCustomer);

                var newTasks = NewCustomerTaskings(newCustomer, orderInfoProvider);

                foreach (var tasking in newTasks)
                    tasksToDo.Enqueue(tasking);

                try
                {
                    // Now we are going to try to 
                    IWorker worker;
                    while((worker = workerManager.GetAvailableWorker()) != null)
                    {
                        var tasking = tasksToDo.Dequeue();
                        worker.PerformTask(tasking);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                customerManager.CheckCustomers();

                Console.WriteLine();
                Console.WriteLine();

                workerManager.ResetWorkerTime();
            }
        }
    }
}
