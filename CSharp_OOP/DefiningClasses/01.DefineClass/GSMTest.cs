namespace GSMInfo
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {
        public static Random rand = new Random();

        public static string[] manufacturers = { "Apple", "Nokia", "HTC", "Lenovo" };
        public static string[] models = { "Iphone", "S850", "Z20", "Lumnia" };

        public static string[] owner = { "Joseph", "Drajo", "Viktor", "Georgi", "Doncho" };

        public static Battery[] battery = {   new Battery("K50", 30, 60, BatteryType.LiIon), 
                                              new Battery("V300-kz",35,65,BatteryType.NiMH), 
                                              new Battery("AAA",25,40,BatteryType.NiCd)};

        public static Display[] display = { new Display(3, 12000000), new Display(4, 8000000), new Display(5, 24000000) };

        public static GSM[] GenerateGSMs(int numberOfGsm)
        {
            GSM[] gsms = new GSM[numberOfGsm];

            for (int i = 0; i < numberOfGsm; i++)
            {
                gsms[i] = new GSM(models[rand.Next(0, models.Length)], manufacturers[rand.Next(0, manufacturers.Length)], rand.Next(100, 1500),
                    owner[rand.Next(0, owner.Length)], battery[rand.Next(0, battery.Length)], display[rand.Next(0, display.Length)], new List<Call>());
            }
            return gsms;
        }

        public static void PrintGSMInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("GSM {0}", gsms[i]);
                Console.WriteLine(new string('-', 40));
            }
            Console.WriteLine("Iphone info: {0}", GSM.IPhone4S);
        }
    }
}
