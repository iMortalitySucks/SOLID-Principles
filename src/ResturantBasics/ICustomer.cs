namespace ResturantBasics
{
    public interface ICustomer
    {
        int WaitTime { get; }
        Mood CurrentMood { get; }

        void Eat();
        void Leave(Mood mood);
        void Pay();
        bool Wait();
    }
}