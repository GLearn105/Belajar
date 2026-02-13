using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            //day16
            Manager manager = new Manager("Eve", 8000, "Sales");
            Console.WriteLine(manager.ShowManagerInfo());
            manager.Work();

            
            
            
            
            
            //day15
            // Person2 person2 = new Person2("Alice", 85);
            // Person2 person3 = new Person2("Bob", 90);

            // Console.WriteLine(person2.Display());
            // Console.WriteLine(person3.Display());
            // Person2.ShowTotalPersons2();




            //day14
            // Person person = new Person("John", 65 );
            // Person person1 = new Person("John", 65 );
            // // person.SayHello();
            // // person.CheckStatus();
            // // person.GetInfo();
            // // person.AddScore(10);
            // // person.ReduceScore(5);

            // // Console.WriteLine(person.Score);
            // // Console.WriteLine(person.GetGrade());
            // Console.WriteLine(person.Display());
            // Person.ShowTotalPersons();



        }
    }
}