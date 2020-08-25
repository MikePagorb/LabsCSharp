using System;

namespace Lab3Track
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"true\" if you want the task to be completed");
            Console.WriteLine("Enter \"false\" if you want the task to be not completed");
            bool passed = Convert.ToBoolean(Console.ReadLine());
            CheckedTaskState checkedTaskState = new CheckedTaskState(passed);
            Task task = new Task(new GivedTaskState(passed));
            Console.WriteLine("Enter number of steps you went through");
            int condition1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < condition1; i++)
            {
                Console.WriteLine("Enter \"next\" if you have moved to the next step");
                Console.WriteLine("Enter \"this\" if you are staying at the current step");
                string condition2 = Convert.ToString(Console.ReadLine());
                if (condition2 == "next")
                    task.NextStep();
                else if (condition2 == "this")
                    task.ThisStep();
                else
                    Console.WriteLine("Error");
            }

        }
    }
}
