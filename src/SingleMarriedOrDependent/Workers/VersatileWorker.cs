using ResturantBasics;

namespace SingleMarriedOrDependent.Workers
{
    /// <summary>
    /// Look ma, no methods!
    /// </summary>
    public class VersatileWorker : Worker
    {
        public int WorkerNumber { get; set; }

        public override string GetName()
        {
            return "Worker " + WorkerNumber;
        }
    }
}
