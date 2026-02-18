using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            
            //Day20
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            // warrior.Attack();
            // warrior.Defend();
            // mage.Attack();

            List<IAttack> attackers = new List<IAttack> { warrior, mage };
            foreach (var attacker in attackers)
            {
                attacker.Attack();
            }
            
            
            
            
            
            
            
            
            //Day19
            // D19Circle circle = new D19Circle (5 );
            // D19Rectangle rectangle = new D19Rectangle (4, 6 );
            // circle.Name = "Circle";
            // rectangle.Name = "Rectangle";
            // circle.CalculateArea();
            // rectangle.CalculateArea();
            
            
            //day18
            // Payment payment1 = new CreditCardPayment();
            // Payment payment2 = new CashPayment();
            // payment1.processPayment();
            // payment1.showPaymentType();
            // payment2.processPayment();
            // payment2.showPaymentType();
            
            
            //day17
            // Shape s1 = new Rectangle (5, 10);
            // Shape s2 = new Circle (5);
            // Console.WriteLine("Area of Rectangle: " + s1.GetArea());
            // Console.WriteLine("Area of Circle: " + s2.GetArea());
            // s1.Display();
            // s2.Display();
            
            
            
            
            //day16
            // Manager manager = new Manager("Eve", 8000, "Sales");
            // Console.WriteLine(manager.ShowManagerInfo());
            // manager.Work();

            
            
            
            
            
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