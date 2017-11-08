namespace ResturantBasics
{
    public interface IWorker
    {
        int TaskNumber { get; }

        void Reset();

        void PerformTask(ITasking tasking);

        string GetName();
    }
}