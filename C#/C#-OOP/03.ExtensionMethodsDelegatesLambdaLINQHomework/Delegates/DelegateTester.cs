namespace Delegates
{
    using System;

    using Delegates.Time;
    using EventModels;
    internal class DelegateTester
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("7. Timer");
            var timer = new Timer();
            timer.Start(Console.WriteLine, "Hello world!", 200);

            Console.WriteLine("8.* Events");
            var eventT = new EventTimer();
            //timer.Start(eventT, "HelloWorld!", 200);
        }
    }
}
