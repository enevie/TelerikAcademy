namespace AnimalFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animals : ISound
    {
        private Sex sex;
        private int age;
        private string name;

        public Animals(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be greater than 0!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public Sex Sex
        {
            get { return this.sex; }
            set
            {
                this.sex = value;
            }
        }

        public abstract void ProduceSound();

        public static double AvarageAge(IEnumerable<Animals> animals)
        {
            return  animals.Average(x => x.Age);
        }
    }
}
