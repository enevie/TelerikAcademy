namespace GSMInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GSMInfo;

    class GSMCallHistoryTest
    {
        public static GSM Lenovo = new GSM("S850", "Lenovo");

        public static Call[] testCalls = {
                new Call(DateTime.Now, "Ivan", "0888888", 125),
                new Call(DateTime.Now, "Petyr", "0888666222", 255),
                new Call(DateTime.Now, "Ivaylo", "0877222353", 300) };

        public static void CreateCallHistroy()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                Lenovo.AddCall(testCalls[i]);
            }
        }

        public static void CallsInformation(List<Call> calls)
        {
            for (int i = 0; i < calls.Count; i++)
            {
                Call.InformationCall(calls[i]);
            }
        }

        public static List<Call> RemoveLongestCall(List<Call> calls)
        {
            decimal currentSum = 0;
            decimal biggestSum = 0;
            int indexOfLongestCall = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                currentSum = calls[i].CurrentSum;
                if (biggestSum < currentSum)
                {
                    biggestSum = currentSum;
                    indexOfLongestCall = i;
                }
            }
            calls.RemoveAt(indexOfLongestCall);
            Call.sum = 0;
            return calls;
        }

        public static void ClearTheCallHistroy(List<Call> calls)
        {
            calls.Clear();
        }
    }
}
