using System;

namespace InterfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper worker = new Worker();
            worker.DevelopConsoleApplication();

            ISkilledDeveloper worker2 = new Worker();
            worker2.DevelopConsoleApplication();
            worker2.DevelopWebApplication();

            Worker worker3 = new Worker();
            ((IDeveloper)worker3).DevelopConsoleApplication();

            worker3.DevelopWebApplication();
            worker3.DevelopConsoleApplication();
        }
    }

    public class Worker : ISkilledDeveloper
    {
        public void DevelopConsoleApplication()
        {
            throw new NotImplementedException();
        }

        public void DevelopWebApplication()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDeveloper
    {
        public void DevelopConsoleApplication();
    }

    public interface ISkilledDeveloper : IDeveloper
    {
        public void DevelopWebApplication();
    }
}
