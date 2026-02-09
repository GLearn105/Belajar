using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("John", 85);
            person.SayHello();
            person.CheckStatus();
            person.GetInfo();
            person.Addscore(10);
        }
    }
}