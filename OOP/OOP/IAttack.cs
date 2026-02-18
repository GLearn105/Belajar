using System;
namespace OOP
{
    interface IAttack
    {
        void Attack();
    }
    interface IDefend
    {
        void Defend();
    }

    class Warrior : IAttack, IDefend
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword!");
        }

        public void Defend()
        {
            Console.WriteLine("Warrior defends with a shield!");
        }
    }
    class Mage : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Mage attacks with a fireball!");
        }
    }

}