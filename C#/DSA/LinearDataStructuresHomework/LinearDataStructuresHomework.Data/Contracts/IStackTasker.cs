using System.Collections.Generic;

namespace LinearDataStructuresHomework.Data.Contracts
{
    public interface IStackTasker : ITasker
    {
        void Fill(uint n);
        IEnumerable<int> Reverse();
    }
}