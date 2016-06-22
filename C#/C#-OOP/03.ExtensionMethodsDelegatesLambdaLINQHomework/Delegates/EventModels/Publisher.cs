namespace Delegates.EventModels
{
    using System;

    public class Publisher
    {
        public event EventHandler<EventTimer> RaiseCustomEvent;

        public void Execute(string message)
        {
            OnRaiseCustomEvent(new EventTimer(message));
        }

        protected virtual void OnRaiseCustomEvent(EventTimer e)
        {
            EventHandler<EventTimer> handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.Message += String.Format("{0}", DateTime.Now.ToString());

                handler(this, e);
            }
        }
    }
}
