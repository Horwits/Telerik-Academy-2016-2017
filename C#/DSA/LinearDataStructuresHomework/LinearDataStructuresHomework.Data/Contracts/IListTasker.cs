using System.Collections.Generic;

namespace LinearDataStructuresHomework.Data.Contracts
{
    public interface IListTasker : ITasker
    {
        void Fill(uint length);

        int CalculateSum();

        double CalculateAverage(double sum);

        IList<int> Sort();

        IList<int> GetTheLongestSubsequence();

        IEnumerable<int> GetOnlyPositiveNumbers();
    }
}