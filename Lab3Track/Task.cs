using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class Task
    {
        public ITaskState State { get; set; }
        public Task(ITaskState taskState)
        {
            State = taskState;
        }
        public void NextStep()
        {
            State.NextStep(this);
        }
        public void ThisStep()
        {
            State.ThisStep(this);
        }
    }
}
