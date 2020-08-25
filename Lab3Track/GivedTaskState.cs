using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class GivedTaskState:ITaskState

    {
        public bool passed;
        public GivedTaskState(bool asd)
        {
            passed = asd;
        }
        public void NextStep(Task task)
        {
            Console.WriteLine("Submit for review");
            task.State = new SentForCheckTaskState(passed);
        }
        public void ThisStep(Task task)
        {
            Console.WriteLine("Task issued");
        }
    }
}
