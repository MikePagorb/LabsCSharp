using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class SentForCheckTaskState:ITaskState

    {
        public bool passed;
        public SentForCheckTaskState(bool asd)
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
            Console.WriteLine("Submit for review");
        }
    }
}
