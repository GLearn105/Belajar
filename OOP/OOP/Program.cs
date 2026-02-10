using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("John", 65);
            // person.SayHello();
            // person.CheckStatus();
            // person.GetInfo();
            person.AddScore(10);
            person.ReduceScore(5);

            Console.WriteLine(person.Score);
            Console.WriteLine(person.GetGrade());



        }
    }
}