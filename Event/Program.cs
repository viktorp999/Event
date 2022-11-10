using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessLogic process = new ProcessLogic();
            process.ProcessCompleted += Completed;
            process.StartProcess();
        }

        public static void Completed(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful? "Completed": "Failed"));
            Console.WriteLine("Completion Time" + e.CompletionDate.ToLongDateString());
        }
    }
}
