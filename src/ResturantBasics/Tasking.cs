namespace ResturantBasics
{
    public abstract class Tasking : ITasking
    {
        public Tasking(string name)
        {
            Name = name;
        }

        public string Name { get; private  set; }

        public abstract bool DoTask();
    }
}
