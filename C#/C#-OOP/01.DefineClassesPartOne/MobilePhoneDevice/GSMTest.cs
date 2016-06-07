namespace MobilePhoneDevice
{
    using System;

    internal class GSMTest
    {
        internal static void Main()
        {
            try
            {
                var noteTwo = new GSM("Samsung Note II", "Samsung", 629.0m, "Daniel Nikolov", new Battery("Samsung", BatteryType.Li_ion, 510, 990), new Display(5.5, 16000000));

                var iphone = GSM.IPhoneFourS;

                var s5 = new GSM("Samsung S5", "Samsung");

                var gsms = new GSM[]
                {
                noteTwo,
                iphone,
                s5
                };

                foreach (var gsm in gsms)
                {
                    Console.WriteLine(gsm.ToString());
                }

                Console.WriteLine();

                CallHistoryTest.TestCallHistoryFunctionallity();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}
