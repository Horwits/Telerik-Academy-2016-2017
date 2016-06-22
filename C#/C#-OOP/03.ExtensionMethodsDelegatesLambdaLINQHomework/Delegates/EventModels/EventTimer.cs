namespace Delegates.EventModels
{
    using System;

    public class EventTimer : EventArgs
    {
        private string message;

        public EventTimer()
            : this(null)
        {

        }

        public EventTimer(string message)
        {
            this.Message = message;
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
            }
        }
    }
}
