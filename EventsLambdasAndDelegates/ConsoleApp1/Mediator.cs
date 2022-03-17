using System;
using System.Collections.Generic;
using System.Text;

namespace EventsLambdasAndDelegates
{
    public class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }
        public event EventHandler<CustomEventArgs> JobChanged;
        public void OnJobChanged(object sender, Job job)
        {
            if (JobChanged != null)
            {
                JobChanged(sender, new CustomEventArgs { Job = job });
            }
        }
        public static Mediator GetInstance()
        {
            return _Instance;

        }
    }
    public class CustomEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}
