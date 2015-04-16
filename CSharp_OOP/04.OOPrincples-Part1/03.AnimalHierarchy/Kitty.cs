namespace AnimalFactory
{
    using System;

    class Kitty : Cat
    {
        public Kitty(string name, int age)
            :base(name,age,Sex.Female)
        {
           
        }
    }
}
