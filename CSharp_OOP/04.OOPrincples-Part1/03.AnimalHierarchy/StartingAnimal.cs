namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AnimalFactory;

    class StartingAnimal
    {
        static void Main()
        {
            var dog = new Dog("Ivo", 15, Sex.Male);
            Console.WriteLine("{0} {1} {2}",dog.Name,dog.Age,dog.Sex);
            dog.ProduceSound();


            var kitty = new Kitty("ivana", 22);
            kitty.ProduceSound();

            var tommy = new Tomcat("Dragan", 3);
            tommy.ProduceSound();

            var cats = new List<Cat>
            {
                new Cat("Petq",3,Sex.Female),
                new Cat("Ivan",15,Sex.Male),
                new Cat("Ilian",2, Sex.Male)
            };
          
            double avarageAge = Animals.AvarageAge(cats);
            Console.WriteLine(avarageAge);
           
        }
    }
}
