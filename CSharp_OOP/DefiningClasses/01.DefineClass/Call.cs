
namespace GSMInfo
{
    using System;
    class Call
    {
        private const decimal CALL_PRICE = 0.35m;

        private DateTime dateOfCall;
        private string dialedNumber;
        private int duration;
        private decimal currentSum;
        public static decimal sum;


        public decimal Sum
        {
            get { return sum; }
        }

        public decimal CurrentSum
        {
            get { return this.currentSum; }
            private set { this.currentSum = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public DateTime DateOfCall
        {
            get { return this.dateOfCall; }
            set { this.dateOfCall = value; }
        }

        public Call(DateTime dateOfCall, string time, string dialedNumber, int duration)
        {
            this.dateOfCall = dateOfCall;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public decimal PriceCalculating()
        {
            currentSum = 0.37m;
            currentSum += (this.duration / 60) * CALL_PRICE;
            sum += currentSum;
            return currentSum;
        }

        public static void InformationCall(Call call)
        {
            Console.WriteLine(string.Format(@"
    date of call: {0}
    dialed number: {1}
    call duration: {2} sec
    call price: {3}"
                , call.dateOfCall, call.dialedNumber, call.duration, call.PriceCalculating()));
            Console.WriteLine(new string('-', 30));

        }
    }
}
