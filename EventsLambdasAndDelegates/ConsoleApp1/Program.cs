using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = Mediator.GetInstance();
            Mediator m2 = Mediator.GetInstance();

            //MyDelegate d = delegate (int n) {
            //    return n;
            //};
            //d += delegate (int n)
            // {
            //     return 2;
            // };
            //Console.WriteLine(d(5)); 

            //var worker = new Worker();
            //worker._workPerformed += delegate (object sender, CustomEventArgs e)
            //{
            //    Console.WriteLine("Work done: " + e.Hours);
            //};
            //worker._workPerformed += delegate (object sender, CustomEventArgs e)
            //{
            //    Console.WriteLine("Work done again: " + e.Hours);
            //};
            //worker.DoWork(4, Worker.WorkType.Development);
        }

        //private delegate int MyDelegate(int num);
        //private static void Worker__workPerformed(object sender, CustomEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }

    //internal class Worker
    //{
    //    //public MyDelegate _workPerformed;
    //    public event EventHandler<CustomEventArgs> _workPerformed;
    //    public void DoWork(int hours, WorkType workType)
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            OnWorkPerformed(i, WorkType.Development);
    //        }
    //    }
    //    public delegate void MyDelegate(object sender, CustomEventArgs args);
    //    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    //    {
    //        if (_workPerformed != null)
    //        {
    //            _workPerformed(this, new CustomEventArgs() { Hours = hours });
    //        }
    //    }
    //    public enum  WorkType
    //    {
    //        Report,
    //        Development,
    //    }
    //}

    //public class CustomEventArgs : EventArgs
    //{
    //    public int Hours { get; set; } = 5;
    //}
    public class Mediator
    {
        public static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;

        }
    }
    public class CustomEventArgs : EventArgs
    {
        public Job Job{ get; set; }
    }
    public class Job
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
    }

}
