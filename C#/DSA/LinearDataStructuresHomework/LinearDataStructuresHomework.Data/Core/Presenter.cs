using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearDataStructuresHomework.Data.Contracts;

namespace LinearDataStructuresHomework.Data.Core
{
    public class Presenter : IPresenter
    {
        private const uint Length = 5;

        private readonly ITaskerFactory taskerFactory;
        private readonly IReadWriteProvider provider;

        public Presenter(ITaskerFactory taskerFactory, IReadWriteProvider provider)
        {
            this.taskerFactory = taskerFactory;
            this.provider = provider;
        }

        public void PresentListTasks()
        {
            var listTasker = this.taskerFactory.GetTasker(typeof(ListTasker)) as IListTasker;
            if (listTasker != null)
            {
                listTasker.Fill(Length);
                this.provider.WriteLine("Sum: ");
                var result = listTasker.CalculateSum();
                this.provider.WriteLine(result);

                this.provider.WriteLine("Average: ");
                var average = listTasker.CalculateAverage(result);
                this.provider.WriteLine(average);

                this.provider.WriteLine("Sort: ");
                var sorted = listTasker.Sort();
                this.provider.WriteLine(string.Join(" ", sorted));

                this.provider.WriteLine("Longest subsequence: ");
                var subsequence = listTasker.GetTheLongestSubsequence();
                this.provider.WriteLine(string.Join(" ", subsequence));

                this.provider.WriteLine("Generate only positive numbers: ");
                var positives = listTasker.GetOnlyPositiveNumbers();
                this.provider.WriteLine(string.Join(" ", positives));
            }
        }

        public void PresentStackTasks()
        {
            var stackTasker = this.taskerFactory.GetTasker(typeof(StackTasker)) as IStackTasker;

            if (stackTasker != null)
            {
                stackTasker.Fill(Length);
                this.provider.WriteLine("Reverse: ");
                var reversed = stackTasker.Reverse();
                this.provider.WriteLine(string.Join(" ", reversed));
            }
        }

        public void PresentArrayTasks()
        {
            var arrayTasker = this.taskerFactory.GetTasker(typeof(ArrayTasker)) as IArrayTasker;

            if (arrayTasker != null)
            {
                arrayTasker.Fill();
                this.provider.WriteLine("Get Times Occur: ");
                var occurance = arrayTasker.GetTimesOccur();
                this.provider.WriteLine(string.Join(" ", occurance));

                this.provider.WriteLine("Get majorant: ");
                var majorant = arrayTasker.GetMajorant();
                this.provider.WriteLine(string.Join(" ", majorant));
            }
        }
    }
}
