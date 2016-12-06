using System.Collections.Generic;

namespace LinearDataStructuresHomework.Data.Contracts
{
    public interface IArrayTasker : ITasker
    {
        void Fill();

        IDictionary<int, int> GetTimesOccur();

        int? GetMajorant();
    }
}
