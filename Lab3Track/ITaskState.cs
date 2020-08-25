using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Track
{
    interface ITaskState
    {
        void NextStep(Task task);
        void ThisStep(Task task);
    }
}
