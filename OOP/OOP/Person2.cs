using System;
namespace OOP
{
    class Person2
    {
        private string name;
        private int score;
        public static int PersonCount;
        public readonly int Id;


        static Person2()
        {
            PersonCount = 0;
            Console.WriteLine("Static Constructor Person2 called.");
        }

        public Person2(string name, int score)
        {
            this.name = name;
            this.score = score;
            PersonCount++;
            Id = PersonCount;
            Console.WriteLine("Constractor Person2 called.");
        }

        public static void ShowTotalPersons2()
        {
            Console.WriteLine("Total Persons2: " + PersonCount);
        }

        public string Display()
        {
            return $"ID: {Id}, Name: {name}, Score: {score}";
        }
        
    }
}