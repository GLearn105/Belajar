using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            //Day28
            var uow = new UnitOfWork();
            uow.Product.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            uow.Product.Add(new Product { Id = 2, Name = "Mouse"});
            uow.Product.Update(new Product { Id = 1, Name = "Gaming Laptop", Price = 1200 });
            uow.Product.Delete(2);
            uow.Product.Remove(new Product { Id = 1, Name = "Gaming Laptop", Price = 1200 });
            uow.Product.RemoveAll();
            uow.Product.Add(new Product { Id = 3, Name = "Keyboard", Price = 50 });

            uow.Commit();
            foreach (var product in uow.Product.GetAll())
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
            
            
            
            //Day27
            // IProductRepository repo = new ProductRepository();
            // ProductService productService = new ProductService(repo);
            // productService.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            // productService.AddProduct(new Product { Id = 2, Name = "Mouse", Price = 25 });
            // productService.ShowAllProducts();
            // productService.UpdateProduct(new Product { Id = 1, Name = "Gaming Laptop", Price = 1200 });
            // productService.DeleteProduct(2);
            // productService.ShowAllProducts();
            
            
            //Day26
            // IPaymentMethod creditCardPayment = new D26CreditCardPayment();
            // IPaymentMethod eWalletPayment = new D26EWalletPayment();
            // IPaymentMethod cashPayment = new D26CashPayment();
            // PaymentProcess paymentProcess1 = new PaymentProcess(creditCardPayment);
            // PaymentProcess paymentProcess2 = new PaymentProcess(eWalletPayment);
            // PaymentProcess paymentProcess3 = new PaymentProcess(cashPayment);
            // paymentProcess1.ExecutePayment();
            // paymentProcess2.ExecutePayment();
            // paymentProcess3.ExecutePayment();
            
            //Day25
            // IPayment creditCardPayment = new D25CreditCardPayment();
            // IPayment paypalPayment = new PayPalPayment();
            // IPayment cryptoPayment = new CryptoPayment();
            // Order order1 = new Order(creditCardPayment);
            // Order order2 = new Order(paypalPayment);
            // Order order3 = new Order(cryptoPayment);
            // order1.Checkout();
            // order2.Checkout();
            // order3.Checkout();

            
            
            //Day24
            // D24Employee D24employee = new D24Employee();
            // D24employee.CalculateSalary();
            // D24EmployeeData employeeData = new D24EmployeeData();
            // employeeData.SaveToDatabase();
            // D24EmployeePayslip employeePayslip = new D24EmployeePayslip();
            // employeePayslip.GeneratePayslip();
            
            
            
            
            //Day23
            // Vehicle electricCar = new ElectricCar();
            // electricCar.Brand = "Tesla";
            // electricCar.Start();
            // ((IElectric)electricCar).Charge();
            
            
            
            
            //Day22
            // IPrintable printable = new Document();
            // printable.Print();
            // ISaveable saveable = new Document();
            // saveable.Save();
            
            
            
            // //Day21
            // Human human = new Human();  
            // human.Work();
            // human.Eat();
            
            
            
            
            
            
            //Day20
            // Warrior warrior = new Warrior();
            // Mage mage = new Mage();
            // // warrior.Attack();
            // // warrior.Defend();
            // // mage.Attack();

            // List<IAttack> attackers = new List<IAttack> { warrior, mage };
            // foreach (var attacker in attackers)
            // {
            //     attacker.Attack();
            // }
                       
            
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