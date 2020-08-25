using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class NotDoneTaskState:ITaskState
    {
        public bool passed;
        public NotDoneTaskState(bool asd)
        {
            passed = asd;
        }
        public void NextStep(Task task)
        {
            Console.WriteLine("Send for retake");
            task.State = new ForwardToCheckTaskState(passed);
        }
        public void ThisStep(Task task)
        {
            Console.WriteLine("Not performed");
        }
    }
}
