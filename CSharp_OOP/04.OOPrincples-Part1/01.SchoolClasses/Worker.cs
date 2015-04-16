namespace StudentsAndWorkers
{
    using System;

    class Worker : Human
    {

        private decimal weekSalery;
        private int hoursPerDay;

        public decimal WeekSalery
        {
            get { return this.weekSalery; }
            set
            {
                this.weekSalery = value;
            }
        }

        public int HoursPerDay
        {
            get { return this.hoursPerDay; }
            set
            {
                if(value<1 || value>10)
                {
                    throw new ArgumentOutOfRangeException("Working hours must be between 1 and 10");
                }
                this.hoursPerDay = value;
            }
        }

        public Worker(decimal weekSalery, int hoursPerDay, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.WeekSalery = weekSalery;
            this.HoursPerDay = hoursPerDay;
        }

        public decimal HourSalery(decimal salery)
        {
            decimal hourSalery = WeekSalery / 5 / this.HoursPerDay;
            return hourSalery;
        }

        public override string ToString()
        {
            return string.Format("{0} with {1:F2} leva hour salery", base.ToString(),HourSalery(this.WeekSalery));
        }

    }
}
