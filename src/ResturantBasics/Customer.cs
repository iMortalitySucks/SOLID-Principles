using System;
using System.Threading;

namespace ResturantBasics
{
    public enum Mood
    {
        Happy,
        Unhappy
    }

    /// <summary>
    /// Regular customer
    /// </summary>
    public class Customer : ICustomer
    {
        private const int MaxWaitTime = 5;

        public int WaitTime { get; private set; }

        public void Eat()
        {
            // Customer eats their food
            Console.WriteLine("The customer is eating...");
            Thread.Sleep(1000);
        }

        public void Pay()
        {
            // Customer pays the billz
            Console.WriteLine("The customer is paying...");
            Thread.Sleep(1000);
        }

        public void Leave(Mood mood)
        {
            Console.WriteLine($"The customer left {mood}!");
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
