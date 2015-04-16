namespace AnimalFactory
{
    using System;

    class Dog : Animals
    {
        public Dog(string name,int age, Sex sex)
            :base(name,age,sex)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau - bau");
        }
    }
}
