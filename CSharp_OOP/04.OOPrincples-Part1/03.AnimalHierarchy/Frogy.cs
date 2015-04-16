namespace AnimalFactory
{
    using System;
    using AnimalFactory;
    class Frogy : Animals
    {
        public Frogy(string name, int age, Sex sex)
            :base(name,age,sex)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Oa- oa");
        }
    }
}
