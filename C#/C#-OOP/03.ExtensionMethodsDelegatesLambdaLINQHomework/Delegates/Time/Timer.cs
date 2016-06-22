namespace Delegates.Time
{
    using EventModels;
    using System;
    using System.Diagnostics;

    public class Timer
    {
        public Stopwatch StopWatch { get; set; }

        public void Start<T>(Action<T> action, T parameter, long time)
        {
            this.StopWatch = new Stopwatch();
            this.StopWatch.Start();

            var securityCounter = 20; //when the number is reached it will stop
            while (this.StopWatch.IsRunning)
            {
                if (time == this.StopWatch.ElapsedMilliseconds)
                {
                    action(parameter);
                    StopWatch.Restart();
                    securityCounter--;
                }

                bool isStopped = securityCounter == 0;
                if (isStopped)
                {
                    break;
                }
            }
        }

        public void Start(EventTimer e, string message, long time)
        {
            this.StopWatch = new Stopwatch();
            this.StopWatch.Start();

            var securityCounter = 200; //when the number is reached it will stop
            while (this.StopWatch.IsRunning)
            {
                if (time == this.StopWatch.ElapsedMilliseconds)
                {
                    e.Message = message;
                    Console.WriteLine(e.Message);
                    StopWatch.Restart();
                    securityCounter--;
                }

                bool isStopped = securityCounter == 0;
                if (isStopped)
                {
                    break;
                }
            }
        }
    }
}
