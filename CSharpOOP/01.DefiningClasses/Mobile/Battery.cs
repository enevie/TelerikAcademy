namespace GSMInfo
{
    using System;
    class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }
        public Battery(string model)
            : this(model, null, null, BatteryType.LiIon)
        {

        }
        public Battery(double? hoursIdle, double? hoursTalk)
            : this(null, hoursIdle, hoursTalk, BatteryType.LiIon)
        {

        }
        public Battery()
            : this(null, null, null, BatteryType.LiIon)
        {

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 10 || value > 100)
                {
                    throw new ArgumentException("Hours must be between 10 and 100");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 5 || value > 24)
                {
                    throw new ArgumentException("The speaking time must be between 5 and 24");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }
    }
}
