namespace StudentCreation
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value<15 || value>50)
                {
                    throw new ArgumentException("Age must be between 15 and 50");
                }
                this.age = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("The first name must be between 3 and 10 chars");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("The last name must be between 3 and 10 chars");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} with age {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
