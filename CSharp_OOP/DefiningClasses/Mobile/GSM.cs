namespace Mobile
{
    class GSM : Battery
    {
        private string model;

        private string manufacturer;

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public decimal price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }

        public string owner { get; set; }

    }
}
