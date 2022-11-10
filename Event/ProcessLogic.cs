using System;

namespace Event
{
    public class ProcessLogic
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public void StartProcess()
        {
            ProcessEventArgs data = new ProcessEventArgs();

            try
            {
                Console.WriteLine("Process Started.");
                data.IsSuccessful = true;
                data.CompletionDate = DateTime.Now;
                OnProcessCompleted(data);
            }
            catch (Exception)
            {
                data.IsSuccessful = false;
                data.CompletionDate = DateTime.Now;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}

