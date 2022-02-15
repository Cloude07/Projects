using System;

namespace EventsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Муфаса");
            Worker worker = new Worker();

            lion.IsHungry += worker.Feed;
            lion.IsHungry += (lion) => Console.WriteLine("Лямбда-выражение покормило льва по кличке " + lion.Name);
            lion.Walk();
        }
    }
}
