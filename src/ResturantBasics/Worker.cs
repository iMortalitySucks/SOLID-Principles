using System;
using System.Threading;

namespace ResturantBasics
{
    public abstract class Worker : IWorker
    {
        // One task per minute
        public const int MaxTasksPerRound = 5;

        public int TaskNumber { get; private set; } = 0;

        protected void CheckTask(string taskname)
        {
            TaskNumber++;
            if (TaskNumber >= MaxTasksPerRound)
            {
                throw new Exception($"{GetName()} is out of time to perform '{taskname}'");
            }
            Console.WriteLine($"{GetName()} is performing '{taskname}'...");
            Thread.Sleep(1000);
        }

        public void Reset()
        {
            TaskNumber = 0;
        }

        public void PerformTask(ITasking tasking)
        {
            CheckTask(tasking.Name);

            if (!tasking.DoTask())
            {
                Console.WriteLine($"{GetName()} was unable to perform '{tasking.Name}' because the customer left unhappy...");
                TaskNumber--; // Task doesn't count if the customer left already...
            }
        }

        public virtual string GetName()
        {
            return GetType().Name;
        }
    }
}
