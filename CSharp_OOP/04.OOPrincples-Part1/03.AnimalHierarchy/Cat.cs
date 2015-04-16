namespace AnimalFactory
{
    using System;
    using AnimalFactory;
    class Cat : Animals
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow - meoew");
        }
    }
}
