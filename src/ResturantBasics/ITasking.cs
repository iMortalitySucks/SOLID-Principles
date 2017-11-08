namespace ResturantBasics
{
    public interface ITasking
    {
        string Name { get; }

        bool DoTask();

        bool TaskCompleted { get; }
    }
}