using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class DoneTaskState:ITaskState
    {
        public void NextStep(Task task)
        {
            Console.WriteLine("Performed");
        }
        public void ThisStep(Task task)
        {
            Console.WriteLine("Performed");
        }
    }
}
