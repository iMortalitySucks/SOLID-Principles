using System;
using System.Threading;

namespace ResturantBasics
{
    public abstract class Worker
    {
        // One task per minute
        private const int MaxTasksPerRound = 5;

        public int TaskNumber { get; private set; } = 0;

        protected void CheckTask(string taskname)
        {
            TaskNumber++;
            if (TaskNumber >= MaxTasksPerRound)
            {
                throw new Exception($"{GetType().Name} is out of time to perform '{taskname}'");
            }
            Console.WriteLine($"{GetType().Name} is performing '{taskname}'...");
            Thread.Sleep(1000);
        }

        public void Reset()
        {
            TaskNumber = 0;
        }
    }
}
