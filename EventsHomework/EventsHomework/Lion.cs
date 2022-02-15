using System;
using System.Threading;

namespace EventsHomework
{
    class Lion
    {
        public string Name { get; }
        public event Action<Lion> IsHungry;

        public Lion(string name)
        {
            Name = name;
        }

        public void Walk()
        {
            Console.WriteLine("Лев гуляет...");
            Thread.Sleep(5000);
            Console.WriteLine("Лев голоден...");
            if (IsHungry != null)
            {
                IsHungry(this);
            }
        }
    }
}

