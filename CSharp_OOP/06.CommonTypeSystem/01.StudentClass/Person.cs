namespace _01.StudentClass
{
    using System;
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            string age = this.Age == null ? "age not set" : "age: " +this.Age.ToString();
            return string.Format("name: {0} {1}",this.Name,age);
        }
    }
}
