using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Alice", 95);
            person.SayHello();
            person.CheckStatus();
        }
    }
}