using System;
namespace OOP
{
    interface IPrintable
    {
        void Print();
    }
    interface ISaveable
    {
        void Save();
    }

    public class Document : IPrintable, ISaveable
    {
        public void Print()
        {
            Console.WriteLine("Printing the document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving the document...");
        }
    }
}