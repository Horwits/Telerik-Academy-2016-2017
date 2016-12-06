using System;

namespace LinearDataStructuresHomework.Data.Contracts
{
    public interface ITaskerFactory
    {
        ITasker GetTasker(Type type);
    }
}
