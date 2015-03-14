namespace MainGSM
{
    using System.Text;
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using GSMInfo;

    class MainGSM
    {
        static void Main()
        {

            GSMCallHistoryTest.CreateCallHistroy();
            GSMCallHistoryTest.CallsInformation(GSMCallHistoryTest.Lenovo.CallHistroy);
            Console.WriteLine("Total bill: " + Call.sum);
            GSMCallHistoryTest.RemoveLongestCall(GSMCallHistoryTest.Lenovo.CallHistroy);
            Console.WriteLine();
            Console.WriteLine("AFTER REMOVING THE LONGEST CAL");
            GSMCallHistoryTest.CallsInformation(GSMCallHistoryTest.Lenovo.CallHistroy);
            Console.WriteLine("Total bill: " + Call.sum);
            GSMCallHistoryTest.ClearTheCallHistroy(GSMCallHistoryTest.Lenovo.CallHistroy);
            Console.WriteLine();
            Console.WriteLine("Print after clearing all : ");
            Console.WriteLine();
            GSMCallHistoryTest.CallsInformation(GSMCallHistoryTest.Lenovo.CallHistroy);

        }
    }
}
