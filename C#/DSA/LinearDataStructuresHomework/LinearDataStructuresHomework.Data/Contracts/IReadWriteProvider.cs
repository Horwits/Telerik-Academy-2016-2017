namespace LinearDataStructuresHomework.Data.Contracts
{
    public interface IReadWriteProvider
    {
        string ReadLine();

        void WriteLine(string line);

        void WriteLine(double number);

        void WriteLine(int number);

        void WriteLine(decimal number);

        void WriteLine(long number);

    }
}