using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    class CheckedTaskState:ITaskState
    {
        public bool passed;
        public CheckedTaskState(bool asd)
        {
            passed = asd;
        }
        public void NextStep(Task task)
        {
            if (passed == true)
            {
                Console.WriteLine("Performed");
                task.State = new DoneTaskState();
            }
            else
                if(passed==false)
            {
                Console.WriteLine("Not performed");
                task.State = new NotDoneTaskState(passed);
            }
            else
                Console.WriteLine("Error");
        }
        public void ThisStep(Task task)
        {
            Console.WriteLine();
        }
    }
}
