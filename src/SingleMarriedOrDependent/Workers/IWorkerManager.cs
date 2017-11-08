using ResturantBasics;

namespace SingleMarriedOrDependent.Workers
{
    public interface IWorkerManager
    {
        IWorker GetAvailableWorker();

        void ResetWorkerTime();
    }
}
