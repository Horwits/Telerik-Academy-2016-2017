namespace AnimalHierarchy.Interfaces
{
    public interface IInputOutputProvider
    {
        string ReadInput();

        void WriteOutput(string value);
    }
}