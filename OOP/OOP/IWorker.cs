using System;
namespace OOP
{
    interface IWorker
    {
        void Work();
    }
    interface IEateble
    {
        void Eat();
    }

    public class Human : IWorker, IEateble
    {
        public void Work()
        {
            Console.WriteLine("Human is Working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is Eating.");
        }
    }
}