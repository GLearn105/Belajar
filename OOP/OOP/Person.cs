using System;
namespace OOP
{
    class Person
    {
        private string name;
        private int score;
        public static int PersonCount;

        public Person(string name, int score)
        {
            this.Name = name;
            this.Score = score;
            PersonCount++;
            Console.WriteLine("Constractor Person called.");
        }
        
        public string Display()
        {
            return $"Name: {Name}, Score: {Score}";
        }

        public static void ShowTotalPersons()
        {
            Console.WriteLine("Total Persons: " + PersonCount);
        }


        public string Name
        {
            get { return name; }
            set { 
                if (!string.IsNullOrEmpty(value)) 
                name = value; 
                else 
                name = "unknown";}
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

        public void AddScore(int value)
        {
            if (value > 0)
                Score += value;
        }

        public void ReduceScore(int value)
        {
            if (value > 0)
                Score -= value;
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public bool IsPassed()
        {
            return Score >= 75;
        }

        public void GetInfo()
        {
            Console.WriteLine("Name: " + Name + ", Score: " + Score);
        }

        public string GetGrade()
        {
            if (Score >= 85)
            {
                return "A";
            }
            else if (Score >= 70)
            {
                return "B";
            }
            else if (Score >= 55)
            {
                return "C";
            }
            else
            {
                return "D";
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