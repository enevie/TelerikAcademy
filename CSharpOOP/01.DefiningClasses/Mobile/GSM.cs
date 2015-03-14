namespace GSMInfo
{
    using System.Text;
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    class GSM
    {
        private static GSM iPhone4S;
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;


        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }

        static GSM()
        {
            IPhone4S = new GSM("Iphone4S", "Apple", 1000, "Joseph", new Battery(), new Display(), new List<Call>());
        }

        // full constructor
        public GSM(string model, string manufacturer, int? price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = callHistory;
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, new Battery(), new Display(), new List<Call>())
        {

        }

        public GSM(string model, string manufacturer, int? price)
            : this(model, manufacturer, price, null, new Battery(), new Display(), new List<Call>())
        {

        }

        public List<Call> CallHistroy
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public int? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price isnt valid!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Invalid name. Must be between 3 and 30 letters!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public List<Call> AddCall(Call call)
        {
            this.callHistory.Add(call);
            return this.callHistory;
        }
        public List<Call> RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
            return this.callHistory;
        }

        public List<Call> ClearCallHistory(List<Call> callHistory)
        {
            callHistory.Clear();
            return callHistory;
        }

        public override string ToString()
        {
            var information = new StringBuilder();
            information.AppendLine("Model: " + this.model);
            information.AppendLine("Manufacturer: " + this.manufacturer);
            information.AppendLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Price: {0:C}", this.price));
            information.AppendLine("Owner: " + this.owner);
            information.AppendLine();
            information.AppendLine("Battery type: " + this.battery.BatteryType);
            information.AppendLine("Battery model: " + this.battery.Model);
            information.AppendLine("Battery Idle Hours: " + this.battery.HoursIdle);
            information.AppendLine("Battery Hours Talk:" + this.battery.HoursTalk);
            information.AppendLine();
            information.AppendLine("Display size :" + this.display.Size);
            information.AppendLine("Display colors:" + this.display.NumberOfColors);

            return information.ToString();
        }
    }
}
