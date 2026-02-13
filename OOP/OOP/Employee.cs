using System;

namespace OOP
{
    class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
            Console.WriteLine("Constructor Employee called.");
        }

        public string ShowInfo()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
        
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Manager : Employee
    {
        public string Departement { get; private set; }

        public Manager(string name, int salary, string departement)
            : base(name, salary)
        {
            this.Departement = departement;
            Console.WriteLine("Constructor Manager called.");
        }

        public string ShowManagerInfo()
        {
            return $"{ShowInfo()}, Departement: {Departement}";
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing departement {Departement}.");
        }
    }
}