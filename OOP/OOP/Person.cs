using System;
namespace OOP
{
    class Person
    {
        private string Name;
        private int Score;

        public Person(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name
        {
            get { return name; }
            set { 
                if (!string.IsNullOrEmpty(value)) 
                name = "unknown"; 
                else name : value;}
        }

        public int Score
        {
            get { return score; }
            private set
            {
                if (value < 0)
                    score = 0;
                else if (value > 100)
                    score = 100;
                else
                    score = value;
            }
            
        }

        public void CheckStatus()
        {
            if (Score >= 75)
            {
                Console.WriteLine(Name + " Kamu Lulus.");
            }
            else
            {
                Console.WriteLine(Name + " Kamu Tidak Lulus.");
            }
        }

        public void SayHello()
        {
            Console.WriteLine("Hello " + Name);
        }
    }

}