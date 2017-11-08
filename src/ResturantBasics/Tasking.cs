namespace ResturantBasics
{
    public abstract class Tasking : ITasking
    {
        public Tasking(string name)
        {
            Name = name;
        }

        public string Name { get; private  set; }

        public virtual bool DoTask()
        {
            TaskCompleted = true;
            return TaskCompleted;
        }

        public bool TaskCompleted { get; private set; }
    }
}
