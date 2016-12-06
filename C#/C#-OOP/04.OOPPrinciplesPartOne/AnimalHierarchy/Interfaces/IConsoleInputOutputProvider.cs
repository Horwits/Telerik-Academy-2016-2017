namespace AnimalHierarchy.Interfaces
{
    using System;

    public interface IConsoleInputOutputProvider : IInputOutputProvider
    {
        ConsoleColor BackgroundColor { get; set; }

        ConsoleColor ForegroundColor { get; set; }

        void ResetColor();
    }
}