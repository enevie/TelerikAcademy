namespace StudentsAndWorkers
{
    using System;
    class Student : Human
    {
        private double grade;

        public Student(double grade, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("The grade must be between 2 and 6!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F2}", base.ToString(), this.Grade);
        }
    }
}
