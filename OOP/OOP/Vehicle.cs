using System;
namespace OOP
{
    abstract class Vehicle
    {
        
        public string Brand { get; set; } = "";
        public abstract void Start();
    }

    interface IElectric
    {
        void Charge();
    }

    class ElectricCar : Vehicle, IElectric
    {
        public override void Start()
        {
            Console.WriteLine($"The electric car {Brand} is starting silently.");
        }

        public void Charge()
        {
            Console.WriteLine($"The electric car {Brand} is charging.");
        }
    }
}