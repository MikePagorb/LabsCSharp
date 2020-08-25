using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class ForwardToCheckTaskState:ITaskState
    {
        public bool passed;
        public ForwardToCheckTaskState(bool asd)
        {
            passed = asd;
        }
        public void NextStep(Task task)
        {
            Console.WriteLine("Checked");
            task.State = new CheckedTaskState(passed);
        }
        public void ThisStep(Task task)
        {
            Console.WriteLine("Send for retake");
        }
    }
}
