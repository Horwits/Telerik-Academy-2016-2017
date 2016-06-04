using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class CallHistoryTest
    {
        internal const decimal PRICE_PER_MINUTE = 0.37m;

        public static int FindLongestCallPosition(ICollection<Call> callHistory)
        {
            var position = -1;

            if (callHistory.Count < 1)
            {
                return position;
            }

            var max = double.MinValue;
            int counter = 0;
            foreach (var call in callHistory)
            {
                var currentMax = call.Duration.TotalSeconds;
                if (currentMax > max)
                {
                    max = currentMax;
                    position = counter;
                }

                counter++;
            }

            return position;
        }
        public static void TestCallHistoryFunctionallity()
        {
            var s6 = new GSM("Samsung Galaxy S6", "Samsung");

            s6.AddCall(new Call(DateTime.Now, new TimeSpan(0, 12, 13), "0886543345"));
            s6.AddCall(new Call(DateTime.Now, new TimeSpan(0, 1, 0), "+359886543345"));
            s6.AddCall(new Call(DateTime.Now, new TimeSpan(0, 14, 2), "0886543345"));
            s6.AddCall(new Call(DateTime.Now, new TimeSpan(0, 5, 1), "0886543345"));

            Console.WriteLine(string.Join(" ", s6.CallHistory));

            var totalPrice = s6.CalculateTotalPriceOfCalls(PRICE_PER_MINUTE);
            Console.WriteLine("{0:c}", totalPrice);

            var longestCallIndex = FindLongestCallPosition(s6.CallHistory);
            s6.DeleteCall(longestCallIndex);

            s6.ClearCallHistory();
        }
    }
}
