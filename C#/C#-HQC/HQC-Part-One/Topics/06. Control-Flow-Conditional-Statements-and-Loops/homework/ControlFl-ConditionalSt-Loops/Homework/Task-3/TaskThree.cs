namespace Homework.Task_3
{
    using System.Text;

    public class TaskThree
    {
        public string ReportIfExpectedValueIsFound(int[] searchArray, int expectedValue, uint loopsCount)
        {
            var output = new StringBuilder();

            for (int i = 0; i < loopsCount; i++)
            {
                output.AppendLine(searchArray[i].ToString());

                var isConditionsMet = this.FindIfConditionsAreMet(i, searchArray[i], expectedValue);
                if (isConditionsMet)
                {
                    var message = "Value Found.";
                    output.AppendLine(message);
                    break;
                }
            }

            return output.ToString();
        }

        private bool FindIfConditionsAreMet(int position, int currentArrayValue, int expectedValue)
        {
            var conditionsAreMet = position % 10 == 0 && currentArrayValue == expectedValue;
            return conditionsAreMet;
        }
    }
}