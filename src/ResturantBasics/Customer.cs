using System;
using System.Threading;

namespace ResturantBasics
{
    public enum Mood
    {
        Waiting,
        Happy,
        Unhappy
    }

    /// <summary>
    /// Regular customer
    /// </summary>
    public class Customer : ICustomer
    {
        public string CustomerName { get; set; } = "Customer";

        private const int MaxWaitTime = 5;

        public int WaitTime { get; private set; }

        public Mood CurrentMood { get; private set; } = Mood.Waiting;

        public void Eat()
        {
            // Customer eats their food
            Console.WriteLine($"{CustomerName} is eating...");
            Thread.Sleep(1000);
        }

        public void Pay()
        {
            // Customer pays the billz
            Console.WriteLine($"{CustomerName} is paying...");
            Thread.Sleep(1000);
        }

        public void Leave(Mood mood)
        {
            CurrentMood = mood;
            Console.WriteLine($"{CustomerName} left {mood}!");
        }

        public bool Wait()
        {
            WaitTime++;

            if(WaitTime >= MaxWaitTime)
            {
                Leave(Mood.Unhappy);
                return false;
            }
            return true;
        }
    }
}
