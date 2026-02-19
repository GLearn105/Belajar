using System;
namespace OOP
{
    interface IWorker
    {
        void work();
    }
    interface IEateble
    {
        void eat();
    }

    public class Human : IWorker, IEateble
    {
        public void work()
        {
            Console.WriteLine("Human is working.");
        }

        public void eat()
        {
            Console.WriteLine("Human is eating.");
        }
    }
}