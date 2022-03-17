using System;
using System.Collections.Generic;
using System.Text;

namespace EventsLambdasAndDelegates
{
    public class EmployeesOnJob
    {
        public EmployeesOnJob()
        {
            Mediator.GetInstance().JobChanged += (o, e) =>
            {
                Console.WriteLine("Job changed Triggered fetching employeed on job id:" +e.Job.Id);
            };
        }
    }
}
