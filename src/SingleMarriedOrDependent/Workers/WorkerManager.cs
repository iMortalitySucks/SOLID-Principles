using System.Collections.Generic;
using System.Linq;
using ResturantBasics;

namespace SingleMarriedOrDependent.Workers
{
    public class WorkerManager : IWorkerManager
    {
        private readonly IEnumerable<IWorker> _workers;

        public WorkerManager(IEnumerable<IWorker> workers)
        {
            _workers = workers;
        }

        public IWorker GetAvailableWorker()
        {
            return _workers.FirstOrDefault(worker => worker.TaskNumber < 4);
        }

        public void ResetWorkerTime()
        {
            foreach (var worker in _workers)
                worker.Reset();
        }
    }
}
